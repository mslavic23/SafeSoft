namespace LicenceApp
{
    partial class FrmUser
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.lblUserLastName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.txtUserLastName = new System.Windows.Forms.TextBox();
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.Location = new System.Drawing.Point(491, 339);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(59, 23);
            this.lblUserPassword.TabIndex = 7;
            this.lblUserPassword.Text = "Lozinka: ";
            this.lblUserPassword.Click += new System.EventHandler(this.LblUserPassword_Click);
            // 
            // lblUserRole
            // 
            this.lblUserRole.Location = new System.Drawing.Point(503, 367);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(47, 23);
            this.lblUserRole.TabIndex = 9;
            this.lblUserRole.Text = "Uloga:";
            this.lblUserRole.Click += new System.EventHandler(this.LblUserRole_Click);
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.Location = new System.Drawing.Point(503, 308);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(47, 23);
            this.lblUserEmail.TabIndex = 5;
            this.lblUserEmail.Text = "Email: ";
            this.lblUserEmail.Click += new System.EventHandler(this.LblUserEmail_Click);
            // 
            // lblUserLastName
            // 
            this.lblUserLastName.Location = new System.Drawing.Point(491, 279);
            this.lblUserLastName.Name = "lblUserLastName";
            this.lblUserLastName.Size = new System.Drawing.Size(59, 23);
            this.lblUserLastName.TabIndex = 3;
            this.lblUserLastName.Text = "Prezime: ";
            this.lblUserLastName.Click += new System.EventHandler(this.LblUserLastName_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(514, 251);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(36, 23);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Ime: ";
            this.lblUserName.Click += new System.EventHandler(this.LblUserName_Click);
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(556, 336);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(286, 22);
            this.txtUserPassword.TabIndex = 8;
            this.txtUserPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(556, 248);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(286, 22);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.TextChanged += new System.EventHandler(this.TxUserName_TextChanged);
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Location = new System.Drawing.Point(556, 305);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(286, 22);
            this.txtUserEmail.TabIndex = 6;
            this.txtUserEmail.TextChanged += new System.EventHandler(this.TxtUserEmail_TextChanged);
            // 
            // txtUserLastName
            // 
            this.txtUserLastName.Location = new System.Drawing.Point(556, 276);
            this.txtUserLastName.Name = "txtUserLastName";
            this.txtUserLastName.Size = new System.Drawing.Size(286, 22);
            this.txtUserLastName.TabIndex = 4;
            this.txtUserLastName.TextChanged += new System.EventHandler(this.TxtUserLastName_TextChanged);
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.Location = new System.Drawing.Point(556, 364);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(286, 24);
            this.cmbUserRole.TabIndex = 10;
            this.cmbUserRole.SelectedIndexChanged += new System.EventHandler(this.CmbUserRole_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(863, 300);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEdit.Location = new System.Drawing.Point(863, 329);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Uredi";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDelete.Location = new System.Drawing.Point(863, 356);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Obriši";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnMain.Location = new System.Drawing.Point(12, 401);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(75, 23);
            this.btnMain.TabIndex = 14;
            this.btnMain.Text = "Izbornik";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.BtnMain_Click);
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
            // dgvUsers
            // 
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUsers.Location = new System.Drawing.Point(12, 233);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(473, 162);
            this.dgvUsers.TabIndex = 17;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsers_CellContentClick);
            this.dgvUsers.SelectionChanged += new System.EventHandler(this.DgvUsers_SelectionChanged);
            // 
            // FrmUser
            // 
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(953, 530);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUserName);
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
            this.Name = "FrmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Korisnici";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.Label lblUserLastName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.TextBox txtUserLastName;
        private System.Windows.Forms.ComboBox cmbUserRole;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.DataGridView dgvUsers;
    }
}