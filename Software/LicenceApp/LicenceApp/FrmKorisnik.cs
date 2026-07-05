using System;
using System.Windows.Forms;

namespace LicenceApp
{
    public partial class FrmKorisnik : Form
    {
        public FrmKorisnik()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void LstKorisnici_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void BtnMain_Click(object sender, EventArgs e)
        {

        }

        private void PbxLogo_Click(object sender, EventArgs e)
        {

        }
    }
}