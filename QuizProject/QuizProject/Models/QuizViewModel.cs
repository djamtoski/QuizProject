using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuizProject.Models
{
    public class QuizViewModel
    {
        [Required]
        public int QuizId { get; set; }

        [Required]
        public string Difficulty { get; set; }

        public string Image_url { get; set; }

        [Required]
        public string QuizTitle { get; set; }

        public string CategoryName { get; set; }

        public string Helper { get; set; }

    }


}