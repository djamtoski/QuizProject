using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizProject.Models
{
    public class QuizUserStatsViewModel
    {
        public int QuizStatsId { get; set; }
        public int QuizId { get; set; }
        public int UserId { get; set; }
        public int? Score { get; set; }
        public DateTime TimeOccured { get; set; }
    }
}