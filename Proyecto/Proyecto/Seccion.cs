using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Seccion
    {
        public int vacantes, numero;
        public List<Horario> horario;
        public Profesor profesor;
        public List<Persona> alumnos;

        public Seccion(int vacantes, int numero, Profesor profesor )
        {
            this.vacantes = vacantes;
            this.numero = numero;
            this.profesor = profesor;
            alumnos = new List<Persona>();
            horario = new List<Horario>();

        }

        public void AgregarAlumno(Alumno alumno)
        {
            alumnos.Add(alumno);
        }
        public void QuitarAlumnos(Alumno alumno)//
        {
            alumnos.Remove(alumno);
        }
        public void MostrarAlumnos()
        {
            Console.WriteLine("Nombre\n");
            foreach (Alumno alumno in alumnos)
            {
                Console.WriteLine(alumno.nombre);

            }
        }
 
    }
}
