using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace stern_it
{
    public partial class Reading : Form
    {

        public Reading()
        {
            InitializeComponent();
        }

        private void Reading_Load(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection(@"Server=localhost;Port=5432;username=postgres;Password=123456;Database=postgres;");
            conn.Open();
            string sql = "Select answered_name , answer,description,priority from requests where id = '" + read_write.id_nex + "'";
            NpgsqlCommand ITcm = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader dar = ITcm.ExecuteReader();
            if (dar.Read())
            {
                NameTxt.Text = (dar["answered_name"].ToString());
                AnswerTxt.Text = (dar["answer"].ToString());
                descriptionTxt.Text = (dar["description"].ToString());
                PriorityTxt.Text = (dar["priority"].ToString());

            }
            ITcm.Dispose();
            dar.Close();


            string ITsq = "Select first_name , email, telephone from tbl_IT_users where first_name = '" + NameTxt.Text + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(ITsq, conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MailTxt.Text = (dr["email"].ToString());
                PhoneTxt.Text = (dr["telephone"].ToString());
            }

            conn.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PriorityTxt.Text == "" || descriptionTxt.Text == "")
            {
                MessageBox.Show("Some parameters are missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter();
                    NpgsqlConnection conn = new NpgsqlConnection(@"Server=localhost;Port=5432;username=postgres;Password=123456;Database=postgres;");
                    conn.Open();
                    string sql = @"update requests " +
                        "set (priority, description)" +
                        " = ('" + PriorityTxt.Text + "','" + descriptionTxt.Text + "')" +
                        "where id = '" + read_write.id_nex + "'";

                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
                    MessageBox.Show("Submit sent successfully", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Submit sent unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void descriptionTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
