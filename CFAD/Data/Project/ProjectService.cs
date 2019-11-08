using CFAD.Models;
using CFAD.Models.Companys;
using CFAD.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFAD.Data
{
    public class ProjectService: IProjectService
    { 
        public DateTime CreationDate { get; set; }
        public List<Project> ProjectList { get; set; }

        public ProjectService(MySQLDBContext context)
        {
            CreationDate = DateTime.Now;

            ProjectList = context.tb_Project.ToList<Project>();
        }

        public List<Project> GetProjects()
        {
            return ProjectList;
        }
        public Project GetProjectById(string ProjectId)
        {
            return ProjectList.Where(us => us.Id.ToString() == ProjectId).FirstOrDefault();
        }

        public DateTime GetCreatedDate()
        {
            return CreationDate;
        }

        public string GetVersion()
        {
            return "v1";
        }
    }
}
