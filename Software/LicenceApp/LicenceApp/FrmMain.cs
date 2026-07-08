using System;
using System.Windows.Forms;

namespace LicenceApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FrmSoftware frmSoftver = new FrmSoftware();
            frmSoftver.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FrmZahtjev frmZahtjev = new FrmZahtjev();
            frmZahtjev.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            FrmUredaj frmUredaj = new FrmUredaj();
            frmUredaj.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            FrmIzvjestaj frmIzvjestaj = new FrmIzvjestaj();
            frmIzvjestaj.Show();
            this.Hide();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            FrmUser frmKorisnik = new FrmUser();
            frmKorisnik.Show();
            this.Hide();
        }

        private void BtnOdjava_Click(object sender, EventArgs e)
        {
            SessionManager.User = null;

            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            bool jeAdmin = SessionManager.User != null && SessionManager.User.Uloga == "Administrator";

            if (!jeAdmin)
            {
                btnSoftwares.Enabled = false;
                btnDevices.Enabled = false;
                btnUsers.Enabled = false;
            }
        }

        private void PbxLogo_Click(object sender, EventArgs e)
        {

        }
    }
}