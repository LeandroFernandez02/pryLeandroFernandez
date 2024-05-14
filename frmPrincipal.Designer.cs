namespace pryLeandroFernandez2
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnsPrincipal = new MenuStrip();
            mnsDibujos = new ToolStripMenuItem();
            mnsFirma = new ToolStripMenuItem();
            mnsJuegos = new ToolStripMenuItem();
            mnsGalaga = new ToolStripMenuItem();
            mnsDatos = new ToolStripMenuItem();
            mnsMonstruario = new ToolStripMenuItem();
            stpBaseDeDatos = new StatusStrip();
            tstpConexionBD = new ToolStripStatusLabel();
            mnsJugadores = new ToolStripMenuItem();
            mnsPrincipal.SuspendLayout();
            stpBaseDeDatos.SuspendLayout();
            SuspendLayout();
            // 
            // mnsPrincipal
            // 
            mnsPrincipal.Items.AddRange(new ToolStripItem[] { mnsDibujos, mnsJuegos, mnsDatos });
            mnsPrincipal.Location = new Point(0, 0);
            mnsPrincipal.Name = "mnsPrincipal";
            mnsPrincipal.Size = new Size(800, 24);
            mnsPrincipal.TabIndex = 0;
            mnsPrincipal.Text = "menuStrip1";
            // 
            // mnsDibujos
            // 
            mnsDibujos.DropDownItems.AddRange(new ToolStripItem[] { mnsFirma });
            mnsDibujos.Name = "mnsDibujos";
            mnsDibujos.Size = new Size(59, 20);
            mnsDibujos.Text = "Dibujos";
            // 
            // mnsFirma
            // 
            mnsFirma.Name = "mnsFirma";
            mnsFirma.Size = new Size(104, 22);
            mnsFirma.Text = "Firma";
            mnsFirma.Click += mnsFirma_Click;
            // 
            // mnsJuegos
            // 
            mnsJuegos.DropDownItems.AddRange(new ToolStripItem[] { mnsGalaga });
            mnsJuegos.Name = "mnsJuegos";
            mnsJuegos.Size = new Size(55, 20);
            mnsJuegos.Text = "Juegos";
            // 
            // mnsGalaga
            // 
            mnsGalaga.Name = "mnsGalaga";
            mnsGalaga.Size = new Size(110, 22);
            mnsGalaga.Text = "Galaga";
            mnsGalaga.Click += mnsGalaga_Click;
            // 
            // mnsDatos
            // 
            mnsDatos.DropDownItems.AddRange(new ToolStripItem[] { mnsMonstruario, mnsJugadores });
            mnsDatos.Name = "mnsDatos";
            mnsDatos.Size = new Size(49, 20);
            mnsDatos.Text = "Datos";
            // 
            // mnsMonstruario
            // 
            mnsMonstruario.Name = "mnsMonstruario";
            mnsMonstruario.Size = new Size(180, 22);
            mnsMonstruario.Text = "Monstruario";
            mnsMonstruario.Click += mnsMonstruario_Click;
            // 
            // stpBaseDeDatos
            // 
            stpBaseDeDatos.Items.AddRange(new ToolStripItem[] { tstpConexionBD });
            stpBaseDeDatos.Location = new Point(0, 428);
            stpBaseDeDatos.Name = "stpBaseDeDatos";
            stpBaseDeDatos.Size = new Size(800, 22);
            stpBaseDeDatos.TabIndex = 1;
            stpBaseDeDatos.Text = "statusStrip1";
            // 
            // tstpConexionBD
            // 
            tstpConexionBD.Name = "tstpConexionBD";
            tstpConexionBD.Size = new Size(0, 17);
            // 
            // mnsJugadores
            // 
            mnsJugadores.Name = "mnsJugadores";
            mnsJugadores.Size = new Size(180, 22);
            mnsJugadores.Text = "Jugadores";
            mnsJugadores.Click += mnsJugadores_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(stpBaseDeDatos);
            Controls.Add(mnsPrincipal);
            MainMenuStrip = mnsPrincipal;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += frmPrincipal_Load;
            mnsPrincipal.ResumeLayout(false);
            mnsPrincipal.PerformLayout();
            stpBaseDeDatos.ResumeLayout(false);
            stpBaseDeDatos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnsPrincipal;
        private ToolStripMenuItem mnsDibujos;
        private ToolStripMenuItem mnsFirma;
        private ToolStripMenuItem mnsJuegos;
        private ToolStripMenuItem mnsGalaga;
        private StatusStrip stpBaseDeDatos;
        private ToolStripStatusLabel tstpConexionBD;
        private ToolStripMenuItem mnsDatos;
        private ToolStripMenuItem mnsMonstruario;
        private ToolStripMenuItem mnsJugadores;
    }
}
