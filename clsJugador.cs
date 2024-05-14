using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;
using System.Media;
using System.Runtime.Intrinsics.X86;
using Microsoft.VisualBasic;
using pryLeandroFernandez3;

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
        private int varPuntaje;
        bool enemigoDestruido = false;
        private Point ultimaPosicionEnemigoDestruido;
        private Point ultimaPosicionNave;

        public string nombresin;               

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
            this.nombresin = frmJuego.varNombre;
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
            ultimaPosicionNave = nave.Location;
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
            pctDisparo.Image = pryLeandroFernandez3.Properties.Resources.disparoGod;
            pctDisparo.Size = new Size(30, 30);
            pctDisparo.BackColor = Color.Black;
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

        // Si sale del formulario o hay colision
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
                                varPuntaje++;
                                FrmJuego.ActualizarPuntaje(varPuntaje);
                            }

                            // Remover disparo de la lista y del formulario
                            listaDisparos.Remove(disparo);
                            FrmJuego.Controls.Remove(disparo);
                            disparo.Dispose();

                            // Sacar posicion de enemigo
                            ultimaPosicionEnemigoDestruido = enemigo.Location;
                            explosionEnemigo();

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

        int vidasRestantes = 3;
        public bool gameOver = false;
        bool colisionDetectada = false;

        public void colisionNavePrincipal(PictureBox nave, PictureBox vidaUno, PictureBox vidaDos, PictureBox vidaTres, Panel pnlGameOver, PictureBox pctGameOver)
        {
            Timer timerControlColision = new Timer();
            timerControlColision.Interval = 200;

            timerControlColision.Tick += (sender, arges) =>
            {
                if (!gameOver)
                {
                    foreach (var enemigo in objEnemigo.ObtenerListaEnemigos())
                    {
                        if (enemigo.Bounds.IntersectsWith(nave.Bounds))
                        {                               
                            if (!colisionDetectada)
                            {
                                colisionDetectada = true;
                                if (vidasRestantes > 0)
                                {
                                    vidasRestantes--;                                   
                                    switch (vidasRestantes)
                                    {
                                        case 2:
                                            // saco vida
                                            FrmJuego.Controls.Remove(vidaTres);
                                            vidaTres.Dispose();
                                            // saco enemigo
                                            FrmJuego.Controls.Remove(enemigo);
                                            objEnemigo.ObtenerListaEnemigos().Remove(enemigo);
                                            enemigo.Dispose();

                                            break;
                                        case 1:
                                            // saco vida
                                            FrmJuego.Controls.Remove(vidaDos);
                                            vidaDos.Dispose();
                                            // saco enemigo
                                            FrmJuego.Controls.Remove(enemigo);
                                            objEnemigo.ObtenerListaEnemigos().Remove(enemigo);
                                            enemigo.Dispose();

                                            break;
                                        // GAME OVER
                                        case 0:
                                            // saco vida
                                            FrmJuego.Controls.Remove(vidaUno);
                                            vidaUno.Dispose();

                                            // saco enemigo
                                            FrmJuego.Controls.Remove(enemigo);
                                            objEnemigo.ObtenerListaEnemigos().Remove(enemigo);
                                            enemigo.Dispose();

                                            // saco la nave principal
                                            FrmJuego.Controls.Remove(nave);
                                            nave.Dispose();

                                            gameOver = true;
                                            timerControlColision.Stop();

                                            // llamo funcion de explsion de la nave
                                            explosionNave(nave, pnlGameOver, pctGameOver);

                                            //BD
                                            cargarBD();
                                            
                                            break;
                                    }
                                }
                            }
                            break;
                        }
                        else
                        {
                            colisionDetectada = false;
                        }
                    }
                }
            };
            timerControlColision.Start();
        }

        

        void explosionNave(PictureBox nave, Panel pnlGameOver, PictureBox pctGameOver)
        {      
            // detener timers
            timerDisparo.Stop();
            timerMoverEnemigo.Stop();           
            timerGeneradorEnemigo.Stop();

            // creo objeto de explosion
            PictureBox pctExplosionNave = new PictureBox();
            pctExplosionNave.Image = pryLeandroFernandez3.Properties.Resources.explosionNave;
            pctExplosionNave .Size = new Size(99, 85);
            pctExplosionNave.BackColor = Color.Black;
            pctExplosionNave.SizeMode = PictureBoxSizeMode.StretchImage;
            pctExplosionNave.Location = ultimaPosicionNave;

            // agrego al formulario
            FrmJuego.Controls.Add(pctExplosionNave);
            pctExplosionNave.BringToFront();  
            
            SoundPlayer sonidoExplosion = new SoundPlayer();
            sonidoExplosion.Stream = pryLeandroFernandez3.Properties.Resources._16_Mistake_Music;
            sonidoExplosion.Play();
            sonidoExplosion.Dispose();

            // timer para mostrar la explosion de la nave principal
            Timer timerExplosionNave = new Timer();
            timerExplosionNave.Interval = 1000;
            timerExplosionNave.Tick += (sender, arges) =>
            {      
                // remuevo objeto de explosion una vez terminado el timer
                FrmJuego.Controls.Remove(pctExplosionNave);
                pctExplosionNave.Dispose();

                timerExplosionNave.Stop();                
               
                pnlGameOver.Visible = true;
                pctGameOver.Enabled = true;
                pnlGameOver.BringToFront();
            };
            timerExplosionNave.Start();
        }

        void explosionEnemigo()
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
                    sonidoExplosion.Dispose();
                    break;
                case 2:
                    sonidoExplosion.Stream = pryLeandroFernandez3.Properties.Resources.enemigo2;
                    sonidoExplosion.Play();
                    sonidoExplosion.Dispose();
                    break;
                case 3:
                    sonidoExplosion.Stream = pryLeandroFernandez3.Properties.Resources.enemigo31;
                    sonidoExplosion.Play();
                    sonidoExplosion.Dispose();
                    break;
                case 4:
                    sonidoExplosion.Stream = pryLeandroFernandez3.Properties.Resources.enemigo41;
                    sonidoExplosion.Play();
                    sonidoExplosion.Dispose();
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
    

        void cargarBD()
        {              
            clsConexionBD objConexionBD = new clsConexionBD();
            objConexionBD.cargarJugadorBD(nombresin, varPuntaje);                      
        }
    }
}
