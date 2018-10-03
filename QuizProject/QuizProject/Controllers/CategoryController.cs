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
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController()
        {
            _categoryRepository = new CategoryRepository();
        }

        // GET: Category
        public ActionResult Index()
        {
            List<CategoryViewModel> model =_categoryRepository.GetAll().Select(t => new CategoryViewModel {
               CategoryId = t.CategoryId,
               CategoryName = t.CategoryName,
               Image_url = t.Image_url
            }).ToList();

            return View(model);
        }

        // PUT: Category
        public ActionResult AddCategory(CategoryViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
                //return Json(new { success = false, message = });
            }
            QuizCategory category = new QuizCategory()
            {
                CategoryName = model.CategoryName,
                Image_url = model.Image_url
                
            };

            _categoryRepository.Insert(category);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            _categoryRepository.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(CategoryViewModel model, int id)
        {
            var temp = _categoryRepository.GetByID(id);
            
            if (!ModelState.IsValid)
            {
                CategoryViewModel model1 = new CategoryViewModel()
                {
                    CategoryId = temp.CategoryId,
                    CategoryName = temp.CategoryName,
                    Image_url = temp.Image_url
                };

                return View(model1);
            }

            var item = _categoryRepository.GetByID(id);
           
            item.CategoryName = model.CategoryName;
            item.Image_url = model.Image_url;
            _categoryRepository.Update(item);

            return RedirectToAction("Index");
        }
    }
}