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
            string carreraAlumno = "";
            int rut = 0;
            bool menuActivo = true;
            bool elBool = false;
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
                Console.WriteLine("Presione Enter para continuar");
                Console.ReadKey();
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
                                            //List<Horario> horarioSemana = s.horario.Where(x=>x.inicio > DateTime.Today && x.inicio < DateTime.Now.AddDays(7)).ToList();
                                            Console.WriteLine("---------------");
                                            Console.WriteLine(s.numero);
                                            Console.WriteLine(s.horario);
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
                }
            }
        }
    }
}

