using System;
using System.Windows.Forms;
using LicenceApp.Models;
using LicenceApp.Repositories;

namespace LicenceApp
{
    public partial class FrmSoftware : Form
    {
        private readonly SoftwareRepository _softwareRepository = new SoftwareRepository();
        private Software _selectedSoftware;

        private const string LicenceTypePerSeat = "per-seat";
        private const string LicenceTypeMonthly = "mjesečna-pretplata";
        private const string LicenceTypeYearly = "godišnja-pretplata";
        private const int PerSeatCount = 50;
        private const int FirstYear = 2000;
        private const int LastYear = 2026;

        public FrmSoftware()
        {
            InitializeComponent();
        }

        private void FrmSoftware_Load(object sender, EventArgs e)
        {
            numTotalSeats.Minimum = 1;
            numTotalSeats.Maximum = 100000;

            cmbLicenceType.Items.Clear();
            cmbLicenceType.Items.Add(LicenceTypePerSeat);
            cmbLicenceType.Items.Add(LicenceTypeMonthly);
            cmbLicenceType.Items.Add(LicenceTypeYearly);
            cmbLicenceType.SelectedIndex = 0;

            cmbSoftwareVersion.Items.Clear();
            for (int year = LastYear; year >= FirstYear; year--)
            {
                cmbSoftwareVersion.Items.Add(year.ToString());
            }
            cmbSoftwareVersion.SelectedIndex = 0;

            RefreshList();
        }

        private void RefreshList()
        {
            var softwares = _softwareRepository.GetAll();

            dgvSoftwares.DataSource = null;
            dgvSoftwares.AutoGenerateColumns = true;
            dgvSoftwares.DataSource = softwares;

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
            numTotalSeats.Value = PerSeatCount;
        }

        private void CmbLicenceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cmbLicenceType.SelectedItem is string licenceType))
                return;

            if (licenceType == LicenceTypePerSeat)
            {
                numTotalSeats.Value = PerSeatCount;
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
            string name = txtSoftwareName.Text;

            if (!(cmbSoftwareVersion.SelectedItem is string version) || !(cmbLicenceType.SelectedItem is string licenceType) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Molimo popunite naziv i odaberite verziju i tip licence!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Software software = new Software
            {
                Naziv = name,
                Verzija = version,
                Tip_licence = licenceType,
                Ukupno_mjesta = (int)numTotalSeats.Value
            };

            bool success = _softwareRepository.Add(software);

            if (success)
            {
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
            if (_selectedSoftware == null)
            {
                MessageBox.Show("Odaberite softver s liste za uređivanje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtSoftwareName.Text;

            if (!(cmbSoftwareVersion.SelectedItem is string version) || !(cmbLicenceType.SelectedItem is string licenceType) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Molimo popunite naziv i odaberite verziju i tip licence!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Software software = new Software
            {
                ID_softver = _selectedSoftware.ID_softver,
                Naziv = name,
                Verzija = version,
                Tip_licence = licenceType,
                Ukupno_mjesta = (int)numTotalSeats.Value
            };

            bool success = _softwareRepository.Update(software);

            if (success)
            {
                MessageBox.Show("Softver uspješno ažuriran!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                RefreshList();
                _selectedSoftware = null;
            }
            else
            {
                MessageBox.Show("Greška prilikom ažuriranja softvera!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedSoftware == null)
            {
                MessageBox.Show("Odaberite softver s liste za brisanje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmation = MessageBox.Show(
                $"Jeste li sigurni da želite obrisati softver {_selectedSoftware.Naziv}?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
                return;

            bool success = _softwareRepository.Delete(_selectedSoftware.ID_softver);

            if (success)
            {
                ClearFields();
                RefreshList();
                _selectedSoftware = null;
            }
            else
            {
                MessageBox.Show("Greška prilikom brisanja softvera!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvSoftwares_SelectionChanged(object sender, EventArgs e)
        {
            _selectedSoftware = dgvSoftwares.CurrentRow?.DataBoundItem as Software;
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









