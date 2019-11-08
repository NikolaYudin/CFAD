using CFAD.Models.Companys;
using CFAD.Models.Projects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFAD.Models
{
    public class MySQLDBContext : DbContext
    {
        public MySQLDBContext(DbContextOptions<MySQLDBContext> options)
        : base(options)
        {
        }
        public DbSet<Company> tb_Company { get; set; }
        public DbSet<User> tb_User { get; set; }
        public DbSet<Project> tb_Project { get; set; }
    }
}
