namespace pryLeandroFernandez2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
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
    }
}
