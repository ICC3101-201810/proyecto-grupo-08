using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Proyecto
{
    [Serializable]
    class Program
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
                Console.WriteLine("si o no");
                string q = Console.ReadLine();
                if (q == "si")
                {
                    Console.WriteLine("Ingrese su rut: ");
                    rut = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese su clave: ");
                    string clave = Console.ReadLine();
                    elBool = carrera.VerificarAlumno(rut, clave);

                    elBool = carrera.VerificarAdmin(rut, clave);///
                    if (elBool == false) { elBool = carrera.VerificarProfe(rut, clave); }
                    /////
                }
                else { goto FINAL; }

            }
            personas.Clear();
            //foreach (Alumno alumno in carrera.alumnos) {if (alumno.rut == rut) { personas.Add(alumno);  } }
            foreach (Curso curso in carrera.cursos)
            {
                foreach (Seccion seccion in curso.secciones)
                {
                    if (seccion.profesor.rut == rut) { personas.Add(seccion.profesor); }
                }
            }



            //persona = carrera.alumnos.First(per => per.rut == rut);

            Persona persona = personas[0];
            if (persona.tipo == "alumno")
            #region ALUMNO
            {
                Persona alumno = personas[0];
                Console.WriteLine("Para cerrar por completo el software, ingrese un cero (0)");
                Console.WriteLine("Bienvenido {0},", persona.nombre);
                Console.WriteLine("Presione Enter para continuar o 0 para salir del programa");
                string cerrar = Console.ReadLine();
                if (cerrar == "0")
                {
                    goto FINAL;
                }
                while (menuActivo == true)
                {
                    MENU:
                    Console.Clear();
                    Console.WriteLine("Que deseas hacer" +
                    " 1.-Tomar Ramo" +
                    " 2.-Botar Ramo" +
                    " 3.-Mostrar Ramos" +
                    " 4.-Cerrar Sesion");
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
                    if (opcion == 0) { goto FINAL; }
                    if (opcion == 4)
                    {
                        goto INICIOSESION;
                    }
                    if (opcion == 1)
                    {
                        MENUTOMADERAMOS:
                        foreach (Curso curso in carrera.cursos) { Console.WriteLine(curso.nombre); }
                        Console.WriteLine("Escriba el nombre del curso que desea tomar");
                        string cursoTomar = Console.ReadLine();
                        if (cursoTomar == "0") { goto FINAL; }
                        try
                        {
                            //string MostrarCursos = "";
                            foreach (Curso c in carrera.cursos)
                            {
                                if (c.nombre == cursoTomar)
                                {
                                    if (alumno.creditos < c.creditos)
                                    {
                                        Console.WriteLine("No tiene los creditos suficientes. Volviendo al menu principal");
                                        goto MENU;
                                    }
                                    else
                                    {
                                        SECCIONES:
                                        c.MostrarSecciones();
                                        /*foreach (Seccion s in c.secciones)
                                        {
                                            List<Horario> horarioSemana = s.horario.Where(x => x.inicio > DateTime.Today && x.inicio < DateTime.Now.AddDays(7)).ToList();
                                            Console.WriteLine("---------------");
                                            Console.WriteLine(s.numero);
                                            foreach (Horario horario in horarioSemana)
                                            {
                                                Console.WriteLine(horario.inicio);
                                            }
                                            Console.ReadKey();
                                        }*/
                                        Console.WriteLine("Ingrese la seccion que desea ");
                                        int seccionTomar = int.Parse(Console.ReadLine());
                                        if (seccionTomar == 0) { goto FINAL; }

                                        try
                                        {
                                            foreach (Seccion s in c.secciones)
                                            {
                                                if (seccionTomar == s.numero)
                                                {
                                                    if (s.RevisarSiTopa(alumno))
                                                    {
                                                        Console.WriteLine("Hay un tope de horario por lo que no es posible agregar su eleccion.\nVolviendo al menu de secciones"); goto SECCIONES;
                                                    }
                                                    else
                                                    {
                                                        if (s.vacantes > 0)
                                                        {
                                                            s.AgregarAlumno(alumno);
                                                            alumno.secciones.Add(s);
                                                            alumno.creditos = alumno.creditos - c.creditos;
                                                            s.vacantes--;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("No hay cupos, volviendo al menu de secciones");
                                                            goto SECCIONES;
                                                        }
                                                    }
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

                        List<Curso> cc = new List<Curso>();
                        List<Seccion> ids = new List<Seccion>();
                        foreach (Curso curso in carrera.cursos)
                        {
                            foreach (Seccion seccion in curso.secciones)
                            {
                                foreach (Seccion sexion in alumno.secciones)
                                {
                                    if (seccion == sexion)
                                    {
                                        cc.Add(curso);
                                        ids.Add(seccion);
                                    }
                                }
                            }
                        }
                        Console.WriteLine("Los cursos que estas cursando son los siguientes: ");
                        foreach (Curso s in cc)
                        {
                            Console.WriteLine("Nombre: {0}    /     NRC: {1}", s.nombre, s.nrc);
                        }
                        Console.ReadKey();
                        Console.WriteLine("Escribe el NRC del curso que deseas eliminar. ");
                        string nrcBotar = Console.ReadLine();
                        if (nrcBotar == "0") { goto FINAL; }
                        try
                        {
                            int index = cc.FindIndex(curso => curso.nrc == nrcBotar);
                            alumno.QuitarSeccion(ids[index]);
                            ids[index].QuitarAlumnos(alumno);
                            //Console.BackgroundColor = ConsoleColor.Green;
                            Console.WriteLine("Curso eliminado con exito :) ");
                            //Console.BackgroundColor = ConsoleColor.Gray;
                            Console.WriteLine("Deseas eliminar otro curso?");
                            string q = Console.ReadLine();
                            if (q == "si")
                            {
                                goto MENUBOTARRAMOS;
                            }
                            else
                            {
                                goto MENU;
                            }

                        }
                        catch
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Elija un curso valido");
                            Console.Beep(); Console.Beep(); Console.ResetColor();
                            goto MENUBOTARRAMOS;
                        }
                    }
                    if (opcion == 3)
                    {
                        carrera.MostrarCursosAlumno(alumno);

                    }

                }
            }
            #endregion
            else if (persona.tipo == "profe")
            #region PROFESOR
            {
                Persona profesor = personas[0];
                Console.WriteLine("Para cerrar por completo el software, ingrese un cero (0)");
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
                    if (opcion == 0) { goto FINAL; }
                    if (opcion == 1)
                    {
                        carrera.MostrarCursosProfe(profesor);
                        foreach (Curso curso in carrera.cursos)
                        {
                            foreach (Seccion seccion in curso.secciones)
                            {
                                if (seccion.profesor == profesor)
                                {
                                    Console.WriteLine("El curso donde hace clases es " + curso.nombre + "\nEn la seccion "); Console.Write(seccion.numero);
                                    Console.WriteLine("Desea ver los alumnos de esta seccion?");
                                    string R = Console.ReadLine();
                                    if (R == "si") { seccion.MostrarAlumnos(); Console.ReadKey(); }
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
                                    Console.ReadKey();

                                }
                                else { Console.WriteLine("Usted no posee horario"); }


                            }
                        }

                    }
                    if (opcion == 3) { goto INICIOSESION; }
                }
            }
            #endregion
            else if (persona.tipo == "admin")
            #region ADMINISTRADOR
            {
                Persona admin = personas[0];
                MENUADMIN:
                Console.WriteLine("Para cerrar por completo el software, ingrese un cero (0)");
                Console.WriteLine("Bienvenido {0}" +
                    " 1.-Agregar alumno" +
                    " 2.-Agregar carrera" +
                    " 3.-Eliminar alumno" +
                    " 4.-Cerrar sesion", admin.nombre);
                int opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion == 0) { goto FINAL; }

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
                    try { Alumno alumnoNuevo = new Alumno(rutN, nombreN, apellidoN, anoN, claveN); Console.WriteLine("Persona creada con exito"); }
                    catch { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Error al crear el alumno"); Console.ResetColor(); goto MENUADMIN; }
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("Ingrese el nombre de la carrera:");
                    string nombreC = Console.ReadLine();
                    Console.WriteLine("Ingrese el nombre de la facultad a la que pertenece:");
                    string facultadC = Console.ReadLine();
                    try { Carrera carreraNueva = new Carrera(nombreC, facultadC); Console.WriteLine("Carrera creada con exito"); }
                    catch { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Error al crear la carrera"); Console.ResetColor(); goto MENUADMIN; }
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
            #endregion
            FINAL:
            Console.WriteLine("Gracias por preferirnos, hasta luego !");
            Console.ReadKey();

        }


    }

}


