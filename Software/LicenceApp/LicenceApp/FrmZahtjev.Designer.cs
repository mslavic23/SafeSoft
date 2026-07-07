namespace LicenceApp
{
    partial class FrmZahtjev
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
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.cmbSoftwareName = new System.Windows.Forms.ComboBox();
            this.cmbDeviceName = new System.Windows.Forms.ComboBox();
            this.txtRequestReason = new System.Windows.Forms.TextBox();
            this.dtpRequestDate = new System.Windows.Forms.DateTimePicker();
            this.lbSoftwareName = new System.Windows.Forms.Label();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblRequestReason = new System.Windows.Forms.Label();
            this.lblRequestDate = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.lstRequestApp = new System.Windows.Forms.ListBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUserName
            // 
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Location = new System.Drawing.Point(473, 81);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(210, 24);
            this.cmbUserName.TabIndex = 1;
            this.cmbUserName.SelectedIndexChanged += new System.EventHandler(this.cmbUser_SelectedIndexChanged);
            // 
            // cmbSoftwareName
            // 
            this.cmbSoftwareName.FormattingEnabled = true;
            this.cmbSoftwareName.Location = new System.Drawing.Point(473, 138);
            this.cmbSoftwareName.Name = "cmbSoftwareName";
            this.cmbSoftwareName.Size = new System.Drawing.Size(210, 24);
            this.cmbSoftwareName.TabIndex = 2;
            this.cmbSoftwareName.SelectedIndexChanged += new System.EventHandler(this.cmbSoftver_SelectedIndexChanged);
            // 
            // cmbDeviceName
            // 
            this.cmbDeviceName.FormattingEnabled = true;
            this.cmbDeviceName.Location = new System.Drawing.Point(473, 110);
            this.cmbDeviceName.Name = "cmbDeviceName";
            this.cmbDeviceName.Size = new System.Drawing.Size(210, 24);
            this.cmbDeviceName.TabIndex = 3;
            this.cmbDeviceName.SelectedIndexChanged += new System.EventHandler(this.cmbDeviceName_SelectedIndexChanged);
            // 
            // txtRequestReason
            // 
            this.txtRequestReason.Location = new System.Drawing.Point(473, 205);
            this.txtRequestReason.MaxLength = 100;
            this.txtRequestReason.Name = "txtRequestReason";
            this.txtRequestReason.Size = new System.Drawing.Size(210, 22);
            this.txtRequestReason.TabIndex = 4;
            this.txtRequestReason.TextChanged += new System.EventHandler(this.txtRequestReason_TextChanged);
            // 
            // dtpRequestDate
            // 
            this.dtpRequestDate.Location = new System.Drawing.Point(473, 171);
            this.dtpRequestDate.Name = "dtpRequestDate";
            this.dtpRequestDate.Size = new System.Drawing.Size(210, 22);
            this.dtpRequestDate.TabIndex = 5;
            this.dtpRequestDate.ValueChanged += new System.EventHandler(this.dtpRequestDate_ValueChanged);
            // 
            // lbSoftwareName
            // 
            this.lbSoftwareName.AutoSize = true;
            this.lbSoftwareName.Location = new System.Drawing.Point(410, 149);
            this.lbSoftwareName.Name = "lbSoftwareName";
            this.lbSoftwareName.Size = new System.Drawing.Size(52, 16);
            this.lbSoftwareName.TabIndex = 6;
            this.lbSoftwareName.Text = "Softver:";
            this.lbSoftwareName.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Location = new System.Drawing.Point(410, 119);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(54, 16);
            this.lblDeviceName.TabIndex = 7;
            this.lblDeviceName.Text = "Uređaj: ";
            this.lblDeviceName.Click += new System.EventHandler(this.lblDeviceName_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(407, 84);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 16);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "Korisnik:";
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // lblRequestReason
            // 
            this.lblRequestReason.AutoSize = true;
            this.lblRequestReason.Location = new System.Drawing.Point(348, 208);
            this.lblRequestReason.Name = "lblRequestReason";
            this.lblRequestReason.Size = new System.Drawing.Size(114, 16);
            this.lblRequestReason.TabIndex = 10;
            this.lblRequestReason.Text = "Razlog korištenja:";
            this.lblRequestReason.Click += new System.EventHandler(this.Label5_Click);
            // 
            // lblRequestDate
            // 
            this.lblRequestDate.AutoSize = true;
            this.lblRequestDate.Location = new System.Drawing.Point(343, 175);
            this.lblRequestDate.Name = "lblRequestDate";
            this.lblRequestDate.Size = new System.Drawing.Size(124, 16);
            this.lblRequestDate.TabIndex = 11;
            this.lblRequestDate.Text = "Datum podnošenja:";
            this.lblRequestDate.Click += new System.EventHandler(this.lbRequestDate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(689, 139);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Uredi";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnUredi_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(689, 168);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Obriši";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnObrisi_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(689, 110);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(689, 219);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(75, 23);
            this.btnMain.TabIndex = 17;
            this.btnMain.Text = "Izbornik";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.BtnGlavni_Click);
            // 
            // lstRequestApp
            // 
            this.lstRequestApp.FormattingEnabled = true;
            this.lstRequestApp.ItemHeight = 16;
            this.lstRequestApp.Location = new System.Drawing.Point(21, 82);
            this.lstRequestApp.Name = "lstRequestApp";
            this.lstRequestApp.Size = new System.Drawing.Size(316, 164);
            this.lstRequestApp.TabIndex = 19;
            this.lstRequestApp.SelectedIndexChanged += new System.EventHandler(this.LstZahtjevi_SelectedIndexChanged);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::LicenceApp.Properties.Resources.SafeSoft_logo;
            this.pbxLogo.Location = new System.Drawing.Point(12, 39);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(335, 37);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 20;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.Click += new System.EventHandler(this.PbxLogo_Click);
            // 
            // FrmZahtjev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 290);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.lstRequestApp);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblRequestDate);
            this.Controls.Add(this.lblRequestReason);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblDeviceName);
            this.Controls.Add(this.lbSoftwareName);
            this.Controls.Add(this.dtpRequestDate);
            this.Controls.Add(this.txtRequestReason);
            this.Controls.Add(this.cmbDeviceName);
            this.Controls.Add(this.cmbSoftwareName);
            this.Controls.Add(this.cmbUserName);
            this.Name = "FrmZahtjev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zahtjevi";
            this.Load += new System.EventHandler(this.FrmZahtjev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.ComboBox cmbSoftwareName;
        private System.Windows.Forms.ComboBox cmbDeviceName;
        private System.Windows.Forms.TextBox txtRequestReason;
        private System.Windows.Forms.DateTimePicker dtpRequestDate;
        private System.Windows.Forms.Label lbSoftwareName;
        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblRequestReason;
        private System.Windows.Forms.Label lblRequestDate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.ListBox lstRequestApp;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}