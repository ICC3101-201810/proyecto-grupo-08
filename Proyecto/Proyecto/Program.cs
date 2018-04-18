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
            Universidad Uandes = new Universidad("Universidad de los Andes");
            string carreraAlumno = "";
            int rut = 0;
            bool elBool = false;
            while (elBool == false)
            {
                Console.WriteLine("Ingrese su carrera: ");
                carreraAlumno = (Console.ReadLine()); elBool = Uandes.VerificarCarrera(Uandes, carreraAlumno);
            }
            Carrera carrera = Uandes.carreras.First(c => c.nombre == carreraAlumno);
            elBool = false;
            while (elBool == false)
            {
                Console.WriteLine("Ingrese su rut: ");
                rut = Convert.ToInt32(Console.Read()); elBool = carrera.VerificarAlumno(carrera, rut);
            }
            Persona persona = carrera.alumnos.First(per => per.rut == rut);


        }


    }
}

