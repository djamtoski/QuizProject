using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuizWebApi.Models
{
    public class ChatViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Chat message:")]
        public string Message { get; set; }

        public DateTime Time { get; set; }
    }
}