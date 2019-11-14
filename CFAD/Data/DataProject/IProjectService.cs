using CFAD.Models.Projects;
using System;
using System.Collections.Generic;

namespace CFAD.Data
{
    public interface IProjectService
    {
        public List<Project> GetProjects(); 
        public List<Project> GetProjectAdd(Guid CompanyId, string Name); 
        public string GetVersion();
        public DateTime GetCreatedDate();
        public Project GetProjectById(Guid ProjectId);

        
    }
}