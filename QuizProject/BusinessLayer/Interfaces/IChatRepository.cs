using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IChatRepository
    {
        IQueryable<Chat> GetAll();
        Chat GetByID(int ID);
        void Insert(Chat category);
        
    }
}
