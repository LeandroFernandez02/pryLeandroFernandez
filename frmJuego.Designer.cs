namespace pryLeandroFernandez2
{
    partial class frmJuego
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
            pctFondo = new PictureBox();
            pctNave = new PictureBox();
            lblContador = new Label();
            lblSalir = new Label();
            ((System.ComponentModel.ISupportInitialize)pctFondo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctNave).BeginInit();
            SuspendLayout();
            // 
            // pctFondo
            // 
            pctFondo.Dock = DockStyle.Fill;
            pctFondo.Image = pryLeandroFernandez3.Properties.Resources.galaga_espacio;
            pctFondo.Location = new Point(0, 0);
            pctFondo.Name = "pctFondo";
            pctFondo.Size = new Size(800, 450);
            pctFondo.SizeMode = PictureBoxSizeMode.StretchImage;
            pctFondo.TabIndex = 0;
            pctFondo.TabStop = false;
            // 
            // pctNave
            // 
            pctNave.BackColor = Color.Black;
            pctNave.Image = pryLeandroFernandez3.Properties.Resources.nave_galaga2;
            pctNave.Location = new Point(357, 341);
            pctNave.Name = "pctNave";
            pctNave.Size = new Size(89, 75);
            pctNave.SizeMode = PictureBoxSizeMode.StretchImage;
            pctNave.TabIndex = 1;
            pctNave.TabStop = false;
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.BackColor = Color.Black;
            lblContador.Font = new Font("Emulogic", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lblContador.ForeColor = Color.White;
            lblContador.Location = new Point(12, 12);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(107, 14);
            lblContador.TabIndex = 2;
            lblContador.Text = "Puntaje = ";
            // 
            // lblSalir
            // 
            lblSalir.AutoSize = true;
            lblSalir.BackColor = Color.Black;
            lblSalir.Cursor = Cursors.Hand;
            lblSalir.Font = new Font("Emulogic", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            lblSalir.ForeColor = Color.White;
            lblSalir.Location = new Point(767, 8);
            lblSalir.Name = "lblSalir";
            lblSalir.Size = new Size(21, 17);
            lblSalir.TabIndex = 3;
            lblSalir.Text = "x";
            lblSalir.Click += lblSalir_Click;
            // 
            // frmJuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSalir);
            Controls.Add(lblContador);
            Controls.Add(pctNave);
            Controls.Add(pctFondo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmJuego";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Galaga";
            KeyDown += frmJuego_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pctFondo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctNave).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pctFondo;
        private PictureBox pctNave;
        private Label lblContador;
        private Label lblSalir;
    }
}