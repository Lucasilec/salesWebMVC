using Microsoft.AspNetCore.Mvc;
using salesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace salesWebMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Departaments()
        {
            List<Departaments> list = new List<Departaments>();
            list.Add(new Departaments { Id = 1, Name = "Eletronics" });
            list.Add(new Departaments { Id = 2, Name = "fashion" });
            return View(list);
        }
        public IActionResult Index()
        {
            return View();
        }       

        public IActionResult About()
        {
            ViewData["Message"] = "Brasil";
            ViewData["Lucas"] = "lucasileck203@outlook.com";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new salesWebMVC.Models.ViewModels.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
