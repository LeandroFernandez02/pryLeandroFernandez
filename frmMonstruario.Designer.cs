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
            mrcCaracteristicas8 = new GroupBox();
            lstAPI = new ListBox();
            mrcCaracteristicas7 = new GroupBox();
            lblDestreza = new Label();
            lblInteligencia = new Label();
            lblSabiduria = new Label();
            lblFortaleza = new Label();
            lblArmadura = new Label();
            statusStrip1 = new StatusStrip();
            tstpConexionBD = new ToolStripStatusLabel();
            tspConexionBD = new ToolStripStatusLabel();
            pnlMonstruario.SuspendLayout();
            mrcCaracteristicas8.SuspendLayout();
            mrcCaracteristicas7.SuspendLayout();
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
            // 
            // pnlMonstruario
            // 
            pnlMonstruario.Controls.Add(mrcCaracteristicas8);
            pnlMonstruario.Controls.Add(mrcCaracteristicas7);
            pnlMonstruario.Controls.Add(trvMonstruario);
            pnlMonstruario.Location = new Point(69, 12);
            pnlMonstruario.Name = "pnlMonstruario";
            pnlMonstruario.Size = new Size(666, 393);
            pnlMonstruario.TabIndex = 1;
            // 
            // mrcCaracteristicas8
            // 
            mrcCaracteristicas8.Controls.Add(lstAPI);
            mrcCaracteristicas8.Location = new Point(327, 149);
            mrcCaracteristicas8.Name = "mrcCaracteristicas8";
            mrcCaracteristicas8.Size = new Size(289, 226);
            mrcCaracteristicas8.TabIndex = 5;
            mrcCaracteristicas8.TabStop = false;
            mrcCaracteristicas8.Text = "Caracteristicas: ETAPA 8";
            // 
            // lstAPI
            // 
            lstAPI.FormattingEnabled = true;
            lstAPI.ItemHeight = 15;
            lstAPI.Location = new Point(6, 20);
            lstAPI.Name = "lstAPI";
            lstAPI.Size = new Size(277, 199);
            lstAPI.TabIndex = 5;
            // 
            // mrcCaracteristicas7
            // 
            mrcCaracteristicas7.Controls.Add(lblDestreza);
            mrcCaracteristicas7.Controls.Add(lblInteligencia);
            mrcCaracteristicas7.Controls.Add(lblSabiduria);
            mrcCaracteristicas7.Controls.Add(lblFortaleza);
            mrcCaracteristicas7.Controls.Add(lblArmadura);
            mrcCaracteristicas7.Location = new Point(327, 17);
            mrcCaracteristicas7.Name = "mrcCaracteristicas7";
            mrcCaracteristicas7.Size = new Size(289, 106);
            mrcCaracteristicas7.TabIndex = 1;
            mrcCaracteristicas7.TabStop = false;
            mrcCaracteristicas7.Text = "Caracteristicas: ETAPA 7";
            // 
            // lblDestreza
            // 
            lblDestreza.AutoSize = true;
            lblDestreza.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDestreza.Location = new Point(6, 83);
            lblDestreza.Name = "lblDestreza";
            lblDestreza.Size = new Size(62, 17);
            lblDestreza.TabIndex = 4;
            lblDestreza.Text = "Destreza:";
            // 
            // lblInteligencia
            // 
            lblInteligencia.AutoSize = true;
            lblInteligencia.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblInteligencia.Location = new Point(6, 66);
            lblInteligencia.Name = "lblInteligencia";
            lblInteligencia.Size = new Size(76, 17);
            lblInteligencia.TabIndex = 3;
            lblInteligencia.Text = "Inteligencia:";
            // 
            // lblSabiduria
            // 
            lblSabiduria.AutoSize = true;
            lblSabiduria.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSabiduria.Location = new Point(6, 49);
            lblSabiduria.Name = "lblSabiduria";
            lblSabiduria.Size = new Size(66, 17);
            lblSabiduria.TabIndex = 2;
            lblSabiduria.Text = "Sabiduria:";
            // 
            // lblFortaleza
            // 
            lblFortaleza.AutoSize = true;
            lblFortaleza.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFortaleza.Location = new Point(6, 32);
            lblFortaleza.Name = "lblFortaleza";
            lblFortaleza.Size = new Size(64, 17);
            lblFortaleza.TabIndex = 1;
            lblFortaleza.Text = "Fortaleza:";
            // 
            // lblArmadura
            // 
            lblArmadura.AutoSize = true;
            lblArmadura.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblArmadura.Location = new Point(6, 15);
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
            mrcCaracteristicas8.ResumeLayout(false);
            mrcCaracteristicas7.ResumeLayout(false);
            mrcCaracteristicas7.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView trvMonstruario;
        private Panel pnlMonstruario;
        private GroupBox mrcCaracteristicas7;
        private Label lblDestreza;
        private Label lblInteligencia;
        private Label lblSabiduria;
        private Label lblFortaleza;
        private Label lblArmadura;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tstpConexionBD;
        private ToolStripStatusLabel tspConexionBD;
        private GroupBox mrcCaracteristicas8;
        private ListBox lstAPI;
    }
}