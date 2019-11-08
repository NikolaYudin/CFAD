using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFAD.Models.Projects
{
    public class Project
    {
        public string Id { get; set; }
        public string IdCompany { get; set; }
        public string Name { get; set; }
        public bool isOnlain { get; set; }
        public bool isAction { get; set; }
        public bool isVisibleCostumer { get; set; }
    }
}
