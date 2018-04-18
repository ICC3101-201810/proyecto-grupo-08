using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Alumno:Persona
    {
        public DateTime anoIngreso;
        public List<Seccion> secciones;

        public Alumno(int rut, string nombre, string apellido, DateTime anoIngreso,string clave) : base(rut, nombre, apellido,clave)
        {
            creditos = 33;
            this.anoIngreso = anoIngreso;
            this.tipo = "alumno";
            secciones = new List<Seccion>();
        }
    }
}
