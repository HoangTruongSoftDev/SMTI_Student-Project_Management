using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMTI_Student_Project_Management.DAL;

namespace SMTI_Student_Project_Management.BLL
{
    public class StudentProject
    {
        private int studentId;
        private string projectCode;
        private DateTime assignmentDate;
        private DateTime submissionDate;

        public int StudentId { get { return studentId; } set { studentId = value; } }
        public string ProjectCode { get { return projectCode; } set { projectCode = value; } }
        public DateTime AssignmentDate { get { return assignmentDate; } set { assignmentDate = value; } }
        public DateTime SubmissionDate { get { return submissionDate; } set { submissionDate = value; } }

        public List<Student> GetAllStudentsByPcode(string projectCode)
        {
            return StudentProjectDB.GetSpecificRecordsByPcode(projectCode);
        }

        public List<Project> GetAllProjectBySid(int studentId)
        {
            return StudentProjectDB.GetSpecificRecordsBySid(studentId);
        }
        public StudentProject GetStudentProject(int studentId, string pCode)
        {
            return StudentProjectDB.GetRecord(studentId, pCode);
        }
        public void SaveStudentProject(StudentProject studentProject)
        {
            StudentProjectDB.SaveRecord(studentProject);
        }
        public void DisplayList(ListView listV, List<StudentProject> listSP)
        {
            listV.Items.Clear();
            foreach(StudentProject itemSP in listSP)
            {
                ListViewItem listVItem = new ListViewItem(itemSP.StudentId.ToString());
                listVItem.SubItems.Add(itemSP.ProjectCode);
                listVItem.SubItems.Add(itemSP.AssignmentDate.ToString());
                listVItem.SubItems.Add(itemSP.SubmissionDate.ToString());
                listV.Items.Add(listVItem);
            }
        }
        public List<StudentProject> GetAllStudentProjects()
        {
            return StudentProjectDB.GetAllRecords();
        }
    }
}
