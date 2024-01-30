using SMTI_Student_Project_Management.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMTI_Student_Project_Management.DAL
{
    public static class TeacherDB
    {
        public static Teacher GetRecord(int id)
        {
            Teacher newTeacher = new Teacher();

            SqlConnection conn = Utility.GetConnectionDB();
            SqlCommand cmdSelectTeacher = new SqlCommand();
            cmdSelectTeacher.Connection = conn;
            cmdSelectTeacher.CommandText = "SELECT * FROM Teachers WHERE TeacherId = @id";
            cmdSelectTeacher.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmdSelectTeacher.ExecuteReader();
            if (reader.Read())
            {
                newTeacher.TeacherId = (int)reader["TeacherId"];
                newTeacher.FirstName = reader["FirstName"].ToString();
                newTeacher.LastName = reader["LastName"].ToString();
                newTeacher.Password = reader["Password"].ToString();
            }
            conn.Close();
            return newTeacher;
        }
    }
}
