using System;
using System.Windows.Forms;
using LicenceApp.Models;
using LicenceApp.Repositories;

namespace LicenceApp
{
    public partial class FrmSoftver : Form
    {
        private readonly SoftverRepository _softverRepository = new SoftverRepository();
        private Softver _odabraniSoftver;

        private const string TipPerSeat = "per-seat";
        private const string TipMjesecnaPretplata = "mjesečna-pretplata";
        private const string TipGodisnjaPretplata = "godišnja-pretplata";
        private const int PerSeatMjesta = 50;

        public FrmSoftver()
        {
            InitializeComponent();
        }

        private void FrmSoftver_Load(object sender, EventArgs e)
        {
            numTotalSeats.Minimum = 1;
            numTotalSeats.Maximum = 100000;

            cmbLicenceType.Items.Clear();
            cmbLicenceType.Items.Add(TipPerSeat);
            cmbLicenceType.Items.Add(TipMjesecnaPretplata);
            cmbLicenceType.Items.Add(TipGodisnjaPretplata);
            cmbLicenceType.SelectedIndex = 0;

            RefreshList();
        }

        private void RefreshList()
        {
            lstSoftwares.Items.Clear();
            foreach (var softver in _softverRepository.GetAll())
            {
                lstSoftwares.Items.Add(softver);
            }
        }

        private void ClearFields()
        {
            txtSoftwareName.Text = "";
            txtSofwareVersion.Text = "";
            cmbLicenceType.SelectedIndex = 0;
            numTotalSeats.Value = PerSeatMjesta;
        }

        private void CmbLicenceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cmbLicenceType.SelectedItem is string tipLicence))
                return;

            if (tipLicence == TipPerSeat)
            {
                numTotalSeats.Value = PerSeatMjesta;
                numTotalSeats.Enabled = false;
            }
            else
            {
                numTotalSeats.Enabled = true;
                numTotalSeats.Value = numTotalSeats.Minimum;
            }
        }

        private void NumTotalSeats_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string naziv = txtSoftwareName.Text;
            string verzija = txtSofwareVersion.Text;

            if (!(cmbLicenceType.SelectedItem is string tipLicence) || string.IsNullOrEmpty(naziv) || string.IsNullOrEmpty(verzija))
            {
                MessageBox.Show("Molimo popunite sva polja i odaberite tip licence!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Softver softver = new Softver
            {
                Naziv = naziv,
                Verzija = verzija,
                Tip_licence = tipLicence,
                Ukupno_mjesta = (int)numTotalSeats.Value
            };

            bool uspjeh = _softverRepository.Add(softver);

            if (uspjeh)
            {
                MessageBox.Show("Softver uspješno dodan!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                RefreshList();
            }
            else
            {
                MessageBox.Show("Greška prilikom dodavanja softvera!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (_odabraniSoftver == null)
            {
                MessageBox.Show("Odaberite softver s liste za uređivanje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string naziv = txtSoftwareName.Text;
            string verzija = txtSofwareVersion.Text;

            if (!(cmbLicenceType.SelectedItem is string tipLicence) || string.IsNullOrEmpty(naziv) || string.IsNullOrEmpty(verzija))
            {
                MessageBox.Show("Molimo popunite sva polja i odaberite tip licence!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Softver softver = new Softver
            {
                ID_softver = _odabraniSoftver.ID_softver,
                Naziv = naziv,
                Verzija = verzija,
                Tip_licence = tipLicence,
                Ukupno_mjesta = (int)numTotalSeats.Value
            };

            bool uspjeh = _softverRepository.Update(softver);

            if (uspjeh)
            {
                MessageBox.Show("Softver uspješno ažuriran!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                RefreshList();
                _odabraniSoftver = null;
            }
            else
            {
                MessageBox.Show("Greška prilikom ažuriranja softvera!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_odabraniSoftver == null)
            {
                MessageBox.Show("Odaberite softver s liste za brisanje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult potvrda = MessageBox.Show(
                $"Jeste li sigurni da želite obrisati softver {_odabraniSoftver.Naziv}?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (potvrda != DialogResult.Yes)
                return;

            bool uspjeh = _softverRepository.Delete(_odabraniSoftver.ID_softver);

            if (uspjeh)
            {
                MessageBox.Show("Softver uspješno obrisan!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                RefreshList();
                _odabraniSoftver = null;
            }
            else
            {
                MessageBox.Show("Greška prilikom brisanja softvera!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LstSoftwares_SelectedIndexChanged(object sender, EventArgs e)
        {
            _odabraniSoftver = lstSoftwares.SelectedItem as Softver;
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

        private void LblTotalSeats_Click(object sender, EventArgs e)
        {

        }

        private void LblLicenceType_Click(object sender, EventArgs e)
        {

        }

        private void TxtSofwareVersion_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblSoftwareVersion_Click(object sender, EventArgs e)
        {

        }

        private void TxtSoftwareName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblSoftwareName_Click(object sender, EventArgs e)
        {

        }
    }
}