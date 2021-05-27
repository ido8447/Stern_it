using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stern_it
{
    public partial class SternIT : Form
    {


        public static string email_nex;
        public SternIT()
        {
            InitializeComponent();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register_page r = new register_page();
            r.Show();

        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {

            email_nex = EmailTxt.Text;

            using (NpgsqlConnection conn = new NpgsqlConnection(@"Server=localhost;Port=5432;username=postgres;Password=123456;Database=postgres;"))
            {
                conn.Open();

                NpgsqlDataAdapter sta = new NpgsqlDataAdapter("Select Count (*) From tbl_users where email='" + EmailTxt.Text + "'and password = '" + PasswordTxt.Text + "'", conn);
                DataTable dt = new DataTable();
                sta.Fill(dt);



                NpgsqlDataAdapter stea = new NpgsqlDataAdapter("Select Count (*) From tbl_it_users where email='" + EmailTxt.Text + "'and password = '" + PasswordTxt.Text + "'", conn);
                DataTable drt = new DataTable();
                stea.Fill(drt);




                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    read_write rw = new read_write();
                    rw.Show();

                }



                else if (drt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Manager mgr = new Manager();
                    mgr.Show();
                }






                else if (EmailTxt.Text == "" || PasswordTxt.Text == "")
                {
                    MessageBox.Show("Please enter email and pasword", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if ((EmailTxt.Text == "eyal" || EmailTxt.Text == "Eyal") && PasswordTxt.Text == "123456")
                {
                    this.Hide();
                    Manager mgr = new Manager();
                    mgr.Show();
                }
                else
                {
                    MessageBox.Show("Wrong email or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exit ex = new Exit();
            ex.UExut();
        }
    }


    
}

