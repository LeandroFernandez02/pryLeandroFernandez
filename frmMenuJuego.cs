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
    public partial class frmMenuJuego : Form
    {
        public frmMenuJuego()
        {
            InitializeComponent();
        }

        private void pctFondo_Click(object sender, EventArgs e)
        {
            frmJuego frmJuego = new frmJuego();
            this.Hide();
            frmJuego.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmJuego frmJuego = new frmJuego();
            this.Hide();
            frmJuego.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmJuego frmJuego = new frmJuego();
            this.Hide();
            frmJuego.Show();
        }
    }
}
