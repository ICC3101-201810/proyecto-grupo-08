using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Universidad Uandes = new Universidad("Universidad de los Andes");
            List<Alumno> alumnos = new List<Alumno>();
            List<Profesor> profesores = new List<Profesor>();
            List<Administrativo> admins = new List<Administrativo>();
            string carreraAlumno = "";
            int rut = 0;
            bool menuActivo = true;
            bool elBool = false;
            INICIOSESION:
            while (elBool == false)
            {

                Console.WriteLine("Ingrese su carrera: ");
                carreraAlumno = (Console.ReadLine()); elBool = Uandes.VerificarCarrera(Uandes, carreraAlumno);
            }
            Carrera carrera = Uandes.carreras.First(c => c.nombre == carreraAlumno);
            elBool = false;
            while (elBool == false)
            {
                Console.WriteLine("Ingrese su rut: ");
                rut = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese su clave: ");
                string clave = Console.ReadLine();
                elBool = carrera.VerificarAlumno(carrera, rut, clave);
            }
            Persona persona = carrera.alumnos.First(per => per.rut == rut);
            if (persona.tipo == "alumno")
            {
                Alumno alumno = alumnos.First(al => al.rut == rut);
                Console.WriteLine("Para volver al menu principal solo ingrese 0");
                Console.WriteLine("Bienvenido {0},", persona.nombre);
                Console.WriteLine("Presione Enter para continuar o 0 para cerrar sesion");
                string cerrar = Console.ReadLine();
                if (cerrar == "0")
                {
                    goto INICIOSESION;
                }
                while (menuActivo == true)
                {
                    MENU:
                    Console.Clear();
                    Console.WriteLine("Que deseas hacer" +
                    " 1.-Tomar Ramo" +
                    " 2.-Botar Ramo" +
                    " 3.-Mostrar Ramos" +
                    " 4.-Salir");
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        if (opcion < -1 || opcion > 4) { throw new DivideByZeroException(); }
                    }
                    catch
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Elija una opción válida entre 1 y 4");
                        Console.Beep(); Console.Beep(); Console.ResetColor();
                        goto MENU;
                    }
                    if (opcion == 0) { goto MENU; }
                    if (opcion == 1)
                    {
                        MENUTOMADERAMOS:
                        foreach (Curso curso in carrera.cursos) { Console.WriteLine(curso.nombre); }
                        Console.WriteLine("Escriba el nombre del curso que desea tomar");
                        string cursoTomar = Console.ReadLine();
                        if (cursoTomar == "0") { goto MENU; }
                        try
                        {
                            foreach (Curso c in carrera.cursos)
                            {
                                if (c.nombre == cursoTomar)
                                {
                                    if (persona.creditos < c.creditos)
                                    {
                                        Console.WriteLine("No tiene los creditos suficientes. Volviendo al menu principal");
                                        goto MENU;
                                    }
                                    else
                                    {
                                        SECCIONES:
                                        foreach (Seccion s in c.secciones)
                                        {
                                            List<Horario> horarioSemana = s.horario.Where(x => x.inicio > DateTime.Today && x.inicio < DateTime.Now.AddDays(7)).ToList();
                                            Console.WriteLine("---------------");
                                            Console.WriteLine(s.numero);
                                            foreach (Horario horario in horarioSemana)
                                            {
                                                Console.WriteLine(horario.inicio);
                                            }
                                        }
                                        Console.WriteLine("Ingrese la seccion que desea ");
                                        int seccionTomar = int.Parse(Console.ReadLine());
                                        if (seccionTomar == 0) { goto MENU; }
                                        try
                                        {
                                            foreach (Seccion s in c.secciones)
                                            {
                                                foreach (Seccion seccion in alumno.secciones)
                                                {
                                                    foreach (Horario horario in seccion.horario)
                                                    {
                                                        foreach (Seccion se in alumno.secciones)
                                                        {
                                                            foreach (Horario ho in seccion.horario)
                                                            {
                                                                if (horario.inicio == ho.inicio)
                                                                {
                                                                    Console.WriteLine("Hay un tope de horario con la seccion {0} en la hora {1}\nVolviendo al menu de secciones", se.numero, ho.inicio); goto SECCIONES;
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                                if (s.numero == seccionTomar && s.vacantes > 0)
                                                {
                                                    s.alumnos.Add(alumno);
                                                    alumno.secciones.Add(s);
                                                    alumno.creditos = persona.creditos - c.creditos;
                                                    s.vacantes--;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("No hay cupos, volviendo al menu de secciones");
                                                    goto SECCIONES;
                                                }
                                            }
                                        }
                                        catch
                                        {
                                            Console.WriteLine("Ingrese una seccion valida");
                                            goto SECCIONES;
                                        }
                                    }
                                }
                            }
                        }
                        catch
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Elija un curso valido");
                            Console.Beep(); Console.Beep(); Console.ResetColor();
                            goto MENUTOMADERAMOS;
                        }
                    }
                    if (opcion == 2)
                    {
                        MENUBOTARRAMOS:
                        foreach (Curso curso in carrera.cursos)
                        {
                            foreach (Alumno alumnobotar in curso.secciones)
                            {

                            }
                            
                        }
                            foreach (Seccion seccion in alumno.secciones) { Console.WriteLine(seccion.numero); }///////////
                        List<Curso> CursoBotar =
                        
                        Console.WriteLine("Escriba el nombre del curso que desea botar");
                      
                        if (cursoBotar == "0") { goto MENU; }
                        try
                        {
                            foreach (Curso c in carrera.cursos)
                            {
                                if (c.nombre == )
                                {
                                    if (persona.creditos < c.creditos)
                                    {
                                        Console.WriteLine("No tiene los creditos suficientes. Volviendo al menu principal");
                                        goto MENU;
                                    }

                                }
                            }
                        }
                        catch { }
                    }

                }
            }
            else if (persona.tipo == "profe")
            {
                Profesor profesor = profesores.First(al => al.rut == rut);
                Console.WriteLine("Para volver al menu principal solo ingrese 0");
                Console.WriteLine("Bienvenido {0},", persona.nombre);
                Console.WriteLine("Presione Enter para continuar");
                Console.ReadKey();
                while (menuActivo == true)
                {
                    MENUPROFE:
                    Console.Clear();
                    Console.WriteLine("Que deseas hacer" +
                    " 1.-Ver Secciones" +
                    " 2.-Ver Horario" +
                    " 3.-Cerrar Sesion");
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        if (opcion < -1 || opcion > 3) { throw new DivideByZeroException(); }
                    }
                    catch
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Elija una opción válida entre 1 y 3");
                        Console.Beep(); Console.Beep(); Console.ResetColor();
                        goto MENUPROFE;
                    }
                    if (opcion == 0) { goto MENUPROFE; }
                    if (opcion == 1)
                    {
                        foreach (Curso curso in carrera.cursos)
                        {
                            foreach (Seccion seccion in curso.secciones)
                            {
                                if (seccion.profesor == profesor)
                                {
                                    Console.WriteLine("El curso donde hace clases es " + curso.nombre + "\nEn la seccion "); Console.Write(seccion.numero);
                                    Console.WriteLine("Desea ver los alumnos de esta seccion?");
                                    string R = Console.ReadLine();
                                    if (R == "si") { seccion.MostrarAlumnos(); }
                                }
                                else { Console.WriteLine("Usted no posee secciones"); }


                            }
                        }

                    }
                    if (opcion == 2)
                    {
                        foreach (Curso curso in carrera.cursos)
                        {
                            foreach (Seccion seccion in curso.secciones)
                            {
                                if (seccion.profesor == profesor)
                                {
                                    foreach (Horario horario in seccion.horario)
                                    {
                                        Console.WriteLine(horario.inicio);
                                    }

                                }
                                else { Console.WriteLine("Usted no posee horario"); }


                            }
                        }

                    }
                    if (opcion == 3) { goto INICIOSESION; }
                }
            }
            else if (persona.tipo == "admin")
            {
                Administrativo admin = admins.First(al => al.rut == rut);
                MENUADMIN:
                Console.WriteLine("Bienvenido {0}" +
                    " 1.-Agregar alumno" +
                    " 2.-Agregar carrera" +
                    " 3.-Eliminar alumno" +
                    " 4.-Cerrar sesion", admin.nombre);
                int opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion == 0) { goto MENUADMIN; }

                else if (opcion == 1)
                {
                    Console.WriteLine("Ingrese el rut:");
                    int rutN = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el nombre:");
                    string nombreN = Console.ReadLine();
                    Console.WriteLine("Ingrese el apellido:");
                    string apellidoN = Console.ReadLine();
                    Console.WriteLine("Ingrese el anio en que ingreso");
                    DateTime anoN = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Ingrese una clave");
                    string claveN = Console.ReadLine();
                    Alumno alumnoNuevo = new Alumno(rutN, nombreN, apellidoN, anoN, claveN);
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("Ingrese el nombre de la carrera:");
                    string nombreC = Console.ReadLine();
                    Console.WriteLine("Ingrese el nombre de la facultad a la que pertenece:");
                    string facultadC = Console.ReadLine();
                    Carrera carreraNueva = new Carrera(nombreC, facultadC);
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("Ingrese el rut del alumno que desea eliminar:");
                    DENUEVO:
                    int rutAl = Convert.ToInt32(Console.ReadLine());
                    try { Alumno alumno = alumnos.First(al => al.rut == rutAl); alumnos.Remove(alumno); }
                    catch { Console.WriteLine("Ingrese un rut valido:"); goto DENUEVO; }
                }
                else if (opcion == 4) { goto INICIOSESION; }
            }
        }

    }
}


