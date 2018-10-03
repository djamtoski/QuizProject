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
    public class QuizQuestionRepository : IQuizQuestionRepository
    {
        private QuizContext db;

        public QuizQuestionRepository()
        {
            db = new QuizContext();
        }

        public void Delete(QuizQuestion question)
        {
            if (question != null)
            {
                db.QuizQuestions.Remove(question);
                db.SaveChanges();
            }

        }

        public void Delete(int questionId)
        {
            var question = GetByID(questionId);
            Delete(question);
        }

        public bool Exists(int questionId)
        {
            return GetAll().Any(t => t.QuestionId == questionId);
        }

        public IQueryable<QuizQuestion> GetAll()
        {
            return db.QuizQuestions;
        }

        public QuizQuestion GetByID(int id)
        {
            return GetAll().SingleOrDefault(t => t.QuestionId == id);
        }

        public void Insert(QuizQuestion question)
        {
            if (question == null)
            {
                return;
            }
            db.QuizQuestions.Add(question);
            db.SaveChanges();
        }

        public void Update(QuizQuestion question)
        {
            if (question != null && Exists(question.QuestionId))
            {
                db.SaveChanges();
            }

        }
    }
}
