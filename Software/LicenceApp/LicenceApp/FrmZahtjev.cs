using System;
using System.Linq;
using System.Windows.Forms;
using LicenceApp.Models;
using LicenceApp.Repositories;

namespace LicenceApp
{
    public partial class FrmZahtjev : Form
    {
        private readonly ZahtjevRepository _zahtjevRepository = new ZahtjevRepository();
        private readonly UserRepository _korisnikRepository = new UserRepository();
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
            var zahtjevi = _zahtjevRepository.GetAll();
            var korisnici = _korisnikRepository.GetAll();
            var softveri = _softverRepository.GetAll();
            var uredaji = _uredajRepository.GetAll();

            dgvRequestApp.Rows.Clear();

            foreach (var zahtjev in zahtjevi)
            {
                var korisnik = korisnici.FirstOrDefault(k => k.ID_korisnik == zahtjev.ID_korisnik);
                var softver = softveri.FirstOrDefault(s => s.ID_softver == zahtjev.ID_softver);
                var uredaj = uredaji.FirstOrDefault(u => u.ID_uredaj == zahtjev.ID_uredaj);

                dgvRequestApp.Rows.Add(
                    zahtjev.ID_zahtjev,
                    korisnik != null ? $"{korisnik.Ime} {korisnik.Prezime}" : "",
                    softver != null ? softver.Naziv : "",
                    uredaj != null ? uredaj.Naziv_racunala : "",
                    zahtjev.Razlog_koristenja,
                    zahtjev.Datum_podnosenja.ToString("dd.MM.yyyy.")
                );
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
            if (!(cmbUserName.SelectedItem is User korisnik) || !(cmbSoftwareName.SelectedItem is Softver softver) || !(cmbDeviceName.SelectedItem is Uredaj uredaj) || string.IsNullOrEmpty(txtRequestReason.Text))
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

            if (!(cmbUserName.SelectedItem is User korisnik) || !(cmbSoftwareName.SelectedItem is Softver softver) || !(cmbDeviceName.SelectedItem is Uredaj uredaj) || string.IsNullOrEmpty(txtRequestReason.Text))
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

        private void DgvRequestApp_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRequestApp.CurrentRow == null)
            {
                _odabraniZahtjev = null;
                return;
            }

            int id = (int)dgvRequestApp.CurrentRow.Cells["colZahtjevId"].Value;
            _odabraniZahtjev = _zahtjevRepository.GetAll().FirstOrDefault(z => z.ID_zahtjev == id);
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