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
    public partial class Admin : Form
    {
        private int UserID;

        public int USERID
        {
            get { return UserID; }
            set { UserID = value; }
        }

        public Admin()
        {
            InitializeComponent();
        }

     

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Program.Admin___Instructor.Show();

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            
            SqlConnection connection = new SqlConnection(Program.CONNECTIONSTRING);
            connection.Open();
            String query = String.Format("Select Administrator_FNAME, Administrator_LNAME From Administrator Where ID = {0}", USERID);
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    toolStripStatusLabel2.Text = dr.GetString(0).ToString() + " " + dr.GetString(1).ToString();
                   
                }
                //don't do anything...
            }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Program.Admin___Admin.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Program.Admin___Admin___Edit.Show();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Program.Admin___Student.Show();

        }

    }
}
