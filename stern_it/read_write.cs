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
    public partial class read_write : Form
    {
        public static string id_nex;
        public read_write()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if(ReadRB.Checked == true)
            {
                if (textBox1.Text != "")
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
                    {
                        MessageBox.Show("Please enter ID number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        NpgsqlConnection conn = new NpgsqlConnection(@"Server=localhost;Port=5432;username=postgres;Password=123456;Database=postgres;");
                        conn.Open();
                        NpgsqlDataAdapter stea = new NpgsqlDataAdapter("Select answer From requests where id=" + textBox1.Text, conn);
                        DataTable drt = new DataTable();
                        stea.Fill(drt);
                        NpgsqlDataAdapter st = new NpgsqlDataAdapter("Select count (*) From requests where id=" + textBox1.Text + "and user_email = '" + SternIT.email_nex + "'", conn);
                        DataTable dat = new DataTable();
                        st.Fill(dat);
                        conn.Close();

                        if (dat.Rows[0][0].ToString() == "0")
                        {
                            MessageBox.Show("This ID does not exist \nPlease write down an existing ID number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (drt.Rows[0][0].ToString() == "")
                        {
                            MessageBox.Show("There's nothing to see right now, we'll get back to you as soon as possible", "Nothing to see", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        else
                        {
                            id_nex = textBox1.Text;
                            Reading rw = new Reading();
                            rw.Show();
                        }
                    }
                    

                }
                else
                {
                    MessageBox.Show("Please enter ID number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             
            }
            else if(WriteRB.Checked == true)
            {
                HelpDesk hd = new HelpDesk();
                hd.Show();
            }
            else if (textBox1.Text != "" && WriteRB.Checked == false && ReadRB.Checked==false)
            {

                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
                    {
                        MessageBox.Show("Please enter ID number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {


                        if (MessageBox.Show("Please choose whether to read or write \nDo you choose 'Read'?", "Read or not", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            NpgsqlConnection conn = new NpgsqlConnection(@"Server=localhost;Port=5432;username=postgres;Password=123456;Database=postgres;");
                            conn.Open();
                            NpgsqlDataAdapter stea = new NpgsqlDataAdapter("Select answer From requests where id=" + textBox1.Text, conn);
                            DataTable drt = new DataTable();
                            stea.Fill(drt);
                            conn.Close();
                            if (drt.Rows[0][0].ToString() == "")
                            {
                                MessageBox.Show("There's nothing to see right now, we'll get back to you as soon as possible", "Nothing to see", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                id_nex = textBox1.Text;
                                Reading rw = new Reading();
                                rw.Show();
                            }
                        }
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exit ex = new Exit();
            ex.UExut();
        }

        private void read_write_Load(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection(@"Server=localhost;Port=5432;username=postgres;Password=123456;Database=postgres;");
             conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand(@"Select id,title,priority,description,status,answer,answered_name from requests  where user_email  = '" + SternIT.email_nex +  "'and title != '' and description !=''", conn);
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
            NpgsqlConnection conn = new NpgsqlConnection(@"Server=localhost;Port=5432;username=postgres;Password=123456;Database=postgres;");
            conn.Open();
            string cid = "Select id,title,priority,description,status,answer,answered_name from requests  where user_email  = '" + SternIT.email_nex + "'and title != '' and description !=''";

            NpgsqlCommand cmd = new NpgsqlCommand(cid, conn);
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
    }
}
