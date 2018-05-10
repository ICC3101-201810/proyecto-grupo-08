﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Universidad
    {
       // public event MostrarRamoDelegate MostrarEnInicio;
        //MostrarEnInicio(cursos);
        public string nombre;
        public List<Carrera> carreras;
        public Universidad(string nombre)
        {
            this.nombre = nombre;
            carreras = new List<Carrera>();
        }
        public void CrearAlumno(int rut, string nombre, string apellido, DateTime ano, string clave) => new Alumno(rut, nombre, apellido, ano, clave);
        public void CrearProfesor(int rut, string nombre, string apellido, DateTime ano, string clave, string titulo) => new Profesor(rut, nombre, apellido, clave, ano, titulo);
        public void CrearAdmin(int rut, string nombre, string apellido, string rango, string clave) => new Administrativo(rut, nombre, apellido, rango, clave);


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
            foreach(Carrera c in carreras)
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
    }

}

