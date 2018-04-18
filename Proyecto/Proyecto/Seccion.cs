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
        public Horario horario;
        public Profesor profesor;
        public List<Alumno> alumnos;

        public Seccion(int vacantes, int numero, Horario horario, Profesor profesor )
        {
            this.vacantes = vacantes;
            this.numero = numero;
            this.horario = horario;
            this.profesor = profesor;
            alumnos = new List<Alumno>();
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
            foreach (Alumno alumno in alumnos)
            {
                Console.WriteLine(alumno.nombre);

            }
        }
    }
}
