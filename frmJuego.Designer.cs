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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJuego));
            pctFondo = new PictureBox();
            pctNave = new PictureBox();
            lblContador = new Label();
            lblSalir = new Label();
            lblPausa = new Label();
            pnlPausa = new Panel();
            btnMenu = new Button();
            btnSalir = new Button();
            btnDespausar = new Button();
            pctLogo = new PictureBox();
            timerDetectarColision = new System.Windows.Forms.Timer(components);
            pctVidaUno = new PictureBox();
            pctVidaDos = new PictureBox();
            pctVidaTres = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctFondo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctNave).BeginInit();
            pnlPausa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctVidaUno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctVidaDos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctVidaTres).BeginInit();
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
            pctNave.Location = new Point(356, 350);
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
            lblContador.Size = new Size(87, 14);
            lblContador.TabIndex = 2;
            lblContador.Text = "Score = ";
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
            // lblPausa
            // 
            lblPausa.AutoSize = true;
            lblPausa.BackColor = Color.Black;
            lblPausa.Font = new Font("Emulogic", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lblPausa.ForeColor = Color.White;
            lblPausa.Location = new Point(691, 12);
            lblPausa.Name = "lblPausa";
            lblPausa.Size = new Size(57, 14);
            lblPausa.TabIndex = 4;
            lblPausa.Text = "Pause";
            lblPausa.Click += lblPausa_Click;
            // 
            // pnlPausa
            // 
            pnlPausa.BackColor = Color.Transparent;
            pnlPausa.Controls.Add(btnMenu);
            pnlPausa.Controls.Add(btnSalir);
            pnlPausa.Controls.Add(btnDespausar);
            pnlPausa.Controls.Add(pctLogo);
            pnlPausa.Location = new Point(281, 74);
            pnlPausa.Name = "pnlPausa";
            pnlPausa.Size = new Size(240, 261);
            pnlPausa.TabIndex = 5;
            pnlPausa.Visible = false;
            // 
            // btnMenu
            // 
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Emulogic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.ForeColor = Color.White;
            btnMenu.Location = new Point(59, 167);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(121, 32);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnSalir
            // 
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Emulogic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(59, 209);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(121, 32);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Close";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnDespausar
            // 
            btnDespausar.Cursor = Cursors.Hand;
            btnDespausar.FlatStyle = FlatStyle.Flat;
            btnDespausar.Font = new Font("Emulogic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDespausar.ForeColor = Color.White;
            btnDespausar.Location = new Point(59, 125);
            btnDespausar.Name = "btnDespausar";
            btnDespausar.Size = new Size(121, 32);
            btnDespausar.TabIndex = 1;
            btnDespausar.Text = "Unpause";
            btnDespausar.UseVisualStyleBackColor = true;
            btnDespausar.Click += btnDespausar_Click;
            // 
            // pctLogo
            // 
            pctLogo.Image = pryLeandroFernandez3.Properties.Resources.Galaga_logo_svg;
            pctLogo.Location = new Point(26, 18);
            pctLogo.Name = "pctLogo";
            pctLogo.Size = new Size(188, 96);
            pctLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pctLogo.TabIndex = 0;
            pctLogo.TabStop = false;
            // 
            // timerDetectarColision
            // 
            timerDetectarColision.Enabled = true;
            // 
            // pctVidaUno
            // 
            pctVidaUno.Image = pryLeandroFernandez3.Properties.Resources.corazonBlanco;
            pctVidaUno.Location = new Point(12, 29);
            pctVidaUno.Name = "pctVidaUno";
            pctVidaUno.Size = new Size(38, 32);
            pctVidaUno.SizeMode = PictureBoxSizeMode.StretchImage;
            pctVidaUno.TabIndex = 6;
            pctVidaUno.TabStop = false;
            // 
            // pctVidaDos
            // 
            pctVidaDos.Image = pryLeandroFernandez3.Properties.Resources.corazonBlanco;
            pctVidaDos.Location = new Point(56, 27);
            pctVidaDos.Name = "pctVidaDos";
            pctVidaDos.Size = new Size(38, 34);
            pctVidaDos.SizeMode = PictureBoxSizeMode.StretchImage;
            pctVidaDos.TabIndex = 7;
            pctVidaDos.TabStop = false;
            // 
            // pctVidaTres
            // 
            pctVidaTres.Image = pryLeandroFernandez3.Properties.Resources.corazonBlanco;
            pctVidaTres.Location = new Point(100, 29);
            pctVidaTres.Name = "pctVidaTres";
            pctVidaTres.Size = new Size(38, 32);
            pctVidaTres.SizeMode = PictureBoxSizeMode.StretchImage;
            pctVidaTres.TabIndex = 8;
            pctVidaTres.TabStop = false;
            // 
            // frmJuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(pctVidaTres);
            Controls.Add(pctVidaDos);
            Controls.Add(pctVidaUno);
            Controls.Add(lblSalir);
            Controls.Add(lblPausa);
            Controls.Add(lblContador);
            Controls.Add(pnlPausa);
            Controls.Add(pctNave);
            Controls.Add(pctFondo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmJuego";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Galaga";
            KeyDown += frmJuego_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pctFondo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctNave).EndInit();
            pnlPausa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctVidaUno).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctVidaDos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctVidaTres).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pctFondo;
        private PictureBox pctNave;
        private Label lblContador;
        private Label lblSalir;
        private Label lblPausa;
        private Panel pnlPausa;
        private Button btnDespausar;
        private PictureBox pctLogo;
        private Button btnMenu;
        private Button btnSalir;
        private System.Windows.Forms.Timer timerDetectarColision;
        private PictureBox pctVidaUno;
        private PictureBox pctVidaDos;
        private PictureBox pctVidaTres;
    }
}