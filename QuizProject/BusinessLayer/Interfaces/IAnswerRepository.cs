using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IAnswerRepository
    {
        IQueryable<Answer> GetAll();
        Answer GetByID(int ID);
        void Insert(Answer answer);
        void Update(Answer answer);
        void Delete(Answer answer);
        void Delete(int answerId);
        bool Exists(int answerId);
    }
}
