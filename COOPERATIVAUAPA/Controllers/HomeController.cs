using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using COOPERATIVAUAPA.Models;

namespace COOPERATIVAUAPA.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contacto()
        {
            ViewBag.Message = "tu página contacto.";

            return View();
        }
        public IActionResult Descripcion()
        {
            ViewBag.Message = "tu página contacto.";

            return View();
        }
        public IActionResult Calculadora()
        {
            ViewBag.Message = "Tu calculadora de préstamos";

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
