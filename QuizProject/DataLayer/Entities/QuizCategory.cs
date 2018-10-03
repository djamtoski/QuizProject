using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class QuizCategory
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Image_url { get; set; }

        public virtual ICollection<Quize> Quizes { get; set; }
    }
}
