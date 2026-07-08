using System;
using System.Windows.Forms;
using LicenceApp.Repositories;

namespace LicenceApp
{
    public partial class FrmLogin : Form
    {
        private readonly UserRepository _userRepository = new UserRepository();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = txtLoginUser.Text;
            string lozinka = txtLoginPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(lozinka))
            {
                MessageBox.Show("Molimo unesite email i lozinku!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = _userRepository.Login(email, lozinka);

            if (user != null)
            {
                SessionManager.User = user;

                FrmMain frmMain = new FrmMain();
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Pogrešno korisničko ime ili lozinka!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PbxAddUser_Click(object sender, EventArgs e)
        {
            FrmUser frmUser = new FrmUser();
            frmUser.Show();
            this.Hide();
        }
    }
}