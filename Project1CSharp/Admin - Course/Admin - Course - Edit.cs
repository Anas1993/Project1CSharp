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
    public partial class Admin___Course___Edit : Form
    {
        public Admin___Course___Edit()
        {
            InitializeComponent();
        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchbox.Enabled = true;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (category.Text == "Course ID")
            {
                SqlConnection connection = new SqlConnection(Program.CONNECTIONSTRING);
                connection.Open();
                String query = String.Format("Select ID From Course Where Course_ID = {0}", searchbox.Text);
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

        private void multirecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (category.Text == "Course ID")
            {
                SqlConnection connection = new SqlConnection(Program.CONNECTIONSTRING);
                connection.Open();
                String query = String.Format("Select * From Course Where Course_ID = {0}", multirecord.Text);
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        courseid.Text = dr.GetInt32(0).ToString();
                        coursename.Text = dr.GetString(1).ToString();
                        coursehours.Value = dr.GetInt32(2);
                        instructorID.Text = dr.GetInt32(3).ToString();
                        coursedescription.Text = dr.GetString(4).ToString();
                       
                    }
                }
                else
                {
                    //MessageBox.Show("No record found!");
                }
            }
            coursename.Enabled = true;
            coursehours.Enabled = true;
            instructorID.Enabled = true;
            coursedescription.Enabled = true;

        }

        private void Admin___Course___Edit_Load(object sender, EventArgs e)
        {
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
            string query = string.Format("UPDATE Course SET Course_ID={0},Course_NAME='{1}',Course_Hours={2},ID={3},Course_Description='{4}' WHERE ID={0}", multirecord.Text, coursename.Text, coursehours.Value.ToString(),instructorID.Text,coursedescription.Text,courseid.Text);
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Record Updated!");
        }
    }
}
