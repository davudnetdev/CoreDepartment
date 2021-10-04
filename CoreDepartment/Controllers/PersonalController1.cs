using CoreDepartment.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDepartment.Controllers
{
    public class PersonalController1 : Controller
    {
        Context c = new Context();
        public IActionResult Index2()
        {
            var values = c.Personals.ToList();
            return View(values);
        }
    }
}
