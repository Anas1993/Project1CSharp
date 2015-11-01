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
    public partial class Admin___Course : Form
    {
        public Admin___Course()
        {
            InitializeComponent();
        }

        private static int id;
        public static int ID
        {
            get { return id; }
            set { id = value; }
        }

        public void getcourseID()
        {
            SqlConnection connection = new SqlConnection(Program.CONNECTIONSTRING);
            connection.Open();
            string query = "Select top 1 ID from Course Order by ID DESC";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ID = dr.GetInt32(0);
                }
                ID = ID + 1;
            }
            else
            {
                ID = 1;
            }
        }

        private void Admin___Course_Load(object sender, EventArgs e)
        {
            getcourseID();
            courseid.Text = ID.ToString();

            //get instructor names...
            SqlConnection connection = new SqlConnection(Program.CONNECTIONSTRING);
            connection.Open();
            String query = String.Format("Select ID From Instructor");
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    instructorID.Items.Add(dr.GetInt32(0));
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Program.CONNECTIONSTRING);
            connection.Open();
            string query = string.Format("Insert into Course values ({0},'{1}',{2},{3},'{4}')",courseid.Text,coursename.Text,coursehours.Value.ToString(),instructorID.Text,coursedescription.Text);
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("New Course Registered!");
            
        }
    }
}
