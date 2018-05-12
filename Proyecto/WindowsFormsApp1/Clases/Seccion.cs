using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Seccion
    {
        public int vacantes;//numero;
        public int nrc;
        public List<Horario> horario;
        public Profesor profesor;
        public List<Persona> alumnos;

        public Seccion(int vacantes, int nrc, Profesor profesor)
        {
            this.vacantes = vacantes;
            this.nrc = nrc;
            this.profesor = profesor;
            alumnos = new List<Persona>();
            horario = new List<Horario>();

        }
    }
}
