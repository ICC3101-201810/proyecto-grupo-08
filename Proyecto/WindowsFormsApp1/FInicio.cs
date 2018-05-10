using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{

    public delegate void CambiarCarreraDelegate(Alumno log, string carrera);
    public partial class FInicio : Form
    {

        public Persona loggeado;
        public Universidad Uandes;
        public FInicio()
        {

            InitializeComponent();
            // cbCarreras  tbRut  tbClave botonCarrera

            BinaryFormatter formateador = new BinaryFormatter();
            Stream miStream = new FileStream("Universidades.un", FileMode.Open, FileAccess.Read, FileShare.None);
            Uandes = (Universidad)formateador.Deserialize(miStream);
            Uandes.MostrarCarreras();
            miStream.Close();
            this.cbCarreras.DataSource = Uandes.MostrarCarreras();
        }

        private void botonCarrera_Click(object sender, EventArgs e)
        {
            Carrera carrera = Uandes.DevolverCarrera(cbCarreras.Text);
            
            try
            {
                Persona loggeado = Uandes.VerPersona(carrera, tbRut.Text);
                if (carrera.VerificarAlumno(int.Parse(tbRut.Text), tbClave.Text))
                {
                    FAlumno form2 = new FAlumno();
                    form2.p = loggeado;
                    form2.carrera = carrera;
                    tbClave.Text = "";
                    tbRut.Text = "";
                    form2.Show();
                }

                else if (carrera.VerificarProfe(int.Parse(tbRut.Text), tbClave.Text))
                {
                    FProfesor form3 = new FProfesor();
                    this.Hide();
                    //form3.carrera = carrera;
                    tbClave.Text = "";
                    tbRut.Text = "";
                    form3.Show();
                }
                else if (carrera.VerificarAdmin(int.Parse(tbRut.Text), tbClave.Text))
                {
                    FAdmin form4 = new FAdmin();
                    this.Hide();
                    //form4.carrera = carrera;
                    tbClave.Text = "";
                    tbRut.Text = "";
                    form4.Show();
                }
                else
                {
                    MessageBox.Show("Rut o contraseña incorrectos.\nPor favor, ingrese los datos correctamente.");
                    tbClave.Text = "";
                    tbRut.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Rut o contraseña incorrectos.\nPor favor, ingrese los datos correctamente.");
            }

        }


        //MostrarRamoDelegate MRDelegate = new MostrarRamoDelegate(UpdateListaRamos);

        //List<String> nombreCarreras = MostrarCarrera();
        //this.cbCarreras.DataSource = nombreCarreras;





        public void UpdateListaRamos()
        {
            //Uandes.


        }

        private void cbCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
