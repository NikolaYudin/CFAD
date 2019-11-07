using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFAD.Models.Companys
{
    public class Company
    {
        //public Company(string v1, string v2, string v3, string v4)
        //{
        //    this.Id = v1;
        //    this.Name = v2;
        //    this.Phone = v3;
        //    this.Adress = v4;
        //}

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Addres { get; set; }
    }
}
