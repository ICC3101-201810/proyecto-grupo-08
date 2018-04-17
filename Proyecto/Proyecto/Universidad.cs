using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Universidad
    {
        string nombre;
        public List<Persona> Personas;
        public Universidad(string nombre)
        {
            this.nombre = nombre;
            Personas = new List<Persona>();
        }
        public void CrearPersona(int rut, string nombre, string apellido, string clave) => new Persona(rut, nombre, apellido, clave);
    }
}


