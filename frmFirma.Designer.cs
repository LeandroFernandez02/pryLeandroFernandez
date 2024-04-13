namespace pryLeandroFernandez2
{
    partial class frmFirma
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
            grpFirma = new GroupBox();
            btnLimpiar = new Button();
            btnFirmar = new Button();
            brnGrabar = new Button();
            pctFirma = new PictureBox();
            grpFirma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctFirma).BeginInit();
            SuspendLayout();
            // 
            // grpFirma
            // 
            grpFirma.Controls.Add(btnLimpiar);
            grpFirma.Controls.Add(btnFirmar);
            grpFirma.Controls.Add(brnGrabar);
            grpFirma.Controls.Add(pctFirma);
            grpFirma.Location = new Point(146, 30);
            grpFirma.Name = "grpFirma";
            grpFirma.Size = new Size(498, 337);
            grpFirma.TabIndex = 0;
            grpFirma.TabStop = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(281, 258);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnFirmar
            // 
            btnFirmar.Location = new Point(55, 258);
            btnFirmar.Name = "btnFirmar";
            btnFirmar.Size = new Size(75, 23);
            btnFirmar.TabIndex = 2;
            btnFirmar.Text = "Firmar";
            btnFirmar.UseVisualStyleBackColor = true;
            btnFirmar.Click += btnFirmar_Click;
            // 
            // brnGrabar
            // 
            brnGrabar.Location = new Point(362, 258);
            brnGrabar.Name = "brnGrabar";
            brnGrabar.Size = new Size(75, 23);
            brnGrabar.TabIndex = 1;
            brnGrabar.Text = "Grabar";
            brnGrabar.UseVisualStyleBackColor = true;
            brnGrabar.Click += brnGrabar_Click;
            // 
            // pctFirma
            // 
            pctFirma.BackColor = Color.White;
            pctFirma.Location = new Point(55, 35);
            pctFirma.Name = "pctFirma";
            pctFirma.Size = new Size(382, 217);
            pctFirma.TabIndex = 0;
            pctFirma.TabStop = false;
            pctFirma.MouseDown += pctFirma_MouseDown;
            pctFirma.MouseMove += pctFirma_MouseMove;
            pctFirma.MouseUp += pctFirma_MouseUp;
            // 
            // frmFirma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpFirma);
            Name = "frmFirma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Firma";
            grpFirma.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctFirma).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpFirma;
        private Button brnGrabar;
        private PictureBox pctFirma;
        private Button btnLimpiar;
        private Button btnFirmar;
    }
}