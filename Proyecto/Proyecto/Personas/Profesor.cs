using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Profesor : Persona
    {
        string titulo;
        int anoIngreso;
        public Profesor(int rut, string nombre, string apellido, string clave, int anoIngreso, string titulo) : base(rut, nombre, apellido, clave)
        {
            this.titulo = titulo;
            this.anoIngreso = anoIngreso;
            this.tipo = "profe";
        }
    }
    
}
