using CFAD.Models.Companys;
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
    }
}
