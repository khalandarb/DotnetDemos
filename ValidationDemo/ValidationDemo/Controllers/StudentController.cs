using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValidationDemo.Models;

namespace ValidationDemo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult StudentDetails()
        {
            return View();
        }

        [HttpPost]
        public ActionResult StudentDetails(Student student)
        {
            if (string.IsNullOrEmpty(student.name))
            {
                ModelState.AddModelError("name", "Invalid Name");
            }
            if(student.age<=0 || student.age > 60)
            {
                ModelState.AddModelError("age", "Age should be 1-60");
            }

            if (ModelState.IsValid)
            {
                ViewBag.name = student.name;
                ViewBag.age = student.age;
            }
            else
            {
                ViewBag.name = "Invalid";
                ViewBag.age = "Invalid";
            }
            return View();
        }
    }
}
