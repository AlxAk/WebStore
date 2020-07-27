using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Controller-Home, Action-Index");
        }
        public IActionResult Some()
        {
            return Content("Controller-Home, Action-Some");
        }
    }
}
