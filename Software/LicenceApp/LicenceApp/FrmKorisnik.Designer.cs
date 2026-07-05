namespace LicenceApp
{
    partial class FrmKorisnik
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstKorisnici = new System.Windows.Forms.ListBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lstKorisnici
            // 
            this.lstKorisnici.ItemHeight = 16;
            this.lstKorisnici.Location = new System.Drawing.Point(119, 231);
            this.lstKorisnici.Name = "lstKorisnici";
            this.lstKorisnici.Size = new System.Drawing.Size(409, 164);
            this.lstKorisnici.TabIndex = 0;
            this.lstKorisnici.SelectedIndexChanged += new System.EventHandler(this.LstKorisnici_SelectedIndexChanged);
            // 
            // lbPassword
            // 
            this.lbPassword.Location = new System.Drawing.Point(549, 332);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(100, 23);
            this.lbPassword.TabIndex = 7;
            this.lbPassword.Text = "Lozinka: ";
            // 
            // lbRole
            // 
            this.lbRole.Location = new System.Drawing.Point(549, 361);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(100, 23);
            this.lbRole.TabIndex = 9;
            this.lbRole.Text = "Uloga:";
            // 
            // lbEmail
            // 
            this.lbEmail.Location = new System.Drawing.Point(549, 305);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(100, 23);
            this.lbEmail.TabIndex = 5;
            this.lbEmail.Text = "Email: ";
            // 
            // lbLastName
            // 
            this.lbLastName.Location = new System.Drawing.Point(549, 273);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(100, 23);
            this.lbLastName.TabIndex = 3;
            this.lbLastName.Text = "Prezime: ";
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(549, 246);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(100, 23);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Ime: ";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(632, 330);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(216, 22);
            this.txtPassword.TabIndex = 8;
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(632, 243);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(216, 22);
            this.txName.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(632, 302);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(216, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(632, 273);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(216, 22);
            this.txtLastName.TabIndex = 4;
            // 
            // cmbRole
            // 
            this.cmbRole.Location = new System.Drawing.Point(632, 358);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(216, 24);
            this.cmbRole.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(904, 283);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(904, 325);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Uredi";
            this.btnEdit.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(904, 354);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Obriši";
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(174, 401);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(75, 23);
            this.btnMain.TabIndex = 14;
            this.btnMain.Text = "Izbornik";
            this.btnMain.Click += new System.EventHandler(this.BtnMain_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(119, 401);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "←";
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::LicenceApp.Properties.Resources.SafeSoft_logo;
            this.pbxLogo.Location = new System.Drawing.Point(66, 77);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(974, 119);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 16;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.Click += new System.EventHandler(this.PbxLogo_Click);
            // 
            // FrmKorisnik
            // 
            this.ClientSize = new System.Drawing.Size(1189, 579);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.lstKorisnici);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbRole);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnBack);
            this.Name = "FrmKorisnik";
            this.Text = "Korisnici";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ListBox lstKorisnici;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}