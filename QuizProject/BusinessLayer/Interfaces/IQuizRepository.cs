using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IQuizRepository
    {
        IQueryable<Quize> GetAll();
        Quize GetByID(int ID);
        void Insert(Quize quiz);
        void Update(Quize quiz);
        void Delete(Quize quiz);
        void Delete(int quizId);
        bool Exists(int quizId);
    }
}
