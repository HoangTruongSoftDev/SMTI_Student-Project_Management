using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTI_Student_Project_Management.DAL
{
    public static class Utility
    {
        public static SqlConnection GetConnectionDB()
        {
            SqlConnection conn = new SqlConnection();

            #region first way of connect string
            //conn.ConnectionString = "server=MSI\\SQLEXPRESS;database=SMTIStudentProjectDB;user=sa;password=johnkid123";
            #endregion

            #region first way of connect string
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            // make sure that the check box System.Configuration in Reference => Assembly => System.Configuration must be checked
            // then go to AppConfig to add the ConnectionString
            #endregion
            conn.Open();
            return conn;
        }
    }
}
