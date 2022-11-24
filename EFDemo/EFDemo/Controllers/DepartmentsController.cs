using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDemo.Models;

namespace EFDemo.Controllers
{
    public class DepartmentsController : Controller
    {
        // GET: Departments
        DepartmentContext context;
        public DepartmentsController()
        {
            context = new DepartmentContext();
        }
        public ActionResult Index()
        {

            return View(context.Departments.ToList());
        }

        // GET: Departments/Details/5
        public ActionResult Details(int id)
        {
            var dept = context.Departments.FirstOrDefault(d => d.DepartmentId == id);
            return View(dept);
        }

        // GET: Departments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Departments/Create
        [HttpPost]
        public ActionResult Create(Department department)
        {
            try
            {
                
                    context.Departments.Add(department);
                    context.SaveChanges();
                

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Departments/Edit/5
        public ActionResult Edit(int id)
        {
            Department dept = context.Departments.FirstOrDefault(d => d.DepartmentId == id);
            return View(dept);
        }

        // POST: Departments/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Department department)
        {
            try
            {
                Department dept1 = context.Departments.FirstOrDefault(d => d.DepartmentId == id);
                dept1.DepartmentId = department.DepartmentId;
                dept1.name = department.name;
                dept1.location = department.location;
               // context.Entry(department).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Departments/Delete/5
        public ActionResult Delete(int id)
        {
            Department dept = context.Departments.FirstOrDefault(d => d.DepartmentId == id);
            return View(dept);
        }

        // POST: Departments/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Department department)
        {
            try
            {
                Department dept1 = context.Departments.FirstOrDefault(d => d.DepartmentId == id);
                context.Departments.Remove(dept1);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
