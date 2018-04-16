using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Curso
    {
        string nrc, nombre;
        int creditos;

        public Curso(string nrc, string nombre, int credito, List<Seccion> secciones)
        {
            this.nrc = nrc;
            this.nombre = nombre;
            this.creditos = credito;
            secciones = new List<Seccion>();
        }



    }
}
