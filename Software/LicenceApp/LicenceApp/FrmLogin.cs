using System;
using System.Drawing;
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
            if (!PromptAdminCredentials(out string email, out string password))
                return;

            var user = _userRepository.Login(email, password);

            if (user == null || user.Uloga != "Administrator")
            {
                MessageBox.Show("Neispravni administratorski podaci!", "Pristup odbijen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmUser frmUser = new FrmUser();
            frmUser.Show();
            this.Hide();
        }

        private bool PromptAdminCredentials(out string email, out string password)
        {
            email = "";
            password = "";

            using (Form prompt = new Form())
            {
                prompt.Width = 320;
                prompt.Height = 220;
                prompt.Text = "Potvrda administratora";
                prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
                prompt.StartPosition = FormStartPosition.CenterParent;
                prompt.MaximizeBox = false;
                prompt.MinimizeBox = false;

                Label lblInfo = new Label() { Left = 20, Top = 15, Width = 270, Text = "Za dodavanje korisnika potrebna je potvrda administratorske lozinke." };
                Label lblEmail = new Label() { Left = 20, Top = 60, Width = 100, Text = "Email:" };
                TextBox txtEmail = new TextBox() { Left = 120, Top = 57, Width = 160 };
                Label lblPassword = new Label() { Left = 20, Top = 95, Width = 100, Text = "Lozinka:" };
                TextBox txtPassword = new TextBox() { Left = 120, Top = 92, Width = 160, PasswordChar = '*' };
                Button btnOk = new Button() { Text = "Potvrdi", Left = 120, Width = 80, Top = 140, DialogResult = DialogResult.OK };
                Button btnCancel = new Button() { Text = "Odustani", Left = 200, Width = 80, Top = 140, DialogResult = DialogResult.Cancel };

                prompt.Controls.Add(lblInfo);
                prompt.Controls.Add(lblEmail);
                prompt.Controls.Add(txtEmail);
                prompt.Controls.Add(lblPassword);
                prompt.Controls.Add(txtPassword);
                prompt.Controls.Add(btnOk);
                prompt.Controls.Add(btnCancel);
                prompt.AcceptButton = btnOk;
                prompt.CancelButton = btnCancel;

                if (prompt.ShowDialog(this) == DialogResult.OK)
                {
                    email = txtEmail.Text;
                    password = txtPassword.Text;
                    return !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password);
                }

                return false;
            }
        }
    }
}