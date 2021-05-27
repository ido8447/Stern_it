using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace stern_it
{
    public partial class register_page : Form
    {
        public static string email_nex;
        public register_page()
        {
            InitializeComponent();
        }



        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection(@"Server=localhost;Port=5432;username=postgres;Password=123456;Database=postgres;");
            conn.Open();
            NpgsqlDataAdapter stea = new NpgsqlDataAdapter("Select Count (*) From tbl_users where email='" + EmailTxt.Text + "'", conn);
            DataTable drt = new DataTable();
            stea.Fill(drt);

            if (PasswordTxt.Text != RePasswordTxt.Text)
            {
                MessageBox.Show("Passwords do not match", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (FirstNameTxt.Text == ""
                 || LastNameTxt.Text == ""
                 || PasswordTxt.Text == ""
                 || EmailTxt.Text == ""
                 || TelephoneTxt.Text == ""
                 || CustomerNameTxt.Text == "")
            {
                MessageBox.Show("Some of your details is missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (drt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("The email is already used", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }




            else
            {
               
                string sql = @"insert into tbl_users (first_name, last_name,  password, customer_name,telephone, email)" +
                    " Values ('" +
                    FirstNameTxt.Text + "', '" +
                    LastNameTxt.Text + "','" +
                    PasswordTxt.Text + "','" +
                    CustomerNameTxt.Text + "','" +
                    TelephoneTxt.Text + "','" +
                    EmailTxt.Text + "')";

                email_nex = EmailTxt.Text;
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                this.Close();

            }
        }

        private void HelpLb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Help_register hr = new Help_register();
            hr.Show();
        }

        private void register_page_Load(object sender, EventArgs e)
        {

        }
    }
    
}
