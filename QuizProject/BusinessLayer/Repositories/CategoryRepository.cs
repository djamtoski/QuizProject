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
    public class CategoryRepository : ICategoryRepository
    {
        private QuizContext db;

        public CategoryRepository()
        {
            db = new QuizContext();
        }

        public void Delete(QuizCategory category)
        {
            if (category != null)
            {
                db.QuizCategories.Remove(category);
                db.SaveChanges();
            }

        }

        public void Delete(int categoryID)
        {
            var category = GetByID(categoryID);
            Delete(category);
        }

        public bool Exists(int categoryID)
        {
            return GetAll().Any(t => t.CategoryId == categoryID);
        }

        public IQueryable<QuizCategory> GetAll()
        {
            return db.QuizCategories;
        }

        public QuizCategory GetByID(int id)
        {
            return GetAll().SingleOrDefault(t => t.CategoryId == id);
        }

        public void Insert(QuizCategory category)
        {
            if (category == null)
            {
                return;
            }
            db.QuizCategories.Add(category);
            db.SaveChanges();
        }

        public void Update(QuizCategory category)
        {
            if (category != null && Exists(category.CategoryId))
            {
                db.SaveChanges();
            }

        }
    }
}
