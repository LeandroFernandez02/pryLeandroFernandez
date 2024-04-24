using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;
using System.Media;
using System.Runtime.Intrinsics.X86;
using Microsoft.VisualBasic;

namespace pryLeandroFernandez2
{
    public class clsJugador
    {
        private Timer timerDisparo;
        private List<PictureBox> listaDisparos;      
        private clsEnemigo objEnemigo;
        private frmJuego FrmJuego;       
        private Timer timerMoverEnemigo;
        private Timer timerGeneradorEnemigo;
        private int varContador;
        bool enemigoDestruido = false;

        // Constructor
        public clsJugador(clsEnemigo enemigo, frmJuego frmJuego, Timer timerMoverEnemigo, Timer timerGeneradorEnemigo)
        {            
            timerDisparo = new Timer();
            timerDisparo.Interval = 1;
            timerDisparo.Tick += timerDisparo_Tick;

            listaDisparos = new List<PictureBox>();            

            this.objEnemigo = enemigo;
            FrmJuego = frmJuego;
            this.timerMoverEnemigo = timerMoverEnemigo;
            this.timerGeneradorEnemigo = timerGeneradorEnemigo;
        }

        public Timer TimerDisparo
        {
            get { return timerDisparo; }
        }

        public Timer TimerMoverEnemigo
        {
            get { return timerMoverEnemigo; }
        }

        // Metodo mover
        public void mover(PictureBox nave, KeyEventArgs e)
        {
            PictureBox pctNave = new PictureBox();
            pctNave = nave;

            switch (e.KeyCode)
            {
                case Keys.Left:

                    if (pctNave.Left >= 10)
                    {
                        pctNave.Left -= 30;
                    }
                    break;

                case Keys.Right:
                    if (pctNave.Right <= 780)
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

            SoundPlayer sonidoDisparo = new SoundPlayer();
            sonidoDisparo.Stream = pryLeandroFernandez3.Properties.Resources.disparo_nave;
            sonidoDisparo.Play();

            listaDisparos.Add(pctDisparo); // Agrega el nuevo disparo a la lista
            if (!timerDisparo.Enabled)
            {
                timerDisparo.Start();
            }
        }

        private Point ultimaPosicionEnemigoDestruido;

        public void timerDisparo_Tick(object sender, EventArgs e)
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

        //int varVida = 3;
        //bool gameOver = false;
        //bool colisionOcurrida = false; // Variable para rastrear si ya ocurrió una colisión

        //public void colisionNavePrincipal(PictureBox nave, PictureBox vidaUno, PictureBox vidaDos, PictureBox vidaTres)
        //{
        //    // Crear un temporizador para controlar la colisión
        //    Timer timerControlColision = new Timer();
        //    timerControlColision.Interval = 100;

        //    // Evento que se ejecuta cada vez que el temporizador hace tick
        //    timerControlColision.Tick += (sender, arges) =>
        //    {
        //        // Verificar si el juego ha terminado
        //        if (!gameOver)
        //        {
        //            // Iterar sobre los enemigos para verificar colisiones
        //            foreach (var enemigo in objEnemigo.ObtenerListaEnemigos())
        //            {
        //                if (enemigo.Bounds.IntersectsWith(nave.Bounds))
        //                {
        //                    // Acciones a realizar en caso de colisión
        //                    if (!colisionOcurrida)
        //                    {
        //                        // Si hay vidas restantes, quitar una vida
        //                        if (varVida > 0)
        //                        {
        //                            varVida--;
        //                            // Remover la representación visual de la vida correspondiente
        //                            switch (varVida)
        //                            {
        //                                case 2:
        //                                    FrmJuego.Controls.Remove(vidaTres);
        //                                    break;
        //                                case 1:
        //                                    FrmJuego.Controls.Remove(vidaDos);
        //                                    break;
        //                                case 0:
        //                                    FrmJuego.Controls.Remove(vidaUno);
        //                                    gameOver = true; // Marcar el final del juego
        //                                    MessageBox.Show("Game Over");
        //                                    break;
        //                            }
        //                        }
        //                        // Marcar que ya ocurrió una colisión para evitar múltiples descuentos de vida en un solo tick
        //                        colisionOcurrida = true;
        //                    }
        //                    // Salir del bucle ya que se detectó una colisión
        //                    break;
        //                }
        //                else
        //                {
        //                    // Reiniciar la variable de colisión para la próxima iteración si no hay colisión
        //                    colisionOcurrida = false;
        //                }
        //            }
        //        }
        //    };

        //    // Iniciar el temporizador
        //    timerControlColision.Start();
        //}

        int vidasRestantes = 3;
        bool gameOver = false;
        bool colisionDetectada = false;

        public void colisionNavePrincipal(PictureBox nave, PictureBox vidaUno, PictureBox vidaDos, PictureBox vidaTres)
        {
            Timer timerControlColision = new Timer();
            timerControlColision.Interval = 400;

            // Manejador de eventos para la detección de colisiones
            timerControlColision.Tick += (sender, arges) =>
            {
                if (!gameOver)
                {
                    // Iterar sobre los enemigos para verificar colisiones
                    foreach (var enemigo in objEnemigo.ObtenerListaEnemigos())
                    {
                        if (enemigo.Bounds.IntersectsWith(nave.Bounds))
                        {   
                            // Si es la primera colisión después de un tiempo, descontar una vida
                            if (!colisionDetectada)
                            {
                                colisionDetectada = true;
                                if (vidasRestantes > 0)
                                {
                                    vidasRestantes--;
                                    // Remover la representación visual de la vida correspondiente
                                    switch (vidasRestantes)
                                    {
                                        case 2:
                                            FrmJuego.Controls.Remove(vidaTres);
                                            break;
                                        case 1:
                                            FrmJuego.Controls.Remove(vidaDos);
                                            break;
                                        case 0:
                                            FrmJuego.Controls.Remove(vidaUno);
                                            gameOver = true;
                                            timerDisparo.Stop();
                                            timerMoverEnemigo.Stop();
                                            timerControlColision.Stop();
                                            timerGeneradorEnemigo.Stop();
                                            MessageBox.Show("Game Over");
                                            break;
                                    }
                                }
                            }
                            break; // Salir del bucle ya que se detectó una colisión
                        }
                        else
                        {
                            // Si no hay colisión, resetear el indicador de colisión detectada
                            colisionDetectada = false;
                        }
                    }
                }
            };

            timerControlColision.Start();
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

            SoundPlayer sonidoExplosion = new SoundPlayer();
            Random rnd = new Random();
            rnd.Next(1, 5);
            switch (rnd.Next(1, 5))
            {
                case 1:                   
                    sonidoExplosion.Stream = pryLeandroFernandez3.Properties.Resources.enemigo_1;
                    sonidoExplosion.Play();
                    break;
                case 2:
                    sonidoExplosion.Stream = pryLeandroFernandez3.Properties.Resources.enemigo2;
                    sonidoExplosion.Play();
                    break;
                case 3:
                    sonidoExplosion.Stream = pryLeandroFernandez3.Properties.Resources.enemigo31;
                    sonidoExplosion.Play();
                    break;
                case 4:
                    sonidoExplosion.Stream = pryLeandroFernandez3.Properties.Resources.enemigo41;
                    sonidoExplosion.Play();
                    break;
            }

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
