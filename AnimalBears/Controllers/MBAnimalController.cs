using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalBears.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnimalBears.Controllers
{
    public class MBAnimalController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Animal a)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }
    }
}