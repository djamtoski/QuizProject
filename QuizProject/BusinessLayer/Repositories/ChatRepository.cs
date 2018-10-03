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
    public class ChatRepository : IChatRepository
    {
        private QuizContext db;

        public ChatRepository()
        {
            db = new QuizContext();
        }


        public IQueryable<Chat> GetAll()
        {
            return db.Chat;
        }

        public Chat GetByID(int id)
        {
            return GetAll().SingleOrDefault(t => t.Id == id);
        }

        public void Insert(Chat chat)
        {
            if (chat == null)
            {
                return;
            }
            db.Chat.Add(chat);
            db.SaveChanges();
        }
    }
}
