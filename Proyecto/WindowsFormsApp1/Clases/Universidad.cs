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
    public class Universidad
    {
        public string nombre;
        public List<Carrera> carreras;
        public Universidad(string nombre)
        {
            this.nombre = nombre;
            carreras = new List<Carrera>();
        }

        public List<string> MostrarCarreras()
        {

            List<string> listaCarreras = new List<string>();
            foreach (Carrera carrera in carreras)
            {
                listaCarreras.Add(carrera.nombre);

            }
            return listaCarreras;
        }

        public Carrera DevolverCarrera(string nomb)
        {
            foreach (Carrera c in carreras)
            {
                if (c.nombre == nomb)
                {
                    return c;
                }
            }
            return null;
        }

        public Persona VerPersona(Carrera c, string rut)
        {
            try
            {
                foreach (Administrativo adm in c.admins)
                {
                    if (adm.rut == int.Parse(rut))
                    {
                        return adm;
                    }
                }
                foreach (Curso cu in c.cursos)
                {
                    foreach (Seccion s in cu.secciones)
                    {
                        if (s.profesor.rut == int.Parse(rut))
                        {
                            return s.profesor;
                        }
                        foreach (Alumno a in s.alumnos)
                        {
                            if (a.rut == int.Parse(rut))
                            {
                                return a;
                            }
                        }
                    }
                }

                return null;
            }
            catch { return null; }
        }



        public List<Persona> DevolverTodosAlumnos()
        {
            List<Persona> listAlum = new List<Persona>();
            foreach(Carrera carrera in carreras)
            {
                foreach(Curso curso in carrera.cursos)
                {
                    foreach(Seccion seccion in curso.secciones)
                    {
                        foreach(Persona alumno in seccion.alumnos)
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
            }
            return listAlum;
        }

        public void BorrarAlumno( string alumRut)
        {
            //INICIO:
            foreach (Carrera carrera in carreras)
            {
                foreach (Curso curso in carrera.cursos)
                {
                    foreach (Seccion seccion in curso.secciones)
                    {
                        try
                        {
                            foreach (Persona alumno in seccion.alumnos)
                            {
                                if (alumRut == alumno.rut.ToString())
                                {
                                    seccion.alumnos.Remove(alumno);
                                }
                            }
                        }
                        catch
                        {
                            //goto INICIO;
                        }
                    }
                }
            }
        }

        public Curso retornarCurso(string nombre)
        {
            foreach (Carrera carrera in carreras)
            {

                foreach (Curso curso in carrera.cursos)
                {

                    if (nombre == curso.nombre)
                    {
                        return curso;
                    }
                }
            }
            return null;
        }

        public bool noRepetirRamo(Persona persona,string nombreCurso)
        {
            foreach (Carrera carrera in carreras)
            {

                foreach (Curso curso in carrera.cursos)
                {
                    if (curso.nombre == nombreCurso)
                    {
                        foreach (Seccion seccion in curso.secciones)
                        {
                            if (seccion.alumnos.Contains(persona))
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }


    }

}


