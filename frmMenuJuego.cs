using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace pryLeandroFernandez2
{
    public partial class frmMenuJuego : Form
    {
        public frmMenuJuego()
        {
            InitializeComponent();
          
            SoundPlayer sonidoNombre = new SoundPlayer();
            sonidoNombre.SoundLocation = "C:\\Users\\pupif\\OneDrive\\Escritorio\\pryLeandroFernandez\\Resources\\Sonido\\nombreSonido.wav";
            sonidoNombre.Play();
            

            pctFondo.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
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
        private string varJugador;
        private void txtJugador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && !string.IsNullOrEmpty(txtJugador.Text))
            {
                e.Handled = true;

                SoundPlayer sonidoInicio = new SoundPlayer();
                sonidoInicio.SoundLocation = "C:\\Users\\pupif\\OneDrive\\Escritorio\\pryLeandroFernandez\\Resources\\Sonido\\Inicio musica.wav";
                sonidoInicio.Play();

                varJugador = txtJugador.Text;

                pctFondo.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;

                pnlJugador.Visible = false;
                pnlJugador.Enabled = false;
            }
        }

        private void abrirJuego()
        {
            frmJuego frmJuego = new frmJuego();
            this.Hide();
            frmJuego.Show();
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
