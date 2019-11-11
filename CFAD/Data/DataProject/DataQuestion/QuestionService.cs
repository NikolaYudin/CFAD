using CFAD.Models;
using CFAD.Models.Companys;
using CFAD.Models.Projects;
using CFAD.Models.Projects.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFAD.Data
{
    public class QuestionService: IQuestionService
    { 
        public DateTime CreationDate { get; set; }
        public List<Question> QuestionList { get; set; }

        public QuestionService(MySQLDBContext context)
        {
            CreationDate = DateTime.Now;

            QuestionList = context.tb_Question.ToList<Question>();
        }

        public List<Question> GetQuestions()
        {
            return QuestionList;
        }
        public Question GetQuestionById(string QuestionId)
        {
            return QuestionList.Where(us => us.Id.ToString() == QuestionId).FirstOrDefault();
        }

        public DateTime GetCreatedDate()
        {
            return CreationDate;
        }

        public string GetVersion()
        {
            return "v1";
        }

        public List<Question> GetQuestionAdd(string ProjectId)
        {
            QuestionList.Add(new Question { Id = Guid.NewGuid().ToString(), IdProject = ProjectId, Name = "Test", Type = 0 });
            return QuestionList;
        }
    }
}
