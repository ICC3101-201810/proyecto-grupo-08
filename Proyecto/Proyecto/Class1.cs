using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Proyecto
{
    class Class1
    {
        static void Main(string[] args)
        {
            BinaryFormatter formateador = new BinaryFormatter();
            Stream miStream = new FileStream("Universidades.un", FileMode.Open, FileAccess.Read, FileShare.None);
            Universidad Uandes = (Universidad)formateador.Deserialize(miStream);
            miStream.Close();
            Uandes.MostrarCarreras();

            Console.WriteLine(Uandes.nombre);

            Console.ReadLine();

            Universidad Uandes = new Universidad("Universidad de los Andes");
            List<Alumno> alumnos = new List<Alumno>();
            List<Profesor> profesores = new List<Profesor>();
            List<Administrativo> admins = new List<Administrativo>();
            List<Persona> personas = new List<Persona>();

            Carrera Ingenieria = new Carrera("ingenieria", "Facultad de Ingeniería y Ciencias Aplicadas");
            Carrera Comercial = new Carrera("comercial", "Facultad de Negocios");
            Alumno alumnoIng = new Alumno(2, "Juan", "Perez", DateTime.Today.AddYears(-7), "a");
            Alumno a1 = new Alumno(3, "Pedro", "Perez", DateTime.Today.AddYears(-2), "a");
            Alumno a2 = new Alumno(4, "Juan", "Soto", DateTime.Today.AddYears(-5), "a");
            Alumno a12 = new Alumno(5, "Felipe", "Arteaga", DateTime.Today.AddYears(-3), "a");
            Alumno a11 = new Alumno(6, "Ignacio", "Sanchez", DateTime.Today.AddYears(-1), "a");
            Alumno a10 = new Alumno(7, "Isidora", "Hernandez", DateTime.Today.AddYears(-2), "a");
            Alumno a9 = new Alumno(8, "Francisca", "Perez", DateTime.Today.AddYears(-4), "a");
            Alumno a8a = new Alumno(9, "Carolina", "Perez", DateTime.Today.AddYears(-2), "a");
            Alumno a7 = new Alumno(10, "Juana", "Perez", DateTime.Today.AddYears(-2), "a");
            Alumno a6 = new Alumno(21, "Sara", "Arteaga", DateTime.Today.AddYears(-2), "a");
            Alumno a5 = new Alumno(22, "Federico", "Sanchez", DateTime.Today.AddYears(-3), "a");
            Alumno a4 = new Alumno(23, "Pepe", "Soto", DateTime.Today.AddYears(-8), "a");
            Alumno a3 = new Alumno(24, "Juan", "Hernandez", DateTime.Today.AddYears(-2), "a");

            Curso calculo2 = new Curso("1201810", "Calculo 2", 6);
            Curso calculo1 = new Curso("2201810", "Calculo 1", 6);
            Curso edo = new Curso("3201810", "Ecuaciones diferenciales ordinarias", 6);
            Curso lineal = new Curso("4201810", "Algebra lineal", 6);
            Curso algebra = new Curso("5201810", "Algebra", 6);

            calculo2.requisitos.Add(calculo1);
            edo.requisitos.Add(lineal);
            edo.requisitos.Add(calculo1);
            lineal.requisitos.Add(algebra);

            Profesor tata = new Profesor(1, "Leonardo", "Sanchez", "1", DateTime.Today.AddYears(-10), "Ingenieria Civil");
            Profesor sat = new Profesor(25, "Ricardo", "Sat", "2", DateTime.Today.AddYears(-10), "Ingenieria Civil");
            Profesor Lorca = new Profesor(26, "Felipe", "Lorca", "3", DateTime.Today.AddYears(-10), "Ingenieria Civil");

            Seccion calculo1Sec1 = new Seccion(60, 1, tata);
            Seccion AlgebraSec1 = new Seccion(42, 1, sat);
            Seccion LinealSec1 = new Seccion(50, 1, Lorca);
            Seccion edoSec1 = new Seccion(50, 1, Lorca);
            Seccion calculo2Sec1 = new Seccion(50, 1, Lorca);
            Horario horarioCal = new Horario("clase", DateTime.Today.AddHours(10), 2);
            Horario horarioCal1 = new Horario("clase", DateTime.Today.AddHours(10), 2);
            Horario horarioAlg = new Horario("clase", DateTime.Today.AddHours(10), 2);
            Horario horarioLin = new Horario("clase", DateTime.Today.AddHours(5), 2);
            Horario horarioLin2 = new Horario("clase", DateTime.Today.AddHours(15), 2);
            Horario horarioLin3 = new Horario("clase", DateTime.Today.AddHours(13), 2);

            calculo1Sec1.alumnos.Add(alumnoIng);
            calculo1Sec1.horario.Add(horarioCal);
            AlgebraSec1.horario.Add(horarioCal);
            AlgebraSec1.horario.Add(horarioCal1);
            LinealSec1.horario.Add(horarioLin);
            LinealSec1.horario.Add(horarioLin2);
            LinealSec1.horario.Add(horarioLin3);
            edoSec1.horario.Add(horarioLin2);
            calculo2Sec1.horario.Add(horarioCal);

            calculo1.secciones.Add(calculo1Sec1);
            algebra.secciones.Add(AlgebraSec1);
            lineal.secciones.Add(LinealSec1);
            edo.secciones.Add(edoSec1);
            calculo2.secciones.Add(calculo2Sec1);

            Ingenieria.cursos.Add(calculo1);
            Ingenieria.cursos.Add(algebra);
            Ingenieria.cursos.Add(lineal);
            Ingenieria.cursos.Add(edo);
            Ingenieria.cursos.Add(calculo2);


            Ingenieria.alumnos.Add(alumnoIng);
            Ingenieria.cursos.Add(calculo2);

            Administrativo admin1 = new Administrativo(0, "admin", "user", "admin", "admin");
            Uandes.carreras.Add(Ingenieria);

            BinaryFormatter formateador = new BinaryFormatter();
            Stream miStream = new FileStream("Universidades.un", FileMode.Create, FileAccess.Write);
            formateador.Serialize(miStream, Uandes);
            miStream.Close();
        }

    }
}
