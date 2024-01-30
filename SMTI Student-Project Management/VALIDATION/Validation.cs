using SMTI_Student_Project_Management.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTI_Student_Project_Management.VALIDATION
{
    public static class Validation
    {
        public static bool IsExceedLimitProject(int studentId)
        {
            StudentProject pa = new StudentProject();
            List<Project> listP = pa.GetAllProjectBySid(studentId);
            if (listP.Count() >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsDuplicated(int studentId, string pCode)
        {
            StudentProject studentProject = new StudentProject();
            studentProject = studentProject.GetStudentProject(studentId, pCode);
            if (studentProject.StudentId == studentId && studentProject.ProjectCode == pCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
