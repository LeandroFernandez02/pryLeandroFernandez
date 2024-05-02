using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLeandroFernandez3
{
    public partial class frmMonstruario : Form
    {
        clsConexionBD objConexionBD;
        public frmMonstruario()
        {
            InitializeComponent();

            objConexionBD = new clsConexionBD();
        }

        private void frmMonstruario_Load(object sender, EventArgs e)
        {
            objConexionBD.cargarTrv(trvMonstruario, tspConexionBD);
            trvMonstruario.NodeMouseDoubleClick += (s, ev) => objConexionBD.TreeView_NodeMouseDoubleClick(s, ev, lblArmadura, lblFortaleza, lblVelocidad, lblInteligencia, lblDestreza);
        }

        private void trvMonstruario_DoubleClick(object sender, EventArgs e)
        {

        }

        private void trvMonstruario_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }
    }
}
