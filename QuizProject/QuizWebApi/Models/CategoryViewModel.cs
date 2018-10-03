using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuizWebApi.Models
{
    public class CategoryViewModel
    {

        public int CategoryId { get; set; }

        [Required]       
        [Display(Name = "Category Name:")]
        public string CategoryName { get; set; }

        [Display(Name = "Image url:")]
        public string Image_url { get; set; }
    }
}