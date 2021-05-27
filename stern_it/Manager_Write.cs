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
    
    public partial class Manager_Write : Form
    {
        public static string FITName;
        public Manager_Write()
        {
            InitializeComponent();
        }

        private void Manager_Write_Load(object sender, EventArgs e)
        {

            IdTxt.Text = Manager.id_nex;
            NpgsqlConnection conn = new NpgsqlConnection(@"Server=localhost;Port=5432;username=postgres;Password=123456;Database=postgres;");
            conn.Open();

            string reqsql = "Select answer,description,status from requests where id = " + Manager.id_nex;
            NpgsqlCommand reqcmd = new NpgsqlCommand(reqsql, conn);
            NpgsqlDataReader reqdr = reqcmd.ExecuteReader();
            reqdr.Read();
            descriptionTxt.Text = (reqdr["description"].ToString());
            StatusTxt.Text = (reqdr["status"].ToString());
            AnswerTxt.Text = (reqdr["answer"].ToString());
            reqcmd.Dispose();
            reqdr.DisposeAsync();



            string sql = "Select tu.first_name , tu.last_name , tu.customer_name , tu.email, tu.telephone from tbl_users tu , requests r where r.id = " + Manager.id_nex + " and r.user_email = tu.email" ;
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            FirstNameTxt.Text = (dr["first_name"].ToString());
            LastNameTxt.Text = (dr["last_name"].ToString());
            CusNameTxt.Text = (dr["customer_name"].ToString());
            EmailTxt.Text = (dr["email"].ToString());
            PhoneNumTxt.Text = (dr["telephone"].ToString());
            cmd.Dispose();
            dr.DisposeAsync();




            conn.Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            FITName = NameTxt.Text;
            {

                NpgsqlConnection conn = new NpgsqlConnection(@"Server=localhost;Port=5432;username=postgres;Password=123456;Database=postgres;");
                conn.Open();

                NpgsqlDataAdapter stea = new NpgsqlDataAdapter("Select Count (*) From tbl_it_users where first_name='" + NameTxt.Text +  "'", conn);
                DataTable drt = new DataTable();
                stea.Fill(drt);


                if (StatusTxt.Text == "" || NameTxt.Text == "")
                {
                    MessageBox.Show("One of the parameters is missing", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                else if (drt.Rows[0][0].ToString() == "1")
                {
                    string sql = @"Update requests " +
                                "Set (status,answer,answered_name) = ('" +
                                 StatusTxt.Text + "', '" +
                                    AnswerTxt.Text + "', '" +
                                    NameTxt.Text +
                                     "')Where id = '" + IdTxt.Text + "'";


                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                    //   da.InsertCommand = cmd;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
                    MessageBox.Show("Submit sent successfully", "OK", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("your first name is incorrect", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }



            }
            this.Close();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StatusTxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
