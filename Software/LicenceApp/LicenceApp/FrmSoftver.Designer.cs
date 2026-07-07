namespace LicenceApp
{
    partial class FrmSoftver
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblSoftwareName = new System.Windows.Forms.Label();
            this.txtSoftwareName = new System.Windows.Forms.TextBox();
            this.lblSoftwareVersion = new System.Windows.Forms.Label();
            this.txtSofwareVersion = new System.Windows.Forms.TextBox();
            this.lblLicenceType = new System.Windows.Forms.Label();
            this.txtLicenceType = new System.Windows.Forms.TextBox();
            this.txtTotalSeats = new System.Windows.Forms.TextBox();
            this.lblTotalSeats = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.lstSoftwares = new System.Windows.Forms.ListBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSoftwareName
            // 
            this.lblSoftwareName.AutoSize = true;
            this.lblSoftwareName.Location = new System.Drawing.Point(467, 111);
            this.lblSoftwareName.Name = "lblSoftwareName";
            this.lblSoftwareName.Size = new System.Drawing.Size(44, 16);
            this.lblSoftwareName.TabIndex = 1;
            this.lblSoftwareName.Text = "Naziv:";
            this.lblSoftwareName.Click += new System.EventHandler(this.lbName_Click);
            // 
            // txtSoftwareName
            // 
            this.txtSoftwareName.Location = new System.Drawing.Point(536, 111);
            this.txtSoftwareName.MaxLength = 30;
            this.txtSoftwareName.Name = "txtSoftwareName";
            this.txtSoftwareName.Size = new System.Drawing.Size(149, 22);
            this.txtSoftwareName.TabIndex = 2;
            this.txtSoftwareName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblSoftwareVersion
            // 
            this.lblSoftwareVersion.AutoSize = true;
            this.lblSoftwareVersion.Location = new System.Drawing.Point(467, 142);
            this.lblSoftwareVersion.Name = "lblSoftwareVersion";
            this.lblSoftwareVersion.Size = new System.Drawing.Size(51, 16);
            this.lblSoftwareVersion.TabIndex = 3;
            this.lblSoftwareVersion.Text = "Verzija:";
            this.lblSoftwareVersion.Click += new System.EventHandler(this.lbVersion_Click);
            // 
            // txtSofwareVersion
            // 
            this.txtSofwareVersion.Location = new System.Drawing.Point(536, 139);
            this.txtSofwareVersion.MaxLength = 6;
            this.txtSofwareVersion.Name = "txtSofwareVersion";
            this.txtSofwareVersion.Size = new System.Drawing.Size(149, 22);
            this.txtSofwareVersion.TabIndex = 4;
            this.txtSofwareVersion.TextChanged += new System.EventHandler(this.txtVersion_TextChanged);
            // 
            // lblLicenceType
            // 
            this.lblLicenceType.AutoSize = true;
            this.lblLicenceType.Location = new System.Drawing.Point(467, 170);
            this.lblLicenceType.Name = "lblLicenceType";
            this.lblLicenceType.Size = new System.Drawing.Size(76, 16);
            this.lblLicenceType.TabIndex = 5;
            this.lblLicenceType.Text = "Tip licence:";
            this.lblLicenceType.Click += new System.EventHandler(this.lbType_Click);
            // 
            // txtLicenceType
            // 
            this.txtLicenceType.Location = new System.Drawing.Point(561, 167);
            this.txtLicenceType.MaxLength = 20;
            this.txtLicenceType.Name = "txtLicenceType";
            this.txtLicenceType.Size = new System.Drawing.Size(124, 22);
            this.txtLicenceType.TabIndex = 6;
            this.txtLicenceType.TextChanged += new System.EventHandler(this.txtType_TextChanged);
            // 
            // txtTotalSeats
            // 
            this.txtTotalSeats.Location = new System.Drawing.Point(585, 195);
            this.txtTotalSeats.MaxLength = 4;
            this.txtTotalSeats.Name = "txtTotalSeats";
            this.txtTotalSeats.Size = new System.Drawing.Size(100, 22);
            this.txtTotalSeats.TabIndex = 7;
            this.txtTotalSeats.TextChanged += new System.EventHandler(this.txtSeats_TextChanged);
            // 
            // lblTotalSeats
            // 
            this.lblTotalSeats.AutoSize = true;
            this.lblTotalSeats.Location = new System.Drawing.Point(467, 198);
            this.lblTotalSeats.Name = "lblTotalSeats";
            this.lblTotalSeats.Size = new System.Drawing.Size(100, 16);
            this.lblTotalSeats.TabIndex = 8;
            this.lblTotalSeats.Text = "Ukupno mjesta:";
            this.lblTotalSeats.Click += new System.EventHandler(this.lbSeats_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(715, 111);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnDodaj_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(715, 142);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Uredi";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnUredi_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(715, 173);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Obriši";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnObrisi_Click_1);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(467, 245);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(77, 26);
            this.btnMain.TabIndex = 13;
            this.btnMain.Text = "Izbornik";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lstSoftwares
            // 
            this.lstSoftwares.FormattingEnabled = true;
            this.lstSoftwares.ItemHeight = 16;
            this.lstSoftwares.Location = new System.Drawing.Point(154, 91);
            this.lstSoftwares.Name = "lstSoftwares";
            this.lstSoftwares.Size = new System.Drawing.Size(307, 180);
            this.lstSoftwares.TabIndex = 15;
            this.lstSoftwares.SelectedIndexChanged += new System.EventHandler(this.LstSoftveri_SelectedIndexChanged_1);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::LicenceApp.Properties.Resources.SafeSoft_logo;
            this.pbxLogo.Location = new System.Drawing.Point(154, 39);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(172, 46);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 16;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.Click += new System.EventHandler(this.PbxLogo_Click);
            // 
            // FrmSoftver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.lstSoftwares);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTotalSeats);
            this.Controls.Add(this.txtTotalSeats);
            this.Controls.Add(this.txtLicenceType);
            this.Controls.Add(this.lblLicenceType);
            this.Controls.Add(this.txtSofwareVersion);
            this.Controls.Add(this.lblSoftwareVersion);
            this.Controls.Add(this.txtSoftwareName);
            this.Controls.Add(this.lblSoftwareName);
            this.Name = "FrmSoftver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Softveri";
            this.Load += new System.EventHandler(this.FrmSoftver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblSoftwareName;
        private System.Windows.Forms.TextBox txtSoftwareName;
        private System.Windows.Forms.Label lblSoftwareVersion;
        private System.Windows.Forms.TextBox txtSofwareVersion;
        private System.Windows.Forms.Label lblLicenceType;
        private System.Windows.Forms.TextBox txtLicenceType;
        private System.Windows.Forms.TextBox txtTotalSeats;
        private System.Windows.Forms.Label lblTotalSeats;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.ListBox lstSoftwares;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}