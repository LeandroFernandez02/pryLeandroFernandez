using pryLeandroFernandez3;

namespace pryLeandroFernandez2
{
    public partial class frmPrincipal : Form
    {
        clsConexionBD objConexionBD;
        public frmPrincipal()
        {
            InitializeComponent();
            objConexionBD = new clsConexionBD();

        }

        private void mnsFirma_Click(object sender, EventArgs e)
        {
            frmFirma FrmFirma = new frmFirma();
            this.Hide();
            FrmFirma.Show();
        }

        private void mnsGalaga_Click(object sender, EventArgs e)
        {
            frmMenuJuego frmMenuJuego = new frmMenuJuego();
            this.Hide();
            frmMenuJuego.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            objConexionBD.conexionBD(tstpConexionBD);

        }
    }
}
