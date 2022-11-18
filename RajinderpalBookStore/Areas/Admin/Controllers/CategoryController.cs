using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RajinderpalsBooks.DataAccess.Repository.IRepository;


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
        // API calls here   
        #region API CALLS
        [HttpGet]
        public IActionResult  GetAll()
        {
            //return Not Found();
            var allObj = _unitOfWork.Category.GetAll();
            return Json(new { data = allObj }); 
        }
        #endregion
    }
}