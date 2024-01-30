namespace SMTI_Student_Project_Management.GUI
{
    partial class FormProjectAssignment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonViewProjectAssignment = new System.Windows.Forms.Button();
            this.listViewProjectAssignments = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewStudent = new System.Windows.Forms.ListView();
            this.columnHeaderStudentId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewProject = new System.Windows.Forms.ListView();
            this.columnHeaderProjectId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProjectTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDueDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonViewProject = new System.Windows.Forms.Button();
            this.buttonViewStudent = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAssignProject = new System.Windows.Forms.Button();
            this.dateTimePickerAssigDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSubmitDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxProject = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonViewProjectAssignment
            // 
            this.buttonViewProjectAssignment.Location = new System.Drawing.Point(559, 524);
            this.buttonViewProjectAssignment.Name = "buttonViewProjectAssignment";
            this.buttonViewProjectAssignment.Size = new System.Drawing.Size(182, 37);
            this.buttonViewProjectAssignment.TabIndex = 22;
            this.buttonViewProjectAssignment.Text = "View Project Assignment";
            this.buttonViewProjectAssignment.UseVisualStyleBackColor = true;
            this.buttonViewProjectAssignment.Click += new System.EventHandler(this.buttonViewProjectAssignment_Click);
            // 
            // listViewProjectAssignments
            // 
            this.listViewProjectAssignments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewProjectAssignments.GridLines = true;
            this.listViewProjectAssignments.HideSelection = false;
            this.listViewProjectAssignments.Location = new System.Drawing.Point(20, 492);
            this.listViewProjectAssignments.Name = "listViewProjectAssignments";
            this.listViewProjectAssignments.Size = new System.Drawing.Size(520, 143);
            this.listViewProjectAssignments.TabIndex = 21;
            this.listViewProjectAssignments.UseCompatibleStateImageBehavior = false;
            this.listViewProjectAssignments.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Student ID";
            this.columnHeader1.Width = 125;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Project ID";
            this.columnHeader2.Width = 122;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Assignment Date";
            this.columnHeader3.Width = 129;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Submission Date";
            this.columnHeader4.Width = 180;
            // 
            // listViewStudent
            // 
            this.listViewStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderStudentId,
            this.columnHeaderFirstName,
            this.columnHeaderLastName});
            this.listViewStudent.GridLines = true;
            this.listViewStudent.HideSelection = false;
            this.listViewStudent.Location = new System.Drawing.Point(20, 370);
            this.listViewStudent.Name = "listViewStudent";
            this.listViewStudent.Size = new System.Drawing.Size(520, 91);
            this.listViewStudent.TabIndex = 19;
            this.listViewStudent.UseCompatibleStateImageBehavior = false;
            this.listViewStudent.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderStudentId
            // 
            this.columnHeaderStudentId.Text = "Student ID";
            this.columnHeaderStudentId.Width = 74;
            // 
            // columnHeaderFirstName
            // 
            this.columnHeaderFirstName.Text = "First Name";
            this.columnHeaderFirstName.Width = 85;
            // 
            // columnHeaderLastName
            // 
            this.columnHeaderLastName.Text = "Last Name";
            this.columnHeaderLastName.Width = 85;
            // 
            // listViewProject
            // 
            this.listViewProject.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderProjectId,
            this.columnHeaderProjectTitle,
            this.columnHeaderDueDate});
            this.listViewProject.GridLines = true;
            this.listViewProject.HideSelection = false;
            this.listViewProject.Location = new System.Drawing.Point(20, 199);
            this.listViewProject.Name = "listViewProject";
            this.listViewProject.Size = new System.Drawing.Size(520, 140);
            this.listViewProject.TabIndex = 18;
            this.listViewProject.UseCompatibleStateImageBehavior = false;
            this.listViewProject.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderProjectId
            // 
            this.columnHeaderProjectId.Text = "Project ID";
            this.columnHeaderProjectId.Width = 115;
            // 
            // columnHeaderProjectTitle
            // 
            this.columnHeaderProjectTitle.Text = "Project Title";
            this.columnHeaderProjectTitle.Width = 120;
            // 
            // columnHeaderDueDate
            // 
            this.columnHeaderDueDate.Text = "Due Date";
            this.columnHeaderDueDate.Width = 139;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(686, 586);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(94, 49);
            this.buttonExit.TabIndex = 17;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonViewProject
            // 
            this.buttonViewProject.Location = new System.Drawing.Point(575, 245);
            this.buttonViewProject.Name = "buttonViewProject";
            this.buttonViewProject.Size = new System.Drawing.Size(138, 38);
            this.buttonViewProject.TabIndex = 16;
            this.buttonViewProject.Text = "View Project";
            this.buttonViewProject.UseVisualStyleBackColor = true;
            this.buttonViewProject.Click += new System.EventHandler(this.buttonViewProject_Click);
            // 
            // buttonViewStudent
            // 
            this.buttonViewStudent.Location = new System.Drawing.Point(575, 386);
            this.buttonViewStudent.Name = "buttonViewStudent";
            this.buttonViewStudent.Size = new System.Drawing.Size(138, 37);
            this.buttonViewStudent.TabIndex = 15;
            this.buttonViewStudent.Text = "View Student";
            this.buttonViewStudent.UseVisualStyleBackColor = true;
            this.buttonViewStudent.Click += new System.EventHandler(this.buttonViewStudent_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonAssignProject);
            this.groupBox1.Controls.Add(this.dateTimePickerAssigDate);
            this.groupBox1.Controls.Add(this.dateTimePickerSubmitDate);
            this.groupBox1.Controls.Add(this.comboBoxStudent);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxProject);
            this.groupBox1.Location = new System.Drawing.Point(20, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 137);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Submission Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Assignment Date";
            // 
            // buttonAssignProject
            // 
            this.buttonAssignProject.Location = new System.Drawing.Point(539, 56);
            this.buttonAssignProject.Name = "buttonAssignProject";
            this.buttonAssignProject.Size = new System.Drawing.Size(138, 40);
            this.buttonAssignProject.TabIndex = 6;
            this.buttonAssignProject.Text = "Assign Project";
            this.buttonAssignProject.UseVisualStyleBackColor = true;
            this.buttonAssignProject.Click += new System.EventHandler(this.buttonAssignProject_Click);
            // 
            // dateTimePickerAssigDate
            // 
            this.dateTimePickerAssigDate.Location = new System.Drawing.Point(36, 99);
            this.dateTimePickerAssigDate.Name = "dateTimePickerAssigDate";
            this.dateTimePickerAssigDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerAssigDate.TabIndex = 4;
            // 
            // dateTimePickerSubmitDate
            // 
            this.dateTimePickerSubmitDate.Location = new System.Drawing.Point(283, 99);
            this.dateTimePickerSubmitDate.Name = "dateTimePickerSubmitDate";
            this.dateTimePickerSubmitDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerSubmitDate.TabIndex = 5;
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(36, 37);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStudent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Project";
            // 
            // comboBoxProject
            // 
            this.comboBoxProject.FormattingEnabled = true;
            this.comboBoxProject.Location = new System.Drawing.Point(283, 37);
            this.comboBoxProject.Name = "comboBoxProject";
            this.comboBoxProject.Size = new System.Drawing.Size(121, 24);
            this.comboBoxProject.TabIndex = 2;
            // 
            // FormProjectAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 667);
            this.Controls.Add(this.buttonViewProjectAssignment);
            this.Controls.Add(this.listViewProjectAssignments);
            this.Controls.Add(this.listViewStudent);
            this.Controls.Add(this.listViewProject);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonViewProject);
            this.Controls.Add(this.buttonViewStudent);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormProjectAssignment";
            this.Text = "FormProjectAssignment";
            this.Load += new System.EventHandler(this.FormProjectAssignment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonViewProjectAssignment;
        private System.Windows.Forms.ListView listViewProjectAssignments;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listViewStudent;
        private System.Windows.Forms.ColumnHeader columnHeaderStudentId;
        private System.Windows.Forms.ColumnHeader columnHeaderFirstName;
        private System.Windows.Forms.ColumnHeader columnHeaderLastName;
        private System.Windows.Forms.ListView listViewProject;
        private System.Windows.Forms.ColumnHeader columnHeaderProjectId;
        private System.Windows.Forms.ColumnHeader columnHeaderProjectTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderDueDate;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonViewProject;
        private System.Windows.Forms.Button buttonViewStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAssignProject;
        private System.Windows.Forms.DateTimePicker dateTimePickerAssigDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerSubmitDate;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxProject;
    }
}