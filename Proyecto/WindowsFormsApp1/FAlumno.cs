using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class FAlumno : Form
    {
        FInicio fInicio = new FInicio();
        public Persona p;
        public Carrera carrera;
        public FAlumno()
        {
            InitializeComponent();


        }
        private void botonAgregarRamo_Click(object sender, EventArgs e)
        {
            AgregarRamos ar = new AgregarRamos();
            ar.Show();
        }

        private void BotonBotarRamo_Click(object sender, EventArgs e)
        {

        }

        private void BotonMostrarRamos_Click(object sender, EventArgs e)
        {
            BindingList<Curso> cursos = new BindingList<Curso>();

            cursos = (carrera.VerCursos(p));
            
            //string mensaje = "Tus Cursos son \n Nombre\t\tNrc\n";
            //foreach (Curso c in cursos)
            //{
            //    foreach (Seccion s in c.secciones)
            //    {

            //    }
                
            //    mensaje = mensaje + "-  " + c.nombre + "\t"   + "\t";
            //}
            MessageBox.Show(carrera.devolverStrDelCurso(cursos,p));
            
        }

        private void botonCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FAlumno_Load(object sender, EventArgs e)
        {
            this.Text = carrera.nombre;
            lbBienvenidaAlumno.Text = "Bienvenido " +p.nombre+" "+p.apellido;
            //lbNombre.Text = p.nombre;
            //lbApellido.Text = p.apellido;
        }
    }
}
