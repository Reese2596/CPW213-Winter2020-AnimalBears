using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalBears.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnimalBears.Controllers
{
    public class AnimalController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormCollection data)
        {
            Animal a = new Animal();
            a.AnimalName = data["animal-name"];
            a.Name = data["name"];
            a.Color = data["color"];

            ViewData["Message"] = "Stuffed Animal Created";

            return View();
        }
    }
}