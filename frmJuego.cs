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
            objJugador.mover(pctNave, e);
            objJugador.disparar(this, pctNave, e);
        }
        public void ActualizarPuntaje(int puntaje)
        {
            lblContador.Text = "Puntaje = " + puntaje.ToString(); // Actualiza el texto del Label con el nuevo puntaje
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
