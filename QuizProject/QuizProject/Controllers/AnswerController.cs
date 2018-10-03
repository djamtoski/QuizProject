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
    public class AnswerController : Controller
    {
        private readonly IAnswerRepository _answerRepository;

        public AnswerController()
        {
            _answerRepository = new AnswerRepository();
        }

        // GET: Answer
        public ActionResult Index()
        {
            return View();
        }

        //PUT: Answer
        public ActionResult AddQuestions()
        {
            var answer = new Answer();
            
            return View();
        }
    }
}