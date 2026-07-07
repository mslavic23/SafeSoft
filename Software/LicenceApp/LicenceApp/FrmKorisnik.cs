using System;
using System.Windows.Forms;
using LicenceApp.Models;
using LicenceApp.Repositories;

namespace LicenceApp
{
    public partial class FrmKorisnik : Form
    {
        private readonly KorisnikRepository _korisnikRepository = new KorisnikRepository();
        private Korisnik _odabraniKorisnik;

        public FrmKorisnik()
        {
            InitializeComponent();
        }

        private void FrmKorisnik_Load(object sender, EventArgs e)
        {
            cmbUserRole.Items.Clear();
            cmbUserRole.Items.Add("Administrator");
            cmbUserRole.Items.Add("Korisnik");

            OsvjeziListu();
        }

        private void OsvjeziListu()
        {
            lstUsers.Items.Clear();
            foreach (var korisnik in _korisnikRepository.GetAll())
            {
                lstUsers.Items.Add(korisnik);
            }
        }

        private void OcistiPolja()
        {
            txtUserName.Text = "";
            txtUserLastName.Text = "";
            txtUserEmail.Text = "";
            txtUserPassword.Text = "";
            cmbUserRole.SelectedIndex = -1;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string ime = txtUserName.Text;
            string prezime = txtUserLastName.Text;
            string email = txtUserEmail.Text;
            string lozinka = txtUserPassword.Text;

            if (!(cmbUserRole.SelectedItem is string uloga) || string.IsNullOrEmpty(ime) || string.IsNullOrEmpty(prezime) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(lozinka))
            {
                MessageBox.Show("Molimo popunite sva polja i odaberite ulogu!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Korisnik korisnik = new Korisnik
            {
                Ime = ime,
                Prezime = prezime,
                Email = email,
                LozinkaHash = lozinka,
                Uloga = uloga
            };

            bool uspjeh = _korisnikRepository.Add(korisnik);

            if (uspjeh)
            {
                MessageBox.Show("Korisnik uspješno dodan!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OcistiPolja();
                OsvjeziListu();
            }
            else
            {
                MessageBox.Show("Greška prilikom dodavanja korisnika!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (_odabraniKorisnik == null)
            {
                MessageBox.Show("Odaberite korisnika s liste za uređivanje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ime = txtUserName.Text;
            string prezime = txtUserLastName.Text;
            string email = txtUserEmail.Text;
            string lozinka = txtUserPassword.Text;

            if (!(cmbUserRole.SelectedItem is string uloga) || string.IsNullOrEmpty(ime) || string.IsNullOrEmpty(prezime) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Molimo popunite Ime, Prezime, Email i odaberite ulogu!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Korisnik korisnik = new Korisnik
            {
                ID_korisnik = _odabraniKorisnik.ID_korisnik,
                Ime = ime,
                Prezime = prezime,
                Email = email,
                LozinkaHash = lozinka,
                Uloga = uloga
            };

            bool uspjeh = _korisnikRepository.Update(korisnik);

            if (uspjeh)
            {
                MessageBox.Show("Korisnik uspješno ažuriran!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OcistiPolja();
                OsvjeziListu();
                _odabraniKorisnik = null;
            }
            else
            {
                MessageBox.Show("Greška prilikom ažuriranja korisnika!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_odabraniKorisnik == null)
            {
                MessageBox.Show("Odaberite korisnika s liste za brisanje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult potvrda = MessageBox.Show(
                $"Jeste li sigurni da želite obrisati korisnika {_odabraniKorisnik.Ime} {_odabraniKorisnik.Prezime}?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (potvrda != DialogResult.Yes)
                return;

            bool uspjeh = _korisnikRepository.Delete(_odabraniKorisnik.ID_korisnik);

            if (uspjeh)
            {
                MessageBox.Show("Korisnik uspješno obrisan!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OcistiPolja();
                OsvjeziListu();
                _odabraniKorisnik = null;
            }
            else
            {
                MessageBox.Show("Greška prilikom brisanja korisnika!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LstKorisnici_SelectedIndexChanged(object sender, EventArgs e)
        {
            _odabraniKorisnik = lstUsers.SelectedItem as Korisnik;
        }

        private void BtnMain_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();
        }

        private void PbxLogo_Click(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblUserName_Click(object sender, EventArgs e)
        {

        }

        private void LblUserLastName_Click(object sender, EventArgs e)
        {

        }

        private void LblUserEmail_Click(object sender, EventArgs e)
        {

        }

        private void LblUserPassword_Click(object sender, EventArgs e)
        {

        }

        private void LblUserRole_Click(object sender, EventArgs e)
        {

        }

        private void TxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUserLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUserEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmbUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}