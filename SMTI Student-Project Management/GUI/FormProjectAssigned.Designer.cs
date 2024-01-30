namespace SMTI_Student_Project_Management.GUI
{
    partial class FormProjectAssigned
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonViewProject = new System.Windows.Forms.Button();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonViewStudent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxProject = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.listViewStudent = new System.Windows.Forms.ListView();
            this.columnHeaderStudentId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewProject = new System.Windows.Forms.ListView();
            this.columnHeaderProjectId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProjectTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDueDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonViewProject);
            this.groupBox2.Controls.Add(this.comboBoxStudent);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(109, -20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 156);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Get Project by Student";
            // 
            // buttonViewProject
            // 
            this.buttonViewProject.Location = new System.Drawing.Point(20, 109);
            this.buttonViewProject.Name = "buttonViewProject";
            this.buttonViewProject.Size = new System.Drawing.Size(121, 32);
            this.buttonViewProject.TabIndex = 21;
            this.buttonViewProject.Text = "View Project";
            this.buttonViewProject.UseVisualStyleBackColor = true;
            this.buttonViewProject.Click += new System.EventHandler(this.buttonViewProject_Click);
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(20, 68);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStudent.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Select Student";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonViewStudent);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxProject);
            this.groupBox1.Location = new System.Drawing.Point(383, -18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 155);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Get Student by Project";
            // 
            // buttonViewStudent
            // 
            this.buttonViewStudent.Location = new System.Drawing.Point(26, 107);
            this.buttonViewStudent.Name = "buttonViewStudent";
            this.buttonViewStudent.Size = new System.Drawing.Size(121, 32);
            this.buttonViewStudent.TabIndex = 20;
            this.buttonViewStudent.Text = "View Student";
            this.buttonViewStudent.UseVisualStyleBackColor = true;
            this.buttonViewStudent.Click += new System.EventHandler(this.buttonViewStudent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Select Project";
            // 
            // comboBoxProject
            // 
            this.comboBoxProject.FormattingEnabled = true;
            this.comboBoxProject.Location = new System.Drawing.Point(26, 66);
            this.comboBoxProject.Name = "comboBoxProject";
            this.comboBoxProject.Size = new System.Drawing.Size(121, 24);
            this.comboBoxProject.TabIndex = 17;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(648, 331);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(94, 49);
            this.buttonClear.TabIndex = 28;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // listViewStudent
            // 
            this.listViewStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderStudentId,
            this.columnHeaderFirstName,
            this.columnHeaderLastName});
            this.listViewStudent.GridLines = true;
            this.listViewStudent.HideSelection = false;
            this.listViewStudent.Location = new System.Drawing.Point(58, 379);
            this.listViewStudent.Name = "listViewStudent";
            this.listViewStudent.Size = new System.Drawing.Size(520, 91);
            this.listViewStudent.TabIndex = 27;
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
            this.listViewProject.Location = new System.Drawing.Point(58, 161);
            this.listViewProject.Name = "listViewProject";
            this.listViewProject.Size = new System.Drawing.Size(520, 181);
            this.listViewProject.TabIndex = 26;
            this.listViewProject.UseCompatibleStateImageBehavior = false;
            this.listViewProject.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderProjectId
            // 
            this.columnHeaderProjectId.Text = "Project ID";
            // 
            // columnHeaderProjectTitle
            // 
            this.columnHeaderProjectTitle.Text = "Project Title";
            // 
            // columnHeaderDueDate
            // 
            this.columnHeaderDueDate.Text = "Due Date";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(648, 421);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(94, 49);
            this.buttonExit.TabIndex = 25;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormProjectAssigned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.listViewStudent);
            this.Controls.Add(this.listViewProject);
            this.Controls.Add(this.buttonExit);
            this.Name = "FormProjectAssigned";
            this.Text = "FormProjectAssigned";
            this.Load += new System.EventHandler(this.FormProjectAssigned_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonViewProject;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonViewStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxProject;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ListView listViewStudent;
        private System.Windows.Forms.ColumnHeader columnHeaderStudentId;
        private System.Windows.Forms.ColumnHeader columnHeaderFirstName;
        private System.Windows.Forms.ColumnHeader columnHeaderLastName;
        private System.Windows.Forms.ListView listViewProject;
        private System.Windows.Forms.ColumnHeader columnHeaderProjectId;
        private System.Windows.Forms.ColumnHeader columnHeaderProjectTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderDueDate;
        private System.Windows.Forms.Button buttonExit;
    }
}