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

            #region Agregar Datos
            try
            {
                BinaryFormatter formateador = new BinaryFormatter();
                Stream miStream = new FileStream("Universidades.un", FileMode.Open, FileAccess.Read, FileShare.None);
                Uandes = (Universidad)formateador.Deserialize(miStream);
                Uandes.MostrarCarreras();
                miStream.Close();
            }
            catch
            {
                Uandes = new Universidad("Universidad de los Andes");
                List<Alumno> alumnos = new List<Alumno>();
                List<Profesor> profesores = new List<Profesor>();
                List<Administrativo> admins = new List<Administrativo>();
                List<Persona> personas = new List<Persona>();

                Carrera Ingenieria = new Carrera("Ingenieria", "Facultad de Ingeniería y Ciencias Aplicadas");
                Carrera Comercial = new Carrera("Comercial", "Facultad de Negocios");
                Carrera Derecho = new Carrera("Derecho", "Facultad de Derecho");
                Alumno alumnoIng = new Alumno(2, "Juan", "Perez", DateTime.Today.AddYears(-7), "a");
                Alumno a1 = new Alumno(3, "Pedro", "Perez", DateTime.Today.AddYears(-2), "a");
                Alumno a2 = new Alumno(1, "Juan", "Soto", DateTime.Today.AddYears(-5), "a");
                Alumno a5 = new Alumno(5, "Federico", "Sanchez", DateTime.Today.AddYears(-3), "a");
                Alumno a4 = new Alumno(6, "Pepe", "Soto", DateTime.Today.AddYears(-8), "a");
                Alumno a3 = new Alumno(7, "Maicl", "Yacson", DateTime.Today.AddYears(-2), "a");
                Alumno a6 = new Alumno(8, "Jorge", "Piasu", DateTime.Today.AddYears(-2), "a");
                Alumno a7 = new Alumno(9, "Jose", "Hernandez", DateTime.Today.AddYears(-2), "a");
                Alumno a8 = new Alumno(10, "Fernando", "Brito", DateTime.Today.AddYears(-2), "a");
                Alumno a9 = new Alumno(11, "Felipe", "Brayatan", DateTime.Today.AddYears(-2), "a");
                Alumno a10 = new Alumno(12, "Gonzalo", "Cabezas", DateTime.Today.AddYears(-2), "a");
                Alumno a11 = new Alumno(13, "Rosario", "Cortes", DateTime.Today.AddYears(-2), "a");
                Alumno a12 = new Alumno(14, "Marcela", "Cortez", DateTime.Today.AddYears(-2), "a");
                Alumno a13 = new Alumno(15, "Ximena", "Lorca", DateTime.Today.AddYears(-2), "a");
                Alumno a14 = new Alumno(4, "Yahayra", "La Bellakeu", DateTime.Today.AddYears(-2), "a");


                Profesor tata = new Profesor(100, "Leonardo", "Sanchez", "a", DateTime.Today.AddYears(-10), "Ingenieria Civil");
                Profesor sat = new Profesor(101, "Ricardo", "Sat", "a", DateTime.Today.AddYears(-10), "Ingenieria Civil");
                Profesor Lorca = new Profesor(102, "Felipe", "Lorca", "a", DateTime.Today.AddYears(-10), "Ingenieria Civil");

                Curso calculo2 = new Curso("Calculo 2", 6);
                Curso calculo1 = new Curso("Calculo 1", 6);
                Curso edo = new Curso("Edo", 6);
                Curso lineal = new Curso("Algebra lineal", 6);
                Curso algebra = new Curso("Algebra", 6);
                Curso teologia = new Curso("Teologia", 2);
                Curso antropologia = new Curso("Antropologia", 2);
                Curso biologia = new Curso("Biologia", 2);
                Curso quimica = new Curso("Quimica", 2);
                Curso programacion = new Curso("Programacion", 2);
                Curso introduccionAlaIng = new Curso("Intro a la Ing", 2);
                Curso peg = new Curso("PEG Ciencias", 2);
                Curso peg1 = new Curso("PEG Historia", 2);
                Curso peg2 = new Curso("PEG Arte", 2);
                Curso minor = new Curso("Minor 1", 2);
                Curso minor1 = new Curso("Minor 2", 2);
                Curso minor2 = new Curso("Minor 3", 2);

                Seccion teologia1 = new Seccion(60, 2018101, Lorca);
                Seccion antropologia1 = new Seccion(60, 2018102, tata);
                Seccion biologia1 = new Seccion(60, 2018103, sat);
                Seccion quimica1 = new Seccion(60, 2018104, tata);
                Seccion programacion1 = new Seccion(60, 2018105, sat);
                Seccion introduccionAlaIng1 = new Seccion(60, 2018106, tata);
                Seccion pega1 = new Seccion(70, 2018107, sat);
                Seccion peg11 = new Seccion(60, 2018108, Lorca);
                Seccion peg21 = new Seccion(60, 2018109, Lorca);
                Seccion minora1 = new Seccion(60, 2018110, tata);
                Seccion minor11 = new Seccion(60, 2018111, Lorca);
                Seccion minor21 = new Seccion(60, 2018112, Lorca);
                Seccion calculo1Sec1 = new Seccion(60, 2018113, tata);
                Seccion AlgebraSec1 = new Seccion(42, 2018114, sat);
                Seccion LinealSec1 = new Seccion(50, 2018115, Lorca);
                Seccion edoSec1 = new Seccion(50, 2018116, Lorca);
                Seccion calculo2Sec1 = new Seccion(50, 2018117, Lorca);

                calculo2.requisitos.Add(calculo1);
                calculo2.requisitos.Add(algebra);
                edo.requisitos.Add(lineal);
                edo.requisitos.Add(calculo1);
                lineal.requisitos.Add(algebra);

                Horario horarioCal = new Horario("clase", DateTime.Today.AddHours(102), 2);
                Horario horarioCal1 = new Horario("clase", DateTime.Today.AddHours(1), 2);
                Horario horarioAlg = new Horario("clase", DateTime.Today.AddHours(32), 2);
                Horario horarioLin = new Horario("clase", DateTime.Today.AddHours(5), 2);
                Horario horarioLin2 = new Horario("clase", DateTime.Today.AddHours(65), 2);
                Horario horarioLin3 = new Horario("clase", DateTime.Today.AddHours(13), 2);
                Horario i = new Horario("clase", DateTime.Today.AddHours(113), 2);
                Horario j = new Horario("clase", DateTime.Today.AddHours(132), 2);
                Horario h = new Horario("clase", DateTime.Today.AddHours(4324), 2);
                Horario g = new Horario("clase", DateTime.Today.AddHours(53), 2);
                Horario f = new Horario("clase", DateTime.Today.AddHours(1423), 2);
                Horario e = new Horario("clase", DateTime.Today.AddHours(113), 2);
                Horario d = new Horario("clase", DateTime.Today.AddHours(313), 2);
                Horario c = new Horario("clase", DateTime.Today.AddHours(233), 2);
                Horario b = new Horario("clase", DateTime.Today.AddHours(131), 2);
                Horario a = new Horario("clase", DateTime.Today.AddHours(173), 2);
                Horario k = new Horario("clase", DateTime.Today.AddHours(773), 2);
                Horario l = new Horario("clase", DateTime.Today.AddHours(163), 2);


                calculo1Sec1.horario.Add(horarioCal);
                AlgebraSec1.horario.Add(horarioCal);
                AlgebraSec1.horario.Add(horarioCal1);
                LinealSec1.horario.Add(horarioLin);
                LinealSec1.horario.Add(horarioLin2);
                LinealSec1.horario.Add(horarioLin3);
                edoSec1.horario.Add(horarioLin2);
                calculo2Sec1.horario.Add(horarioCal);
                minor11.horario.Add(a);
                minora1.horario.Add(b);
                minor21.horario.Add(c);
                pega1.horario.Add(d);
                peg11.horario.Add(e);
                peg21.horario.Add(f);
                introduccionAlaIng1.horario.Add(g);
                programacion1.horario.Add(h);
                quimica1.horario.Add(i);
                biologia1.horario.Add(j);
                antropologia1.horario.Add(k);
                teologia1.horario.Add(l);


                minor1.secciones.Add(minora1);
                minor2.secciones.Add(minor21);
                minor.secciones.Add(minor11);
                peg2.secciones.Add(pega1);
                peg1.secciones.Add(peg21);
                peg.secciones.Add(peg11);
                introduccionAlaIng.secciones.Add(introduccionAlaIng1);
                programacion.secciones.Add(programacion1);
                quimica.secciones.Add(quimica1);
                biologia.secciones.Add(biologia1);
                calculo1.secciones.Add(calculo1Sec1);
                algebra.secciones.Add(AlgebraSec1);
                lineal.secciones.Add(LinealSec1);
                edo.secciones.Add(edoSec1);
                calculo2.secciones.Add(calculo2Sec1);
                teologia.secciones.Add(teologia1);
                antropologia.secciones.Add(antropologia1);


                calculo1Sec1.alumnos.Add(alumnoIng);
                calculo1Sec1.alumnos.Add(a1);
                AlgebraSec1.alumnos.Add(a2);
                LinealSec1.alumnos.Add(a3);
                edoSec1.alumnos.Add(a4);
                programacion1.alumnos.Add(a5);
                programacion1.alumnos.Add(alumnoIng);
                programacion1.alumnos.Add(a1);
                programacion1.alumnos.Add(a2);
                programacion1.alumnos.Add(a3);
                programacion1.alumnos.Add(a4);
                quimica1.alumnos.Add(a5);
                quimica1.alumnos.Add(alumnoIng);
                quimica1.alumnos.Add(a1);
                quimica1.alumnos.Add(a2);
                quimica1.alumnos.Add(a3);
                quimica1.alumnos.Add(a4);
                calculo2Sec1.alumnos.Add(a5);
                calculo1Sec1.alumnos.Add(a6);
                calculo1Sec1.alumnos.Add(a7);
                AlgebraSec1.alumnos.Add(a8);
                LinealSec1.alumnos.Add(a9);
                edoSec1.alumnos.Add(a10);
                programacion1.alumnos.Add(a11);
                programacion1.alumnos.Add(a12);
                programacion1.alumnos.Add(a13);
                programacion1.alumnos.Add(a14);
                programacion1.alumnos.Add(a6);
                programacion1.alumnos.Add(a7);
                quimica1.alumnos.Add(a8);
                quimica1.alumnos.Add(a9);
                quimica1.alumnos.Add(a10);
                quimica1.alumnos.Add(a11);
                quimica1.alumnos.Add(a12);
                quimica1.alumnos.Add(a14);
                calculo2Sec1.alumnos.Add(a2);
                teologia1.alumnos.Add(a4);
                antropologia1.alumnos.Add(a11);
                peg21.alumnos.Add(a14);
                peg11.alumnos.Add(a12);
                pega1.alumnos.Add(a10);
                minora1.alumnos.Add(a1);
                minor21.alumnos.Add(a2);
                minor11.alumnos.Add(a4);
                introduccionAlaIng1.alumnos.Add(a3);
                biologia1.alumnos.Add(a5);
                calculo2Sec1.alumnos.Add(a6);
                teologia1.alumnos.Add(a8);
                antropologia1.alumnos.Add(a7);
                peg21.alumnos.Add(a9);
                peg11.alumnos.Add(a10);
                pega1.alumnos.Add(a1);
                minora1.alumnos.Add(a2);
                minor21.alumnos.Add(a3);
                minor11.alumnos.Add(a5);
                introduccionAlaIng1.alumnos.Add(a6);
                biologia1.alumnos.Add(a7);



                a4.aprobados.Add(algebra);
                a4.aprobados.Add(lineal);
                a4.aprobados.Add(calculo1);
                a3.aprobados.Add(algebra);
                a5.aprobados.Add(calculo1);
                a5.aprobados.Add(algebra);

                Ingenieria.cursos.Add(calculo2);
                Ingenieria.cursos.Add(calculo1);
                Ingenieria.cursos.Add(edo);
                Ingenieria.cursos.Add(lineal);
                Ingenieria.cursos.Add(programacion);
                Ingenieria.cursos.Add(quimica);
                Ingenieria.cursos.Add(biologia);
                Ingenieria.cursos.Add(peg);
                Ingenieria.cursos.Add(peg1);
                Ingenieria.cursos.Add(peg2);
                Ingenieria.cursos.Add(minor);
                Ingenieria.cursos.Add(minor1);
                Ingenieria.cursos.Add(minor2);
                Ingenieria.cursos.Add(introduccionAlaIng);
                Ingenieria.cursos.Add(teologia);
                Ingenieria.cursos.Add(antropologia);

                Administrativo admin1 = new Administrativo(0, "admin", "admin", "admin", "admin");
                Uandes.carreras.Add(Ingenieria);
                Uandes.carreras.Add(Comercial);
                Uandes.carreras.Add(Derecho);
                Ingenieria.admins.Add(admin1);
                Comercial.admins.Add(admin1);
                Derecho.admins.Add(admin1);
                BinaryFormatter formateador = new BinaryFormatter();
                Stream miStream = new FileStream("Universidades.un", FileMode.Create, FileAccess.Write);
                formateador.Serialize(miStream, Uandes);
                miStream.Close();
            }
            #endregion

            #region Ordenar los paneles y form
            this.Location = new Point(0, 0);
            panelAdministrador.Location = new Point(0, 0);
            panelAdministradorCrearAlumno.Location = new Point(0, 0);
            panelAlumno.Location = new Point(0, 0);
            panelBorrarAlumno.Location = new Point(0, 0);
            panelBotarRamo.Location = new Point(0, 0);
            panelCursosProfesor.Location = new Point(0, 0);
            PanelInicio.Location = new Point(0, 0);
            panelTomaRamoAlumno.Location = new Point(0, 0);
            panelProfesor.Location = new Point(0, 0);
            panelVerHorarioProfe.Location = new Point(0, 0);
            panelAdministradorAgregarCurso.Location = new Point(0, 0);
            panelAdministradorAgregarSeccion.Location = new Point(0, 0);
            panelAdministradorEliminarCurso.Location = new Point(0, 0);
            panelAdministradorEliminarSeccion.Location = new Point(0, 0);
            this.Text = Uandes.nombre;
            #endregion

            this.cbCarreras.DataSource = Uandes.MostrarCarreras();
            cbAdministradorAlumnoNuevoCarreras.DataSource = Uandes.MostrarCarreras();
            carrera = Uandes.DevolverCarrera(cbCarreras.Text);
            

        }

        private void botonCarrera_Click(object sender, EventArgs e)
        {
            carrera = Uandes.DevolverCarrera(cbCarreras.Text);

            try
            {
                loggeado = Uandes.VerPersona(carrera, tbRut.Text);
                if (carrera.VerificarAlumno(int.Parse(tbRut.Text), tbClave.Text))
                {
                    tbClave.Text = "";
                    tbRut.Text = "";
                    lbBienvenidoAlumno.Text = "Bienvenido \n" + loggeado.nombre + " " + loggeado.apellido;
                    PanelInicio.Hide();
                    panelAlumno.Show();
                }

                else if (carrera.VerificarProfe(int.Parse(tbRut.Text), tbClave.Text))
                {
                    lbBienvenidoProfesor.Text = "Bienvenido \n" + loggeado.nombre + " " + loggeado.apellido;
                    tbClave.Text = "";
                    tbRut.Text = "";
                    PanelInicio.Hide();
                    panelProfesor.Show();
                }
                else if (carrera.VerificarAdmin(int.Parse(tbRut.Text), tbClave.Text))
                {
                    lbBienvenidoAdministrador.Text = "Bienvenido \n" + loggeado.nombre + " " + loggeado.apellido;
                    tbClave.Text = "";
                    tbRut.Text = "";
                    PanelInicio.Hide();
                    tbAdministradorCrearAlumnoEstado.Text = "";
                    panelAdministrador.Show();
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

        #region Botones Volver, Salir, Cerrar Sesion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void botonCerrarSeccionAlumno_Click(object sender, EventArgs e)
        {
            panelAlumno.Hide();
            PanelInicio.Show();
        }
        private void btnTomarRamosAlumnoSalir_Click(object sender, EventArgs e)
        {
            panelTomaRamoAlumno.Hide();
            panelAlumno.Show();
        }
        private void btnSalirProfesor_Click(object sender, EventArgs e)
        {
            panelProfesor.Hide();
            PanelInicio.Show();
        }
        private void btnVolverVerHorario_Click(object sender, EventArgs e)
        {
            panelVerHorarioProfe.Hide();
            panelProfesor.Show();
        }
        private void btnSalirBotarRamo_Click(object sender, EventArgs e)
        {
            panelBotarRamo.Hide();
            panelAlumno.Show();
        }
        private void btnVolverCursosProfesor_Click(object sender, EventArgs e)
        {
            panelCursosProfesor.Hide();
            panelProfesor.Show();
        }
        private void btnAdministradorCerrar_Click(object sender, EventArgs e)
        {
            panelAdministrador.Hide();
            PanelInicio.Show();
        }
        private void btnAdministradorEliminarCursoVolver_Click(object sender, EventArgs e)
        {
            panelAdministradorEliminarCurso.Hide();
            panelAdministrador.Show();
        }

        private void btnAdministradorEliminarSeccionVolver_Click(object sender, EventArgs e)
        {
            panelAdministradorEliminarSeccion.Hide();
            panelAdministrador.Show();
        }

        private void btnAdministradorAgregarCursoVolver_Click(object sender, EventArgs e)
        {
            panelAdministradorAgregarCurso.Hide();
            panelAdministrador.Show();
        }

        private void btnAdministradorAgregarSeccionVolver_Click(object sender, EventArgs e)
        {
            panelAdministradorAgregarSeccion.Hide();
            panelAdministrador.Show();
        }
        private void btnAdministradorCrearAlumnoVolver_Click(object sender, EventArgs e)
        {
            panelAdministradorCrearAlumno.Hide();
            panelAdministrador.Show();
        }
        private void btnVolverBorrarAlumno_Click(object sender, EventArgs e)
        {

            panelBorrarAlumno.Hide();
            panelAdministrador.Show();

        }
        #endregion

        private void FInicio_Load(object sender, EventArgs e)
        {
            PanelInicio.Show();
            lbAvisoTomaRamo.Text = "";
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

        

        private void btnVerAlumnos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(carrera.RetornarCurso(cbCursosProfesor.Text).MostarALumnosCurso(loggeado));

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

        

        private void btnVerHorarioProfe_Click(object sender, EventArgs e)
        {
            carrera = Uandes.DevolverCarrera(cbCarreras.Text);
            MessageBox.Show(carrera.RetornarCurso(cbVerHorarioProfe.Text).VerHorarioCurso(loggeado));
        }

        private void btnBorrarAlumno_Click(object sender, EventArgs e)
        {
            alumnosU = Uandes.DevolverTodosAlumnos();
            AlumnosString.Clear();
            foreach (Persona alumno in alumnosU)
            {
                AlumnosString.Add(alumno.nombre + '-' + alumno.rut.ToString());
            }
            cbBorrarAlumno.DataSource = AlumnosString;
            panelAdministrador.Hide();
            panelBorrarAlumno.Show();
        }

        

        private void btnBorrarAlumnoMetodo_Click(object sender, EventArgs e)
        {
            string[] asd = cbBorrarAlumno.Text.Split('-');
            MessageBox.Show(asd[1]);
            Uandes.BorrarAlumno(asd[1]);
            AlumnosString.Remove(cbBorrarAlumno.Text);
            cbBotarRamo.Refresh();
        }

       

        private void btnAdministradorAgregarCurso_Click(object sender, EventArgs e)
        {
            panelAdministradorAgregarCurso.Show();
            panelAdministrador.Hide();
        }

        private void btnAdministradorEliminarCurso_Click(object sender, EventArgs e)
        {
            panelAdministradorEliminarCurso.Show();
            panelAdministrador.Hide();
        }

        private void btnAdministradorAgregarSeccion_Click(object sender, EventArgs e)
        {
            panelAdministradorAgregarSeccion.Show();
            panelAdministrador.Hide();
        }

        private void btnAdministradorEliminarSeccion_Click(object sender, EventArgs e)
        {
            panelAdministradorEliminarSeccion.Show();
            panelAdministrador.Hide();
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
