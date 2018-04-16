using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Alumno:Persona
    {
        DateTime anoIngreso;

        public Alumno(int rut, string nombre, string apellido, DateTime anoIngreso,string clave) : base(rut, nombre, apellido,clave)
        {
            this.anoIngreso = anoIngreso;
        }
    }
}
