using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//using ClosedXML.Excel;
using System.Data;

namespace Student_Management_System
{
    internal class DatabaseHelper
    {
        private static readonly string connectionString = "Server=.;Database=StudentsDB;Trusted_Connection=True;"; //"Data Source=.;Initial Catalog=StudentsDB;Integrated Security=True";

        public static void AddStudent(string name, int age, string major, double gpa)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Students (Name, Age, Major, GPA) VALUES (@Name, @Age, @Major, @GPA)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@Major", major);
                cmd.Parameters.AddWithValue("@GPA", gpa);

                con.Open(); // conn is valid within this using block
                cmd.ExecuteNonQuery();

            }

            //LoadData(); // Refresh table
        }
    }
}
