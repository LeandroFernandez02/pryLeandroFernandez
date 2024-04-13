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
    public partial class frmFirma : Form
    {
        private bool dibujando = false;
        private Point dibujoPrevio;
        private Bitmap firmaBitmap = new Bitmap(382, 217);

        public frmFirma()
        {
            InitializeComponent();

            using (Graphics papel = Graphics.FromImage(firmaBitmap))
            {
                papel.Clear(Color.White);
            }
            pctFirma.Image = firmaBitmap;

            // Configuro pct para que acepte los movimientos del mouse
            pctFirma.MouseDown += pctFirma_MouseDown;
            pctFirma.MouseUp += pctFirma_MouseUp;
            pctFirma.MouseMove += pctFirma_MouseMove;

            pctFirma.Enabled = false;
        }


        private void pctFirma_MouseDown(object sender, MouseEventArgs e)
        {
            // Cuando apreto click empieza a "firmar"
            dibujando = true;
            dibujoPrevio = e.Location;
        }

        private void pctFirma_MouseUp(object sender, MouseEventArgs e)
        {
            // Cuando dejo de apretar no deja de "firmar"
            dibujando = false;
        }

        private void pctFirma_MouseMove(object sender, MouseEventArgs e)
        {
            //Pregunto si esta dibujando
            if (dibujando)
            {
                // En caso de pasar la condicion llamo a la clase graphics y creo el objeto "papelFirma" y el asigno el "pctFirma"
                using (Graphics papelFirma = Graphics.FromImage(firmaBitmap))
                {
                    // Creo el lapiz para hacer la firma
                    Pen lapizFirma = new Pen(Color.Black);
                    papelFirma.DrawLine(lapizFirma, dibujoPrevio, e.Location);
                    dibujoPrevio = e.Location;
                }
                pctFirma.Refresh();
            }
        }

        private void brnGrabar_Click(object sender, EventArgs e)
        {           
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres guardar la firma?", "Confirmación", MessageBoxButtons.OKCancel);

            if (resultado == DialogResult.OK)
            {
                using (SaveFileDialog ventanaArchivos = new SaveFileDialog())
                {
                    ventanaArchivos.Filter = "JPEG Image|*.jpg";
                    ventanaArchivos.Title = "Imagen de Firma";

                    if (ventanaArchivos.ShowDialog() == DialogResult.OK)
                    {
                        firmaBitmap.Save(ventanaArchivos.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                }

                using (Graphics papel = Graphics.FromImage(firmaBitmap))
                {
                    papel.Clear(Color.White);
                }
                pctFirma.Refresh();
            }           
        }

        private void btnFirmar_Click(object sender, EventArgs e)
        {
            pctFirma.Enabled = true;
            if (btnFirmar.Text == "Firmar")
            {
                btnFirmar.Text = "Detener";
                
            }
            else if (btnFirmar.Text == "Detener")
            {
                pctFirma.Enabled = false;
                btnFirmar.Text = "Firmar";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            using (Graphics papel = Graphics.FromImage(firmaBitmap))
            {
                papel.Clear(Color.White);
            }
            pctFirma.Refresh();
        }
    }
}
