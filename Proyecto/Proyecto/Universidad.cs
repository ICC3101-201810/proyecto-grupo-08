using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Universidad
    {
        public string nombre;
        public List<Carrera> carreras;
        public Universidad(string nombre)
        {
            this.nombre = nombre;
            carreras = new List<Carrera>();
        }
        public void CrearAlumno(int rut, string nombre, string apellido,int ano ,string clave) => new Alumno(rut, nombre, apellido,ano, clave);
        public void CrearProfesor(int rut, string nombre, string apellido,int ano, string clave, string titulo) => new Profesor(rut, nombre, apellido,clave,ano,titulo);
        public void CrearAdmin(int rut, string nombre, string apellido,string rango, string clave) => new Administrativo(rut, nombre, apellido,rango, clave);

        public bool VerificarCarrera(Universidad universidad, string nombre)
        {
            foreach (Carrera c in universidad.carreras)
            {
                if (c.nombre == nombre) { return true; }
            }
            Console.BackgroundColor = ConsoleColor.Yellow; Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Ingrese datos correctos"); Console.Beep(); Console.Beep(); Console.ResetColor();
            return false;
        }

    }

}


