using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HyphenMinus.Models;

namespace HyphenMinus.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new TestViewModel
            {
                DoubleValue = -0.144551456
            };

            return View(model);
        }
    }
}
