using CFAD.Models;
using CFAD.Models.Companys;
using CFAD.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFAD.Data
{
    public class ProjectService : IProjectService
    {
        public DateTime CreationDate { get; set; }
        public List<Project> ProjectList { get; set; }

        public ProjectService(ApplicationDbContext context)
        {
            CreationDate = DateTime.Now;

            ProjectList = context.CFAD_Project.ToList<Project>();
        }

        public List<Project> GetProjects()
        {
            return ProjectList;
        }

        public List<Project> GetProjectAdd(Guid CompanyId, string Name)
        {
            ProjectList.Add(new Project { Id = Guid.NewGuid(), IdCompany = CompanyId, Name = Name, Visible = false, IsOnlain = false, VisibleCustomer = false });

            return ProjectList;
        }

        public Project GetProjectById(Guid ProjectId)
        {
            return ProjectList.Where(us => us.Id == ProjectId).FirstOrDefault();
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
