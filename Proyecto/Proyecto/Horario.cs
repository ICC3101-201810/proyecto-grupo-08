using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
  class Horario
  {
      DateTime horario;
      string tipo;//Ayudantia, Clase, Laboratorio o Prueba
      public Horario(string tipo, DateTime horario)
      {
          this.tipo = tipo;
          this.horario = horario;
      }
  }
}
