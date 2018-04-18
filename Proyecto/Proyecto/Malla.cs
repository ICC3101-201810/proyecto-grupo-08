using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Malla
    {
      string ano;
      List<Curso> cursos;
      public Malla(string ano)
      {
          this.ano =ano;
          cursos = new List<Curso>();
      }
    }
}
