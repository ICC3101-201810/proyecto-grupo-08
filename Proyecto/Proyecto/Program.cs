using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su rut: ");
            int rut = Convert.ToInt32(Console.Read());
            var ruts = Universidad.Personas.Where(per => per.rut == rut);
            while ( ruts == null )
            {
                Console.WriteLine("Ingrese un rut valido: ");
                rut = Convert.ToInt32(Console.Read());
            }
        }
    }
}
