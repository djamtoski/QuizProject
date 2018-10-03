using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizProject.Models
{
    public class OverallViewModel
    {
        public AnswerViewModel AnswerViewModel { get; set; }
        public UserViewModel UserViewModel { get; set; }
        public QuizUserStatsViewModel QuizUserStatsViewModel { get; set; }
        public CategoryViewModel CategoryViewModel { get; set; }
        public QuizViewModel QuizViewModel { get; set; }
        public QuizQuestionViewModel QuizQuestionViewModel { get; set; }
    }
}