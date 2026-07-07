using System;
using System.Windows.Forms;
using LicenceApp.Models;
using LicenceApp.Repositories;

namespace LicenceApp
{
    public partial class FrmZahtjev : Form
    {
        private readonly ZahtjevRepository _zahtjevRepository = new ZahtjevRepository();
        private readonly KorisnikRepository _korisnikRepository = new KorisnikRepository();
        private readonly SoftverRepository _softverRepository = new SoftverRepository();
        private readonly UredajRepository _uredajRepository = new UredajRepository();

        private Zahtjev _odabraniZahtjev;

        public FrmZahtjev()
        {
            InitializeComponent();
        }

        private void FrmZahtjev_Load(object sender, EventArgs e)
        {
            cmbUserName.Items.Clear();
            foreach (var korisnik in _korisnikRepository.GetAll())
            {
                cmbUserName.Items.Add(korisnik);
            }

            cmbSoftwareName.Items.Clear();
            foreach (var softver in _softverRepository.GetAll())
            {
                cmbSoftwareName.Items.Add(softver);
            }

            cmbDeviceName.Items.Clear();
            foreach (var uredaj in _uredajRepository.GetAll())
            {
                cmbDeviceName.Items.Add(uredaj);
            }

            dtpRequestDate.Value = DateTime.Now;

            RefreshList();
        }

        private void RefreshList()
        {
            lstRequestApp.Items.Clear();
            foreach (var zahtjev in _zahtjevRepository.GetAll())
            {
                lstRequestApp.Items.Add(zahtjev);
            }
        }

        private void ClearFields()
        {
            cmbUserName.SelectedIndex = -1;
            cmbSoftwareName.SelectedIndex = -1;
            cmbDeviceName.SelectedIndex = -1;
            txtRequestReason.Text = "";
            dtpRequestDate.Value = DateTime.Now;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!(cmbUserName.SelectedItem is Korisnik korisnik) || !(cmbSoftwareName.SelectedItem is Softver softver) || !(cmbDeviceName.SelectedItem is Uredaj uredaj) || string.IsNullOrEmpty(txtRequestReason.Text))
            {
                MessageBox.Show("Molimo odaberite korisnika, softver, uređaj i unesite razlog korištenja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!_zahtjevRepository.HasAvailableSeats(softver.ID_softver))
            {
                MessageBox.Show("Nema slobodnih mjesta za odabrani softver!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Zahtjev zahtjev = new Zahtjev
            {
                ID_korisnik = korisnik.ID_korisnik,
                ID_softver = softver.ID_softver,
                ID_uredaj = uredaj.ID_uredaj,
                Razlog_koristenja = txtRequestReason.Text,
                Datum_podnosenja = dtpRequestDate.Value
            };

            bool uspjeh = _zahtjevRepository.Add(zahtjev);

            if (uspjeh)
            {
                MessageBox.Show("Zahtjev uspješno dodan!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                RefreshList();
            }
            else
            {
                MessageBox.Show("Greška prilikom dodavanja zahtjeva!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (_odabraniZahtjev == null)
            {
                MessageBox.Show("Odaberite zahtjev s liste za uređivanje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!(cmbUserName.SelectedItem is Korisnik korisnik) || !(cmbSoftwareName.SelectedItem is Softver softver) || !(cmbDeviceName.SelectedItem is Uredaj uredaj) || string.IsNullOrEmpty(txtRequestReason.Text))
            {
                MessageBox.Show("Molimo odaberite korisnika, softver, uređaj i unesite razlog korištenja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Zahtjev zahtjev = new Zahtjev
            {
                ID_zahtjev = _odabraniZahtjev.ID_zahtjev,
                ID_korisnik = korisnik.ID_korisnik,
                ID_softver = softver.ID_softver,
                ID_uredaj = uredaj.ID_uredaj,
                Razlog_koristenja = txtRequestReason.Text,
                Datum_podnosenja = dtpRequestDate.Value
            };

            bool uspjeh = _zahtjevRepository.Update(zahtjev);

            if (uspjeh)
            {
                MessageBox.Show("Zahtjev uspješno ažuriran!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                RefreshList();
                _odabraniZahtjev = null;
            }
            else
            {
                MessageBox.Show("Greška prilikom ažuriranja zahtjeva!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_odabraniZahtjev == null)
            {
                MessageBox.Show("Odaberite zahtjev s liste za brisanje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult potvrda = MessageBox.Show(
                $"Jeste li sigurni da želite obrisati {_odabraniZahtjev}?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (potvrda != DialogResult.Yes)
                return;

            bool uspjeh = _zahtjevRepository.Delete(_odabraniZahtjev.ID_zahtjev);

            if (uspjeh)
            {
                MessageBox.Show("Zahtjev uspješno obrisan!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                RefreshList();
                _odabraniZahtjev = null;
            }
            else
            {
                MessageBox.Show("Greška prilikom brisanja zahtjeva!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LstRequestApp_SelectedIndexChanged(object sender, EventArgs e)
        {
            _odabraniZahtjev = lstRequestApp.SelectedItem as Zahtjev;
        }

        private void BtnMain_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();
        }

        private void LbSoftwareName_Click(object sender, EventArgs e)
        {

        }

        private void LblRequestReason_Click(object sender, EventArgs e)
        {

        }

        private void PbxLogo_Click(object sender, EventArgs e)
        {

        }

        private void CmbSoftwareName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtRequestReason_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LblRequestDate_Click(object sender, EventArgs e)
        {

        }

        private void LblUserName_Click(object sender, EventArgs e)
        {

        }

        private void LblDeviceName_Click(object sender, EventArgs e)
        {

        }

        private void CmbDeviceName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DtpRequestDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}