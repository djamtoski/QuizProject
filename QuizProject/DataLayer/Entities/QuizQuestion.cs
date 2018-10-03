using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class QuizQuestion
    {
        public int QuestionId { get; set; }
        public int ForQuizId { get; set; }
        public string QuestionText { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
        public virtual Quize Quiz { get; set; }
    }
}
