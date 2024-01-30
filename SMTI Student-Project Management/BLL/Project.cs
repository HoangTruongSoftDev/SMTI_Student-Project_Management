using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMTI_Student_Project_Management.DAL;

namespace SMTI_Student_Project_Management.BLL
{
    public class Project
    {
        private string projectCode;
        private string projectTitle;
        private DateTime dueDate;

        public string ProjectCode
        {
            get { return projectCode; }
            set { projectCode = value; }
        }
        public string ProjectTitle { get { return projectTitle; } set { projectTitle = value; } }
        public DateTime DueDate { get { return dueDate; } set {dueDate = value; } }
        public List<Project> GetAllProjects()
        {
            return ProjectDB.GetAllRecords();
        }
        public void DisplayList(ListView listV, List<Project> listP)
        {
            listV.Items.Clear();
            foreach (Project itemP in listP)
            {
                ListViewItem listVItem = new ListViewItem(itemP.ProjectCode);
                listVItem.SubItems.Add(itemP.ProjectTitle);
                listVItem.SubItems.Add(Convert.ToString(itemP.DueDate));
                listV.Items.Add(listVItem);
            }
        }
    }
}
