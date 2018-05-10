using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Carrera
    {
        public string nombre, facultad;
        //public List<Alumno> alumnos;
        public List<Administrativo> admins;
        public List<Curso> cursos;
        public Carrera(string nombre, string facultad)
        {
            this.nombre = nombre;
            this.facultad = facultad;
            //alumnos = new List<Alumno>();
            cursos = new List<Curso>();
            admins = new List<Administrativo>();
        }
        public bool VerificarAlumno(int rut, string clave)
        {
            foreach (Curso c in cursos)
            {
                foreach (Seccion s in c.secciones)
                {
                    foreach (Alumno a in s.alumnos)
                    {
                        if (a.rut == rut && a.clave == clave)
                        {
                            return true;
                        }
                    }
                }

            }

            return false;
        }

        public bool VerificarAdmin(int rut, string clave)
        {
            foreach (Administrativo a in admins)
            {
                if (a.rut == rut && a.clave == clave)
                {
                    return true;
                }

            }

            return false;
        }


        public void MostrarCursosProfe(Persona profe)
        {
            string a = "Tus Cursos son:\n";
            foreach (Curso curso in cursos)
            {
                foreach (Seccion seccion in curso.secciones)
                {
                    if (seccion.profesor == profe)
                    {
                        a = a + curso.nombre + " NRC " + curso.nrc + " seccion " + seccion.numero + "\n";
                    }
                }
            }
            MessageBox.Show(a);
        }

        public void MostrarCursosAlumno(Persona alumno)
        {
            string a = "Tus Cursos son:\n";
            foreach (Curso curso in cursos)
            {
                foreach (Seccion seccion in curso.secciones)
                {
                    foreach (Persona alum in seccion.alumnos)
                    {
                        if (alum == alumno)
                        {
                            
                            a = a + curso.nombre + " NRC " + curso.nrc + " seccion " + seccion.numero + "\n";

                        }
                    }

                }
            }
            MessageBox.Show(a);

        }

        public bool VerificarProfe(int rut, string clave)
        {
            foreach (Curso curso in cursos)
            {
                foreach (Seccion seccion in curso.secciones)
                {
                    if (seccion.profesor.clave == clave && seccion.profesor.rut == rut)
                    {
                        return true;
                    }
                }

            }

            return false;
        }

        public BindingList<Curso> VerCursos(Persona p)
        {
            BindingList<Curso> lista = new BindingList<Curso>();
            foreach (Curso c in cursos)
            {
                foreach (Seccion s in c.secciones)
                {
                    foreach (Alumno a in s.alumnos)
                    {
                        if (a == p)
                        {
                            if (lista.Contains(c))
                            {
                                //Wena los cabres
                            }
                            else
                            {
                                lista.Add(c);
                            }
                        }
                    }
                }
            }

            return lista;
        }

    }
}

