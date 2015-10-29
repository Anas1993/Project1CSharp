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
    public partial class FirstUserReg : Form
    {
        public FirstUserReg()
        {
            InitializeComponent();
        }

        private void FirstUserReg_Load(object sender, EventArgs e)
        {
            MessageBox.Show("No user found in the database! Click Ok to create an admin account..");
            toolStripStatusLabel2.Text = Program.ID.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check if text1=text2
            if (textBox1.Text == textBox2.Text)
            {
                //enter data.
                SqlConnection connection = new SqlConnection(Program.CONNECTIONSTRING);
                connection.Open();
                string query = String.Format("INSERT INTO Login Values ({0},'{1}','{2}')",Program.ID.ToString(),textBox1.Text,"Administrator");
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Account created successfully. Your ID is: " + Program.ID.ToString());
                connection.Close();
                this.Hide();
                Program.Login.Show();
            }
        }
    }
}
