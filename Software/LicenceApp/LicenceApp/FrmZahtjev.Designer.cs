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
            this.dgvRequestApp = new System.Windows.Forms.DataGridView();
            this.colZahtjevId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKorisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoftver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUredaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRazlog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUserName
            // 
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Location = new System.Drawing.Point(77, 384);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(210, 24);
            this.cmbUserName.TabIndex = 1;
            this.cmbUserName.SelectedIndexChanged += new System.EventHandler(this.CmbUserName_SelectedIndexChanged);
            // 
            // cmbSoftwareName
            // 
            this.cmbSoftwareName.FormattingEnabled = true;
            this.cmbSoftwareName.Location = new System.Drawing.Point(726, 384);
            this.cmbSoftwareName.Name = "cmbSoftwareName";
            this.cmbSoftwareName.Size = new System.Drawing.Size(266, 24);
            this.cmbSoftwareName.TabIndex = 2;
            this.cmbSoftwareName.SelectedIndexChanged += new System.EventHandler(this.CmbSoftwareName_SelectedIndexChanged);
            // 
            // cmbDeviceName
            // 
            this.cmbDeviceName.FormattingEnabled = true;
            this.cmbDeviceName.Location = new System.Drawing.Point(376, 384);
            this.cmbDeviceName.Name = "cmbDeviceName";
            this.cmbDeviceName.Size = new System.Drawing.Size(261, 24);
            this.cmbDeviceName.TabIndex = 3;
            this.cmbDeviceName.SelectedIndexChanged += new System.EventHandler(this.CmbDeviceName_SelectedIndexChanged);
            // 
            // txtRequestReason
            // 
            this.txtRequestReason.Location = new System.Drawing.Point(540, 439);
            this.txtRequestReason.MaxLength = 100;
            this.txtRequestReason.Name = "txtRequestReason";
            this.txtRequestReason.Size = new System.Drawing.Size(452, 22);
            this.txtRequestReason.TabIndex = 4;
            this.txtRequestReason.TextChanged += new System.EventHandler(this.TxtRequestReason_TextChanged);
            // 
            // dtpRequestDate
            // 
            this.dtpRequestDate.Location = new System.Drawing.Point(148, 440);
            this.dtpRequestDate.Name = "dtpRequestDate";
            this.dtpRequestDate.Size = new System.Drawing.Size(222, 22);
            this.dtpRequestDate.TabIndex = 5;
            this.dtpRequestDate.ValueChanged += new System.EventHandler(this.DtpRequestDate_ValueChanged);
            // 
            // lbSoftwareName
            // 
            this.lbSoftwareName.AutoSize = true;
            this.lbSoftwareName.Location = new System.Drawing.Point(668, 387);
            this.lbSoftwareName.Name = "lbSoftwareName";
            this.lbSoftwareName.Size = new System.Drawing.Size(52, 16);
            this.lbSoftwareName.TabIndex = 6;
            this.lbSoftwareName.Text = "Softver:";
            this.lbSoftwareName.Click += new System.EventHandler(this.LbSoftwareName_Click);
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Location = new System.Drawing.Point(316, 387);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(54, 16);
            this.lblDeviceName.TabIndex = 7;
            this.lblDeviceName.Text = "Uređaj: ";
            this.lblDeviceName.Click += new System.EventHandler(this.LblDeviceName_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(18, 387);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 16);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "Korisnik:";
            this.lblUserName.Click += new System.EventHandler(this.LblUserName_Click);
            // 
            // lblRequestReason
            // 
            this.lblRequestReason.AutoSize = true;
            this.lblRequestReason.Location = new System.Drawing.Point(420, 442);
            this.lblRequestReason.Name = "lblRequestReason";
            this.lblRequestReason.Size = new System.Drawing.Size(114, 16);
            this.lblRequestReason.TabIndex = 10;
            this.lblRequestReason.Text = "Razlog korištenja:";
            this.lblRequestReason.Click += new System.EventHandler(this.LblRequestReason_Click);
            // 
            // lblRequestDate
            // 
            this.lblRequestDate.AutoSize = true;
            this.lblRequestDate.Location = new System.Drawing.Point(18, 445);
            this.lblRequestDate.Name = "lblRequestDate";
            this.lblRequestDate.Size = new System.Drawing.Size(124, 16);
            this.lblRequestDate.TabIndex = 11;
            this.lblRequestDate.Text = "Datum podnošenja:";
            this.lblRequestDate.Click += new System.EventHandler(this.LblRequestDate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(677, 493);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Uredi";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(758, 493);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Obriši";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(917, 493);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(12, 493);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(75, 23);
            this.btnMain.TabIndex = 17;
            this.btnMain.Text = "Izbornik";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.BtnMain_Click);
            // 
            // dgvRequestApp
            // 
            this.dgvRequestApp.AllowUserToAddRows = false;
            this.dgvRequestApp.AllowUserToDeleteRows = false;
            this.dgvRequestApp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequestApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequestApp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colZahtjevId,
            this.colKorisnik,
            this.colSoftver,
            this.colUredaj,
            this.colRazlog,
            this.colDatum});
            this.dgvRequestApp.Location = new System.Drawing.Point(21, 95);
            this.dgvRequestApp.MultiSelect = false;
            this.dgvRequestApp.Name = "dgvRequestApp";
            this.dgvRequestApp.ReadOnly = true;
            this.dgvRequestApp.RowHeadersWidth = 25;
            this.dgvRequestApp.RowTemplate.Height = 24;
            this.dgvRequestApp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequestApp.Size = new System.Drawing.Size(971, 267);
            this.dgvRequestApp.TabIndex = 19;
            this.dgvRequestApp.SelectionChanged += new System.EventHandler(this.DgvRequestApp_SelectionChanged);
            // 
            // colZahtjevId
            // 
            this.colZahtjevId.HeaderText = "ID";
            this.colZahtjevId.MinimumWidth = 6;
            this.colZahtjevId.Name = "colZahtjevId";
            this.colZahtjevId.ReadOnly = true;
            this.colZahtjevId.Visible = false;
            // 
            // colKorisnik
            // 
            this.colKorisnik.HeaderText = "Korisnik";
            this.colKorisnik.MinimumWidth = 6;
            this.colKorisnik.Name = "colKorisnik";
            this.colKorisnik.ReadOnly = true;
            // 
            // colSoftver
            // 
            this.colSoftver.HeaderText = "Softver";
            this.colSoftver.MinimumWidth = 6;
            this.colSoftver.Name = "colSoftver";
            this.colSoftver.ReadOnly = true;
            // 
            // colUredaj
            // 
            this.colUredaj.HeaderText = "Uređaj";
            this.colUredaj.MinimumWidth = 6;
            this.colUredaj.Name = "colUredaj";
            this.colUredaj.ReadOnly = true;
            // 
            // colRazlog
            // 
            this.colRazlog.HeaderText = "Razlog";
            this.colRazlog.MinimumWidth = 6;
            this.colRazlog.Name = "colRazlog";
            this.colRazlog.ReadOnly = true;
            // 
            // colDatum
            // 
            this.colDatum.HeaderText = "Datum";
            this.colDatum.MinimumWidth = 6;
            this.colDatum.Name = "colDatum";
            this.colDatum.ReadOnly = true;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::LicenceApp.Properties.Resources.SafeSoft_logo;
            this.pbxLogo.Location = new System.Drawing.Point(376, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(211, 67);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 20;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.Click += new System.EventHandler(this.PbxLogo_Click);
            // 
            // FrmZahtjev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1021, 614);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.dgvRequestApp);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestApp)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvRequestApp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colZahtjevId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKorisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoftver;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUredaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRazlog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatum;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}