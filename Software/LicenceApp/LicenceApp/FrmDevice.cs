using System;
using System.Windows.Forms;
using LicenceApp.Models;
using LicenceApp.Repositories;

namespace LicenceApp
{
    public partial class FrmDevice : Form
    {
        private readonly DeviceRepository _deviceRepository = new DeviceRepository();
        private Device _selectedDevice;

        public FrmDevice()
        {
            InitializeComponent();
        }

        private void FrmDevice_Load(object sender, EventArgs e)
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
            foreach (var device in _deviceRepository.GetAll())
            {
                lstDevices.Items.Add(device);
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
            string name = txtDeviceName.Text;

            if (!(cmbDeviceLocation.SelectedItem is string location) || !(cmbDeviceType.SelectedItem is string type) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Molimo popunite naziv i odaberite lokaciju i tip uređaja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Device device = new Device
            {
                Naziv_racunala = name,
                Lokacija = location,
                Tip_uredaja = type
            };

            bool success = _deviceRepository.Add(device);

            if (success)
            {
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
            if (_selectedDevice == null)
            {
                MessageBox.Show("Odaberite uređaj s liste za uređivanje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtDeviceName.Text;

            if (!(cmbDeviceLocation.SelectedItem is string location) || !(cmbDeviceType.SelectedItem is string type) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Molimo popunite naziv i odaberite lokaciju i tip uređaja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Device device = new Device
            {
                ID_uredaj = _selectedDevice.ID_uredaj,
                Naziv_racunala = name,
                Lokacija = location,
                Tip_uredaja = type
            };

            bool success = _deviceRepository.Update(device);

            if (success)
            {
                MessageBox.Show("Uređaj uspješno ažuriran!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                RefreshList();
                _selectedDevice = null;
            }
            else
            {
                MessageBox.Show("Greška prilikom ažuriranja uređaja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedDevice == null)
            {
                MessageBox.Show("Odaberite uređaj s liste za brisanje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmation = MessageBox.Show(
                $"Jeste li sigurni da želite obrisati uređaj {_selectedDevice.Naziv_racunala}?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
                return;

            bool success = _deviceRepository.Delete(_selectedDevice.ID_uredaj);

            if (success)
            {
                ClearFields();
                RefreshList();
                _selectedDevice = null;
            }
            else
            {
                MessageBox.Show("Greška prilikom brisanja uređaja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LstDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedDevice = lstDevices.SelectedItem as Device;
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