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
using System.Media;

namespace WindowsFormsApp1
{

    public delegate void CambiarCarreraDelegate(Alumno log, string carrera);
    public partial class FInicio : Form
    {

        public Persona loggeado;
        public Universidad Uandes;
        public Carrera carrera;
        List<Curso> cursos = new List<Curso>();
        List<Persona> alumnosU = new List<Persona>();
 
        BindingList<string> CursosString = new BindingList<string>();
        BindingList<string> CursosStringProfesor = new BindingList<string>();
        BindingList<string> AlumnosString = new BindingList<string>();
        List<string> todosLosCursos = new List<string>();
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
            cbAdministradorAlumnoNuevoCarreras.DataSource = Uandes.MostrarCarreras();

        }

        private void botonCarrera_Click(object sender, EventArgs e)
        {
            carrera = Uandes.DevolverCarrera(cbCarreras.Text);

            try
            {
                loggeado = Uandes.VerPersona(carrera, tbRut.Text);
                if (carrera.VerificarAlumno(int.Parse(tbRut.Text), tbClave.Text))
                {
                    FAlumno form2 = new FAlumno();
                    form2.p = loggeado;
                    form2.carrera = carrera;
                    tbClave.Text = "";
                    tbRut.Text = "";
                    lbBienvenidoAlumno.Text = "Bienvenido " + loggeado.nombre + " " + loggeado.apellido;
                    PanelInicio.Hide();
                    panelAlumno.Show();
                    //form2.Show();
                }

                else if (carrera.VerificarProfe(int.Parse(tbRut.Text), tbClave.Text))
                {
                    FProfesor form3 = new FProfesor();
                    //this.Hide();
                    form3.p = loggeado;
                    form3.carrera = carrera;
                    lbBienvenidoProfesor.Text = "Bienvenido \n" + loggeado.nombre + " " + loggeado.apellido;
                    tbClave.Text = "";
                    tbRut.Text = "";
                    PanelInicio.Hide();
                    panelProfesor.Show();
                    //form3.Show();
                }
                else if (carrera.VerificarAdmin(int.Parse(tbRut.Text), tbClave.Text))
                {
                    FAdmin form4 = new FAdmin();
                    //this.Hide();
                    //form4.carrera = carrera;
                    lbBienvenidoAdministrador.Text = "Bienvenido \n" + loggeado.nombre + " " + loggeado.apellido;
                    tbClave.Text = "";
                    tbRut.Text = "";
                    PanelInicio.Hide();
                    tbAdministradorCrearAlumnoEstado.Text = "";
                    panelAdministrador.Show();
                    //form4.Show();
                }
                else
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Rut o contraseña incorrectos.\nPor favor, ingrese los datos correctamente.");
                    tbClave.Text = "";
                    tbRut.Text = "";
                    SendKeys.Send("{TAB}");
                }
            }
            catch
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Rut o contraseña incorrectos.\nPor favor, ingrese los datos correctamente.");
                tbClave.Text = "";
                tbRut.Text = "";
                SendKeys.Send("{TAB}");
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

        private void FInicio_Load(object sender, EventArgs e)
        {
            PanelInicio.Show();
            lbAvisoTomaRamo.Text = "";
        }

        private void panelAlumno_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botonCerrarSeccionAlumno_Click(object sender, EventArgs e)
        {
            panelAlumno.Hide();
            PanelInicio.Show();
        }

        private void botonVerRamosAlumno_Click(object sender, EventArgs e)
        {
            carrera = Uandes.DevolverCarrera(cbCarreras.Text);
            cursos = (carrera.VerCursos(loggeado));
            MessageBox.Show(carrera.devolverStrDelCurso(cursos, loggeado));
        }



        private void tbClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.botonCarrera_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbRut_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void botonAgeregarRamoAlumno_Click(object sender, EventArgs e)
        {
            panelAlumno.Hide();
            panelTomaRamoAlumno.Show();
            todosLosCursos.Clear();
            foreach (Curso c in carrera.cursos) { todosLosCursos.Add(c.nombre); }
            cbAgregarRamoAlumno.DataSource = todosLosCursos;

        }

        private void btnTomarRamosAlumnoSalir_Click(object sender, EventArgs e)
        {
            panelTomaRamoAlumno.Hide();
            panelAlumno.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarTomarRamoAlumno_Click(object sender, EventArgs e)
        {

            if (carrera.RetornarCurso(cbAgregarRamoAlumno.Text).RequisitosAprobados(loggeado) && loggeado.TopeHorario(carrera, carrera.RetornarSeccion(cbSeccionTomarRamoAlumno.Text)))

            {
                carrera.agregarRamo(cbAgregarRamoAlumno.Text, int.Parse(cbSeccionTomarRamoAlumno.Text), loggeado);
                lbAvisoTomaRamo.ForeColor = Color.Black;
                lbAvisoTomaRamo.Text = cbAgregarRamoAlumno.Text + " fue agregado con exito";
            }
            else
            {
                SystemSounds.Hand.Play();
                lbAvisoTomaRamo.ForeColor = Color.Red;
                lbAvisoTomaRamo.Text = "No puedes tomar " + cbAgregarRamoAlumno.Text;

            }
        }

        private void cbAgregarRamoAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSeccionTomarRamoAlumno.DataSource = carrera.DevolverNrc(cbAgregarRamoAlumno.Text);
        }

        private void btnSalirBotarRamo_Click(object sender, EventArgs e)
        {
            panelBotarRamo.Hide();
            panelAlumno.Show();
        }

        private void botonBotarRamoAlumno_Click(object sender, EventArgs e) //BOTON FORM 4 BOTONES
        {
            panelAlumno.Hide();

            cursos = (carrera.VerCursos(loggeado));
            CursosString.Clear();
            foreach (Curso curso in cursos)
            {
                CursosString.Add(curso.nombre);

            }
            cbBotarRamo.DataSource = CursosString;

            lbAvisoBotarRamo.Text = "";
            panelBotarRamo.Show();
        }

        private void btnBotarRamo_Click(object sender, EventArgs e)//BOTON BOTAR RAMO
        {
            if (carrera.BotarRamo(loggeado.rut, carrera.RetornarCurso(cbBotarRamo.Text))) { lbAvisoBotarRamo.Text = cbBotarRamo.Text + " fue botado con exito"; }
            CursosString.Remove(cbBotarRamo.Text);
            cbBotarRamo.Refresh();
        }

        private void FInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter formateador = new BinaryFormatter();
            Stream miStream = new FileStream("Universidades.un", FileMode.Create, FileAccess.Write);
            formateador.Serialize(miStream, Uandes);
            miStream.Close();
            MessageBox.Show("Todos los datos modificados han sido guardados con exito.\n Gracias por preferirnos");
        }

        private void btnSalirProfesor_Click(object sender, EventArgs e)
        {
            panelProfesor.Hide();
            PanelInicio.Show();
        }

        private void btnCursosProfesor_Click(object sender, EventArgs e)
        {
            cursos = (carrera.VerCursos(loggeado));
            CursosStringProfesor.Clear();
            foreach (Curso curso in cursos)
            {     
                CursosStringProfesor.Add(curso.nombre);
                          
            }

            cbCursosProfesor.DataSource = CursosStringProfesor;
            
            panelProfesor.Hide();
            panelCursosProfesor.Show();
        }

        private void btnVolverCursosProfesor_Click(object sender, EventArgs e)
        {
            panelCursosProfesor.Hide();
            panelProfesor.Show();
        }

        private void btnVerAlumnos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(carrera.RetornarCurso(cbCursosProfesor.Text).MostarALumnosCurso(loggeado));

        }

        private void btnAdministradorCerrar_Click(object sender, EventArgs e)
        {
            panelAdministrador.Hide();
            PanelInicio.Show();
        }

        private void btnAdministradorAgregarAlumno_Click(object sender, EventArgs e)
        {
            panelAdministrador.Hide();
            panelAdministradorCrearAlumno.Show();
            todosLosCursos.Clear();
            foreach (Curso c in carrera.cursos) { todosLosCursos.Add(c.nombre); }
            cbAdministradorAlumnoNuevoRamo.DataSource = todosLosCursos;
        }

        private void btnAdministradorAgregarAlumnoNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno alumnoNuevo = new Alumno(int.Parse(tbAdministradoAgregarRut.Text), tbAdministradorAgregarNombre.Text, tbAdministradorAgregarApellido.Text, DateTime.Today, tbAdministradorAgregarClave.Text);
                tbAdministradorCrearAlumnoEstado.Text = tbAdministradorAgregarNombre.Text + " fue Creado con exito"; tbAdministradorAgregarNombre.Text = ""; tbAdministradoAgregarRut.Text = ""; tbAdministradorAgregarApellido.Text = ""; tbAdministradorAgregarClave.Text = "";
            }
            catch { tbAdministradorCrearAlumnoEstado.Text = "Hubo un error al intentar crear al alumno\nporfavor verifique los datos."; SystemSounds.Hand.Play(); }
        }

        private void btnAdministradorCrearAlumnoVolver_Click(object sender, EventArgs e)
        {
            panelAdministradorCrearAlumno.Hide();
            panelAdministrador.Show();
        }

        private void btnHorarioProfesor_Click(object sender, EventArgs e)
        {
            
            cursos = (carrera.VerCursos(loggeado));
            CursosStringProfesor.Clear();//
            foreach (Curso curso in cursos)
            {  
                CursosStringProfesor.Add(curso.nombre);
            }
            cbVerHorarioProfe.DataSource = CursosStringProfesor;
            panelProfesor.Hide();
            panelVerHorarioProfe.Show();
        }

        private void btnVolverVerHorario_Click(object sender, EventArgs e)
        {
            panelVerHorarioProfe.Hide();
            panelProfesor.Show();
        }

        private void btnVerHorarioProfe_Click(object sender, EventArgs e)
        {
            carrera = Uandes.DevolverCarrera(cbCarreras.Text);
            MessageBox.Show(carrera.RetornarCurso(cbVerHorarioProfe.Text).VerHorarioCurso(loggeado));
        }

        private void btnBorrarAlumno_Click(object sender, EventArgs e)
        {
            alumnosU.Clear();
            alumnosU = Uandes.DevolverTodosAlumnos();
            AlumnosString.Clear();
            foreach (Persona alumno in alumnosU)
            {
                AlumnosString.Add(alumno.nombre+"   "+alumno.rut.ToString());
            }
            cbBorrarAlumno.DataSource = AlumnosString;
            panelAdministrador.Hide();
            panelBorrarAlumno.Show();
        }

        private void btnVolverBorrarAlumno_Click(object sender, EventArgs e)
        {
           
            panelBorrarAlumno.Hide();
            panelAdministrador.Show();

        }

        private void btnBorrarAlumnoMetodo_Click(object sender, EventArgs e)//bpanel borrar alumno
        {
            alumnosU.Clear();
            alumnosU = Uandes.DevolverTodosAlumnos();
            AlumnosString.Clear();
            foreach (Persona alumno in alumnosU)
            {
                AlumnosString.Add(alumno.nombre + '-' + alumno.rut.ToString());
            }
            cbBorrarAlumno.DataSource = AlumnosString;
            string[] asd = cbBorrarAlumno.Text.Split('-');
            Uandes.BorrarAlumno(asd[1]);

            
        }

        
    }
}

/*


    HACER QUE EL ADMIN PUEDA AGREGAR UN CURSO SOLO CREDITOS Y NOMBRE
    Y OTRA WEA PARA LA SECCION CON TODAS SUS COSAS

    try{
    tambien try para la seccion
            Curso cursoNuevo = new Curso(tbAdministradorAgregarRamoNombre.Text, int.Parse(tbAdministradorAgregarRamoCreditos.Text))
            tbAdministradorAgregarRamoEstado.Text = tbAdministradorAgregarCursoNombre.Text + " fue Creado con exito"; 
            tbAdministradorAgregarRamoNrc.Text="";
            tbAdministradorAgregarRamoNombre.Text="";
            tbAdministradorAgregarRamoProfesorNombre.Text="";
            tbAdministradorAgregarRamoProfesorApellido.Text="";
            tbAdministradorAgregarRamoCreditos.Text="";
    }
                catch { tbAdministradorAgregarRamoEstado.Text = "Hubo un error al intentar crear al alumno\nporfavor verifique los datos."; SystemSounds.Hand.Play(); }

tbAdministradorAgregarRamoNrc
tbAdministradorAgregarRamoNombre
tbAdministradorAgregarRamoProfesorNombre
tbAdministradorAgregarRamoProfesorApellido
tbAdministradorAgregarRamoCreditos


*/
