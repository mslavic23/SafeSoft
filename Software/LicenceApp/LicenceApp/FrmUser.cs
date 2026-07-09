using System;
using System.Windows.Forms;
using LicenceApp.Models;
using LicenceApp.Repositories;

namespace LicenceApp
{
    public partial class FrmUser : Form
    {
        private readonly UserRepository _userRepository = new UserRepository();
        private User _selectedUser;

        public FrmUser()
        {
            InitializeComponent();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            cmbUserRole.Items.Clear();
            cmbUserRole.Items.Add("Administrator");
            cmbUserRole.Items.Add("Korisnik");

            RefreshList();
        }

        private void RefreshList()
        {
            var users = _userRepository.GetAll();

            dgvUsers.DataSource = null;
            dgvUsers.AutoGenerateColumns = true;
            dgvUsers.DataSource = users;

            if (dgvUsers.Columns.Contains("Ime"))
                dgvUsers.Columns["Ime"].HeaderText = "Ime";
            if (dgvUsers.Columns.Contains("Prezime"))
                dgvUsers.Columns["Prezime"].HeaderText = "Prezime";
            if (dgvUsers.Columns.Contains("Email"))
                dgvUsers.Columns["Email"].HeaderText = "Email";
            if (dgvUsers.Columns.Contains("Uloga"))
                dgvUsers.Columns["Uloga"].HeaderText = "Uloga";
            if (dgvUsers.Columns.Contains("LozinkaHash"))
                dgvUsers.Columns["LozinkaHash"].Visible = false;
            if (dgvUsers.Columns.Contains("ID_korisnik"))
                dgvUsers.Columns["ID_korisnik"].Visible = false;
        }

        private void ClearFields()
        {
            txtUserName.Text = "";
            txtUserLastName.Text = "";
            txtUserEmail.Text = "";
            txtUserPassword.Text = "";
            cmbUserRole.SelectedIndex = -1;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string firstName = txtUserName.Text;
            string lastName = txtUserLastName.Text;
            string email = txtUserEmail.Text;
            string password = txtUserPassword.Text;

            if (!(cmbUserRole.SelectedItem is string role) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Molimo popunite sva polja i odaberite ulogu!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_userRepository.EmailExists(email))
            {
                MessageBox.Show("Korisnik s tim emailom već postoji!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User user = new User
            {
                Ime = firstName,
                Prezime = lastName,
                Email = email,
                LozinkaHash = password,
                Uloga = role
            };

            bool success = _userRepository.Add(user);

            if (success)
            {
                ClearFields();
                RefreshList();
            }
            else
            {
                MessageBox.Show("Greška prilikom dodavanja korisnika!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedUser == null)
            {
                MessageBox.Show("Odaberite korisnika s liste za uređivanje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string firstName = txtUserName.Text;
            string lastName = txtUserLastName.Text;
            string email = txtUserEmail.Text;
            string password = txtUserPassword.Text;

            if (!(cmbUserRole.SelectedItem is string role) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Molimo popunite Ime, Prezime, Email i odaberite ulogu!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User user = new User
            {
                ID_korisnik = _selectedUser.ID_korisnik,
                Ime = firstName,
                Prezime = lastName,
                Email = email,
                LozinkaHash = password,
                Uloga = role
            };

            bool success = _userRepository.Update(user);

            if (success)
            {
                MessageBox.Show("Korisnik uspješno ažuriran!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                RefreshList();
                _selectedUser = null;
            }
            else
            {
                MessageBox.Show("Greška prilikom ažuriranja korisnika!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedUser == null)
            {
                MessageBox.Show("Odaberite korisnika s liste za brisanje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmation = MessageBox.Show(
                $"Jeste li sigurni da želite obrisati korisnika {_selectedUser.Ime} {_selectedUser.Prezime}?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
                return;

            bool success = _userRepository.Delete(_selectedUser.ID_korisnik);

            if (success)
            {
                ClearFields();
                RefreshList();
                _selectedUser = null;
            }
            else
            {
                MessageBox.Show("Greška prilikom brisanja korisnika!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            _selectedUser = dgvUsers.CurrentRow?.DataBoundItem as User;
        }

        private void DgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
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