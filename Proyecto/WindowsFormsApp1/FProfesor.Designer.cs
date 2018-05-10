namespace WindowsFormsApp1
{
    partial class FProfesor
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
            this.botonVerSeccionesProfe = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.botonCerrarSesionProfe = new System.Windows.Forms.Button();
            this.lbBienvenidaProfe = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.botonVerSeccionesProfe, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.botonCerrarSesionProfe, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(157, 88);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(472, 249);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // botonVerSeccionesProfe
            // 
            this.botonVerSeccionesProfe.Location = new System.Drawing.Point(3, 3);
            this.botonVerSeccionesProfe.Name = "botonVerSeccionesProfe";
            this.botonVerSeccionesProfe.Size = new System.Drawing.Size(230, 118);
            this.botonVerSeccionesProfe.TabIndex = 0;
            this.botonVerSeccionesProfe.Text = "Ver Secciones";
            this.botonVerSeccionesProfe.UseVisualStyleBackColor = true;
            this.botonVerSeccionesProfe.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 118);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // botonCerrarSesionProfe
            // 
            this.botonCerrarSesionProfe.Location = new System.Drawing.Point(3, 127);
            this.botonCerrarSesionProfe.Name = "botonCerrarSesionProfe";
            this.botonCerrarSesionProfe.Size = new System.Drawing.Size(230, 119);
            this.botonCerrarSesionProfe.TabIndex = 2;
            this.botonCerrarSesionProfe.Text = "Cerrar Sesión";
            this.botonCerrarSesionProfe.UseVisualStyleBackColor = true;
            this.botonCerrarSesionProfe.Click += new System.EventHandler(this.botonSalirProfe_Click);
            // 
            // lbBienvenidaProfe
            // 
            this.lbBienvenidaProfe.AutoSize = true;
            this.lbBienvenidaProfe.Location = new System.Drawing.Point(281, 41);
            this.lbBienvenidaProfe.Name = "lbBienvenidaProfe";
            this.lbBienvenidaProfe.Size = new System.Drawing.Size(109, 25);
            this.lbBienvenidaProfe.TabIndex = 1;
            this.lbBienvenidaProfe.Text = "Bienvenido";
            // 
            // FProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbBienvenidaProfe);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FProfesor";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FProfesor_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button botonVerSeccionesProfe;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button botonCerrarSesionProfe;
        private System.Windows.Forms.Label lbBienvenidaProfe;
    }
}