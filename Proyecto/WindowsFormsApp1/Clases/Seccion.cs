using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Seccion
    {
        public int vacantes;//numero;
        public int nrc;
        public List<Horario> horario;
        public Profesor profesor;
        public List<Persona> alumnos;

        public Seccion(int vacantes, int nrc, Profesor profesor)
        {
            this.vacantes = vacantes;
            //this.numero = numero;
            this.nrc = nrc;
            this.profesor = profesor;
            alumnos = new List<Persona>();
            horario = new List<Horario>();

        }

        public void AgregarAlumno(Persona alumno)
        {
            alumnos.Add(alumno);
        }
        public void QuitarAlumnos(Persona alumno)//
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

        public bool Esta(Persona alumno)
        {
            foreach (Alumno a in alumnos)
            {
                if (Equals(alumno, a))
                {
                    return true;
                }
            }
            return false;

        }

        //public bool RevisarSiTopa(Persona alumno)
        //{
        //    foreach (Seccion seccion in alumno.secciones)
        //    {
        //        foreach (Horario horario in seccion.horario)
        //        {
        //            foreach (Seccion se in alumno.secciones)
        //            {
        //                foreach (Horario ho in seccion.horario)
        //                {
        //                    if (horario.inicio == ho.inicio)
        //                    {
        //                        return true;
        //                    }
        //                }

        //            }
        //        }
        //    }
        //    return false;
        //}
        //public Curso VerCurso(Carrera cr)
        //{
        //    foreach (Curso c in cr.cursos)
        //    {
        //        foreach (Seccion s in c.secciones)
        //        {
        //            if (s.numero == this.numero)
        //            {
        //                return c;
        //            }
        //        }
        //    }
        //    return null;
        //}
    }
}
