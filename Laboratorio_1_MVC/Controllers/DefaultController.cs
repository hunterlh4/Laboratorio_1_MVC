using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio_1_MVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MostraDatos()
        {
            ViewBag.Escuela = "Ingenieria de Sistemas";
            ViewBag.curso = "Programacion web II";
            ViewBag.Ciclo = 9;

            ViewData["Docente"] = "Enrique  Lachipa Valencia";
            ViewData["Estudiante"] = 20;

            return View();
        }
    }
}