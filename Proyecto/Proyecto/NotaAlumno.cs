﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class NotaAlumno_Curso
    {
        public double nota;
        public Alumno  alumno;
        public Seccion  seccion;
        public NotaAlumno_Curso(double nota, Alumno alumno, Seccion seccion)
        {
            this.alumno = alumno;
            this.nota = nota;
            this.seccion = seccion;
        }
    }
}
