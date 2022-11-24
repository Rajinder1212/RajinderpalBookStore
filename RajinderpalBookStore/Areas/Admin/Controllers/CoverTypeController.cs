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
    public class CoverTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;


        public CoverTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)// action method for upsert
        {
            CoverType coverType = new CoverType();   //using RajinderpalsBooks.models;
            if (id == null)
            {
                // this is for create
                return View(coverType);
            }
            //this fro the edit
            coverType = _unitOfWork.CoverType.Get(id.GetValueOrDefault());
            if (coverType == null)
            {
                return NotFound();
            }
            return View(coverType);

        }
        // use HTTP POST to define the post-action method
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Upsert(CoverType coverType)
        {
            if (coverType.Id == 0)
            {
                _unitOfWork.CoverType.Add(coverType);
                _unitOfWork.Save();
            }
            else
            {
                _unitOfWork.CoverType.Update(coverType);
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
            var allObj = _unitOfWork.CoverType.GetAll();
            return Json(new { data = allObj });
        }
        [HttpDelete]                // added an HttpDelete 
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.CoverType.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.CoverType.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete successful" });
        }

        public static implicit operator CoverTypeController(Category v)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}