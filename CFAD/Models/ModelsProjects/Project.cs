using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFAD.Models.Projects
{
    public class Project
    {
        public Guid Id { get; set; }
        public Guid IdCompany { get; set; }
        public string Name { get; set; }
        public bool IsOnlain { get; set; }
        public bool Visible { get; set; }
        public bool VisibleCustomer { get; set; }
    }
}
