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
            StyleButton(btnClear, Color.FromArgb(127, 140, 141));   // Gray
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
            bool validAge = int.TryParse(numAge.Text, out int age) && age > 0 && age < 120;
            bool validGPA = double.TryParse(txtGPA.Text, out double gpa) && gpa >= 0.0 && gpa <= 4.0;
            bool validMajor = !string.IsNullOrWhiteSpace(txtMajor.Text);

            if (validName && validAge && validGPA && validMajor)
            {
                DatabaseHelper.AddStudent(txtName.Text, age, txtMajor.Text, gpa);
                MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
