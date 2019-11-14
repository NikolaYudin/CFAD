using CFAD.Models.Companys;
using CFAD.Models.Projects;
using CFAD.Models.Projects.Questions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFAD.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        public DbSet<Company> CFAD_Company { get; set; }
        public DbSet<User> CFAD_User { get; set; }
        public DbSet<Project> CFAD_Project { get; set; }
        public DbSet<Question> CFAD_Question { get; set; }
    }
}

