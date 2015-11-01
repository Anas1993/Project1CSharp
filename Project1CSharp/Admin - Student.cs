using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project1CSharp
{
    public partial class Admin___Student : Form
    {
        public Admin___Student()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Admin___Student_Load(object sender, EventArgs e)
        {
            Program.GetEndID();
            id.Text = Program.ID.ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Program.CONNECTIONSTRING);
            connection.Open();
            string gender = "";
            if (male.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            string queryx = string.Format("Insert into Login values ({0},'{1}','{2}')", id.Text, password1.Text, "Student");
            string query = string.Format("INSERT INTO Student Values ({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", id.Text, firstname.Text, lastname.Text, emailaddress.Text, phonenumber.Text, dateTimePicker1.Value.Date, (nic1.Text + nic2.Text + nic3.Text), gender, bloodgroup.Text,fathername.Text,fatherphone.Text, address.Text, city.Text, country.Text);
            SqlCommand commandx = new SqlCommand(queryx, connection);
            SqlCommand command = new SqlCommand(query, connection);
            commandx.ExecuteNonQuery();
            command.ExecuteNonQuery();
            MessageBox.Show("New Student Registered!");
            connection.Close();

        }
    }
}
