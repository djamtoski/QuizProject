using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IQuizUserStatsRepository
    {
        IQueryable<QuizUserStats> GetAll();
        QuizUserStats GetByID(int ID);
        void Insert(QuizUserStats quizUserStats);
        void Update(QuizUserStats quizUserStats);
        void Delete(QuizUserStats quizUserStats);
        void Delete(int quizUserStatsId);
        bool Exists(int quizUserStatsId);
    }
}
