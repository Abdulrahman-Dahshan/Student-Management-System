using System;
using System.Windows.Forms;
using System.Drawing;
using System.Xml.Linq;
using System.Data;
using System.Data.SqlClient;

namespace Student_Management_System
{
    public partial class StudentManagementSystem : Form
    {
        public StudentManagementSystem()
        {
            InitializeComponent();
            StyleControls();
        }

        private void StyleControls()
        {
            // Set the form background and font
            this.BackColor = Color.FromArgb(245, 248, 255);
            this.Font = new Font("Segoe UI", 10);

            // Style each button with its own color
            StyleButton(btnAdd, Color.FromArgb(39, 174, 96));       // Green
            StyleButton(btnUpdate, Color.FromArgb(243, 156, 18));   // Orange
            StyleButton(btnSave, Color.FromArgb(127, 140, 141));   // Gray
            StyleButton(btnDelete, Color.FromArgb(231, 76, 60));    // Red

            // Style DataGridView
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            dataGridView1.GridColor = Color.Gainsboro;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void StyleButton(Button btn, Color backColor)
        {
            btn.BackColor = backColor;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.Height = 40;
            btn.Width = 130;
            btn.Cursor = Cursors.Hand;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool validName = !string.IsNullOrWhiteSpace(txtName.Text);
            bool validCode = int.TryParse(txtCode.Text, out int code) && code > 0;
            bool validMajor = !string.IsNullOrWhiteSpace(cmbMajor.Text);
            bool validGPA = double.TryParse(txtGPA.Text, out double gpa) && gpa >= 0.0 && gpa <= 4.0;

            if (validName && validCode && validGPA && validMajor)
            {
              bool valid = DatabaseHelper.AddStudent(txtName.Text, code, cmbMajor.Text, gpa);
                if (valid)
                {
                    MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                else
                {
                    MessageBox.Show("A student with the same code already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            
            else
            {
                MessageBox.Show("Please fill in all fields correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool validCode = int.TryParse(txtCode.Text, out int code) && code > 0;
            if (validCode)
            {
               bool exist =  DatabaseHelper.DeleteStudent(code);
                if (exist)
                {
                    MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("There is no student with the same code!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                MessageBox.Show("Please enter a valid student code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();

            string filePath = saveFileDialog.FileName;
            if (!string.IsNullOrWhiteSpace(filePath))
            {
                if (!filePath.EndsWith(".xlsx"))
                {
                    filePath += ".xlsx";
                }

                DatabaseHelper.ExportUsersToExcel(filePath);
                MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No file path selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
