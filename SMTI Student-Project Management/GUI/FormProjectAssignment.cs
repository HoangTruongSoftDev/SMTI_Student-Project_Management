using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMTI_Student_Project_Management.BLL;
using SMTI_Student_Project_Management.VALIDATION;
namespace SMTI_Student_Project_Management.GUI
{
    public partial class FormProjectAssignment : Form
    {
        public FormProjectAssignment()
        {
            InitializeComponent();
        }

        private void FormProjectAssignment_Load(object sender, EventArgs e)
        {
            Student newStudent = new Student();
            List<Student> listS = newStudent.GetAllStudents();
            foreach (Student currentStudent in listS)
            {
                comboBoxStudent.Items.Add(currentStudent.StudentId);
            }

            Project newProject = new Project();
            List<Project> listP = newProject.GetAllProjects();
            foreach (Project currentProject in listP)
            {
                comboBoxProject.Items.Add(currentProject.ProjectCode);
            }
        }

        private void buttonAssignProject_Click(object sender, EventArgs e)
        {
            if (!Validation.IsDuplicated(Convert.ToInt32(comboBoxStudent.Text),comboBoxProject.Text))
            {
                if (!Validation.IsExceedLimitProject(Convert.ToInt32(comboBoxStudent.Text)))
                {
                    StudentProject studentProject = new StudentProject();
                    studentProject.StudentId = Convert.ToInt32(comboBoxStudent.Text);
                    studentProject.ProjectCode = comboBoxProject.Text;
                    studentProject.AssignmentDate = Convert.ToDateTime(dateTimePickerAssigDate.Text);
                    studentProject.SubmissionDate = Convert.ToDateTime(dateTimePickerSubmitDate.Text);
                    studentProject.SaveStudentProject(studentProject);
                }
                else
                {
                    MessageBox.Show("This student already has been assigned for 3 projects", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("This student already has been assigned for this project", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonViewProject_Click(object sender, EventArgs e)
        {
            Project newProject = new Project();
            List<Project> listP = newProject.GetAllProjects();
            newProject.DisplayList(listViewProject, listP);
        }
        
        private void buttonViewStudent_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student();
            List<Student> listS = newStudent.GetAllStudents();
            newStudent.DisplayList(listViewStudent, listS);
        }

        private void buttonViewProjectAssignment_Click(object sender, EventArgs e)
        {
            StudentProject sp = new StudentProject();
            List<StudentProject> listSP = sp.GetAllStudentProjects();
            sp.DisplayList(listViewProjectAssignments, listSP);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            var asking = MessageBox.Show("Do you want to exit the application? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (asking == DialogResult.Yes)
            {
                MessageBox.Show("Thank you for using our application", "Exit Sucessfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
    }
}
