//using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Drawing.Font;

namespace Student_Management_System
{
    partial class StudentManagementSystem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLabel = new Label();
            lblMajor = new Label();
            txtName = new TextBox();
            cmbMajor = new ComboBox();
            CodeLabel = new Label();
            GpsLabel = new Label();
            txtGPA = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            SearchLabel = new Label();
            txtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colCode = new DataGridViewTextBoxColumn();
            colMajor = new DataGridViewTextBoxColumn();
            colGPA = new DataGridViewTextBoxColumn();
            saveFileDialog = new SaveFileDialog();
            txtCode = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtLabel
            // 
            txtLabel.AutoSize = true;
            txtLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLabel.Location = new Point(40, 46);
            txtLabel.Name = "txtLabel";
            txtLabel.Size = new Size(135, 25);
            txtLabel.TabIndex = 0;
            txtLabel.Text = "Student Name:";
            // 
            // lblMajor
            // 
            lblMajor.AutoSize = true;
            lblMajor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMajor.Location = new Point(40, 108);
            lblMajor.Name = "lblMajor";
            lblMajor.Size = new Size(66, 25);
            lblMajor.TabIndex = 1;
            lblMajor.Text = "Major:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(196, 46);
            txtName.Name = "txtName";
            txtName.Size = new Size(176, 29);
            txtName.TabIndex = 2;
            // 
            // cmbMajor
            // 
            cmbMajor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMajor.FormattingEnabled = true;
            cmbMajor.Items.AddRange(new object[] { "Computer Science", "Mathematics", "Physics", "Chemistry", "Biology", "Engineering" });
            cmbMajor.Location = new Point(196, 108);
            cmbMajor.Name = "cmbMajor";
            cmbMajor.Size = new Size(176, 29);
            cmbMajor.TabIndex = 3;
            // 
            // CodeLabel
            // 
            CodeLabel.AutoSize = true;
            CodeLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CodeLabel.Location = new Point(466, 49);
            CodeLabel.Name = "CodeLabel";
            CodeLabel.Size = new Size(60, 25);
            CodeLabel.TabIndex = 4;
            CodeLabel.Text = "Code:";
            // 
            // GpsLabel
            // 
            GpsLabel.AutoSize = true;
            GpsLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GpsLabel.Location = new Point(466, 108);
            GpsLabel.Name = "GpsLabel";
            GpsLabel.Size = new Size(51, 25);
            GpsLabel.TabIndex = 6;
            GpsLabel.Text = "GPA:";
            // 
            // txtGPA
            // 
            txtGPA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGPA.Location = new Point(536, 105);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(72, 29);
            txtGPA.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(65, 201);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 35);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(228, 201);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 35);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(536, 201);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 35);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save File";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(386, 201);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 35);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // SearchLabel
            // 
            SearchLabel.AutoSize = true;
            SearchLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchLabel.Location = new Point(40, 281);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(73, 25);
            SearchLabel.TabIndex = 12;
            SearchLabel.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(118, 278);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(230, 29);
            txtSearch.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colID, colName, colCode, colMajor, colGPA });
            dataGridView1.Location = new Point(83, 351);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(573, 48);
            dataGridView1.TabIndex = 14;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Width = 50;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.Width = 200;
            // 
            // colCode
            // 
            colCode.HeaderText = "Code";
            colCode.Name = "colCode";
            colCode.Width = 50;
            // 
            // colMajor
            // 
            colMajor.HeaderText = "Major";
            colMajor.Name = "colMajor";
            colMajor.Width = 160;
            // 
            // colGPA
            // 
            colGPA.HeaderText = "GPA";
            colGPA.Name = "colGPA";
            colGPA.Width = 70;
            // 
            // txtCode
            // 
            txtCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCode.Location = new Point(536, 49);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(176, 29);
            txtCode.TabIndex = 15;
            // 
            // StudentManagementSystem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 450);
            Controls.Add(txtCode);
            Controls.Add(dataGridView1);
            Controls.Add(txtSearch);
            Controls.Add(SearchLabel);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtGPA);
            Controls.Add(GpsLabel);
            Controls.Add(CodeLabel);
            Controls.Add(cmbMajor);
            Controls.Add(txtName);
            Controls.Add(lblMajor);
            Controls.Add(txtLabel);
            Name = "StudentManagementSystem";
            Text = "Student Management System";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtLabel;
        private Label lblMajor;
        private TextBox txtName;
        private ComboBox cmbMajor;
        private Label CodeLabel;
        private Label GpsLabel;
        private TextBox txtGPA;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnSave;
        private Button btnDelete;
        private Label SearchLabel;
        private TextBox txtSearch;
        private DataGridView dataGridView1;
        private SaveFileDialog saveFileDialog;
        private TextBox txtCode;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCode;
        private DataGridViewTextBoxColumn colMajor;
        private DataGridViewTextBoxColumn colGPA;
    }
}