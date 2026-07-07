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
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.lblUserLastName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.txUserName = new System.Windows.Forms.TextBox();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.txtUserLastName = new System.Windows.Forms.TextBox();
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lstUsers
            // 
            this.lstUsers.ItemHeight = 16;
            this.lstUsers.Location = new System.Drawing.Point(119, 231);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(409, 164);
            this.lstUsers.TabIndex = 0;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.LstKorisnici_SelectedIndexChanged);
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.Location = new System.Drawing.Point(549, 332);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(100, 23);
            this.lblUserPassword.TabIndex = 7;
            this.lblUserPassword.Text = "Lozinka: ";
            this.lblUserPassword.Click += new System.EventHandler(this.lblUserPassword_Click);
            // 
            // lblUserRole
            // 
            this.lblUserRole.Location = new System.Drawing.Point(549, 361);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(100, 23);
            this.lblUserRole.TabIndex = 9;
            this.lblUserRole.Text = "Uloga:";
            this.lblUserRole.Click += new System.EventHandler(this.lblUserRole_Click);
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.Location = new System.Drawing.Point(549, 305);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(100, 23);
            this.lblUserEmail.TabIndex = 5;
            this.lblUserEmail.Text = "Email: ";
            this.lblUserEmail.Click += new System.EventHandler(this.lblUserEmail_Click);
            // 
            // lblUserLastName
            // 
            this.lblUserLastName.Location = new System.Drawing.Point(549, 273);
            this.lblUserLastName.Name = "lblUserLastName";
            this.lblUserLastName.Size = new System.Drawing.Size(100, 23);
            this.lblUserLastName.TabIndex = 3;
            this.lblUserLastName.Text = "Prezime: ";
            this.lblUserLastName.Click += new System.EventHandler(this.lblUserLastName_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(549, 246);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(100, 23);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Ime: ";
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(632, 330);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(216, 22);
            this.txtUserPassword.TabIndex = 8;
            this.txtUserPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txUserName
            // 
            this.txUserName.Location = new System.Drawing.Point(632, 243);
            this.txUserName.Name = "txUserName";
            this.txUserName.Size = new System.Drawing.Size(216, 22);
            this.txUserName.TabIndex = 2;
            this.txUserName.TextChanged += new System.EventHandler(this.txUserName_TextChanged);
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Location = new System.Drawing.Point(632, 302);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(216, 22);
            this.txtUserEmail.TabIndex = 6;
            this.txtUserEmail.TextChanged += new System.EventHandler(this.txtUserEmail_TextChanged);
            // 
            // txtUserLastName
            // 
            this.txtUserLastName.Location = new System.Drawing.Point(632, 273);
            this.txtUserLastName.Name = "txtUserLastName";
            this.txtUserLastName.Size = new System.Drawing.Size(216, 22);
            this.txtUserLastName.TabIndex = 4;
            this.txtUserLastName.TextChanged += new System.EventHandler(this.txtUserLastName_TextChanged);
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.Location = new System.Drawing.Point(632, 358);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(216, 24);
            this.cmbUserRole.TabIndex = 10;
            this.cmbUserRole.SelectedIndexChanged += new System.EventHandler(this.cmbUserRole_SelectedIndexChanged);
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
            this.Controls.Add(this.lstUsers);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txUserName);
            this.Controls.Add(this.lblUserLastName);
            this.Controls.Add(this.txtUserLastName);
            this.Controls.Add(this.lblUserEmail);
            this.Controls.Add(this.txtUserEmail);
            this.Controls.Add(this.lblUserPassword);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.lblUserRole);
            this.Controls.Add(this.cmbUserRole);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnBack);
            this.Name = "FrmKorisnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Korisnici";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.Label lblUserLastName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.TextBox txUserName;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.TextBox txtUserLastName;
        private System.Windows.Forms.ComboBox cmbUserRole;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}