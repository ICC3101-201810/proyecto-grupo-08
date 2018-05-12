using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Curso
    {
        public string nombre;
        public int creditos;
        public List<Curso> requisitos;//esto
        public List<Seccion> secciones;//esto


        public Curso(string nombre, int credito)
        {
            this.nombre = nombre;
            this.creditos = credito;
            secciones = new List<Seccion>();
            requisitos = new List<Curso>();//esto
        }

        public int mostrarNrc(Persona persona)
        {
            foreach (Seccion s in secciones)
            {
                if (s.profesor == persona)
                {
                    return s.nrc;
                }
                foreach (Persona alumno in s.alumnos)
                {
                    if (alumno == persona)
                    {
                        return s.nrc;
                    }
                }
            }
            return 0;
        }

        public bool RequisitosAprobados(Persona a)
        {
            foreach (Curso requisito in requisitos)
            {
                if (a.aprobados.Contains(requisito))
                {
                    continue;
                }
                else { return false; }
            }
            return true;
        }

        public string MostarALumnosCurso(Persona profe)
        {
            string str = "Los alumnos de " + nombre + " son:\n";
            
            foreach(Seccion seccion in secciones)
            {
                if (seccion.profesor == profe)
                {
                    foreach(Persona alumno in seccion.alumnos)
                    {
                        str = str + alumno.nombre + " " + alumno.apellido + "\n";

                    }
                    
                }
            }
            return str;
        }

        public string VerHorarioCurso(Persona profe)
        {
            string str = "El horario de " + nombre + " es\n";
            foreach (Seccion seccion in secciones)
            {
                if (seccion.profesor == profe)
                {
                    foreach (Horario horario in seccion.horario)
                    {
                        str = str + horario.inicio.DayOfWeek.ToString()+"\t "+horario.inicio.TimeOfDay.ToString()+ "\n";
                    }

                }
            }
            return str;

        }

        public void CrearSeccion(DateTime dateTi,int nrcc,int vacan,Profesor profe)
        {
            Seccion secc = new Seccion(vacan, nrcc, profe);
            Horario horario = new Horario("clase", dateTi, 2);
            secc.horario.Add(horario);
            secciones.Add(secc);
        }

    }
}
