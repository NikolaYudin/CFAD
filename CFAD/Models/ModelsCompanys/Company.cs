using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFAD.Models.Companys
{
    public class Company
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Addres { get; set; }
    }
}
