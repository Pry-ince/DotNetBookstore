﻿using DotNetBookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetBookstore.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            var categories = new List<Category>();
            for (var i = 1; i < 11; i++)
            {
                categories.Add(new Category { CategoryId = i, Name = "Category " + i.ToString() });
            }    
                return View(categories);
        }

        public IActionResult Browse(string category)
        {
            ViewBag.Category = category;
            return View();
        }
    }
}
