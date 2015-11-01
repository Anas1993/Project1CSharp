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
            if (category.Text == "ID")
            {
                SqlConnection connection = new SqlConnection(Program.CONNECTIONSTRING);
                connection.Open();
                String query = String.Format("Select * From Administrator Where ID = {0}", multirecord.Text);
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        firstname.Text = dr.GetString(1).ToString();
                        lastname.Text = dr.GetString(2).ToString();
                        emailaddress.Text = dr.GetString(3).ToString();
                        phonenumber.Text = dr.GetString(4).ToString();
                        dateofbirth.Value = dr.GetDateTime(5);
                        //(textBox10.Text+textBox12.Text+textBox13.Text)
                        nic1.Text = dr.GetString(6).ToString();
                        if (dr.GetString(7).ToString() == "Male")
                        {
                            male.Select();

                        }
                        else
                        {
                            female.Select();
                        }
                        address.Text = dr.GetString(9).ToString();
                        city.Text = dr.GetString(10).ToString();
                        country.Text = dr.GetString(11).ToString();

                        //textBox10.Text = dr.GetString(6).ToString();
                        string NIC = dr.GetString(6).ToString();
                        nic1.Text = NIC.Substring(0, 5);
                        nic2.Text = NIC.Substring(5, 7);
                        nic3.Text = NIC.Substring(12, 1);
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
                        bloodgroup.Text = dr.GetString(8).ToString();

                    }
                }
                else
                {
                    //MessageBox.Show("No record found!");
                }
            }


            firstname.Enabled = true;
            lastname.Enabled = true;
            //textBox3.Enabled = true;
            emailaddress.Enabled = true;
            address.Enabled = true;
            city.Enabled = true;
            country.Enabled = true;
            //textBox9.Enabled = true;
            nic1.Enabled = true;
            phonenumber.Enabled = true;
            nic2.Enabled = true;
            nic3.Enabled = true;
            dateofbirth.Enabled = true;
            bloodgroup.Enabled = true;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchbox.Enabled = true;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (category.Text == "ID")
            {
                SqlConnection connection = new SqlConnection(Program.CONNECTIONSTRING);
                connection.Open();
                String query = String.Format("Select ID From Administrator Where ID = {0}", searchbox.Text);
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        multirecord.Items.Add(dr.GetInt32(0));
                    }

                    multirecord.Enabled = true;
                }
                else
                {

                    multirecord.Enabled = false;
                    MessageBox.Show("No record found!");
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            password2.Enabled = true;
            password1.Enabled = true;
            password2.Text = "";
            password1.Text = "";
            PASSWORDCHANGECLICKED = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Program.CONNECTIONSTRING);
            string gender = "";
            if (male.Checked)
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
                string queryx = string.Format("UPDATE Login SET ID={0},Password='{1}',UserType='{2}' WHERE ID={0}", multirecord.Text, password1.Text, "Administrator");
                SqlCommand commandx = new SqlCommand(queryx, connection);
                commandx.ExecuteNonQuery();
               
               
                connection.Close();
      
            }
            // regular query..
            connection.Open();
            string query = string.Format("UPDATE Administrator SET ID={0},Administrator_FNAME='{1}',Administrator_LNAME='{2}',Administrator_Email='{3}',Administrator_Phone='{4}',Date_of_Birth='{5}',NIC='{6}',Gender='{7}',Blood_Group='{8}',Home_Address='{9}',Home_City='{10}',Home_County='{11}' WHERE ID={0}", multirecord.Text, firstname.Text, lastname.Text, emailaddress.Text, phonenumber.Text, dateofbirth.Value.Date, (nic1.Text + nic2.Text + nic3.Text), gender, bloodgroup.Text, address.Text, city.Text, country.Text);
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Record Updated!");
        }
    }
}
