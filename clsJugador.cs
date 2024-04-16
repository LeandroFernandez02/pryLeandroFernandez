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
        private clsEnemigo objEnemigo;
        private frmJuego FrmJuego;
        private Timer timerMoverEnemigo;
        private int varContador;
        bool enemigoDestruido = false;

        // Constructor
        public clsJugador(clsEnemigo enemigo, frmJuego frmJuego, Timer timerMoverEnemigo )
        {            
            timerDisparo = new Timer();
            timerDisparo.Interval = 1;
            timerDisparo.Tick += timerDisparo_Tick;

            listaDisparos = new List<PictureBox>();            

            this.objEnemigo = enemigo;
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
            PictureBox pctDisparo = new PictureBox(); // Crea una nueva instancia de PictureBox para cada disparo
            pctDisparo.Image = pryLeandroFernandez3.Properties.Resources.disparo1;
            pctDisparo.Size = new Size(30, 30);
            pctDisparo.BackColor = Color.Transparent;
            pctDisparo.SizeMode = PictureBoxSizeMode.StretchImage;
            pctDisparo.Location = new Point(nave.Location.X + 30, 300);
            enemigoDestruido = false;

            FrmJuego.Controls.Add(pctDisparo);
            pctDisparo.BringToFront();

            listaDisparos.Add(pctDisparo); // Agrega el nuevo disparo a la lista
            if (!timerDisparo.Enabled)
            {
                timerDisparo.Start();
            }
        }

        private Point ultimaPosicionEnemigoDestruido;
        private void timerDisparo_Tick(object sender, EventArgs e)
        {
            // Si sale del formulario
            foreach (var disparo in listaDisparos.ToList())
            {
                disparo.Top -= 8; // Velocidad

                if (disparo.Top <= 0)
                {                 
                    listaDisparos.Remove(disparo);
                    if (disparo.Parent != null)
                    {
                        disparo.Parent.Controls.Remove(disparo);
                    }
                    disparo.Dispose();
                }
                else
                {
                    // Colision
                    foreach (var enemigo in objEnemigo.ObtenerListaEnemigos())
                    {
                        if (disparo.Bounds.IntersectsWith(enemigo.Bounds))
                        {
                            if (!enemigoDestruido)
                            {
                                enemigoDestruido = true;
                                varContador++;
                                FrmJuego.ActualizarPuntaje(varContador);
                            }

                            // Remover disparo de la lista y del formulario
                            listaDisparos.Remove(disparo);
                            FrmJuego.Controls.Remove(disparo);
                            disparo.Dispose();

                            // Sacar posicion de enemigo
                            ultimaPosicionEnemigoDestruido = enemigo.Location;
                            explosion();

                            // Remover el enemigo de la lista y del formulario
                            objEnemigo.ObtenerListaEnemigos().Remove(enemigo);                           
                            if (enemigo.Parent != null)
                            {
                                enemigo.Parent.Controls.Remove(enemigo);
                            }
                            enemigo.Dispose();
                            
                            break; 
                        }
                    }
                }
            }
        }

        void explosion()
        {
            PictureBox pctExplosion = new PictureBox();
            pctExplosion.Image = pryLeandroFernandez3.Properties.Resources.explosion_enemigo_2_unscreen;
            pctExplosion.Size = new Size(50, 50);
            pctExplosion.BackColor = Color.Black;
            pctExplosion.SizeMode = PictureBoxSizeMode.StretchImage;
            pctExplosion.Location = ultimaPosicionEnemigoDestruido;

            FrmJuego.Controls.Add(pctExplosion);
            pctExplosion.BringToFront();

            Timer timerExplosion = new Timer();
            timerExplosion.Interval = 300;
            timerExplosion.Tick += (sender, arges) =>
            {
                FrmJuego.Controls.Remove(pctExplosion);
                pctExplosion.Dispose();

                timerExplosion.Stop();
            };
            timerExplosion.Start();          
        }
    }
}
