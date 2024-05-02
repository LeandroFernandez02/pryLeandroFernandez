namespace pryLeandroFernandez3
{
    partial class frmMonstruario
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
            trvMonstruario = new TreeView();
            pnlMonstruario = new Panel();
            mrcCaracteristicas = new GroupBox();
            lblDestreza = new Label();
            lblInteligencia = new Label();
            lblVelocidad = new Label();
            lblFortaleza = new Label();
            lblArmadura = new Label();
            statusStrip1 = new StatusStrip();
            tstpConexionBD = new ToolStripStatusLabel();
            tspConexionBD = new ToolStripStatusLabel();
            pnlMonstruario.SuspendLayout();
            mrcCaracteristicas.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // trvMonstruario
            // 
            trvMonstruario.Location = new Point(3, 3);
            trvMonstruario.Name = "trvMonstruario";
            trvMonstruario.Size = new Size(262, 387);
            trvMonstruario.TabIndex = 0;
            trvMonstruario.NodeMouseDoubleClick += trvMonstruario_NodeMouseDoubleClick;
            trvMonstruario.DoubleClick += trvMonstruario_DoubleClick;
            // 
            // pnlMonstruario
            // 
            pnlMonstruario.Controls.Add(mrcCaracteristicas);
            pnlMonstruario.Controls.Add(trvMonstruario);
            pnlMonstruario.Location = new Point(69, 12);
            pnlMonstruario.Name = "pnlMonstruario";
            pnlMonstruario.Size = new Size(666, 393);
            pnlMonstruario.TabIndex = 1;
            // 
            // mrcCaracteristicas
            // 
            mrcCaracteristicas.Controls.Add(lblDestreza);
            mrcCaracteristicas.Controls.Add(lblInteligencia);
            mrcCaracteristicas.Controls.Add(lblVelocidad);
            mrcCaracteristicas.Controls.Add(lblFortaleza);
            mrcCaracteristicas.Controls.Add(lblArmadura);
            mrcCaracteristicas.Location = new Point(321, 40);
            mrcCaracteristicas.Name = "mrcCaracteristicas";
            mrcCaracteristicas.Size = new Size(244, 282);
            mrcCaracteristicas.TabIndex = 1;
            mrcCaracteristicas.TabStop = false;
            mrcCaracteristicas.Text = "Caracteristicas";
            // 
            // lblDestreza
            // 
            lblDestreza.AutoSize = true;
            lblDestreza.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDestreza.Location = new Point(17, 130);
            lblDestreza.Name = "lblDestreza";
            lblDestreza.Size = new Size(62, 17);
            lblDestreza.TabIndex = 4;
            lblDestreza.Text = "Destreza:";
            // 
            // lblInteligencia
            // 
            lblInteligencia.AutoSize = true;
            lblInteligencia.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblInteligencia.Location = new Point(17, 106);
            lblInteligencia.Name = "lblInteligencia";
            lblInteligencia.Size = new Size(76, 17);
            lblInteligencia.TabIndex = 3;
            lblInteligencia.Text = "Inteligencia:";
            // 
            // lblVelocidad
            // 
            lblVelocidad.AutoSize = true;
            lblVelocidad.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblVelocidad.Location = new Point(17, 82);
            lblVelocidad.Name = "lblVelocidad";
            lblVelocidad.Size = new Size(66, 17);
            lblVelocidad.TabIndex = 2;
            lblVelocidad.Text = "Sabiduria:";
            // 
            // lblFortaleza
            // 
            lblFortaleza.AutoSize = true;
            lblFortaleza.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFortaleza.Location = new Point(17, 58);
            lblFortaleza.Name = "lblFortaleza";
            lblFortaleza.Size = new Size(64, 17);
            lblFortaleza.TabIndex = 1;
            lblFortaleza.Text = "Fortaleza:";
            // 
            // lblArmadura
            // 
            lblArmadura.AutoSize = true;
            lblArmadura.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblArmadura.Location = new Point(17, 34);
            lblArmadura.Name = "lblArmadura";
            lblArmadura.Size = new Size(69, 17);
            lblArmadura.TabIndex = 0;
            lblArmadura.Text = "Armadura:";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tstpConexionBD, tspConexionBD });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // tstpConexionBD
            // 
            tstpConexionBD.Name = "tstpConexionBD";
            tstpConexionBD.Size = new Size(0, 17);
            // 
            // tspConexionBD
            // 
            tspConexionBD.Name = "tspConexionBD";
            tspConexionBD.Size = new Size(16, 17);
            tspConexionBD.Text = "...";
            // 
            // frmMonstruario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(pnlMonstruario);
            Name = "frmMonstruario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Monstruario";
            Load += frmMonstruario_Load;
            pnlMonstruario.ResumeLayout(false);
            mrcCaracteristicas.ResumeLayout(false);
            mrcCaracteristicas.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView trvMonstruario;
        private Panel pnlMonstruario;
        private GroupBox mrcCaracteristicas;
        private Label lblDestreza;
        private Label lblInteligencia;
        private Label lblVelocidad;
        private Label lblFortaleza;
        private Label lblArmadura;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tstpConexionBD;
        private ToolStripStatusLabel tspConexionBD;
    }
}