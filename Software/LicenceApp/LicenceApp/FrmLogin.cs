using System;
using System.Windows.Forms;
using LicenceApp.Repositories;

namespace LicenceApp
{
    public partial class FrmLogin : Form
    {
        private readonly KorisnikRepository _korisnikRepository = new KorisnikRepository();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = txtLoginUser.Text;
            string lozinka = txtLoginPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(lozinka))
            {
                MessageBox.Show("Molimo unesite email i lozinku!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var korisnik = _korisnikRepository.Prijava(email, lozinka);

            if (korisnik != null)
            {
                SessionManager.Korisnik = korisnik;

                MessageBox.Show("Prijava uspješna! Dobrodošli, " + korisnik.Ime + "!", "Prijava", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmMain frmMain = new FrmMain();
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Pogrešno korisničko ime ili lozinka!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PbxAddUser_Click(object sender, EventArgs e)
        {
            FrmKorisnik frmKorisnik = new FrmKorisnik();
            frmKorisnik.Show();
            this.Hide();
        }
    }
}