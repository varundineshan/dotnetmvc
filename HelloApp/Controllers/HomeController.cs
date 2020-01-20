using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HelloApp.Models;

namespace HelloApp.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        [RequireHttps]
        public IActionResult UserForm()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(FormModel model)
        {
            ViewBag.name = model.name;
            ViewBag.age = model.age;
            ViewBag.email = model.email;
            return View();
        }

    }
}
