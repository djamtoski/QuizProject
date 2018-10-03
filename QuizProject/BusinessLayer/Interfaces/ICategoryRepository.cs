using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface ICategoryRepository
    {
        IQueryable<QuizCategory> GetAll();
        QuizCategory GetByID(int ID);
        void Insert(QuizCategory category);
        void Update(QuizCategory category);
        void Delete(QuizCategory category);
        void Delete(int categoryId);
        bool Exists(int categoryId);
    }
}
