﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio_1_MVC.Models
{
    public class ClsEstudiante
    {
        public String dni { get; set; }
        public String apellido { get; set; }
        public String nombre { get; set; }
        public int edad { get; set; }
        public double talla { get; set; }
        public Boolean sexo { get; set; }
    }
}