using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project1CSharp
{
    static class Program
    {
        public static Login Login = new Login();
        //public static FirstUserReg FirstUserReg = new FirstUserReg();
        public static Admin Admin = new Admin();
        //public static Admin___Instructor Admin___Instructor = new Admin___Instructor();
        public static Admin___Admin Admin___Admin = new Admin___Admin();
        public static Admin___Admin___Edit Admin___Admin___Edit = new Admin___Admin___Edit();
        public static Admin___Student Admin___Student = new Admin___Student();
        public static Admin___Student___Edit Admin___Student___Edit = new Admin___Student___Edit();
        public static Admin___Course Admin___Course = new Admin___Course();
 

        private static string connectionString;
        private static int id;

        public static string CONNECTIONSTRING
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public static int ID
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CONNECTIONSTRING = @"Data Source=localhost\sqlexpress;Initial Catalog=TestDatabase;Integrated Security=True";
            Application.EnableVisualStyles();
            Program.GetEndID();
            Application.Run(Login);
        
        }

        public static void GetEndID()
        {
            SqlConnection connection = new SqlConnection(CONNECTIONSTRING);
            connection.Open();
            string query = "Select top 1 ID from Login Order by ID DESC";
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

    }
}
