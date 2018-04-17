using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Seccion
    {
        public int vacantes, numero;
        public Horario horario;
        public Profesor profesor;
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
