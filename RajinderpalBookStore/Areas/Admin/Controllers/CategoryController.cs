﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RajinderpalBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly UnitOfWork _unitOfwork;

        public CategoryController(UnitOfWork unitOfWork)
        {
            _unitOfwork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
        // API calls here
        #region API Calls
        [HttpGet]
        public IActionResult GetAll()
        {
            // return NotFound ();
            var allObj = _unitOfwork.Category.Getall();
            return Json(new { data = allObj });
        }
        #endregion
    }
}