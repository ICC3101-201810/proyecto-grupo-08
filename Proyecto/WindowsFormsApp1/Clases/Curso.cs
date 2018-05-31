using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Media;

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

        public BindingList<Tabla> VerHorarioCurso(Persona profe)
        {
            BindingList<Tabla> lista = new BindingList<Tabla>();
            foreach (Seccion seccion in secciones)
            {
                if (seccion.profesor == profe)
                {
                    foreach (Horario horario in seccion.horario)
                    {
                        lista.Add(new Tabla(nombre, horario.tipo, horario.inicio.DayOfWeek.ToString() + "  " + horario.inicio.TimeOfDay.ToString(), seccion.nrc.ToString(),horario.duracion));
                    }

                }
            }
            return lista;

        }

        public void CrearSeccion(List<Horario> dateTi,int nrcc,int vacan,Profesor profe)
        {
            Seccion secc = new Seccion(vacan, nrcc, profe);
            secc.horario = dateTi;
            secciones.Add(secc);
        }

    }
}
