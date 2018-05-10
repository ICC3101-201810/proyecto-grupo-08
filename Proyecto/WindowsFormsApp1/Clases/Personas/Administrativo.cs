using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Administrativo:Persona
    {
        string rango;
        public Administrativo(int rut, string nombre, string apellido, string rango, string clave):base(rut,nombre,apellido,clave)
        {
            this.rango = rango;
            this.tipo = "admin";
        }
    }
}
