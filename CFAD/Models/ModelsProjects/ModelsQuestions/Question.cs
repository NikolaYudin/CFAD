using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFAD.Models.Projects.Questions
{
    public class Question
    {
        public Guid Id { get; set; }
        public Guid IdProject { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
    }
}
