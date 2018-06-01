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

        public BindingList<Tabla> devolverStrDelCurso(List<Curso> listaDeCursos, Persona p)
        {
            BindingList<Tabla> lista = new BindingList<Tabla>();
            foreach (Curso c in listaDeCursos)
            {
                foreach (Horario horario in c.secciones[0].horario)
                {
                    if (c.nombre == "") { continue; }
                    else
                    {
                        Tabla elementoTabla = new Tabla(c.nombre, horario.tipo, horario.inicio.DayOfWeek.ToString() + "  " + horario.inicio.TimeOfDay.ToString(), c.mostrarNrc(p).ToString(), horario.duracion);
                        lista.Add(elementoTabla);
                    }
                }

            }
            return lista;
        }

        public BindingList<int> DevolverNrc(string cursoString)
        {
            BindingList<int> nrcs = new BindingList<int>();
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
        public bool ExisteNrc(string nrcString)
        {
            foreach (Curso curso in cursos)
            {
                 foreach (Seccion seccion in curso.secciones)
                 {
                    if (seccion.nrc == Convert.ToInt32(nrcString)) {return true;}
                 }          
            }
            return false;

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

        public Profesor RetornarProfesor(string pro)
        {
            foreach (Curso c in cursos)
            {
                foreach (Seccion s in c.secciones)
                {
                    if (s.profesor.nombre == pro)
                    {
                        return s.profesor;

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

        public List<Profesor> RetornarProfesoresCarreras() ////
        {
            List<Profesor> profes = new List<Profesor>();
            foreach (Curso curso in cursos)
            {
                foreach (Seccion seccion in curso.secciones)
                {

                    if (profes.Contains(seccion.profesor))
                    {
                        continue;
                    }
                    else
                    {
                        profes.Add(seccion.profesor);
                    }
                }

            }
            return profes;
        }

        public Curso devolverCursoDeUnNrc(int nrc)
        {
            foreach (Curso c in cursos)
            {
                foreach (Seccion s in c.secciones)
                {
                    if (s.nrc == nrc)
                    {
                        return c;
                    }
                }
            }
            return null;
        }
        public Seccion devolverSeccionDeUnNrc(int nrc)
        {
            foreach (Curso c in cursos)
            {
                foreach (Seccion s in c.secciones)
                {
                    if (s.nrc == nrc)
                    {
                        return s;
                    }
                }
            }
            return null;
        }

        public void EliminarCurso(Curso curso)
        {
            try
            {
                foreach (Curso cur in cursos)
                {
                    if (cur == curso)
                    {
                        cursos.Remove(cur);
                    }
                }
            }
            catch { }

        }

        public List<Persona> DevolverTodosAlumnos()
        {
            List<Persona> listAlum = new List<Persona>();
            foreach (Curso curso in cursos)
            {
                foreach (Seccion seccion in curso.secciones)
                {
                    foreach (Persona alumno in seccion.alumnos)
                    {
                        if (listAlum.Contains(alumno))
                        {

                        }
                        else
                        {
                            listAlum.Add(alumno);
                        }

                    }
                }
            }

            return listAlum;
        }

    }
}

