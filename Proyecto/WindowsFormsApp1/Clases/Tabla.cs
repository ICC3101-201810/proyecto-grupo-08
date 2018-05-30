using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Tabla
    {
        string nombre;
        string horario;
        string nrc, tipo;

        public Tabla(string nombre, string tipo, string horario, string nrc)
        {
            this.Nombre = nombre;
            this.Horario = horario;
            this.Nrc = nrc;
            this.Tipo = tipo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Horario { get => horario; set => horario = value; }
        public string Nrc { get => nrc; set => nrc = value; }
       
    }
}
