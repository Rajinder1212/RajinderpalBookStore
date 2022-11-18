using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RajinderpalsBooks.DataAccess.Repository.IRepository;
using RajinderpalsBooks.Models;

namespace RajinderpalBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly UnitOfWork _unitOfWork;
      

        public CategoryController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)// action method for upsert
        {
            CategoryController category = new Category();   //using RajinderpalsBooks.models;
            if (id == null)
            {
                // this is for create
                return View(category);
            }
            //this fro the edit
            category = _unitOfWork.Category.Get(id.GetValueOrDefault());
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
            
        }

        // API calls here   
        #region API CALLS
        [HttpGet]
        public IActionResult  GetAll()
        {
            //return Not Found();
            var allObj = _unitOfWork.Category.GetAll();
            return Json(new { data = allObj }); 
        }

        public static implicit operator CategoryController(Category v)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}