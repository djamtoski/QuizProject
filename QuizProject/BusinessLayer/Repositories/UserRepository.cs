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
    public class UserRepository : IUserRepository
    {
        private QuizContext db;

        public UserRepository()
        {
            db = new QuizContext();
        }

        public void Delete(User user)
        {
            if (user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }


        }

        public void Delete(int userId)
        {
            var user = GetByID(userId);
            Delete(user);
        }

        public bool Exists(int userId)
        {
            return GetAll().Any(t => t.UserId == userId);
        }

        public IQueryable<User> GetAll()
        {
            return db.Users;
        }

        public User GetByID(int id)
        {
            return GetAll().SingleOrDefault(t => t.UserId == id);
        }

        public void Insert(User user)
        {
            if (user == null)
            {
                return;
            }
            db.Users.Add(user);
            db.SaveChanges();
        }

        public void Update(User user)
        {
            if (user != null && Exists(user.UserId))
            {
                db.SaveChanges();
            }

        }
    }
}
