using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Carrera
    {
      string nombre,facultad;
      List<Alumno> alumnos;
      public Carrera(string nombre,string facultad)

      this.nombre = nombre ;
      this.facultad = facultad ;
      alumnos = new List<Alumno>();


    }
}
