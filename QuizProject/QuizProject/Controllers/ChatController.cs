using BusinessLayer.Interfaces;
using BusinessLayer.Repositories;
using DataLayer.Entities;
using QuizProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuizProject.Controllers
{
    public class ChatController : Controller
    {
        private readonly IChatRepository _chatRepository;

        public ChatController()
        {
            _chatRepository = new ChatRepository();
        }
        // GET: Chat
        public ActionResult Index()
        {
            List<ChatViewModel> model = _chatRepository.GetAll().Select(t => new ChatViewModel
            {
                Id = t.Id,
                Message = t.Message,
                Time = t.Time
            }).ToList();

            return View(model);
        }

        public ActionResult Get()
        {
            var timeMinus10 = DateTime.Now.AddSeconds(-10);
            var model = _chatRepository.GetAll().Where(t => t.Time > timeMinus10).ToList();
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Insert(ChatViewModel chat)
        {
            _chatRepository.Insert(new Chat
            {
                Message = chat.Message,
                Time = DateTime.Now
            });

            return Json(chat);
        }
    }
}