using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClosedXML.Excel;
using System.Data;
using System.Drawing;

namespace Student_Management_System
{
    internal class DatabaseHelper
    {
        private static readonly string connectionString = "Server=.;Database=StudentsDB;Trusted_Connection=True;"; //"Data Source=.;Initial Catalog=StudentsDB;Integrated Security=True";

        public static bool AddStudent(string name, int code, string major, double gpa)
        {
            if (!CheckStudent(code))   // Check if the student already exists before inserting  
            {
                string insertQuery = "INSERT INTO Students (Name, Code, Major, GPA) VALUES (@Name, @Code, @Major, @GPA)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Explicitly open the connection  
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@Name", name);
                        insertCmd.Parameters.AddWithValue("@Code", code);
                        insertCmd.Parameters.AddWithValue("@Major", major);
                        insertCmd.Parameters.AddWithValue("@GPA", gpa);

                        insertCmd.ExecuteNonQuery();  
                    }
                }
                return true; // Successfully added
            }
            else
            {
                return false;
            }
        }



        public static bool DeleteStudent(int code)
        {
            if (CheckStudent(code))  // Ensure the student exists before deleting  
            {
                string deleteQuery = "DELETE FROM Students WHERE Code = @Code";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, connection))
                    {
                        deleteCmd.Parameters.AddWithValue("@Code", code);
                        deleteCmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            else
            {
                return false;               
            }
        }



        public static bool UpdateStudent(string name, int code, string major, double gpa)
        {
            if (CheckStudent(code)) // Check if the student exists before updating  
            {
                string updateQuery = "UPDATE Students SET Name = @Name, Major = @Major, GPA = @GPA WHERE Code = @Code";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Open the connection explicitly
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection))
                    {
                        updateCmd.Parameters.AddWithValue("@Name", name);
                        updateCmd.Parameters.AddWithValue("@Code", code);
                        updateCmd.Parameters.AddWithValue("@Major", major);
                        updateCmd.Parameters.AddWithValue("@GPA", gpa);

                        updateCmd.ExecuteNonQuery(); // Execute the update query
                    }
                }
                return true;
            }
            else
            {
                return false;            
            }
        }

        public static DataTable SearchStudentByName(string name)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Students WHERE Name LIKE @Name";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", "%" + name + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }



        public static bool CheckStudent(int code)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                // Check if the student with the same code exists
                string checkQuery = "SELECT COUNT(*) FROM Students WHERE Code = @Code";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                {
                    checkCmd.Parameters.AddWithValue("@Code", code);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count == 0)
                    {
                        
                        return false; // Student does not exist
                    }
                    else
                    {
                        return true; // Student exists
                    }

                }
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

        internal static DataTable GetAllStudents()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Students";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
