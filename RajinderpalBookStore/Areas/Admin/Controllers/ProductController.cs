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
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;


        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)// action method for upsert
        {
            Product product = new Product();   //using RajinderpalsBooks.models;
            if (id == null)
            {
                // this is for create
                return View(product);
            }
            //this fro the edit
            product = _unitOfWork.Product.Get(id.GetValueOrDefault());
            if (product == null)
            {
                return NotFound();
            }
            return View(product);

        }
        // use HTTP POST to define the post-action method
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Upsert(Product product)
        {
            if (product.Id == 0)
            {
                _unitOfWork.Product.Add(product);
                _unitOfWork.Save();
            }
            else
            {
                _unitOfWork.Product.Update(product);
            }
            _unitOfWork.Save();
            return RedirectToAction(nameof(Index));   // to see all the categories
        }


        // API calls here   
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            //return Not Found();
            var allObj = _unitOfWork.Product.GetAll();
            return Json(new { data = allObj });
        }
        [HttpDelete]                // added an HttpDelete 
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Product.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.Product.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete successful" });
        }

        public static implicit operator ProductController(Product v)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}