using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTI_Student_Project_Management.BLL
{
    public class User
    {
        private int userId;
        private string password;
        private string logInAs;

        public int UserId { get { return userId; } set { userId = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string LogInAs { get { return logInAs; } set {logInAs = value; } } //log in as student or teacher
    }
}
