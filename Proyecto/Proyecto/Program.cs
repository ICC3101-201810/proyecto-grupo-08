using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrera carrera;
            Console.WriteLine("Ingrese su carrera: ");
            string carreraAlumno = (Console.Read());
            if (carrera.nombre = carreraAlumno)
            {

              Console.WriteLine("Ingrese su rut: ");
              int rut = Convert.ToInt32(Console.Read());
              var ruts = carrera.alumnos.Where(per => per.rut == rut);
              while ( ruts == null )
              {
                  Console.WriteLine("Ingrese un rut valido: ");
                  rut = Convert.ToInt32(Console.Read());

              Alumno alumno = carrera.alumnos.Find();
              }

            }
        }
    }
}
