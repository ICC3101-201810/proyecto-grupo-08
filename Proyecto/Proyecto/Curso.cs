using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Curso
    {
      public string nrc, nombre;
      public int creditos;
      public List<Curso> requisitos;//esto
      public List<Seccion> secciones;//esto

      public Curso(string nrc, string nombre, int credito)
      {
          this.nrc = nrc;
          this.nombre = nombre;
          this.creditos = credito;
          secciones = new List<Seccion>();
          requisitos = new List<Curso>();//esto
      }
      public void AgregarRequisito(Curso curso,Curso requisito )
      {
        curso.requisitos.Add(requisito);
      }
      public void QuitarRequisito(Curso curso,Curso requisito )
      {
        curso.requisitos.Remove(requisito);
      }
      public void MostrarRequisito(Curso curso)
      {
        Console.WriteLine(curso.requisitos);
      }
    }
}
