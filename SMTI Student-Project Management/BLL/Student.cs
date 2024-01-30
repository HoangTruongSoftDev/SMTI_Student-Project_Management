using SMTI_Student_Project_Management.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMTI_Student_Project_Management.BLL
{


    public class Student
    {
        private int studentId;
        private string firstName;
        private string lastName;
        private string password;
        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }

        public string Password { get => password; set => password = value; }

        public List<Student> GetAllStudents()
        {
            return StudentDB.GetAllRecords();
        }
        public Student GetStudent(int studentId)
        {
            return StudentDB.GetRecord(studentId);
        }
        public void DisplayList(ListView listV, List<Student> listS)
        {
            listV.Items.Clear();
            foreach (Student itemS in listS)
            {
                ListViewItem listVItem = new ListViewItem(itemS.StudentId.ToString());
                listVItem.SubItems.Add(itemS.FirstName);
                listVItem.SubItems.Add(itemS.LastName);
                listV.Items.Add(listVItem);
            }
        }
    }
}
