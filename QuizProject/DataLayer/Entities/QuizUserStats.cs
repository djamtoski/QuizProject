using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class QuizUserStats
    {
        public int QuizStatsId { get; set; }
        public int QuizId { get; set; }
        public int UserId { get; set; }
        public int Score { get; set; }
        public DateTime TimePlayed { get; set; }

        public virtual Quize Quiz { get; set; }
        public virtual User User { get; set; }
    }
}
