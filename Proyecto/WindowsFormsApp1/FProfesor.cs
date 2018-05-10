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
    public partial class FProfesor : Form
    {
        public Persona p;
        public Carrera carrera;
        public FProfesor()
        {
            InitializeComponent();
        }

        private void FProfesor_Load(object sender, EventArgs e)
        {
            this.Text = carrera.nombre;
            lbBienvenidaProfe.Text = "Bienvenido " + p.nombre + " " + p.apellido;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingList<Curso> cursos = new BindingList<Curso>();

            cursos = (carrera.VerCursos(p));

            string mensaje = "Tus Cursos son \n Nombre\t\tNrc\n";
            foreach (Curso c in cursos)
            {
                
                mensaje = mensaje + "-  " + c.nombre + "\t" + c.mostrarNrc(p).ToString() + "\n";
            }
            MessageBox.Show(mensaje);
        }

        private void botonSalirProfe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
