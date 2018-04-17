using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Persona
    {
        public int rut;
        public string nombre, apellido, clave;

        public Persona(int rut, string nombre, string apellido, string clave)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.apellido = apellido;
            this.clave = clave;
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

    }
}
