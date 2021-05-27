using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Web;
using Npgsql;



namespace stern_it
{
    public partial class HelpDesk : Form
    {
        
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public HelpDesk()
        {
            InitializeComponent();
        }
        private void HelpDesk_Load(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection(@"Server=localhost;Port=5432;username=postgres;Password=123456;Database=postgres;");
            conn.Open();
            string sql = "Select first_name , email from tbl_users where email = '" + SternIT.email_nex + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                NameEmail.Text = (dr["first_name"].ToString());
            }
            
            conn.Close();

        }

        private void DescriptionLb_Click(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
            
        {
            if (PriorityTxt.Text == "" || descriptionTXT.Text == "" || TitleTxt.Text == "")
            {
                MessageBox.Show("One of the parameters are missing", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            else
            {

                try
                {

                    NpgsqlConnection conn = new NpgsqlConnection(@"Server=localhost;Port=5432;username=postgres;Password=123456;Database=postgres;");

                    conn.Open();

                    string sql = "insert into requests (user_email , priority,title,description) Values ('" + SternIT.email_nex + "','" + PriorityTxt.Text + "','" + TitleTxt.Text + "','" + descriptionTXT.Text + "')";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Submit send successfully", "Successfully", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    conn.Dispose();

                }
                catch
                {
                    MessageBox.Show("Submit sent unsuccessful","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
        }

        private void NameEmail_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
 

        }
    }
}
