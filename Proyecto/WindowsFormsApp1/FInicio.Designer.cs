namespace WindowsFormsApp1
{
    partial class FInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbCarreras = new System.Windows.Forms.ComboBox();
            this.botonCarrera = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRut = new System.Windows.Forms.TextBox();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelInicio = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelAlumno = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.botonBotarRamoAlumno = new System.Windows.Forms.Button();
            this.botonVerRamosAlumno = new System.Windows.Forms.Button();
            this.botonAgeregarRamoAlumno = new System.Windows.Forms.Button();
            this.botonCerrarSeccionAlumno = new System.Windows.Forms.Button();
            this.lbBienvenidoAlumno = new System.Windows.Forms.Label();
            this.panelTomaRamoAlumno = new System.Windows.Forms.Panel();
            this.lbAvisoTomaRamo = new System.Windows.Forms.Label();
            this.lbSeccionTomaRamos = new System.Windows.Forms.Label();
            this.cbSeccionTomarRamoAlumno = new System.Windows.Forms.ComboBox();
            this.btnAceptarTomarRamoAlumno = new System.Windows.Forms.Button();
            this.btnTomarRamosAlumnoSalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAgregarRamoAlumno = new System.Windows.Forms.ComboBox();
            this.panelBotarRamo = new System.Windows.Forms.Panel();
            this.cbBotarRamo = new System.Windows.Forms.ComboBox();
            this.lbAvisoBotarRamo = new System.Windows.Forms.Label();
            this.btnSalirBotarRamo = new System.Windows.Forms.Button();
            this.btnBotarRamo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panelProfesor = new System.Windows.Forms.Panel();
            this.btnSalirProfesor = new System.Windows.Forms.Button();
            this.btnHorarioProfesor = new System.Windows.Forms.Button();
            this.lbBienvenidoProfesor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCursosProfesor = new System.Windows.Forms.Button();
            this.panelCursosProfesor = new System.Windows.Forms.Panel();
            this.cbCursosProfesor = new System.Windows.Forms.ComboBox();
            this.btnVolverCursosProfesor = new System.Windows.Forms.Button();
            this.btnVerAlumnos = new System.Windows.Forms.Button();
            this.PanelInicio.SuspendLayout();
            this.panelAlumno.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelTomaRamoAlumno.SuspendLayout();
            this.panelBotarRamo.SuspendLayout();
            this.panelProfesor.SuspendLayout();
            this.panelCursosProfesor.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCarreras
            // 
            this.cbCarreras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarreras.FormattingEnabled = true;
            this.cbCarreras.Location = new System.Drawing.Point(32, 81);
            this.cbCarreras.Name = "cbCarreras";
            this.cbCarreras.Size = new System.Drawing.Size(381, 32);
            this.cbCarreras.TabIndex = 0;
            this.cbCarreras.SelectedIndexChanged += new System.EventHandler(this.cbCarreras_SelectedIndexChanged);
            // 
            // botonCarrera
            // 
            this.botonCarrera.Location = new System.Drawing.Point(238, 345);
            this.botonCarrera.Name = "botonCarrera";
            this.botonCarrera.Size = new System.Drawing.Size(175, 65);
            this.botonCarrera.TabIndex = 1;
            this.botonCarrera.Text = "Ingresar";
            this.botonCarrera.UseVisualStyleBackColor = true;
            this.botonCarrera.Click += new System.EventHandler(this.botonCarrera_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese su rut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese su clave";
            // 
            // tbRut
            // 
            this.tbRut.Location = new System.Drawing.Point(32, 190);
            this.tbRut.Name = "tbRut";
            this.tbRut.Size = new System.Drawing.Size(381, 29);
            this.tbRut.TabIndex = 4;
            this.tbRut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbRut_KeyDown);
            // 
            // tbClave
            // 
            this.tbClave.Location = new System.Drawing.Point(32, 290);
            this.tbClave.Name = "tbClave";
            this.tbClave.Size = new System.Drawing.Size(381, 29);
            this.tbClave.TabIndex = 5;
            this.tbClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbClave_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seleccione su Carrera";
            // 
            // PanelInicio
            // 
            this.PanelInicio.Controls.Add(this.btnSalir);
            this.PanelInicio.Controls.Add(this.label3);
            this.PanelInicio.Controls.Add(this.cbCarreras);
            this.PanelInicio.Controls.Add(this.tbClave);
            this.PanelInicio.Controls.Add(this.botonCarrera);
            this.PanelInicio.Controls.Add(this.tbRut);
            this.PanelInicio.Controls.Add(this.label1);
            this.PanelInicio.Controls.Add(this.label2);
            this.PanelInicio.Location = new System.Drawing.Point(176, 55);
            this.PanelInicio.Name = "PanelInicio";
            this.PanelInicio.Size = new System.Drawing.Size(445, 431);
            this.PanelInicio.TabIndex = 7;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(32, 345);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(175, 65);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelAlumno
            // 
            this.panelAlumno.Controls.Add(this.panelBotarRamo);
            this.panelAlumno.Controls.Add(this.tableLayoutPanel1);
            this.panelAlumno.Controls.Add(this.lbBienvenidoAlumno);
            this.panelAlumno.Location = new System.Drawing.Point(1530, 292);
            this.panelAlumno.Name = "panelAlumno";
            this.panelAlumno.Size = new System.Drawing.Size(715, 467);
            this.panelAlumno.TabIndex = 8;
            this.panelAlumno.Visible = false;
            this.panelAlumno.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAlumno_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.botonBotarRamoAlumno, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.botonVerRamosAlumno, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.botonAgeregarRamoAlumno, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.botonCerrarSeccionAlumno, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(114, 139);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(479, 247);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // botonBotarRamoAlumno
            // 
            this.botonBotarRamoAlumno.Location = new System.Drawing.Point(242, 3);
            this.botonBotarRamoAlumno.Name = "botonBotarRamoAlumno";
            this.botonBotarRamoAlumno.Size = new System.Drawing.Size(234, 117);
            this.botonBotarRamoAlumno.TabIndex = 1;
            this.botonBotarRamoAlumno.Text = "Botar Ramo";
            this.botonBotarRamoAlumno.UseVisualStyleBackColor = true;
            this.botonBotarRamoAlumno.Click += new System.EventHandler(this.botonBotarRamoAlumno_Click);
            // 
            // botonVerRamosAlumno
            // 
            this.botonVerRamosAlumno.Location = new System.Drawing.Point(3, 126);
            this.botonVerRamosAlumno.Name = "botonVerRamosAlumno";
            this.botonVerRamosAlumno.Size = new System.Drawing.Size(233, 118);
            this.botonVerRamosAlumno.TabIndex = 2;
            this.botonVerRamosAlumno.Text = "Ver Ramos";
            this.botonVerRamosAlumno.UseVisualStyleBackColor = true;
            this.botonVerRamosAlumno.Click += new System.EventHandler(this.botonVerRamosAlumno_Click);
            // 
            // botonAgeregarRamoAlumno
            // 
            this.botonAgeregarRamoAlumno.Location = new System.Drawing.Point(3, 3);
            this.botonAgeregarRamoAlumno.Name = "botonAgeregarRamoAlumno";
            this.botonAgeregarRamoAlumno.Size = new System.Drawing.Size(233, 117);
            this.botonAgeregarRamoAlumno.TabIndex = 0;
            this.botonAgeregarRamoAlumno.Text = "Agregar Ramo";
            this.botonAgeregarRamoAlumno.UseVisualStyleBackColor = true;
            this.botonAgeregarRamoAlumno.Click += new System.EventHandler(this.botonAgeregarRamoAlumno_Click);
            // 
            // botonCerrarSeccionAlumno
            // 
            this.botonCerrarSeccionAlumno.Location = new System.Drawing.Point(242, 126);
            this.botonCerrarSeccionAlumno.Name = "botonCerrarSeccionAlumno";
            this.botonCerrarSeccionAlumno.Size = new System.Drawing.Size(234, 118);
            this.botonCerrarSeccionAlumno.TabIndex = 3;
            this.botonCerrarSeccionAlumno.Text = "Cerrar Sesión";
            this.botonCerrarSeccionAlumno.UseVisualStyleBackColor = true;
            this.botonCerrarSeccionAlumno.Click += new System.EventHandler(this.botonCerrarSeccionAlumno_Click);
            // 
            // lbBienvenidoAlumno
            // 
            this.lbBienvenidoAlumno.AutoSize = true;
            this.lbBienvenidoAlumno.Location = new System.Drawing.Point(224, 75);
            this.lbBienvenidoAlumno.Name = "lbBienvenidoAlumno";
            this.lbBienvenidoAlumno.Size = new System.Drawing.Size(109, 25);
            this.lbBienvenidoAlumno.TabIndex = 4;
            this.lbBienvenidoAlumno.Text = "Bienvenido";
            // 
            // panelTomaRamoAlumno
            // 
            this.panelTomaRamoAlumno.Controls.Add(this.lbAvisoTomaRamo);
            this.panelTomaRamoAlumno.Controls.Add(this.lbSeccionTomaRamos);
            this.panelTomaRamoAlumno.Controls.Add(this.cbSeccionTomarRamoAlumno);
            this.panelTomaRamoAlumno.Controls.Add(this.btnAceptarTomarRamoAlumno);
            this.panelTomaRamoAlumno.Controls.Add(this.btnTomarRamosAlumnoSalir);
            this.panelTomaRamoAlumno.Controls.Add(this.label4);
            this.panelTomaRamoAlumno.Controls.Add(this.cbAgregarRamoAlumno);
            this.panelTomaRamoAlumno.Location = new System.Drawing.Point(1756, 12);
            this.panelTomaRamoAlumno.Name = "panelTomaRamoAlumno";
            this.panelTomaRamoAlumno.Size = new System.Drawing.Size(712, 520);
            this.panelTomaRamoAlumno.TabIndex = 9;
            this.panelTomaRamoAlumno.Visible = false;
            // 
            // lbAvisoTomaRamo
            // 
            this.lbAvisoTomaRamo.AutoSize = true;
            this.lbAvisoTomaRamo.Location = new System.Drawing.Point(147, 446);
            this.lbAvisoTomaRamo.Name = "lbAvisoTomaRamo";
            this.lbAvisoTomaRamo.Size = new System.Drawing.Size(64, 25);
            this.lbAvisoTomaRamo.TabIndex = 6;
            this.lbAvisoTomaRamo.Text = "label5";
            // 
            // lbSeccionTomaRamos
            // 
            this.lbSeccionTomaRamos.AutoSize = true;
            this.lbSeccionTomaRamos.Location = new System.Drawing.Point(158, 180);
            this.lbSeccionTomaRamos.Name = "lbSeccionTomaRamos";
            this.lbSeccionTomaRamos.Size = new System.Drawing.Size(270, 25);
            this.lbSeccionTomaRamos.TabIndex = 5;
            this.lbSeccionTomaRamos.Text = "Seleccione una seccion (nrc).";
            // 
            // cbSeccionTomarRamoAlumno
            // 
            this.cbSeccionTomarRamoAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeccionTomarRamoAlumno.FormattingEnabled = true;
            this.cbSeccionTomarRamoAlumno.Location = new System.Drawing.Point(163, 242);
            this.cbSeccionTomarRamoAlumno.Name = "cbSeccionTomarRamoAlumno";
            this.cbSeccionTomarRamoAlumno.Size = new System.Drawing.Size(385, 32);
            this.cbSeccionTomarRamoAlumno.TabIndex = 4;
            // 
            // btnAceptarTomarRamoAlumno
            // 
            this.btnAceptarTomarRamoAlumno.Location = new System.Drawing.Point(152, 321);
            this.btnAceptarTomarRamoAlumno.Name = "btnAceptarTomarRamoAlumno";
            this.btnAceptarTomarRamoAlumno.Size = new System.Drawing.Size(177, 65);
            this.btnAceptarTomarRamoAlumno.TabIndex = 3;
            this.btnAceptarTomarRamoAlumno.Text = "Tomar Ramo";
            this.btnAceptarTomarRamoAlumno.UseVisualStyleBackColor = true;
            this.btnAceptarTomarRamoAlumno.Click += new System.EventHandler(this.btnAceptarTomarRamoAlumno_Click);
            // 
            // btnTomarRamosAlumnoSalir
            // 
            this.btnTomarRamosAlumnoSalir.Location = new System.Drawing.Point(408, 320);
            this.btnTomarRamosAlumnoSalir.Name = "btnTomarRamosAlumnoSalir";
            this.btnTomarRamosAlumnoSalir.Size = new System.Drawing.Size(177, 65);
            this.btnTomarRamosAlumnoSalir.TabIndex = 2;
            this.btnTomarRamosAlumnoSalir.Text = "Salir";
            this.btnTomarRamosAlumnoSalir.UseVisualStyleBackColor = true;
            this.btnTomarRamosAlumnoSalir.Click += new System.EventHandler(this.btnTomarRamosAlumnoSalir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(438, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "A  continuación, escoja el ramo que desea tomar.";
            // 
            // cbAgregarRamoAlumno
            // 
            this.cbAgregarRamoAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAgregarRamoAlumno.FormattingEnabled = true;
            this.cbAgregarRamoAlumno.Location = new System.Drawing.Point(163, 114);
            this.cbAgregarRamoAlumno.Name = "cbAgregarRamoAlumno";
            this.cbAgregarRamoAlumno.Size = new System.Drawing.Size(385, 32);
            this.cbAgregarRamoAlumno.TabIndex = 0;
            this.cbAgregarRamoAlumno.SelectedIndexChanged += new System.EventHandler(this.cbAgregarRamoAlumno_SelectedIndexChanged);
            // 
            // panelBotarRamo
            // 
            this.panelBotarRamo.Controls.Add(this.cbBotarRamo);
            this.panelBotarRamo.Controls.Add(this.lbAvisoBotarRamo);
            this.panelBotarRamo.Controls.Add(this.btnSalirBotarRamo);
            this.panelBotarRamo.Controls.Add(this.btnBotarRamo);
            this.panelBotarRamo.Controls.Add(this.label5);
            this.panelBotarRamo.Location = new System.Drawing.Point(155, 117);
            this.panelBotarRamo.Name = "panelBotarRamo";
            this.panelBotarRamo.Size = new System.Drawing.Size(706, 520);
            this.panelBotarRamo.TabIndex = 7;
            this.panelBotarRamo.Visible = false;
            // 
            // cbBotarRamo
            // 
            this.cbBotarRamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBotarRamo.FormattingEnabled = true;
            this.cbBotarRamo.Location = new System.Drawing.Point(176, 114);
            this.cbBotarRamo.Name = "cbBotarRamo";
            this.cbBotarRamo.Size = new System.Drawing.Size(388, 32);
            this.cbBotarRamo.TabIndex = 4;
            // 
            // lbAvisoBotarRamo
            // 
            this.lbAvisoBotarRamo.AutoSize = true;
            this.lbAvisoBotarRamo.Location = new System.Drawing.Point(171, 445);
            this.lbAvisoBotarRamo.Name = "lbAvisoBotarRamo";
            this.lbAvisoBotarRamo.Size = new System.Drawing.Size(64, 25);
            this.lbAvisoBotarRamo.TabIndex = 3;
            this.lbAvisoBotarRamo.Text = "label6";
            // 
            // btnSalirBotarRamo
            // 
            this.btnSalirBotarRamo.Location = new System.Drawing.Point(434, 323);
            this.btnSalirBotarRamo.Name = "btnSalirBotarRamo";
            this.btnSalirBotarRamo.Size = new System.Drawing.Size(177, 64);
            this.btnSalirBotarRamo.TabIndex = 2;
            this.btnSalirBotarRamo.Text = "Salir";
            this.btnSalirBotarRamo.UseVisualStyleBackColor = true;
            this.btnSalirBotarRamo.Click += new System.EventHandler(this.btnSalirBotarRamo_Click);
            // 
            // btnBotarRamo
            // 
            this.btnBotarRamo.Location = new System.Drawing.Point(103, 321);
            this.btnBotarRamo.Name = "btnBotarRamo";
            this.btnBotarRamo.Size = new System.Drawing.Size(177, 66);
            this.btnBotarRamo.TabIndex = 1;
            this.btnBotarRamo.Text = "Botar Ramo";
            this.btnBotarRamo.UseVisualStyleBackColor = true;
            this.btnBotarRamo.Click += new System.EventHandler(this.btnBotarRamo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(428, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "A continuación, escoja el ramo que desea botar.";
            // 
            // panelProfesor
            // 
            this.panelProfesor.Controls.Add(this.btnCursosProfesor);
            this.panelProfesor.Controls.Add(this.label7);
            this.panelProfesor.Controls.Add(this.lbBienvenidoProfesor);
            this.panelProfesor.Controls.Add(this.btnHorarioProfesor);
            this.panelProfesor.Controls.Add(this.btnSalirProfesor);
            this.panelProfesor.Location = new System.Drawing.Point(790, 81);
            this.panelProfesor.Name = "panelProfesor";
            this.panelProfesor.Size = new System.Drawing.Size(709, 517);
            this.panelProfesor.TabIndex = 10;
            this.panelProfesor.Visible = false;
            // 
            // btnSalirProfesor
            // 
            this.btnSalirProfesor.Location = new System.Drawing.Point(489, 371);
            this.btnSalirProfesor.Name = "btnSalirProfesor";
            this.btnSalirProfesor.Size = new System.Drawing.Size(190, 99);
            this.btnSalirProfesor.TabIndex = 0;
            this.btnSalirProfesor.Text = "Cerrar Sesión";
            this.btnSalirProfesor.UseVisualStyleBackColor = true;
            this.btnSalirProfesor.Click += new System.EventHandler(this.btnSalirProfesor_Click);
            // 
            // btnHorarioProfesor
            // 
            this.btnHorarioProfesor.Location = new System.Drawing.Point(267, 371);
            this.btnHorarioProfesor.Name = "btnHorarioProfesor";
            this.btnHorarioProfesor.Size = new System.Drawing.Size(190, 95);
            this.btnHorarioProfesor.TabIndex = 1;
            this.btnHorarioProfesor.Text = "Ver Horario";
            this.btnHorarioProfesor.UseVisualStyleBackColor = true;
            // 
            // lbBienvenidoProfesor
            // 
            this.lbBienvenidoProfesor.AutoSize = true;
            this.lbBienvenidoProfesor.Location = new System.Drawing.Point(406, 109);
            this.lbBienvenidoProfesor.Name = "lbBienvenidoProfesor";
            this.lbBienvenidoProfesor.Size = new System.Drawing.Size(64, 25);
            this.lbBienvenidoProfesor.TabIndex = 2;
            this.lbBienvenidoProfesor.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "LOGO DE LA U";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCursosProfesor
            // 
            this.btnCursosProfesor.Location = new System.Drawing.Point(50, 373);
            this.btnCursosProfesor.Name = "btnCursosProfesor";
            this.btnCursosProfesor.Size = new System.Drawing.Size(190, 95);
            this.btnCursosProfesor.TabIndex = 4;
            this.btnCursosProfesor.Text = "Ver Cursos";
            this.btnCursosProfesor.UseVisualStyleBackColor = true;
            this.btnCursosProfesor.Click += new System.EventHandler(this.btnCursosProfesor_Click);
            // 
            // panelCursosProfesor
            // 
            this.panelCursosProfesor.Controls.Add(this.btnVerAlumnos);
            this.panelCursosProfesor.Controls.Add(this.btnVolverCursosProfesor);
            this.panelCursosProfesor.Controls.Add(this.cbCursosProfesor);
            this.panelCursosProfesor.Location = new System.Drawing.Point(109, 362);
            this.panelCursosProfesor.Name = "panelCursosProfesor";
            this.panelCursosProfesor.Size = new System.Drawing.Size(706, 517);
            this.panelCursosProfesor.TabIndex = 5;
            this.panelCursosProfesor.Visible = false;
            // 
            // cbCursosProfesor
            // 
            this.cbCursosProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCursosProfesor.FormattingEnabled = true;
            this.cbCursosProfesor.Location = new System.Drawing.Point(100, 74);
            this.cbCursosProfesor.Name = "cbCursosProfesor";
            this.cbCursosProfesor.Size = new System.Drawing.Size(515, 32);
            this.cbCursosProfesor.TabIndex = 0;
            // 
            // btnVolverCursosProfesor
            // 
            this.btnVolverCursosProfesor.Location = new System.Drawing.Point(375, 223);
            this.btnVolverCursosProfesor.Name = "btnVolverCursosProfesor";
            this.btnVolverCursosProfesor.Size = new System.Drawing.Size(240, 223);
            this.btnVolverCursosProfesor.TabIndex = 1;
            this.btnVolverCursosProfesor.Text = "Volver";
            this.btnVolverCursosProfesor.UseVisualStyleBackColor = true;
            this.btnVolverCursosProfesor.Click += new System.EventHandler(this.btnVolverCursosProfesor_Click);
            // 
            // btnVerAlumnos
            // 
            this.btnVerAlumnos.Location = new System.Drawing.Point(100, 223);
            this.btnVerAlumnos.Name = "btnVerAlumnos";
            this.btnVerAlumnos.Size = new System.Drawing.Size(240, 223);
            this.btnVerAlumnos.TabIndex = 2;
            this.btnVerAlumnos.Text = "Ver Alumnos";
            this.btnVerAlumnos.UseVisualStyleBackColor = true;
            this.btnVerAlumnos.Click += new System.EventHandler(this.btnVerAlumnos_Click);
            // 
            // FInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2377, 853);
            this.Controls.Add(this.panelCursosProfesor);
            this.Controls.Add(this.panelProfesor);
            this.Controls.Add(this.panelTomaRamoAlumno);
            this.Controls.Add(this.panelAlumno);
            this.Controls.Add(this.PanelInicio);
            this.Name = "FInicio";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FInicio_FormClosing);
            this.Load += new System.EventHandler(this.FInicio_Load);
            this.PanelInicio.ResumeLayout(false);
            this.PanelInicio.PerformLayout();
            this.panelAlumno.ResumeLayout(false);
            this.panelAlumno.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelTomaRamoAlumno.ResumeLayout(false);
            this.panelTomaRamoAlumno.PerformLayout();
            this.panelBotarRamo.ResumeLayout(false);
            this.panelBotarRamo.PerformLayout();
            this.panelProfesor.ResumeLayout(false);
            this.panelProfesor.PerformLayout();
            this.panelCursosProfesor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCarreras;
        private System.Windows.Forms.Button botonCarrera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRut;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelInicio;
        private System.Windows.Forms.Panel panelAlumno;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button botonAgeregarRamoAlumno;
        private System.Windows.Forms.Button botonBotarRamoAlumno;
        private System.Windows.Forms.Button botonVerRamosAlumno;
        private System.Windows.Forms.Button botonCerrarSeccionAlumno;
        private System.Windows.Forms.Label lbBienvenidoAlumno;
        private System.Windows.Forms.Panel panelTomaRamoAlumno;
        private System.Windows.Forms.ComboBox cbAgregarRamoAlumno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAceptarTomarRamoAlumno;
        private System.Windows.Forms.Button btnTomarRamosAlumnoSalir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lbSeccionTomaRamos;
        private System.Windows.Forms.ComboBox cbSeccionTomarRamoAlumno;
        private System.Windows.Forms.Label lbAvisoTomaRamo;
        private System.Windows.Forms.Panel panelBotarRamo;
        private System.Windows.Forms.Button btnBotarRamo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbAvisoBotarRamo;
        private System.Windows.Forms.Button btnSalirBotarRamo;
        private System.Windows.Forms.ComboBox cbBotarRamo;
        private System.Windows.Forms.Panel panelProfesor;
        private System.Windows.Forms.Label lbBienvenidoProfesor;
        private System.Windows.Forms.Button btnHorarioProfesor;
        private System.Windows.Forms.Button btnSalirProfesor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCursosProfesor;
        private System.Windows.Forms.Panel panelCursosProfesor;
        private System.Windows.Forms.Button btnVerAlumnos;
        private System.Windows.Forms.Button btnVolverCursosProfesor;
        private System.Windows.Forms.ComboBox cbCursosProfesor;
    }
}

