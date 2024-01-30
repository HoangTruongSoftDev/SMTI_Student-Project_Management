using SMTI_Student_Project_Management.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMTI_Student_Project_Management.GUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxId.Text);
            string password = textBoxPassword.Text;
            string role = comboBoxRole.Text;

            switch (role)
            {
                case "Student":
                    {
                        Student newStudent = new Student();
                        newStudent = newStudent.GetStudent(id);
                        if (newStudent.StudentId == id)
                        {
                            if (newStudent.Password == password)
                            {
                                MessageBox.Show("Login successfully", "Sucessfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Application.Run(new FormProjectAssigned());
                            }
                            else
                            {
                                MessageBox.Show("The password is wrong please retry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBoxId.Focus();
                                textBoxId.Text = "";
                                textBoxPassword.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("The student id is wrong please retry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxId.Focus();
                            textBoxId.Text = "";
                            textBoxPassword.Text = "";
                        }
                        break;
                    }
                case "Teacher":
                    {
                        Teacher newTeacher = new Teacher();
                        newTeacher = newTeacher.GetTeacher(id);
                        if (newTeacher.TeacherId == id)
                        {
                            if (newTeacher.Password == password)
                            {
                                MessageBox.Show("Login successfully", "Sucessfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Application.Run(new FormProjectAssignment());
                            }
                            else
                            {
                                MessageBox.Show("The password is wrong please retry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBoxId.Focus();
                                textBoxId.Text = "";
                                textBoxPassword.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("The teacher id is wrong please retry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxId.Focus();
                            textBoxId.Text = "";
                            textBoxPassword.Text = "";
                        }
                        break;
                    }
                    default:
                    {
                        MessageBox.Show("Please choose the role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show("The teacher id is wrong please retry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxId.Focus();
                        textBoxId.Text = "";
                        textBoxPassword.Text = "";
                        break;
                    }
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (comboBoxRole.Text == "Student")
            {
                labelID.Text = "Student ID";
            }
            else if (comboBoxRole.Text == "Teacher")
            {
                labelID.Text = "Teacher ID";
            }
        }
    }
}
