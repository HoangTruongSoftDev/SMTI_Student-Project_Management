using SMTI_Student_Project_Management.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTI_Student_Project_Management.BLL
{
    public class Teacher
    {
        private int teacherId;
        private string firstName;
        private string lastName;
        private string password;
        public int TeacherId
        {
            get { return teacherId; }
            set { teacherId = value; }
        }
        public string FirstName
            { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }

        public string Password { get => password; set => password = value; }

        public Teacher GetTeacher (int teacherId)
        {
            return TeacherDB.GetRecord(teacherId);
        }
    }
}
