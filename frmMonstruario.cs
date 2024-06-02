using Newtonsoft.Json.Linq;
using System.Net.Http;
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
        clsAPI objAPI;

        public frmMonstruario()
        {
            InitializeComponent();
            objConexionBD = new clsConexionBD();
            objAPI = new clsAPI();
        }

        private void frmMonstruario_Load(object sender, EventArgs e)
        {
            // cargar treeView
            objConexionBD.cargarTrv(trvMonstruario, tspConexionBD);
        }

        private async void trvMonstruario_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // seleccionar monstruo ETAPA 7
            objConexionBD.seleccionarNodo(e, lblArmadura, lblFortaleza, lblSabiduria, lblInteligencia, lblDestreza);

            // seleccionar monstruo ETAPA 8 (API)
            objAPI.seleccionarMonstruo(e,lstAPI);
        }
    }
}
