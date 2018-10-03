using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string AspNetUserId { get; set; }
        public string Username { get; set; }

        public virtual QuizUserStats QuizUserStats { get; set; }
    }
}
