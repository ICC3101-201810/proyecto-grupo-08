using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Semestre
    {
        int tag;


        public Semestre(int tag, List<Curso> cursos)
        {
            this.tag = tag;
            cursos = new List<Curso>();
        }
    }
}