using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio_1_MVC.Models;

namespace Laboratorio_1_MVC.Controllers
{
    public class EstudiantesController : Controller
    {
        // GET: Estudiantes
        public ActionResult Index()
        {
            List<ClsEstudiantes> lista = new List<ClsEstudiantes>();


            ClsEstudiantes objE1 = new ClsEstudiantes();

            objE1.dni = "71205269";
            objE1.nombre = "AlexArmando";
            objE1.apellido = "Ticona Mamani";
            objE1.edad = 25;
            objE1.talla = 1.65;
            objE1.sexo = "H";
            lista.Add(objE1);

            ClsEstudiantes objE2 = new ClsEstudiantes();

            objE2.dni = "01010101";
            objE2.nombre = "pedro";
            objE2.apellido = "Ticona ";
            objE2.edad = 40;
            objE2.talla = 1.75;
            objE2.sexo = "H";
            lista.Add(objE2);

            ClsEstudiantes objE3 = new ClsEstudiantes();

            objE3.dni = "21415869";
            objE3.nombre = "diego";
            objE3.apellido = "gimenes";
            objE3.edad = 15;
            objE3.talla = 1.65;
            objE3.sexo = "H";
            lista.Add(objE3);

            ClsEstudiantes objE4 = new ClsEstudiantes();

            objE4.dni = "12345678";
            objE4.nombre = "Karla";
            objE4.apellido = "mendoza Quiñonez";
            objE4.edad = 17;
            objE4.talla = 1.69;
            objE4.sexo = "F";
            lista.Add(objE4);

            ClsEstudiantes objE5 = new ClsEstudiantes();

            objE5.dni = "87654321";
            objE5.nombre = "carlos arnold";
            objE5.apellido = "carpio jimenez";
            objE5.edad = 26;
            objE5.talla = 1.69;
            objE5.sexo = "H";
            lista.Add(objE5);


            ClsEstudiantes objE6 = new ClsEstudiantes();

            objE6.dni = "71717171";
            objE6.nombre = "carlos arnold nuevo";
            objE6.apellido = "carpio jimenez prueba";
            objE6.edad = 40;
            objE6.talla = 1.79;
            objE6.sexo = "H";
            lista.Add(objE6);



            return View("Index", lista);
        }
    }
}