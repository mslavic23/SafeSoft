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
        private const int PrvaGodina = 2000;
        private const int ZadnjaGodina = 2026;

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

            cmbSoftwareVersion.Items.Clear();
            for (int godina = ZadnjaGodina; godina >= PrvaGodina; godina--)
            {
                cmbSoftwareVersion.Items.Add(godina.ToString());
            }
            cmbSoftwareVersion.SelectedIndex = 0;

            RefreshList();
        }

        private void RefreshList()
        {
            var softveri = _softverRepository.GetAll();

            dgvSoftwares.DataSource = null;
            dgvSoftwares.AutoGenerateColumns = true;
            dgvSoftwares.DataSource = softveri;

            if (dgvSoftwares.Columns.Contains("Naziv"))
                dgvSoftwares.Columns["Naziv"].HeaderText = "Naziv";
            if (dgvSoftwares.Columns.Contains("Verzija"))
                dgvSoftwares.Columns["Verzija"].HeaderText = "Verzija";
            if (dgvSoftwares.Columns.Contains("Tip_licence"))
                dgvSoftwares.Columns["Tip_licence"].HeaderText = "Tip licence";
            if (dgvSoftwares.Columns.Contains("Ukupno_mjesta"))
                dgvSoftwares.Columns["Ukupno_mjesta"].HeaderText = "Ukupno mjesta";
            if (dgvSoftwares.Columns.Contains("ID_softver"))
                dgvSoftwares.Columns["ID_softver"].Visible = false;
        }

        private void ClearFields()
        {
            txtSoftwareName.Text = "";
            cmbSoftwareVersion.SelectedIndex = 0;
            cmbLicenceType.SelectedIndex = 0;
            numTotalSeats.Value = PerSeatMjesta;
        }

        private void CmbLicenceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipLicence = cmbLicenceType.SelectedItem as string;
            if (tipLicence == null)
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

        private void CmbSoftwareVersion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NumTotalSeats_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string naziv = txtSoftwareName.Text;
            string verzija = cmbSoftwareVersion.SelectedItem as string;
            string tipLicence = cmbLicenceType.SelectedItem as string;

            if (string.IsNullOrEmpty(naziv) || verzija == null || tipLicence == null)
            {
                MessageBox.Show("Molimo popunite naziv i odaberite verziju i tip licence!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            string verzija = cmbSoftwareVersion.SelectedItem as string;
            string tipLicence = cmbLicenceType.SelectedItem as string;

            if (string.IsNullOrEmpty(naziv) || verzija == null || tipLicence == null)
            {
                MessageBox.Show("Molimo popunite naziv i odaberite verziju i tip licence!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void DgvSoftwares_SelectionChanged(object sender, EventArgs e)
        {
            _odabraniSoftver = dgvSoftwares.CurrentRow?.DataBoundItem as Softver;
        }

        private void DgvSoftwares_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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