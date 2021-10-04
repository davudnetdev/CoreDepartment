using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDepartment.Models;

namespace CoreDepartment.Controllers
{
    public class DepartmentController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var values = c.Departments.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult  NewDepartment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult  NewDepartment(Department d)
        {
            c.Departments.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public IActionResult DepartmentDelete(int Id)

        {
            var dep = c.Departments.Find( Id);
            c.Departments.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DepartmentBring(int id)
        {
            var dpr = c.Departments.Find(id);
            return View(dpr);
        }
        public IActionResult DepartmentUpdate(Department d)
        {
            var dr = c.Departments.Find(d.Id);
            dr.DepartmentName = d.DepartmentName;
            dr.Id = d.Id;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
