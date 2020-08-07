using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Employee> _employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Age = 30,
                FirstName = "Серега",
                Patronymic = "Александрович",
                SurName = "Закатов"
            },
            new Employee
            {
                Id = 2,
                Age = 50,
                FirstName = "Леха",
                Patronymic = "Александрович",
                SurName = "Шавкунов"
            }
        };

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Some()
        {
            return View();
        }
        public IActionResult Employees()
        {
            return View(_employees);
        }
        public IActionResult Employee(int id)
        {
            var employee = _employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }
    }
}
