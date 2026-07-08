using System;
using System.Drawing;
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
            FrmRequestApp frmZahtjev = new FrmRequestApp();
            frmZahtjev.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            FrmDevice frmUredaj = new FrmDevice();
            frmUredaj.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            FrmReport frmIzvjestaj = new FrmReport();
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

                btnSoftwares.BackColor = Color.White;
                btnDevices.BackColor = Color.White;
                btnUsers.BackColor = Color.White;
            }
        }

        private void PbxLogo_Click(object sender, EventArgs e)
        {

        }
    }
}