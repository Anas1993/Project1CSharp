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
    public partial class Admin___Admin___Edit : Form
    {
        private Boolean PasswordChangeClicked = false;
        public Boolean PASSWORDCHANGECLICKED
        {
            get { return PasswordChangeClicked; }
            set { PasswordChangeClicked = value; }
        }

        public Admin___Admin___Edit()
        {
            InitializeComponent();
        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                        textBox5.Text = dr.GetString(9).ToString();
                        textBox6.Text = dr.GetString(10).ToString();
                        textBox7.Text = dr.GetString(11).ToString();

                        //textBox10.Text = dr.GetString(6).ToString();
                        string NIC = dr.GetString(6).ToString();
                        textBox10.Text = NIC.Substring(0, 5);
                        textBox12.Text = NIC.Substring(5, 7);
                        textBox13.Text = NIC.Substring(12, 1);
                        //textBox12.Text = NIC.Substring(11, 12);
                        //13 - 5, 7, 1

                        /*
                         *string myString = "A quick brown fox jumps over a lazy dog.";
            string subString = myString.Substring(5);
            string anotherSubString = myString.Substring(12, 8);
            Console.WriteLine(subString);
            Console.WriteLine(anotherSubString); 
                         *
                         */
                        comboBox3.Text = dr.GetString(8).ToString();

                    }
                }
                else
                {
                    //MessageBox.Show("No record found!");
                }
            }


            textBox1.Enabled = true;
            textBox2.Enabled = true;
            //textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            //textBox9.Enabled = true;
            textBox10.Enabled = true;
            textBox11.Enabled = true;
            textBox12.Enabled = true;
            textBox13.Enabled = true;
            dateTimePicker1.Enabled = true;
            comboBox3.Enabled = true;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox14.Enabled = true;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
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

                    comboBox2.Enabled = true;
                }
                else
                {

                    comboBox2.Enabled = false;
                    MessageBox.Show("No record found!");
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
            textBox9.Enabled = true;
            textBox3.Text = "";
            textBox9.Text = "";
            PASSWORDCHANGECLICKED = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Program.CONNECTIONSTRING);
            string gender = "";
            if (radioButton1.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            } 

            if (PASSWORDCHANGECLICKED == true)
            {
                //update login table as well
                connection.Open();
                /*
                 * UPDATE Customers
SET ContactName='Alfred Schmidt', City='Hamburg'
WHERE CustomerName='Alfreds Futterkiste';
                 */
                string queryx = string.Format("UPDATE Login SET ID={0},Password='{1}',UserType='{2}' WHERE ID={0}", comboBox2.Text, textBox9.Text, "Administrator");
                SqlCommand commandx = new SqlCommand(queryx, connection);
                commandx.ExecuteNonQuery();
               
               
                connection.Close();
      
            }
            // regular query..
            connection.Open();
            string query = string.Format("UPDATE Administrator SET ID={0},Administrator_FNAME='{1}',Administrator_LNAME='{2}',Administrator_Email='{3}',Administrator_Phone='{4}',Date_of_Birth='{5}',NIC='{6}',Gender='{7}',Blood_Group='{8}',Home_Address='{9}',Home_City='{10}',Home_County='{11}' WHERE ID={0}", comboBox2.Text, textBox1.Text, textBox2.Text, textBox4.Text, textBox11.Text, dateTimePicker1.Value.Date, (textBox10.Text + textBox12.Text + textBox13.Text), gender, comboBox3.Text, textBox5.Text, textBox6.Text, textBox7.Text);
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Record Updated!");
        }
    }
}
