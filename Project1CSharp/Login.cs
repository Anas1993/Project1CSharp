using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic;
using System.Data.SqlClient;

namespace Project1CSharp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (Program.ID == 1)
            {
                MessageBox.Show("No user found in the database! Click Ok to create an admin account..");
                
                Program.Admin___Admin.Show();
            }
            else
            {
                Program.Login.Show();

            }
            // check if the database has any records.. if record found stay in normal position
            // else show an inputbox which asks user to enter password twice and display userID.

            
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            try
            {
                //login into admin..
                SqlConnection connection = new SqlConnection(Program.CONNECTIONSTRING);
                connection.Open();
                String query = String.Format("Select ID, UserType From Login Where ID = {0} AND Password = '{1}'", textBox1.Text, textBox2.Text);
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader dr = cmd.ExecuteReader();

                int UserID = 0; 
                String UserType = "";
                
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        UserID = dr.GetInt32(0);
                        UserType = dr.GetString(1).ToString();

                    }
                }
                else
                {
                    //show msg.. wrong username or password.
                    MessageBox.Show("Wrong username or password.");
                }
                if (UserType == "Administrator")
                {
                    MessageBox.Show("Admin");
                    Program.Admin.USERID = UserID;
                    Program.Admin.Show();
                    //send ID to admin form...

                }
                else if (UserType == "Student")
                {
                    MessageBox.Show("Student");

                }
                else if (UserType == "Teacher")
                {
                    MessageBox.Show("Teacher");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }
    }
}
