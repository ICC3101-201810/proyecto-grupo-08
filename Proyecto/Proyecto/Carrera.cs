using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Carrera
    {
        public string nombre, facultad;
        public List<Alumno> alumnos;
        public Carrera(string nombre, string facultad)
        {
            this.nombre = nombre;
            this.facultad = facultad;
            alumnos = new List<Alumno>();
        }
        public bool VerificarAlumno(Carrera carrera, int rut)
        {
            foreach (Alumno a in carrera.alumnos)
            {
                if (a.rut == rut) { return true; }
            }
            Console.BackgroundColor = ConsoleColor.Yellow; Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Ingrese datos correctos"); Console.Beep(); Console.Beep(); Console.ResetColor();
            return false;
        }
        public void AgregarAlumno(Alumno alumno)
        {
            alumnos.Add(alumno);
        }
        public void MostrarAlumnos()
        {
            foreach (Alumno alumno in alumnos)
            {
                Console.WriteLine(alumno.nombre);
            }
        }
    }
}
