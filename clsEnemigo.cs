using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;
using System.Media;



namespace pryLeandroFernandez2
{
    public class clsEnemigo
    {
        public Timer timerMover;
        private List<PictureBox> listaEnemigos;
        public PictureBox pctEnemigo;
        Timer timerGeneradorEnemigos = new Timer();
        int intervaloInicial = 1500; // Intervalo inicial del temporizador en milisegundos
        int intervaloMinimo = 800; // Intervalo mínimo del temporizador en milisegundos

        // Constructor
        public clsEnemigo()
        {
            timerMover = new Timer();
            timerMover.Interval = 1;
            timerMover.Tick += timerMover_Tick;

            listaEnemigos = new List<PictureBox>(); 
        }

        public Timer TimerGeneradorEnemigo
        {
            get { return timerGeneradorEnemigos; }
        }
   
        // Metodo mover
        public void mover(frmJuego FrmJuego)
        {           
            timerGeneradorEnemigos.Interval = 1500; // dos segundos
            timerGeneradorEnemigos.Tick += (sender, arges) =>
            {
                crearEnemigo(FrmJuego);
            };
            timerGeneradorEnemigos.Start();           
        }

        // Funion crearEnemigo
        void crearEnemigo(frmJuego FrmJuego)
        {
            pctEnemigo = new PictureBox();

            Random rnd = new Random();
            rnd.Next(1,8);
            int randomX = rnd.Next(0, FrmJuego.ClientSize.Width - pctEnemigo.Width);            

            switch (rnd.Next(1,8))
            {
                case 1:
                    pctEnemigo.Image = pryLeandroFernandez3.Properties.Resources.galaga_enemigo_removebg_preview;
                    pctEnemigo.Size = new Size(50, 50);
                    break;
                case 2:
                    pctEnemigo.Image = pryLeandroFernandez3.Properties.Resources.galaga_enemigo2_removebg_preview;
                    pctEnemigo.Size = new Size(60, 60);
                    break;
                case 3:
                    pctEnemigo.Image = pryLeandroFernandez3.Properties.Resources.enemigo3;
                    pctEnemigo.Size = new Size(50, 50);
                    break;
                case 4:
                    pctEnemigo.Image = pryLeandroFernandez3.Properties.Resources.enemigo4;
                    pctEnemigo.Size = new Size(50, 50);
                    break;
                case 5:
                    pctEnemigo.Image = pryLeandroFernandez3.Properties.Resources.enemigo5;
                    pctEnemigo.Size = new Size(40, 40);
                    break;
                case 6:
                    pctEnemigo.Image = pryLeandroFernandez3.Properties.Resources.enemigo6;
                    pctEnemigo.Size = new Size(50, 50);
                    break;
                case 7:
                    pctEnemigo.Image = pryLeandroFernandez3.Properties.Resources.enemigo7;
                    pctEnemigo.Size = new Size(50, 50);
                    break;               
            }
            //pctEnemigo.Size = new Size(50, 50);
            pctEnemigo.BackColor = Color.Black;
            pctEnemigo.SizeMode = PictureBoxSizeMode.StretchImage;
            pctEnemigo.Location = new Point(randomX, -50);
            FrmJuego.Controls.Add(pctEnemigo);
            pctEnemigo.BringToFront();

            listaEnemigos.Add(pctEnemigo);

            if (timerGeneradorEnemigos.Interval > intervaloMinimo)
            {
                timerGeneradorEnemigos.Interval -= 20; // Reducir el intervalo en 50 milisegundos
            }

            if (!timerMover.Enabled == true)
            {
                timerMover.Start();
            }
        }     

        // Procedimiento timerMover
        private void timerMover_Tick(object sender, EventArgs e)
        {
            foreach (var enemigo in listaEnemigos.ToList())
            {
                enemigo.Top += 2; // Velocidad

                if (enemigo.Top >= 500)
                {
                    // Remover el PictureBox del disparo del formulario y de la lista
                    listaEnemigos.Remove(enemigo);
                    if(enemigo.Parent != null)
                    {
                        enemigo.Parent.Controls.Remove(enemigo);
                    }                   
                    enemigo.Dispose();
                }
            }
        }

        public List<PictureBox> ObtenerListaEnemigos()
        {
            return listaEnemigos;
        }
    }
}
