using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuizProject.Models
{
    public class AddEditQuizViewModel
    {
        public int? QuizId { get; set; }
        
        [Required]
        public string Difficulty { get; set; }

        [Required]
        public string Image_url { get; set; }

        [Required]
        public string QuizTitle { get; set; }
        
        public List<CategoryViewModel> CategoryOption { get; set; }

        [Display(Name = "Select category")]
        public int? SelectedCategoryId { get; set; }

        public string Helper { get; set; }

    }
}