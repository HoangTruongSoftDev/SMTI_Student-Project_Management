using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMTI_Student_Project_Management.BLL;
namespace SMTI_Student_Project_Management.DAL
{
    public static class StudentProjectDB
    {
        
        public static List<Project> GetSpecificRecordsBySid(int id)
        {
            List<Project> listP = new List<Project>();
            using (SqlConnection conn = Utility.GetConnectionDB())
            {
                SqlCommand cmdSelectProjects = new SqlCommand("SELECT p.ProjectCode, p.ProjectTitle, p.DueDate " +
                                                              "FROM ProjectAssignments pa " +
                                                              "JOIN Projects p " +
                                                              "ON p.ProjectCode = pa.ProjectCode " +
                                                              "WHERE pa.StudentId = @id;",conn);
                cmdSelectProjects.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmdSelectProjects.ExecuteReader();
                Project newProject;
                while (reader.Read())
                {
                    newProject = new Project();
                    newProject.ProjectCode = reader["ProjectCode"].ToString();
                    newProject.ProjectTitle = reader["ProjectTitle"].ToString();
                    newProject.DueDate = (DateTime)reader["DueDate"];
                    listP.Add(newProject);
                }
            }
                return listP;
        }
        public static List<Student> GetSpecificRecordsByPcode(string pcode)
        {
            List<Student> listS = new List<Student>();
            SqlConnection conn = Utility.GetConnectionDB();
            SqlCommand cmdSelectStudents = new SqlCommand();
            cmdSelectStudents.Connection = conn;
            cmdSelectStudents.CommandText = "SELECT s.StudentId, s.FirstName, s.LastName " +
                                            "FROM Students s " +
                                            "JOIN ProjectAssignments pa " +
                                            "ON s.StudentId = pa.StudentId " +
                                            "WHERE pa.ProjectCode = @pcode;";
            cmdSelectStudents.Parameters.AddWithValue("@pcode", pcode);
            SqlDataReader reader = cmdSelectStudents.ExecuteReader();
            Student newStudent;
            while(reader.Read())
            {
                newStudent = new Student();
                newStudent.StudentId = Convert.ToInt32(reader["StudentId"]);
                newStudent.FirstName = reader["FirstName"].ToString();
                newStudent.LastName = reader["LastName"].ToString();
                listS.Add(newStudent);
            }
            conn.Close();
            return listS;
        }
        public static StudentProject GetRecord(int studentId, string pCode)
        {
            StudentProject studentProject = new StudentProject();
            using (SqlConnection conn = Utility.GetConnectionDB())
            {
                SqlCommand cmdSelectRecord = new SqlCommand("SELECT * FROM ProjectAssignments WHERE StudentId = @studentId AND ProjectCode = @pCode;",conn);
                cmdSelectRecord.Parameters.AddWithValue("@studentId", studentId);
                cmdSelectRecord.Parameters.AddWithValue("@pCode",pCode);
                SqlDataReader reader = cmdSelectRecord.ExecuteReader();
                if (reader.Read())
                {
                    studentProject.StudentId = Convert.ToInt32(reader["StudentId"]);
                    studentProject.ProjectCode = reader["ProjectCode"].ToString();
                    studentProject.AssignmentDate = Convert.ToDateTime(reader["AssignmentDate"]);
                    studentProject.SubmissionDate = Convert.ToDateTime(reader["SubmissionDate"]);
                }
            }

                return studentProject;
        }
        public static void SaveRecord(StudentProject studentProject)
        {
            SqlConnection conn = Utility.GetConnectionDB();
            SqlCommand cmdInsert = new SqlCommand("INSERT INTO ProjectAssignments VALUES (@studentId, @projectCode, @assignmentDate, @submissionDate);",conn);
            cmdInsert.Parameters.AddWithValue("@studentId", studentProject.StudentId);
            cmdInsert.Parameters.AddWithValue("@projectCode", studentProject.ProjectCode);
            cmdInsert.Parameters.AddWithValue("@assignmentDate", studentProject.AssignmentDate);
            cmdInsert.Parameters.AddWithValue("@submissionDate", studentProject.SubmissionDate);
            cmdInsert.ExecuteNonQuery();
            conn.Close();
        }
        public static List<StudentProject> GetAllRecords()
        {
            List<StudentProject> listSP = new List<StudentProject>();
            using (SqlConnection conn = Utility.GetConnectionDB())
            {
                SqlCommand cmdSelect = new SqlCommand("SELECT * FROM ProjectAssignments;",conn);
                SqlDataReader reader = cmdSelect.ExecuteReader();
                StudentProject studentProject;
                while (reader.Read())
                {
                    studentProject = new StudentProject();
                    studentProject.StudentId = (int)reader["StudentId"];
                    studentProject.ProjectCode = reader["ProjectCode"].ToString();
                    studentProject.AssignmentDate = (DateTime)reader["AssignmentDate"];
                    studentProject.SubmissionDate = Convert.ToDateTime(reader["SubmissionDate"]);
                    listSP.Add(studentProject);
                }
            }
            return listSP;
        }
    }
}
