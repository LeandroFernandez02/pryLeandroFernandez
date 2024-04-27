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
    public partial class frmJuego : Form
    {
        clsJugador objJugador;
        clsEnemigo objEnemigo;
        bool juegoPausado;

        public frmJuego()
        {
            InitializeComponent();

            objEnemigo = new clsEnemigo();
            objJugador = new clsJugador(objEnemigo, this, objEnemigo.timerMover, objEnemigo.timerGeneradorEnemigos);

            objEnemigo.mover(this);

            SoundPlayer sonidoAmbiente = new SoundPlayer();
            sonidoAmbiente.Stream = pryLeandroFernandez3.Properties.Resources.Juego_Ambiente;
            sonidoAmbiente.Play();

            objJugador.colisionNavePrincipal(pctNave, pctVidaUno, pctVidaDos, pctVidaTres, pnlGameOver, pctGameOver);
        }

        private void frmJuego_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    pausar();
                    e.Handled = true;
                    break;
            }

            if (!juegoPausado) // Verifica si el juego no está pausado
            {
                objJugador.mover(pctNave, e);
                objJugador.disparar(this, pctNave, e);
            }

        }
        public void ActualizarPuntaje(int puntaje)
        {
            lblContador.Text = "Score = " + puntaje.ToString(); // Actualiza el texto del Label con el nuevo puntaje
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblPausa_Click(object sender, EventArgs e)
        {
            pausar();
        }

        void pausar()
        {
            switch (juegoPausado)
            {
                case false:
                    juegoPausado = true;
                    lblPausa.Text = "Unpause";


                    objEnemigo.TimerGeneradorEnemigo.Stop();
                    objJugador.TimerDisparo.Stop();
                    objJugador.TimerMoverEnemigo.Stop();
                    pnlPausa.BringToFront();
                    pnlPausa.Visible = true;

                    break;

                case true:
                    juegoPausado = false;
                    lblPausa.Text = "Pause";


                    objEnemigo.TimerGeneradorEnemigo.Start();
                    objJugador.TimerDisparo.Start();
                    objJugador.TimerMoverEnemigo.Start();
                    pnlPausa.Visible = false;

                    break;
            }
        }

        private void btnDespausar_Click(object sender, EventArgs e)
        {
            juegoPausado = false;
            lblPausa.Text = "Pause";


            objEnemigo.TimerGeneradorEnemigo.Start();
            objJugador.TimerDisparo.Start();
            objJugador.TimerMoverEnemigo.Start();
            pnlPausa.Visible = false;

            this.Focus();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            this.Hide();
            frmPrincipal.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            frmMenuJuego frmMenuJuego = new frmMenuJuego();
            this.Hide();
            frmMenuJuego.Show();           
        }        
    }
}
