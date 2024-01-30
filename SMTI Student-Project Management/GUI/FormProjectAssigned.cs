using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMTI_Student_Project_Management.BLL;
namespace SMTI_Student_Project_Management.GUI
{
    public partial class FormProjectAssigned : Form
    {
        public FormProjectAssigned()
        {
            InitializeComponent();
        }
        private void DisplayList(ListView listV,List<Project> listP)
        {
            listV.Items.Clear();
            foreach (Project currentProject in listP)
            {
                ListViewItem listVItem = new ListViewItem(currentProject.ProjectCode);
                listVItem.SubItems.Add(currentProject.ProjectTitle);
                listVItem.SubItems.Add(currentProject.DueDate.ToString());
                listV.Items.Add(listVItem);
            }
        }
        private void DisplayList(ListView listV, List<Student> listS)
        {
            listV.Items.Clear();
            foreach (Student currentStudent in listS)
            {
                ListViewItem listVItem = new ListViewItem(Convert.ToString(currentStudent.StudentId));
                listVItem.SubItems.Add(currentStudent.FirstName);
                listVItem.SubItems.Add(currentStudent.LastName);
                listV.Items.Add(listVItem);
            }
        }
        private void buttonViewProject_Click(object sender, EventArgs e)
        {
            int studentId = Convert.ToInt32(comboBoxStudent.Text);
            StudentProject sp = new StudentProject();
            List<Project> listProjects = sp.GetAllProjectBySid(studentId);
            DisplayList(listViewProject, listProjects);
        }

        private void FormProjectAssigned_Load(object sender, EventArgs e)
        {
            Student newStudent = new Student();
            List<Student> listS = new List<Student>();
            listS = newStudent.GetAllStudents();
            foreach (Student currentStudent in listS)
            {
                comboBoxStudent.Items.Add(currentStudent.StudentId);
            }

            Project newProject = new Project();
            List<Project> listP = new List<Project>();
            listP = newProject.GetAllProjects();
            foreach (Project currentProject in listP)
            {
                comboBoxProject.Items.Add(currentProject.ProjectCode);
            }
        }

        private void buttonViewStudent_Click(object sender, EventArgs e)
        {
            string pCode = comboBoxProject.Text;           
            StudentProject pa = new StudentProject();
            List<Student> listS = pa.GetAllStudentsByPcode(pCode);
            DisplayList(listViewStudent, listS);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listViewProject.Items.Clear();
            listViewStudent.Items.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            var asking = MessageBox.Show("Do you want to exit the application? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (asking ==DialogResult.Yes)
            {
                MessageBox.Show("Thank you for using our application", "Exit Sucessfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
    }
}
