using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore123.Models;

namespace WebStore123.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<Employee> _Employees = new()
        {
            new Employee { Id = 1, LastName = "Иванов", FirstName = "Иван", Patronymic = "Иванович", Age = 27 },
            new Employee { Id = 2, LastName = "Сергеев", FirstName = "Сергей", Patronymic = "Сергеевич", Age = 17 },
            new Employee { Id = 3, LastName = "Денисов", FirstName = "Денис", Patronymic = "Денисович", Age = 27 },
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SecondAction(string id)
        {
            return Content($"Second Action With parametr {id}");
        }

        public IActionResult Employees()
        {
            return View(_Employees);
        }
    }
}
