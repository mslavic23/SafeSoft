using System;
using System.Linq;
using System.Windows.Forms;
using LicenceApp.Models;
using LicenceApp.Repositories;

namespace LicenceApp
{
    public partial class FrmRequestApp : Form
    {
        private readonly RequestAppRepository _requestRepository = new RequestAppRepository();
        private readonly UserRepository _userRepository = new UserRepository();
        private readonly SoftwareRepository _softwareRepository = new SoftwareRepository();
        private readonly DeviceRepository _deviceRepository = new DeviceRepository();

        private RequestApp _selectedRequest;

        public FrmRequestApp()
        {
            InitializeComponent();
        }

        private void FrmRequestApp_Load(object sender, EventArgs e)
        {
            bool isAdmin = SessionManager.User != null && SessionManager.User.Uloga == "Administrator";

            cmbUserName.Items.Clear();
            if (isAdmin)
            {
                foreach (var user in _userRepository.GetAll())
                {
                    cmbUserName.Items.Add(user);
                }
            }
            else
            {
                cmbUserName.Items.Add(SessionManager.User);
                cmbUserName.SelectedIndex = 0;
            }

            cmbSoftwareName.Items.Clear();
            foreach (var software in _softwareRepository.GetAll())
            {
                cmbSoftwareName.Items.Add(software);
            }

            cmbDeviceName.Items.Clear();
            foreach (var device in _deviceRepository.GetAll())
            {
                cmbDeviceName.Items.Add(device);
            }

            dtpRequestDate.Value = DateTime.Now;

            RefreshList();
        }

        private void RefreshList()
        {
            bool isAdmin = SessionManager.User != null && SessionManager.User.Uloga == "Administrator";

            var requests = isAdmin
                ? _requestRepository.GetAll()
                : _requestRepository.GetByUser(SessionManager.User.ID_korisnik);

            var users = _userRepository.GetAll();
            var softwares = _softwareRepository.GetAll();
            var devices = _deviceRepository.GetAll();

            dgvRequestApp.Rows.Clear();

            foreach (var request in requests)
            {
                var user = users.FirstOrDefault(u => u.ID_korisnik == request.ID_korisnik);
                var software = softwares.FirstOrDefault(s => s.ID_softver == request.ID_softver);
                var device = devices.FirstOrDefault(d => d.ID_uredaj == request.ID_uredaj);

                dgvRequestApp.Rows.Add(
                    request.ID_zahtjev,
                    user != null ? $"{user.Ime} {user.Prezime}" : "",
                    software != null ? software.Naziv : "",
                    device != null ? device.Naziv_racunala : "",
                    request.Razlog_koristenja,
                    request.Datum_podnosenja.ToString("dd.MM.yyyy.")
                );
            }
        }

        private void ClearFields()
        {
            bool isAdmin = SessionManager.User != null && SessionManager.User.Uloga == "Administrator";

            if (isAdmin)
                cmbUserName.SelectedIndex = -1;

            cmbSoftwareName.SelectedIndex = -1;
            cmbDeviceName.SelectedIndex = -1;
            txtRequestReason.Text = "";
            dtpRequestDate.Value = DateTime.Now;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            User user = cmbUserName.SelectedItem as User;
            Software software = cmbSoftwareName.SelectedItem as Software;
            Device device = cmbDeviceName.SelectedItem as Device;

            if (user == null || software == null || device == null || string.IsNullOrEmpty(txtRequestReason.Text))
            {
                MessageBox.Show("Molimo odaberite korisnika, softver, uređaj i unesite razlog korištenja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!_requestRepository.HasAvailableSeats(software.ID_softver))
            {
                MessageBox.Show("Nema slobodnih mjesta za odabrani softver!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RequestApp request = new RequestApp
            {
                ID_korisnik = user.ID_korisnik,
                ID_softver = software.ID_softver,
                ID_uredaj = device.ID_uredaj,
                Razlog_koristenja = txtRequestReason.Text,
                Datum_podnosenja = dtpRequestDate.Value
            };

            bool success = _requestRepository.Add(request);

            if (success)
            {
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
            if (_selectedRequest == null)
            {
                MessageBox.Show("Odaberite zahtjev s liste za uređivanje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User user = cmbUserName.SelectedItem as User;
            Software software = cmbSoftwareName.SelectedItem as Software;
            Device device = cmbDeviceName.SelectedItem as Device;

            if (user == null || software == null || device == null || string.IsNullOrEmpty(txtRequestReason.Text))
            {
                MessageBox.Show("Molimo odaberite korisnika, softver, uređaj i unesite razlog korištenja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RequestApp request = new RequestApp
            {
                ID_zahtjev = _selectedRequest.ID_zahtjev,
                ID_korisnik = user.ID_korisnik,
                ID_softver = software.ID_softver,
                ID_uredaj = device.ID_uredaj,
                Razlog_koristenja = txtRequestReason.Text,
                Datum_podnosenja = dtpRequestDate.Value
            };

            bool success = _requestRepository.Update(request);

            if (success)
            {
                MessageBox.Show("Zahtjev uspješno ažuriran!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                RefreshList();
                _selectedRequest = null;
            }
            else
            {
                MessageBox.Show("Greška prilikom ažuriranja zahtjeva!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedRequest == null)
            {
                MessageBox.Show("Odaberite zahtjev s liste za brisanje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmation = MessageBox.Show(
                "Jeste li sigurni da želite obrisati odabrani zahtjev?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
                return;

            bool success = _requestRepository.Delete(_selectedRequest.ID_zahtjev);

            if (success)
            {
                ClearFields();
                RefreshList();
                _selectedRequest = null;
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
                _selectedRequest = null;
                return;
            }

            int id = (int)dgvRequestApp.CurrentRow.Cells["colZahtjevId"].Value;
            _selectedRequest = _requestRepository.GetAll().FirstOrDefault(r => r.ID_zahtjev == id);
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