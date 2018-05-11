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
                        a = a + curso.nombre + " NRC " + seccion.nrc + "\n";
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

                            a = a + curso.nombre + " NRC " + seccion.nrc + "\n";

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

        public List<Curso> VerCursos(Persona p)
        {
            List<Curso> lista = new List<Curso>();
            foreach (Curso c in cursos)
            {
                foreach (Seccion s in c.secciones)
                {
                    if (s.profesor == p) //mismo metodo aplica en profes
                    {
                        if (lista.Contains(c))
                        {

                        }
                        else
                        {
                            lista.Add(c);
                        }
                    }
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

        public string devolverStrDelCurso(List<Curso> listaDeCursos, Persona p)
        {
            string mensaje = "Tus Cursos son \n Nombre\t\tNrc\n";
            foreach (Curso c in listaDeCursos)
            {
                mensaje = mensaje + "-  " + c.nombre + "\t" + c.mostrarNrc(p).ToString() + "\n";
            }
            return mensaje;
        }

        public List<int> DevolverNrc(string cursoString)
        {
            List<int> nrcs = new List<int>();
            foreach (Curso curso in cursos)
            {
                if (curso.nombre == cursoString)
                {
                    foreach (Seccion seccion in curso.secciones)
                    {
                        nrcs.Add(seccion.nrc);
                    }
                }
            }
            return nrcs;

        }
        public void agregarRamo(string nombreCurso, int nrc, Persona personaAgregar)
        {
            foreach (Curso c in cursos)
            {
                if (c.nombre == nombreCurso)
                {
                    foreach (Seccion s in c.secciones)
                    {
                        if (s.nrc == nrc)
                        {
                            s.alumnos.Add(personaAgregar);
                        }
                    }
                }
            }

        }

        public Curso RetornarCurso(string s)
        {
            foreach (Curso c in cursos)
            {
                if (c.nombre == s)
                {
                    return c;
                }
            }
            return null;
        }

        public Seccion RetornarSeccion(string s)
        {
            foreach (Curso c in cursos)
            {
                foreach (Seccion sec in c.secciones)
                {
                    if (sec.nrc == int.Parse(s))
                    {
                        return sec;
                    }
                }

            }
            return null;
        }

        public bool BotarRamo(int rutAlumno, Curso c)
        {
            foreach (Seccion se in c.secciones)
            {
                foreach (Persona a in se.alumnos)
                {
                    if (a.rut == rutAlumno)
                    {
                        se.alumnos.Remove(a);
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

