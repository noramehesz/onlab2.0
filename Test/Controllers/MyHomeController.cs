using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GrillBerWebApp.Controllers
{
    public class MyHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyHome()
        {
           // ViewData["Message"] = "Ez hol fog megjelenni?";

            return View();
        }
    }
}