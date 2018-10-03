using BusinessLayer.Interfaces;
using DataLayer.Contexts;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repositories
{
    public class QuizRepository : IQuizRepository
    {
        private QuizContext db;

        public QuizRepository()
        {
            db = new QuizContext();
        }

        public void Delete(Quize quiz)
        {
            if (quiz != null)
            {
                db.Quizes.Remove(quiz);
                db.SaveChanges();
            }

        }

        public void Delete(int quizID)
        {
            var Quiz = GetByID(quizID);
            Delete(Quiz);
        }

        public bool Exists(int quizID)
        {
            return GetAll().Any(t => t.QuizId == quizID);
        }

        public IQueryable<Quize> GetAll()
        {
            return db.Quizes;
        }

        public Quize GetByID(int id)
        {
            return GetAll().SingleOrDefault(t => t.QuizId == id);
        }

        public void Insert(Quize quiz)
        {
            if (quiz == null)
            {
                return;
            }
            db.Quizes.Add(quiz);
            db.SaveChanges();
        }

        public void Update(Quize quiz)
        {
            if (quiz != null && Exists(quiz.QuizId))
            {
                db.SaveChanges();
            }

        }
    }
}
