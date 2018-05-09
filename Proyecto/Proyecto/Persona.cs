using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    [Serializable]
    public abstract class Persona
    {
        public int rut, creditos;
        public string nombre, apellido, clave, tipo;
        public List<Seccion> secciones;

        public Persona(int rut, string nombre, string apellido, string clave)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.apellido = apellido;
            this.clave = clave;
            secciones = new List<Seccion>();
        }

        public bool Login(Persona persona)
        {
            Console.WriteLine("Ingrese su rut: ");
            int rut = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su contraseña: ");
            string clave = Console.ReadLine();
            if (persona.rut == rut && persona.clave == clave) { return true; }
            else { return false; }
        }

        public void QuitarSeccion(Seccion seccion)
        {
            secciones.Remove(seccion);
        }

        public bool iniciarSesion(Carrera carrera, int rut, string clave)
        {
            foreach (Administrativo admin in carrera.admins)
            {
                if (admin.rut == rut && admin.clave == clave)
                {
                    return true;
                }
            }
            foreach (Curso curso in carrera.cursos)
            {
                foreach (Seccion seccion in curso.secciones)
                {
                    if (seccion.profesor.rut == rut && seccion.profesor.clave == clave)
                    {
                        return true;
                    }
                    foreach (Persona p in seccion.alumnos)
                    {
                        if (p.rut == rut && p.clave == clave)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
            
        }
    }
}
