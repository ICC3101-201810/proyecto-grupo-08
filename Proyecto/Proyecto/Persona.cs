using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public abstract class Persona
    {
        public int rut,creditos;
        public string nombre, apellido, clave,tipo;
        public List<Seccion> secciones;

        public Persona(int rut, string nombre, string apellido, string clave)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.apellido = apellido;
            this.clave = clave;
            secciones = new List<Seccion>();
        }

        public bool Login(Persona persona)
        {
            Console.WriteLine("Ingrese su rut: ");
            int rut = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su contraseña: ");
            string clave = Console.ReadLine();
            if (persona.rut == rut && persona.clave == clave){return true;}
            else { return false; }
        }

        public void QuitarSeccion(Seccion seccion)
        {
            secciones.Remove(seccion);
        }

    }
}
