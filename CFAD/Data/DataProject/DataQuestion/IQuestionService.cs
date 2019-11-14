using CFAD.Models.Projects;
using CFAD.Models.Projects.Questions;
using System;
using System.Collections.Generic;

namespace CFAD.Data
{
    public interface IQuestionService
    {
        public List<Question> GetQuestions(); 
        public string GetVersion();
        public DateTime GetCreatedDate();
        public Question GetQuestionById(Guid QuestionId);
        public List<Question> GetQuestionAdd(Guid ProjectId);
    }
}