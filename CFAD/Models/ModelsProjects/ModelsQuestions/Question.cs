using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFAD.Models.Projects.Questions
{
    public class Question
    {
        public string Id { get; set; }
        public string IdProject { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
    }
}
