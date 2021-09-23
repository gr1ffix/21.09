using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _21._09.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() // http://localhost:5000/Home/Index
        {
            return Content("Контроллер индекс");
        }
        public IActionResult SecondAction(string id)
        {
            return Content($"Second action with{id}");
        }


    }
}
