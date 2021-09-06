using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio_1_MVC.Models;

namespace Laboratorio_1_MVC.Controllers
{
    public class EstudianteController : Controller
    {
        // GET: Estudiante
        public ActionResult Index()
        {
            ClsEstudiante objEstudiante = new ClsEstudiante();

            objEstudiante.dni = "71205269";
            objEstudiante.nombre = "AlexArmando";
            objEstudiante.apellido = "Ticona Mamani";
            objEstudiante.edad = 25;
            objEstudiante.talla = 1.65;
            objEstudiante.sexo = true;

            return View(objEstudiante);
        }
    }
}