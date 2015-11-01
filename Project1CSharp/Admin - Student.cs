using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            textBox8.Text = Program.ID.ToString();
           
        }
    }
}
