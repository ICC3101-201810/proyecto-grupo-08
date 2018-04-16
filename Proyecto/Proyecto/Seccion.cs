using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Seccion
    {
        int vacantes, numero;
        Horario horario;
        Profesor profesor;
        public Seccion(int vacantes, int numero, Horario horario, Profesor profesor, List<Alumno> alumnos)
        {
            this.vacantes = vacantes;
            this.numero = numero;
            this.horario = horario;
            this.profesor = profesor;
            alumnos = List<Alumno>();

        }
    }
}