using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLeandroFernandez2
{
    public partial class frmMenuJuego : Form
    {        
        public frmMenuJuego()
        {
            InitializeComponent();

            /*
            pctFondo.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;      
            */
        }

        private void pctFondo_Click(object sender, EventArgs e)
        {
            abrirJuego();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            abrirJuego();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            abrirJuego();
        }

        private void abrirJuego()
        {
            frmJuego frmJuego = new frmJuego();
            this.Hide();
            frmJuego.Show();
        }

        private void txtJugador_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            // Si se presiona la tecla Enter y el cuadro de texto no está vacío, habilita los Picture Box
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtJugador.Text))
            {
                pctFondo.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
            }
            */
        }
    }
}
