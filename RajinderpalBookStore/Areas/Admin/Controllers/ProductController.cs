using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RajinderpalsBooks.DataAccess.Repository.IRepository;
using RajinderpalsBooks.Models;
using RajinderpalsBooks.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RajinderpalBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;


        public ProductController(IUnitOfWork unitOfWork , IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)// action method for upsert
        {
            ProductVM productVM = new ProductVM()
            {
                Product = new Product(),
                CategoryList = _unitOfWork.Category.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),
                CoverTypeList = _unitOfWork.CoverType.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                })
            };
           // Product product = new Product();   //using RajinderpalsBooks.models;
            if (id == null)
            {
                // this is for create
                return View(productVM);
            }
            //this fro the edit
            productVM.Product = _unitOfWork.Product.Get(id.GetValueOrDefault());
            if (productVM == null)
            {
                return NotFound();
            }
            return View(productVM);

        }
        // use HTTP POST to define the post-action method
        /*[HttpPost]
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
        }*/


        // API calls here   
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            //return Not Found();
            var allObj = _unitOfWork.Product.GetAll(includeProperties:"Category, CoverType");
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