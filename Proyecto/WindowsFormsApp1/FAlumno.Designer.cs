namespace WindowsFormsApp1
{
    partial class FAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.botonAgregarRamo = new System.Windows.Forms.Button();
            this.BotonBotarRamo = new System.Windows.Forms.Button();
            this.BotonMostrarRamos = new System.Windows.Forms.Button();
            this.botonCerrarSesion = new System.Windows.Forms.Button();
            this.lbBienvenidaAlumno = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.botonAgregarRamo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BotonBotarRamo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BotonMostrarRamos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.botonCerrarSesion, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(138, 83);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(496, 246);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // botonAgregarRamo
            // 
            this.botonAgregarRamo.Location = new System.Drawing.Point(3, 3);
            this.botonAgregarRamo.Name = "botonAgregarRamo";
            this.botonAgregarRamo.Size = new System.Drawing.Size(242, 117);
            this.botonAgregarRamo.TabIndex = 0;
            this.botonAgregarRamo.Text = "Agregar Ramo";
            this.botonAgregarRamo.UseVisualStyleBackColor = true;
            this.botonAgregarRamo.Click += new System.EventHandler(this.botonAgregarRamo_Click);
            // 
            // BotonBotarRamo
            // 
            this.BotonBotarRamo.Location = new System.Drawing.Point(251, 3);
            this.BotonBotarRamo.Name = "BotonBotarRamo";
            this.BotonBotarRamo.Size = new System.Drawing.Size(242, 117);
            this.BotonBotarRamo.TabIndex = 1;
            this.BotonBotarRamo.Text = "Botar Ramo";
            this.BotonBotarRamo.UseVisualStyleBackColor = true;
            this.BotonBotarRamo.Click += new System.EventHandler(this.BotonBotarRamo_Click);
            // 
            // BotonMostrarRamos
            // 
            this.BotonMostrarRamos.Location = new System.Drawing.Point(3, 126);
            this.BotonMostrarRamos.Name = "BotonMostrarRamos";
            this.BotonMostrarRamos.Size = new System.Drawing.Size(242, 117);
            this.BotonMostrarRamos.TabIndex = 2;
            this.BotonMostrarRamos.Text = "Mostrar Ramos";
            this.BotonMostrarRamos.UseVisualStyleBackColor = true;
            this.BotonMostrarRamos.Click += new System.EventHandler(this.BotonMostrarRamos_Click);
            // 
            // botonCerrarSesion
            // 
            this.botonCerrarSesion.Location = new System.Drawing.Point(251, 126);
            this.botonCerrarSesion.Name = "botonCerrarSesion";
            this.botonCerrarSesion.Size = new System.Drawing.Size(242, 117);
            this.botonCerrarSesion.TabIndex = 3;
            this.botonCerrarSesion.Text = "Cerrar Sesión";
            this.botonCerrarSesion.UseVisualStyleBackColor = true;
            this.botonCerrarSesion.Click += new System.EventHandler(this.botonCerrarSesion_Click);
            // 
            // lbBienvenidaAlumno
            // 
            this.lbBienvenidaAlumno.AutoSize = true;
            this.lbBienvenidaAlumno.Location = new System.Drawing.Point(322, 30);
            this.lbBienvenidaAlumno.Name = "lbBienvenidaAlumno";
            this.lbBienvenidaAlumno.Size = new System.Drawing.Size(114, 25);
            this.lbBienvenidaAlumno.TabIndex = 3;
            this.lbBienvenidaAlumno.Text = "Bienvenido ";
            // 
            // FAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbBienvenidaAlumno);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FAlumno";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FAlumno_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BotonBotarRamo;
        private System.Windows.Forms.Button BotonMostrarRamos;
        private System.Windows.Forms.Button botonCerrarSesion;
        private System.Windows.Forms.Button botonAgregarRamo;
        private System.Windows.Forms.Label lbBienvenidaAlumno;
    }
}