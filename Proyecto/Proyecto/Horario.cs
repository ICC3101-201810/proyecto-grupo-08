using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Horario
    {
        public List<Tuple<DateTime,DateTime>> horario;
        string tipo;//Ayudantia, Clase, Laboratorio o Prueba
        public Horario(string tipo, List<Tuple<DateTime, DateTime>> horario)
        {
            this.tipo = tipo;
            this.horario = horario;
        }
    }
}
