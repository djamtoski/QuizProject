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
    public class QuizUserStatsRepository : IQuizUserStatsRepository
    {
        private QuizContext db;

        public QuizUserStatsRepository()
        {
            db = new QuizContext();
        }


        public void Delete(QuizUserStats quizUserStats)
        {
            if (quizUserStats != null)
            {
                db.QuizUserStats.Remove(quizUserStats);
                db.SaveChanges();
            }
        }


        public void Delete(int quizUserStatsId)
        {
            var quizUserStats = GetByID(quizUserStatsId);
            Delete(quizUserStats);
        }


        public bool Exists(int quizUserStatsId)
        {
            return GetAll().Any(t => t.QuizStatsId == quizUserStatsId);
        }


        public IQueryable<QuizUserStats> GetAll()
        {
            return db.QuizUserStats;
        }


        public QuizUserStats GetByID(int id)
        {
            return GetAll().SingleOrDefault(t => t.QuizStatsId == id);
        }


        public void Insert(QuizUserStats quizUserStats)
        {
            if (quizUserStats == null)
            {
                return;
            }
            db.QuizUserStats.Add(quizUserStats);
            db.SaveChanges();
        }


        public void Update(QuizUserStats quizUserStats)
        {
            if (quizUserStats != null && Exists(quizUserStats.QuizStatsId))
            {
                db.SaveChanges();
            }

        }
    }
}
