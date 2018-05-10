namespace WindowsFormsApp1
{
    partial class AgregarRamos
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
            this.cbMostrarRamo = new System.Windows.Forms.ComboBox();
            this.bTomarRamo = new System.Windows.Forms.Button();
            this.bSalirTomarRamo = new System.Windows.Forms.Button();
            this.lMostrarRamo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbMostrarRamo
            // 
            this.cbMostrarRamo.FormattingEnabled = true;
            this.cbMostrarRamo.Location = new System.Drawing.Point(166, 168);
            this.cbMostrarRamo.Name = "cbMostrarRamo";
            this.cbMostrarRamo.Size = new System.Drawing.Size(451, 32);
            this.cbMostrarRamo.TabIndex = 0;
            // 
            // bTomarRamo
            // 
            this.bTomarRamo.Location = new System.Drawing.Point(84, 280);
            this.bTomarRamo.Name = "bTomarRamo";
            this.bTomarRamo.Size = new System.Drawing.Size(140, 63);
            this.bTomarRamo.TabIndex = 1;
            this.bTomarRamo.Text = "Tomar Ramo";
            this.bTomarRamo.UseVisualStyleBackColor = true;
            // 
            // bSalirTomarRamo
            // 
            this.bSalirTomarRamo.Location = new System.Drawing.Point(554, 280);
            this.bSalirTomarRamo.Name = "bSalirTomarRamo";
            this.bSalirTomarRamo.Size = new System.Drawing.Size(140, 63);
            this.bSalirTomarRamo.TabIndex = 2;
            this.bSalirTomarRamo.Text = "Salir";
            this.bSalirTomarRamo.UseVisualStyleBackColor = true;
            // 
            // lMostrarRamo
            // 
            this.lMostrarRamo.AutoSize = true;
            this.lMostrarRamo.Location = new System.Drawing.Point(360, 299);
            this.lMostrarRamo.Name = "lMostrarRamo";
            this.lMostrarRamo.Size = new System.Drawing.Size(17, 25);
            this.lMostrarRamo.TabIndex = 3;
            this.lMostrarRamo.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "A continuación, escoja el ramo que desea tomar.";
            // 
            // AgregarRamoscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lMostrarRamo);
            this.Controls.Add(this.bSalirTomarRamo);
            this.Controls.Add(this.bTomarRamo);
            this.Controls.Add(this.cbMostrarRamo);
            this.Name = "AgregarRamoscs";
            this.Text = "AgregarRamoscs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMostrarRamo;
        private System.Windows.Forms.Button bTomarRamo;
        private System.Windows.Forms.Button bSalirTomarRamo;
        private System.Windows.Forms.Label lMostrarRamo;
        private System.Windows.Forms.Label label2;
    }
}