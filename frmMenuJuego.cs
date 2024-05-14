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
using System.IO;
using pryLeandroFernandez3;
using System.Security.Cryptography.X509Certificates;

namespace pryLeandroFernandez2
{
    public partial class frmMenuJuego : Form
    {
        public string varNombre;
        public frmMenuJuego()
        {
            InitializeComponent();

            

            SoundPlayer sonidoNombre = new SoundPlayer();
            sonidoNombre.Stream = pryLeandroFernandez3.Properties.Resources.nombreSonido;
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

        private void abrirJuego()
        {
            frmJuego frmJuego = new frmJuego(varNombre);
            this.Hide();
            frmJuego.Show();
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;

                    varNombre = txtNombre.Text;

                    SoundPlayer sonidoInicio = new SoundPlayer();
                    sonidoInicio.Stream = pryLeandroFernandez3.Properties.Resources.Inicio_musica;
                    sonidoInicio.Play();
                    
                    pctFondo.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                                    
                    pnlJugador.Visible = false;
                    pnlJugador.Enabled = false;
                    
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("ERROR: " + error);
                throw;
            }
        }
        /*
   try
   {
       if (e.KeyCode == Keys.Enter)
       {
           e.Handled = true;

           varNombresote = txtJugador.Text;

           SoundPlayer sonidoInicio = new SoundPlayer();
           sonidoInicio.Stream = pryLeandroFernandez3.Properties.Resources.Inicio_musica;
           sonidoInicio.Play();

           pctFondo.Enabled = true;
           pictureBox2.Enabled = true;
           pictureBox3.Enabled = true;

           pnlJugador.Visible = false;
           pnlJugador.Enabled = false;
       }
   }
   catch (Exception error)
   {
       MessageBox.Show("ERROR: " + error);
       throw;
   }
   */

    }
}
