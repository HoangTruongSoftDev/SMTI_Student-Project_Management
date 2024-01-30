using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMTI_Student_Project_Management.BLL;
namespace SMTI_Student_Project_Management.DAL
{
    public static class ProjectDB
    {
        public static List<Project> GetAllRecords()
        {
            List<Project> listP = new List<Project>();
            using (SqlConnection conn = Utility.GetConnectionDB())
            {
                SqlCommand cmdSelectProjects = new SqlCommand("SELECT * FROM Projects",conn);
                SqlDataReader reader = cmdSelectProjects.ExecuteReader();
                Project currentProject;
                while (reader.Read())
                {
                    currentProject = new Project();
                    currentProject.ProjectCode = reader["ProjectCode"].ToString();
                    currentProject.ProjectTitle = reader["ProjectTitle"].ToString();
                    currentProject.DueDate = (DateTime)reader["DueDate"];
                    listP.Add(currentProject);
                }
            }
            return listP;
        }
    }
}
