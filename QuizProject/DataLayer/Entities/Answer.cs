using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public int ForQuestionId { get; set; }
        public bool Correct { get; set; }
        public string AnswerExplanation { get; set; }

        public virtual QuizQuestion QuizQuestion { get; set; }
    }
}
