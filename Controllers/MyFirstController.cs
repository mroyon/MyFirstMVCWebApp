using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVCWebApp.Controllers
{
    public class MyFirstController : Controller
    {

        // default view 
        public IActionResult Index()
        {
            return View();
        }


        // MySecondView view 
        public IActionResult MySecondView()
        {
            return View();
        }
    }
}
