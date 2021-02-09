using Microsoft.AspNetCore.Mvc;
using salesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace salesWebMVC.Controllers.Models
{
    public class DepartamentsController1 : Controller
    {
        public IActionResult Index()
        {
            List<Departaments> list = new List<Departaments>();
            list.Add(new Departaments { Id = 1, Name = "Eletronics" });
            list.Add(new Departaments { Id = 2, Name = "fashion" });
            return View(list);
        }
    }
}
