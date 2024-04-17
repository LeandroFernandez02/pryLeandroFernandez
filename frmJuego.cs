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
    public partial class frmJuego : Form
    {
        clsJugador objJugador;
        clsEnemigo objEnemigo;

        public frmJuego()
        {
            InitializeComponent();

            objEnemigo = new clsEnemigo();
            objJugador = new clsJugador(objEnemigo, this, objEnemigo.timerMover);

            objEnemigo.mover(this);
        }

        private void frmJuego_KeyDown(object sender, KeyEventArgs e)
        {
            if (!juegoPausado) // Verifica si el juego no está pausado
            {
                objJugador.mover(pctNave, e);
                objJugador.disparar(this, pctNave, e);
            }
            
            objJugador.mover(pctNave, e);
            objJugador.disparar(this, pctNave, e);
            
        }
        public void ActualizarPuntaje(int puntaje)
        {
            lblContador.Text = "Score = " + puntaje.ToString(); // Actualiza el texto del Label con el nuevo puntaje
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pctFondo_Click(object sender, EventArgs e)
        {

        }
        bool juegoPausado;
        private void lblPausa_Click(object sender, EventArgs e)
        {
            switch (juegoPausado)
            {
                case false:
                    lblPausa.Text = "Pause";
                    juegoPausado = true;

                    objEnemigo.TimerGeneradorEnemigo.Stop();
                    objJugador.TimerDisparo.Stop();
                    objJugador.TimerMoverEnemigo.Stop();


                    break;

                case true:
                    lblPausa.Text = "Unpause";
                    juegoPausado = false;

                    objEnemigo.TimerGeneradorEnemigo.Start();
                    objJugador.TimerDisparo.Start();
                    objJugador.TimerMoverEnemigo.Start();

                    break;
            }           
        }
    }
}
