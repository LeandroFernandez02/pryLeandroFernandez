namespace pryLeandroFernandez2
{
    partial class frmMenuJuego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuJuego));
            pctFondo = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pnlJugador = new Panel();
            txtJugador = new TextBox();
            lblJugador = new Label();
            lblSalir = new Label();
            ((System.ComponentModel.ISupportInitialize)pctFondo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlJugador.SuspendLayout();
            SuspendLayout();
            // 
            // pctFondo
            // 
            pctFondo.Image = pryLeandroFernandez3.Properties.Resources.galaga_inicio;
            pctFondo.Location = new Point(-12, -8);
            pctFondo.Name = "pctFondo";
            pctFondo.Size = new Size(824, 458);
            pctFondo.SizeMode = PictureBoxSizeMode.StretchImage;
            pctFondo.TabIndex = 0;
            pctFondo.TabStop = false;
            pctFondo.Click += pctFondo_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Location = new Point(289, 298);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(223, 129);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Black;
            pictureBox3.Location = new Point(289, -8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(223, 73);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pnlJugador
            // 
            pnlJugador.BackColor = Color.Black;
            pnlJugador.Controls.Add(txtJugador);
            pnlJugador.Controls.Add(lblJugador);
            pnlJugador.Location = new Point(191, 221);
            pnlJugador.Name = "pnlJugador";
            pnlJugador.Size = new Size(421, 49);
            pnlJugador.TabIndex = 3;
            // 
            // txtJugador
            // 
            txtJugador.BackColor = Color.Black;
            txtJugador.BorderStyle = BorderStyle.None;
            txtJugador.Cursor = Cursors.IBeam;
            txtJugador.Font = new Font("Emulogic", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            txtJugador.ForeColor = Color.White;
            txtJugador.Location = new Point(221, 19);
            txtJugador.Name = "txtJugador";
            txtJugador.Size = new Size(100, 17);
            txtJugador.TabIndex = 1;
            txtJugador.KeyPress += txtJugador_KeyPress;
            // 
            // lblJugador
            // 
            lblJugador.AutoSize = true;
            lblJugador.Font = new Font("Emulogic", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            lblJugador.ForeColor = Color.White;
            lblJugador.Location = new Point(122, 19);
            lblJugador.Name = "lblJugador";
            lblJugador.Size = new Size(99, 17);
            lblJugador.TabIndex = 0;
            lblJugador.Text = "Player:";
            // 
            // lblSalir
            // 
            lblSalir.AutoSize = true;
            lblSalir.BackColor = Color.Black;
            lblSalir.Cursor = Cursors.Hand;
            lblSalir.Font = new Font("Emulogic", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            lblSalir.ForeColor = Color.White;
            lblSalir.Location = new Point(767, 9);
            lblSalir.Name = "lblSalir";
            lblSalir.Size = new Size(21, 17);
            lblSalir.TabIndex = 4;
            lblSalir.Text = "x";
            lblSalir.Click += lblSalir_Click;
            // 
            // frmMenuJuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSalir);
            Controls.Add(pnlJugador);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pctFondo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMenuJuego";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Galaga";
            ((System.ComponentModel.ISupportInitialize)pctFondo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlJugador.ResumeLayout(false);
            pnlJugador.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pctFondo;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel pnlJugador;
        private TextBox txtJugador;
        private Label lblJugador;
        private Label lblSalir;
    }
}