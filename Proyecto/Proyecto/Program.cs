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
            List<Universidad> universidades = new List<Universidad>();
            Console.WriteLine("Ingrese su universidad: ");
            string universidadAlumno = (Console.ReadLine());
            Console.WriteLine("Ingrese su carrera: ");
            string carreraAlumno = (Console.ReadLine());
            
            try { Universidad universidadP = universidades.First(u => u.nombre == universidadAlumno); Carrera carreraP = universidadP.carreras.First(c => c.nombre == carreraAlumno); }
            catch {Console.BackgroundColor = ConsoleColor.Yellow;Console.ForegroundColor = ConsoleColor.Red;Console.WriteLine("Ingrese datos correctos");Console.Beep(); Console.Beep(); Console.ResetColor();}

            //Universidad universidad = universidades.First(u => u.nombre == universidadAlumno); Carrera carrera = universidad.carreras.First(c => c.nombre == carreraAlumno);

            Console.WriteLine("Ingrese su rut: ");
            int rut = Convert.ToInt32(Console.Read());
            Persona persona = carrera.alumnos.First(per => per.rut == rut);
            while (ruts == null)
            {
                Console.WriteLine("Ingrese un rut valido: ");
                rut = Convert.ToInt32(Console.Read());

                Alumno alumno = carrera.alumnos.Find();
            }


        }
    }
}
