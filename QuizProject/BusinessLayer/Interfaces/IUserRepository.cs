using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IUserRepository
    {
        IQueryable<User> GetAll();
        User GetByID(int ID);
        void Insert(User sser);
        void Update(User sser);
        void Delete(User sser);
        void Delete(int sserId);
        bool Exists(int sserId);
    }
}
