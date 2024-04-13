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
            pctFondo = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctFondo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            // frmMenuJuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pctFondo);
            Name = "frmMenuJuego";
            Text = "Menu Galaga";
            ((System.ComponentModel.ISupportInitialize)pctFondo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pctFondo;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}