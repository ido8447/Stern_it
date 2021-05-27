using Microsoft.VisualBasic.CompilerServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace stern_it
{
    public partial class Manager : Form
    {
        public static string id_nex;
        public Manager()
        {
            InitializeComponent();
        }

        private void AddUsersBtn_Click(object sender, EventArgs e)
        {
            Add_IT_Users itu = new Add_IT_Users();
            itu.Show();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Exit ex = new Exit();
            ex.UExut();
        }

        

        private void AddUsersBtn_Click_1(object sender, EventArgs e)
        {
            Add_Users adi = new Add_Users();
            adi.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection(@"Server=localhost;Port=5432;username=postgres;Password=123456;Database=postgres;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(@"Select r.id, tu.first_name, tu.last_name , tu.email ,r.title, r.priority, r.status, tu.telephone, r.description , r.answer , r.answered_name from tbl_users tu, requests r where r.title!= '' and r.description != '' and tu.email = r.user_email", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable datb = new DataTable();
            da.Fill(datb);
            BindingSource bsor = new BindingSource();
            bsor.DataSource = datb;
            dataGridView1.DataSource = bsor;
            da.Update(datb);
            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IdTxt.Text == "")
            {
                MessageBox.Show("Please press an ID number before you press 'Show'", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {

                if (System.Text.RegularExpressions.Regex.IsMatch(IdTxt.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter ID number","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    using NpgsqlConnection conn = new NpgsqlConnection(@"Server=localhost;Port=5432;username=postgres;Password=123456;Database=postgres;");
                    conn.Open();

                    NpgsqlDataAdapter sta = new NpgsqlDataAdapter("Select Count (*) From requests where id='" + IdTxt.Text + "'", conn);
                    DataTable dt = new DataTable();
                    sta.Fill(dt);

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        string id = IdTxt.Text;
                        id_nex = id;
                        Manager_Write mg = new Manager_Write();
                        mg.Show();
                    }
                    else
                    {
                        MessageBox.Show("There's nothing to see in this ID number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IdTxt.Text == "")
            {
                MessageBox.Show("Please press an ID number before you press 'Delete'", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {

                NpgsqlDataAdapter da = new NpgsqlDataAdapter();
                NpgsqlConnection conn = new NpgsqlConnection(@"Server=localhost;Port=5432;username=postgres;Password=123456;Database=postgres;");
                string sql = @"delete from requests where (id) =('" + IdTxt.Text + "')";
     //           string status = "select status from requests where id = ('" + IdTxt.Text + "')";
      //          NpgsqlCommand cmdstatus = new NpgsqlCommand(status, conn);
                conn.Open();
        //        NpgsqlDataReader dr = cmdstatus.ExecuteReader();
                if (MessageBox.Show("Are you sure you want to remove " + IdTxt.Text + "?" , "Warning", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                   
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                    da.InsertCommand = cmd;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
                }

            }
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection(@"Server=localhost;Port=5432;username=postgres;Password=123456;Database=postgres;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(@"Select r.id, tu.first_name, tu.last_name , tu.email ,r.title, r.priority, r.status, tu.telephone, r.description , r.answer , r.answered_name from tbl_users tu, requests r where r.title!= '' and r.description != '' and tu.email = r.user_email", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable datb = new DataTable();
            da.Fill(datb);
            BindingSource bsor = new BindingSource();
            bsor.DataSource = datb;
            dataGridView1.DataSource = bsor;
            da.Update(datb);
            conn.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
