using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Semestre
    {
        public int tag;
        public List<Curso> cursos;
        public Semestre(int tag)
        {
            this.tag = tag;
            cursos = new List<Curso>();
        }

        public void AddCurso(Curso curso)
        {
          cursos.Add(curso);
        }
    }
}
