using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFAD.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int IdRole { get; set; }
        public Guid IdCompany { get; set; }

    }
}
