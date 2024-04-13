using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace pryLeandroFernandez2
{
    public class clsJugador
    {
        private Timer timerDisparo;
        private List<PictureBox> listaDisparos;      
        private clsEnemigo enemigo;
        private frmJuego FrmJuego;
        private Timer timerMoverEnemigo;
        private int varContador;       

        // Constructor
        public clsJugador(clsEnemigo enemigo, frmJuego frmJuego, Timer timerMoverEnemigo )
        {            
            timerDisparo = new Timer();
            timerDisparo.Interval = 1;
            timerDisparo.Tick += timerDisparo_Tick;

            listaDisparos = new List<PictureBox>();            

            this.enemigo = enemigo;
            FrmJuego = frmJuego;
            this.timerMoverEnemigo = timerMoverEnemigo;           
        }

        

        // Metodo mover
        public void mover(PictureBox nave, KeyEventArgs e)
        {
            PictureBox pctNave = new PictureBox();
            pctNave = nave;

            switch (e.KeyCode)
            {
                case Keys.Left:

                    if (pctNave.Left >= 30)
                    {
                        pctNave.Left -= 30;
                    }
                    break;

                case Keys.Right:
                    if (pctNave.Right <= 770)
                    {
                        pctNave.Left += 30;
                    }
                    break;
            }

        }

        // Metodo disparar
        public void disparar(frmJuego FrmJuego, PictureBox nave, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    crearDisparo(FrmJuego, nave);
                    break;
            }
        }

        PictureBox pctDisparo = new PictureBox();
        // Funcion crearDisparo
        void crearDisparo(frmJuego FrmJuego, PictureBox nave)
        {
            pctDisparo = new PictureBox();
            pctDisparo.Image = pryLeandroFernandez3.Properties.Resources.disparo1;
            pctDisparo.Size = new Size(30, 30);
            pctDisparo.BackColor = Color.Black;
            pctDisparo.SizeMode = PictureBoxSizeMode.StretchImage;
            pctDisparo.Location = new Point(nave.Location.X + 30, 300 );
            enemigoDestruido = false;

            FrmJuego.Controls.Add(pctDisparo);
            pctDisparo.BringToFront();

            listaDisparos.Add(pctDisparo);
            if (!timerDisparo.Enabled)
            {
                timerDisparo.Start();
            }
        }
         
        bool enemigoDestruido = false; //bandera      
        private void timerDisparo_Tick(object sender, EventArgs e)
        {
            foreach (var disparo in listaDisparos.ToList())
            {
                disparo.Top -= 8; // Velocidad

                if (disparo.Top <= 0)
                {
                    // Remover el PictureBox del disparo del formulario y de la lista
                    listaDisparos.Remove(disparo);
                    if (disparo.Parent != null)
                    {
                        disparo.Parent.Controls.Remove(disparo);
                    }
                    disparo.Dispose();
                }
                else if (enemigo != null && enemigo.pctEnemigo != null && disparo.Bounds.IntersectsWith(enemigo.pctEnemigo.Bounds))
                {
                    if (!enemigoDestruido)
                    {
                        enemigoDestruido = true; // Marcar el enemigo como destruido para evitar incrementos adicionales del puntaje

                        varContador++;
                        FrmJuego.ActualizarPuntaje(varContador);
                    }

                    listaDisparos.Remove(disparo);
                    if (disparo.Parent != null)
                    {
                        disparo.Parent.Controls.Remove(disparo);
                    }
                    disparo.Dispose();

                    colision();
                }
            }
        }
        void colision()
        {
            FrmJuego.Controls.Remove(pctDisparo);
            pctDisparo.Dispose();

            timerMoverEnemigo.Stop();

            enemigo.pctEnemigo.Image = pryLeandroFernandez3.Properties.Resources.explosion_enemigo_2_unscreen;

            Timer timerExplosion = new Timer();
            timerExplosion.Interval = 300;
            timerExplosion.Tick += (sender, args) =>
            {
                FrmJuego.Controls.Remove(enemigo.pctEnemigo);
                enemigo.pctEnemigo.Dispose();

                timerExplosion.Stop();
                timerExplosion.Dispose();
            };
            timerExplosion.Start();
        }
    }

}
