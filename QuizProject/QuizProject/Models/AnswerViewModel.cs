using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizProject.Models
{
    public class AnswerViewModel
    {
        public int AnswerId { get; set; }
        public int ForQuestionId { get; set; }
        public bool Correct { get; set; }
        public string AnswerExplanation { get; set; }
    }
}