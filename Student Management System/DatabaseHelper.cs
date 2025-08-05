using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClosedXML.Excel;
using System.Data;

namespace Student_Management_System
{
    internal class DatabaseHelper
    {
        private static readonly string connectionString = "Server=.;Database=StudentsDB;Trusted_Connection=True;"; //"Data Source=.;Initial Catalog=StudentsDB;Integrated Security=True";

        public static bool AddStudent(string name, int code, string major, double gpa)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Check if the student with the same code already exists
                string checkQuery = "SELECT COUNT(*) FROM Students WHERE Code = @Code";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                {
                    checkCmd.Parameters.AddWithValue("@Code", code);

                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        return false; // Student already exists
                    }
                }

                // Insert if not duplicate
                string insertQuery = "INSERT INTO Students (Name, Code, Major, GPA) VALUES (@Name, @Code, @Major, @GPA)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                {
                    insertCmd.Parameters.AddWithValue("@Name", name);
                    insertCmd.Parameters.AddWithValue("@Code", code);
                    insertCmd.Parameters.AddWithValue("@Major", major);
                    insertCmd.Parameters.AddWithValue("@GPA", gpa);

                    insertCmd.ExecuteNonQuery();
                    return true; // Successfully added
                }
            }
        }




        public static void DeleteStudent(int code)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Students WHERE Code = @Code";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Code", code);
                
                con.Open();
                cmd.ExecuteNonQuery();
            }
            
        }

        public static void ExportUsersToExcel(string filePath)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Students";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        workbook.Worksheets.Add(dt, "Students");
                        workbook.SaveAs(filePath);
                    }
                }
            }
        }



    }
}
