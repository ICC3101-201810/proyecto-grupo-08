using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Carrera
    {
        public string nombre, facultad;
        public List<Alumno> alumnos;
        public Carrera(string nombre, string facultad)
        {
            this.nombre = nombre;
            this.facultad = facultad;
            alumnos = new List<Alumno>();
        }

    }
}
