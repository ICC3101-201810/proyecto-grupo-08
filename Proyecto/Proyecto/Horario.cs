using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Horario
    {
        public DateTime inicio;
        public int duracion;
        string tipo;//Ayudantia, Clase, Laboratorio o Prueba
        public Horario(string tipo, DateTime inicio, int duracion)
        {
            this.tipo = tipo;
            this.inicio = inicio;
            this.duracion = duracion;
        }
    }
}
