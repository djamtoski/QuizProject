using BusinessLayer.Interfaces;
using BusinessLayer.Repositories;
using QuizProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuizProject.Controllers
{
    public class QuizQuestionController : Controller
    {
        private IQuizQuestionRepository _quizQuestionRepository;
        private IQuizRepository _quizRepository;

        public QuizQuestionController()
        {
            _quizQuestionRepository = new QuizQuestionRepository();
            _quizRepository = new QuizRepository();
        }
        // GET: QuizQuestion
        public ActionResult Index(List<QuizQuestionViewModel> model)
        {
           model = _quizQuestionRepository.GetAll().Select(t => new QuizQuestionViewModel
           {
               ForQuizId = t.ForQuizId,
               QuestionId =t.QuestionId,
               QuestionText = t.QuestionText
           }).ToList();

            return View(model);
        }

       
        public ActionResult AddQuestion(QuizQuestionViewModel model , int id)
        {
            if (!ModelState.IsValid)
            {
               

                return View(model);
            }

            
            _quizQuestionRepository.Insert(new DataLayer.Entities.QuizQuestion
            {
                ForQuizId = id,
                QuestionText = model.QuestionText
            });

            return RedirectToAction("AddQuestion");
        }
    }
}