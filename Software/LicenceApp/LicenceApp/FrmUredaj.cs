using System;
using System.Windows.Forms;
using LicenceApp.Models;
using LicenceApp.Repositories;

namespace LicenceApp
{
    public partial class FrmUredaj : Form
    {
        private readonly UredajRepository _uredajRepository = new UredajRepository();
        private Uredaj _odabraniUredaj;

        public FrmUredaj()
        {
            InitializeComponent();
        }

        private void FrmUredaj_Load(object sender, EventArgs e)
        {
            cmbDeviceLocation.Items.Clear();
            cmbDeviceLocation.Items.Add("ured");
            cmbDeviceLocation.Items.Add("dvorana");
            cmbDeviceLocation.SelectedIndex = 0;

            cmbDeviceType.Items.Clear();
            cmbDeviceType.Items.Add("laptop");
            cmbDeviceType.Items.Add("desktop");
            cmbDeviceType.SelectedIndex = 0;

            RefreshList();
        }

        private void RefreshList()
        {
            lstDevices.Items.Clear();
            foreach (var uredaj in _uredajRepository.GetAll())
            {
                lstDevices.Items.Add(uredaj);
            }
        }

        private void ClearFields()
        {
            txtDeviceName.Text = "";
            cmbDeviceLocation.SelectedIndex = 0;
            cmbDeviceType.SelectedIndex = 0;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string naziv = txtDeviceName.Text;

            if (!(cmbDeviceLocation.SelectedItem is string lokacija) || !(cmbDeviceType.SelectedItem is string tip) || string.IsNullOrEmpty(naziv))
            {
                MessageBox.Show("Molimo popunite naziv i odaberite lokaciju i tip uređaja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Uredaj uredaj = new Uredaj
            {
                Naziv_racunala = naziv,
                Lokacija = lokacija,
                Tip_uredaja = tip
            };

            bool uspjeh = _uredajRepository.Add(uredaj);

            if (uspjeh)
            {
                MessageBox.Show("Uređaj uspješno dodan!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                RefreshList();
            }
            else
            {
                MessageBox.Show("Greška prilikom dodavanja uređaja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (_odabraniUredaj == null)
            {
                MessageBox.Show("Odaberite uređaj s liste za uređivanje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string naziv = txtDeviceName.Text;

            if (!(cmbDeviceLocation.SelectedItem is string lokacija) || !(cmbDeviceType.SelectedItem is string tip) || string.IsNullOrEmpty(naziv))
            {
                MessageBox.Show("Molimo popunite naziv i odaberite lokaciju i tip uređaja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Uredaj uredaj = new Uredaj
            {
                ID_uredaj = _odabraniUredaj.ID_uredaj,
                Naziv_racunala = naziv,
                Lokacija = lokacija,
                Tip_uredaja = tip
            };

            bool uspjeh = _uredajRepository.Update(uredaj);

            if (uspjeh)
            {
                MessageBox.Show("Uređaj uspješno ažuriran!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                RefreshList();
                _odabraniUredaj = null;
            }
            else
            {
                MessageBox.Show("Greška prilikom ažuriranja uređaja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_odabraniUredaj == null)
            {
                MessageBox.Show("Odaberite uređaj s liste za brisanje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult potvrda = MessageBox.Show(
                $"Jeste li sigurni da želite obrisati uređaj {_odabraniUredaj.Naziv_racunala}?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (potvrda != DialogResult.Yes)
                return;

            bool uspjeh = _uredajRepository.Delete(_odabraniUredaj.ID_uredaj);

            if (uspjeh)
            {
                MessageBox.Show("Uređaj uspješno obrisan!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                RefreshList();
                _odabraniUredaj = null;
            }
            else
            {
                MessageBox.Show("Greška prilikom brisanja uređaja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LstDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            _odabraniUredaj = lstDevices.SelectedItem as Uredaj;
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

        private void LblDeviceType_Click(object sender, EventArgs e)
        {

        }

        private void LblDeviceLocation_Click(object sender, EventArgs e)
        {

        }

        private void LblDeviceName_Click(object sender, EventArgs e)
        {

        }

        private void TxtDeviceName_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmbDeviceLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbDeviceType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}