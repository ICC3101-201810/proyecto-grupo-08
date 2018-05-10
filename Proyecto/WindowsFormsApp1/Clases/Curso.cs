using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    [Serializable]
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

        public void AgregarRequisito(Curso requisito)//
        {
            requisitos.Add(requisito);
        }
        public void QuitarRequisito(Curso requisito)//
        {
            requisitos.Remove(requisito);
        }
        public void MostrarRequisito() //esto
        {
            foreach (Curso CursRequisito in requisitos)
            {
                Console.WriteLine(CursRequisito.nombre);
            }
        }
        public void CrearSeccion(Seccion seccion)//esto
        {
            secciones.Add(seccion);
        }
        public void MostrarSecciones()
        {
            string a="";
            foreach (Seccion s in secciones)
            {
                List<Horario> horarioSemana = s.horario.Where(x => x.inicio > DateTime.Today && x.inicio < DateTime.Now.AddDays(7)).ToList();
                a = a + "seccion " + s.numero+ "\n----------------\n";
                foreach (Horario horario in horarioSemana)
                {
                    a= a+horario.inicio+"\n";
                    //Console.WriteLine(horario.inicio);
                }
                a += "\n----------------\n";
                MessageBox.Show(a);
            }
        }

              

       /* public void MostrarSiEsta(Persona alumno)
        {
            string a = "Tus Cursos son:\n";
            foreach (Seccion seccion in secciones)
            {
                foreach (Persona per in seccion.alumnos)
                {
                    if (alumno == per)
                    {
                        a = a + nombre + " NRC " + nrc + " seccion " + seccion.numero + "\n";
                        
                    }
                }
            }
            MessageBox.Show(a);*/
                
            
        



    }
}
