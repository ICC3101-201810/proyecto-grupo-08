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
            this.SuspendLayout();
            // 
            // cbCarreras
            // 
            this.cbCarreras.FormattingEnabled = true;
            this.cbCarreras.Location = new System.Drawing.Point(86, 96);
            this.cbCarreras.Name = "cbCarreras";
            this.cbCarreras.Size = new System.Drawing.Size(381, 32);
            this.cbCarreras.TabIndex = 0;
            this.cbCarreras.SelectedIndexChanged += new System.EventHandler(this.cbCarreras_SelectedIndexChanged);
            // 
            // botonCarrera
            // 
            this.botonCarrera.Location = new System.Drawing.Point(168, 362);
            this.botonCarrera.Name = "botonCarrera";
            this.botonCarrera.Size = new System.Drawing.Size(191, 65);
            this.botonCarrera.TabIndex = 1;
            this.botonCarrera.Text = "Ingresar";
            this.botonCarrera.UseVisualStyleBackColor = true;
            this.botonCarrera.Click += new System.EventHandler(this.botonCarrera_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese su rut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese su clave";
            // 
            // tbRut
            // 
            this.tbRut.Location = new System.Drawing.Point(86, 205);
            this.tbRut.Name = "tbRut";
            this.tbRut.Size = new System.Drawing.Size(381, 29);
            this.tbRut.TabIndex = 4;
            // 
            // tbClave
            // 
            this.tbClave.Location = new System.Drawing.Point(86, 305);
            this.tbClave.Name = "tbClave";
            this.tbClave.Size = new System.Drawing.Size(381, 29);
            this.tbClave.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seleccione su Carrera";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 457);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbClave);
            this.Controls.Add(this.tbRut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonCarrera);
            this.Controls.Add(this.cbCarreras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCarreras;
        private System.Windows.Forms.Button botonCarrera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRut;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.Label label3;
    }
}

