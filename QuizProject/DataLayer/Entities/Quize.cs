using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Quize
    {
        public int QuizId { get; set; }
        public int QuizCategoryId { get; set; }
        public string QuizTitle { get; set; }
        public string QuizDifficulty { get; set; }
        public string Image_url { get; set; }
        public string QuizDescription { get; set; }

        public virtual QuizCategory Category { get; set; }
        public virtual QuizUserStats QuizUserStats { get; set; }
        public virtual ICollection<QuizQuestion> QuizQuestions { get; set; }
    }
}
