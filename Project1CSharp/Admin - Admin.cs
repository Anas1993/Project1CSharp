using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1CSharp
{
    public partial class Admin___Admin : Form
    {
        

        public Admin___Admin()
        {
            InitializeComponent();
        }

        private void Admin___Admin_Load(object sender, EventArgs e)
        {
            textBox8.Text = Program.ID.ToString();
            if (Program.ID > 1)
            {
                this.button2.Text = "Back";

            }
            else
            {
                this.button2.Text = "Exit";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // save here...

            SqlConnection connection = new SqlConnection(Program.CONNECTIONSTRING);
            connection.Open();
            string gender = "";
            if (radioButton1.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            string queryx = string.Format("Insert into Login values ({0},'{1}','{2}')", textBox8.Text, textBox9.Text, "Administrator");
            string query = string.Format("INSERT INTO Administrator Values ({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", textBox8.Text, textBox1.Text, textBox2.Text, textBox4.Text, textBox11.Text, dateTimePicker1.Value.Date, (textBox10.Text + textBox12.Text + textBox13.Text), gender, comboBox3.Text, textBox5.Text, textBox6.Text, textBox7.Text);
            SqlCommand commandx = new SqlCommand(queryx, connection);
            SqlCommand command = new SqlCommand(query, connection);
            commandx.ExecuteNonQuery();
            command.ExecuteNonQuery();
            MessageBox.Show("New Admin Registered!");
            connection.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.button2.Text == "Back")
            {
                //hide screen go back..
            }
            else
            {
                //exit program

            }
        }

        private void editExistingUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {/*
            if (comboBox1.Text == "ID")
            {
                SqlConnection connection = new SqlConnection(Program.CONNECTIONSTRING);
                connection.Open();
                String query = String.Format("Select ID From Administrator Where ID = {0}", textBox14.Text);
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        comboBox2.Items.Add(dr.GetInt32(0));
                    }
                }
                else
                {
                    MessageBox.Show("No record found!");
                }
            }
          */ 
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {/*
            if (comboBox1.Text == "ID")
            {
                SqlConnection connection = new SqlConnection(Program.CONNECTIONSTRING);
                connection.Open();
                String query = String.Format("Select * From Administrator Where ID = {0}", comboBox2.Text);
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        //comboBox2.Items.Add(dr.GetInt32(0));
                        textBox8.Text = dr.GetInt32(0).ToString();
                        textBox1.Text = dr.GetString(1).ToString();
                        textBox2.Text = dr.GetString(2).ToString();
                        textBox4.Text = dr.GetString(3).ToString();
                        textBox11.Text = dr.GetString(4).ToString();
                        dateTimePicker1.Value = dr.GetDateTime(5);
                        //(textBox10.Text+textBox12.Text+textBox13.Text)
                        textBox10.Text = dr.GetString(6).ToString();
                        if (dr.GetString(7).ToString() == "Male")
                        {
                            radioButton1.Select();

                        }
                        else
                        {
                            radioButton2.Select();
                        }

                    }
                }
                else
                {
                    //MessageBox.Show("No record found!");
                }
            }

            */
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
