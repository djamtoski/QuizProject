using BusinessLayer.Interfaces;
using BusinessLayer.Repositories;
using DataLayer.Entities;
using QuizWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace QuizWebApi.Controllers
{
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
    public class QuizController : ApiController
    {
        private IQuizRepository _quizRepository;
        private ICategoryRepository _categoryRepository;

        public QuizController()
        {
            _quizRepository = new QuizRepository();
            _categoryRepository = new CategoryRepository();
        }

        public List<QuizViewModel> GetAll()
        {
                return _quizRepository.GetAll().Select(t => new QuizViewModel
                {
                    QuizId = t.QuizId,
                    QuizTitle = t.QuizTitle,
                    Image_url = t.Image_url,
                    Difficulty = t.QuizDifficulty,
                    CategoryName = t.Category.CategoryName
                }).ToList();
        }

        public QuizViewModel Get(int id)
        {
            var mod = _quizRepository.GetByID(id);
            QuizViewModel model = new QuizViewModel();
            model.QuizId = mod.QuizId;
            model.QuizTitle = mod.QuizTitle;
            model.Image_url = mod.Image_url;
            model.Difficulty = mod.QuizDifficulty;
            model.CategoryName = mod.Category.CategoryName;
                return model;
        }

        public void Add(QuizViewModel model)
        {
            if(model == null)
            {
                throw new HttpResponseException(HttpStatusCode.NoContent);
            }
        }

        public void Delete(int id)
        {
            var quiz = _quizRepository.GetByID(id);
            if (quiz == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _quizRepository.Delete(id);
        }

    }
}
