using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuizWebApi.Models
{
    public class QuizQuestionViewModel
    {
        public int? QuestionId { get; set; }

        [Required]
        public int ForQuizId { get; set; }
        [Required]
        public string QuestionText { get; set; }

    }
}