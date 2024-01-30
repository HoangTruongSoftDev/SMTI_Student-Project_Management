using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMTI_Student_Project_Management.BLL;
namespace SMTI_Student_Project_Management.DAL
{
    public static class StudentDB
    {
        public static List<Student> GetAllRecords()
        {
            List<Student> listS = new List<Student>();

            using (SqlConnection conn = Utility.GetConnectionDB()) //use this way we don't need to close the Database connection because it will close it automatically
            {
                SqlCommand cmdSelect = new SqlCommand("SELECT * FROM Students", conn);
                SqlDataReader reader = cmdSelect.ExecuteReader();
                Student s;
                while (reader.Read())
                {
                    s = new Student();
                    s.StudentId = Convert.ToInt32(reader["StudentId"]);
                    s.FirstName = reader["FirstName"].ToString();
                    s.LastName = reader["LastName"].ToString();
                    s.Password = reader["Password"].ToString();
                    listS.Add(s);
                }
            }
            return listS;
        }

        public static Student GetRecord(int id)
        {
            Student newStudent = new Student();
            using (SqlConnection conn = Utility.GetConnectionDB())
            {
                SqlCommand cmdSelectStudent = new SqlCommand("SELECT * FROM Students WHERE StudentId = @id;", conn);
                cmdSelectStudent.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmdSelectStudent.ExecuteReader();
                if (reader.Read())
                {
                    newStudent.StudentId = (int)(reader["StudentId"]);
                    newStudent.FirstName = reader["FirstName"].ToString();
                    newStudent.LastName = reader["LastName"].ToString();
                    newStudent.Password = reader["Password"].ToString();
                }
            }
                return newStudent;
        }
        
    }
}
