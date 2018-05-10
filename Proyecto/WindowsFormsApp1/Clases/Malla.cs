using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
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
