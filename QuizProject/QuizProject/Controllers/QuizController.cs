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
    public class QuizController : Controller
    {
        private IQuizRepository _quizRepository;
        private ICategoryRepository _categoryRepository;

        public QuizController()
        {
            _quizRepository = new QuizRepository();
            _categoryRepository = new CategoryRepository();
        }

        // GET: Quiz
        public ActionResult Index(int? id)
        {
            if (id == null) { 
            var model1 = _quizRepository.GetAll().Select(t => new QuizViewModel
            {
                QuizId = t.QuizId,
                QuizTitle = t.QuizTitle,
                Image_url = t.Image_url,
                Difficulty = t.QuizDifficulty,
                CategoryName = t.Category.CategoryName

            }).ToList();
            return View(model1);
            }


            var model = _quizRepository.GetAll().Where(t => t.QuizCategoryId == id).Select(t => new QuizViewModel
            {
                QuizId = t.QuizId,
                QuizTitle = t.QuizTitle,
                CategoryName = t.Category.CategoryName,
                Image_url = t.Image_url,
                Difficulty = t.QuizDifficulty,
                Helper = "helper"
            }).ToList();
            
            return View(model);
        }    

        //[HttpPost]
        public ActionResult Add(AddEditQuizViewModel model, string helper)
        {
            if (!ModelState.IsValid)
            {

                model.CategoryOption = _categoryRepository.GetAll().Select(t => new CategoryViewModel
                {
                    CategoryId = t.CategoryId,
                    CategoryName = t.CategoryName,
                    Image_url = t.Image_url
                }).ToList();
                return View(model);

            }

            _quizRepository.Insert(new DataLayer.Entities.Quize
            {
                QuizTitle = model.QuizTitle,
                QuizDifficulty = model.Difficulty,
                Image_url = model.Image_url,
                QuizCategoryId = (int)model.SelectedCategoryId
            });
            if (helper == null)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index/" + model.SelectedCategoryId);

        }

        public ActionResult Delete(int id, string helper)
        {
            if (helper == null)
            {
                _quizRepository.Delete(id);
                return RedirectToAction("Index");

            }
            var categoryId = _quizRepository.GetByID(id).Category.CategoryId;
            _quizRepository.Delete(id);
            return RedirectToAction("Index/" + categoryId);
        }



        //public ActionResult Edit(int id)
        //{
        //    var temp = _quizRepository.GetByID(id);
        //    AddEditQuizViewModel model = new AddEditQuizViewModel
        //    {
        //        QuizTitle = temp.QuizTitle,
        //        Difficulty = temp.QuizDifficulty,
        //        Image_url = temp.Image_url,
        //        SelectedCategoryId = temp.QuizCategoryId,
        //        CategoryOption = _categoryRepository.GetAll().Select(t => new CategoryViewModel
        //        {
        //            CategoryName = t.CategoryName,
        //            CategoryId = t.CategoryId
        //        }).ToList()
        //    };


        //    return View(model);
        //}

        //[HttpPost]

        public ActionResult Edit(AddEditQuizViewModel model, int id , string helper)
        {
            if (!ModelState.IsValid)
            {

                var temp = _quizRepository.GetByID(id);
                
                AddEditQuizViewModel model1 = new AddEditQuizViewModel
                {
                    QuizTitle = temp.QuizTitle,
                    Difficulty  = temp.QuizDifficulty,
                    Image_url = temp.Image_url,
                    SelectedCategoryId = temp.QuizCategoryId,
                    CategoryOption = _categoryRepository.GetAll().Select(t => new CategoryViewModel
                    {
                        CategoryName = t.CategoryName,
                        CategoryId = t.CategoryId
                    }).ToList()
                };

                return View(model1);

            }

            var item = _quizRepository.GetByID(id);
            item.QuizTitle = model.QuizTitle;
            item.QuizDifficulty = model.Difficulty;
            item.QuizCategoryId = (int)model.SelectedCategoryId;
            item.Image_url = model.Image_url;
            
            _quizRepository.Update(item);

            if (helper == null)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index/" + item.QuizCategoryId);
        }

    }
}