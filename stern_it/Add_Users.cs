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
    public partial class Add_Users : Form
    {
        public Add_Users()
        {
            InitializeComponent();
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UsersITBtn_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection(@"Server=localhost;Port=5432;username=postgres;Password=123456;Database=postgres;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT id, First_name,last_name,customer_name,email,telephone,password FROM tbl_users group by telephone", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable datb = new DataTable();
            da.Fill(datb);
            BindingSource bsor = new BindingSource();
            bsor.DataSource = datb;
            DataTables.DataSource = bsor;
            da.Update(datb);
            conn.Close();

        }


        private void SaveBtn_Click(object sender, EventArgs e)
        {
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            NpgsqlConnection conn = new NpgsqlConnection(@"Server=localhost;Port=5432;username=postgres;Password=123456;Database=postgres;");
            string sql = @"insert into tbl_users (first_name, last_name, password, customer_name,telephone, email)" +
                " VALUES ('" +
                FirstNameTxt.Text + "', '" +
                LastNameTxt.Text + "','" +
                PasswordTxt.Text + "','" +
                CustomerNameTxt.Text + "','" +
                PhoneTxt.Text + "','" +
                EmailTxt.Text + "')";


            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            conn.Open();
            da.InsertCommand = cmd;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();


        }

        private void DeleteLb_Click(object sender, EventArgs e)
        {
            if (IdTxt.Text == "")
            {
                MessageBox.Show("Please press an ID number before you press 'Delete'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                NpgsqlDataAdapter da = new NpgsqlDataAdapter();
                NpgsqlConnection conn = new NpgsqlConnection(@"Server=localhost;Port=5432;username=postgres;Password=123456;Database=postgres;");
                string sql = @"delete from tbl_users" + " where (id)" + " = ('" + IdTxt.Text + "')";

                if (MessageBox.Show("Are you sure you want to remove " + IdTxt.Text + " ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                    conn.Open();
                    da.InsertCommand = cmd;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
                }

            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update? \nUpdate button will not be processed without ID number and all details\n Any detail you don't enter into the input 'update' will update it to null", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (IdTxt.Text == "")
                {
                    MessageBox.Show("Please press an ID number before you press 'Update'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {


                    NpgsqlConnection conn = new NpgsqlConnection(@"Server=localhost;Port=5432;username=postgres;Password=123456;Database=postgres;");
                    conn.Open();

                    string sql = "update tbl_users " +
                                 "Set (first_name , last_name , email , password ,customer_name, telephone) = ('" +
                                 FirstNameTxt.Text + "','" +
                                 LastNameTxt.Text + "','" +
                                 EmailTxt.Text + "','" +
                                 PasswordTxt.Text + "','" +
                                 CustomerNameTxt.Text + "','" +
                                 PhoneTxt.Text + "')where id = '" + IdTxt.Text + "'";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

            }

        }
    }
}

