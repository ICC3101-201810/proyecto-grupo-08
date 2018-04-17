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
        public List<Carrera> carreras;
        public Universidad(string nombre)
        {
            this.nombre = nombre;
            carreras = new List<Carrera>();
        }
        public void CrearPersona(int rut, string nombre, string apellido, string clave) => new Persona(rut, nombre, apellido, clave);
    }
}


