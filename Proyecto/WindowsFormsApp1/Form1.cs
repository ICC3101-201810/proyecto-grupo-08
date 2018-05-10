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

    public delegate void MostrarRamoDelegate();
    public partial class Form1 : Form
    {

        public Universidad Uandes;
        public Form1()
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
                if (carrera.VerificarAlumno(int.Parse(tbRut.Text), tbClave.Text))
                {

                }
                else if (carrera.VerificarProfe(int.Parse(tbRut.Text), tbClave.Text))
                {

                }
                else if (carrera.VerificarAdmin(int.Parse(tbRut.Text), tbClave.Text))
                {

                }
                else
                {
                    MessageBox.Show("Rut o contraseña incorrectos.\nPor favor, ingrese los datos correctamente.");

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
