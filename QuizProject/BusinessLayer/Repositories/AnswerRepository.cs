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
    public class AnswerRepository : IAnswerRepository
    {
        private QuizContext db;

        public AnswerRepository()
        {
            db = new QuizContext();
        }

        public void Delete(Answer answer)
        {
            if (answer != null)
            {
                db.Answers.Remove(answer);
                db.SaveChanges();
            }


        }

        public void Delete(int answerID)
        {
            var answer = GetByID(answerID);
            Delete(answer);
        }

        public bool Exists(int answerID)
        {
            return GetAll().Any(t => t.AnswerId == answerID);
        }

        public IQueryable<Answer> GetAll()
        {
            return db.Answers;
        }

        public Answer GetByID(int id)
        {
            return GetAll().SingleOrDefault(t => t.AnswerId == id);
        }

        public void Insert(Answer answer)
        {
            if (answer == null)
            {
                return;
            }
            db.Answers.Add(answer);
            db.SaveChanges();
        }

        public void Update(Answer answer)
        {
            if (answer != null && Exists(answer.AnswerId))
            {
                db.SaveChanges();
            }

        }

        
        

        public void printall10()
        {
            List<object> asd = new List<object>();
            asd.Add("asd");
            asd.Add(1);
            
        }
    }
}


public class Goce
{
    public int asd { get; set; }
    public string ime { get; set; }

    public Goce()
    {
        this.asd = 1;
        this.ime = " GGG";
    }
}


