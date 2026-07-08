namespace LicenceApp
{
    partial class FrmSoftware
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
            this.cmbSoftwareVersion = new System.Windows.Forms.ComboBox();
            this.lblLicenceType = new System.Windows.Forms.Label();
            this.lblTotalSeats = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.cmbLicenceType = new System.Windows.Forms.ComboBox();
            this.numTotalSeats = new System.Windows.Forms.NumericUpDown();
            this.dgvSoftwares = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoftwares)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSoftwareName
            // 
            this.lblSoftwareName.AutoSize = true;
            this.lblSoftwareName.Location = new System.Drawing.Point(9, 86);
            this.lblSoftwareName.Name = "lblSoftwareName";
            this.lblSoftwareName.Size = new System.Drawing.Size(44, 16);
            this.lblSoftwareName.TabIndex = 1;
            this.lblSoftwareName.Text = "Naziv:";
            this.lblSoftwareName.Click += new System.EventHandler(this.LblSoftwareName_Click);
            // 
            // txtSoftwareName
            // 
            this.txtSoftwareName.Location = new System.Drawing.Point(59, 83);
            this.txtSoftwareName.MaxLength = 30;
            this.txtSoftwareName.Name = "txtSoftwareName";
            this.txtSoftwareName.Size = new System.Drawing.Size(149, 22);
            this.txtSoftwareName.TabIndex = 2;
            this.txtSoftwareName.TextChanged += new System.EventHandler(this.TxtSoftwareName_TextChanged);
            // 
            // lblSoftwareVersion
            // 
            this.lblSoftwareVersion.AutoSize = true;
            this.lblSoftwareVersion.Location = new System.Drawing.Point(231, 86);
            this.lblSoftwareVersion.Name = "lblSoftwareVersion";
            this.lblSoftwareVersion.Size = new System.Drawing.Size(51, 16);
            this.lblSoftwareVersion.TabIndex = 3;
            this.lblSoftwareVersion.Text = "Verzija:";
            this.lblSoftwareVersion.Click += new System.EventHandler(this.LblSoftwareVersion_Click);
            // 
            // cmbSoftwareVersion
            // 
            this.cmbSoftwareVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSoftwareVersion.FormattingEnabled = true;
            this.cmbSoftwareVersion.Location = new System.Drawing.Point(288, 83);
            this.cmbSoftwareVersion.Name = "cmbSoftwareVersion";
            this.cmbSoftwareVersion.Size = new System.Drawing.Size(90, 24);
            this.cmbSoftwareVersion.TabIndex = 4;
            this.cmbSoftwareVersion.SelectedIndexChanged += new System.EventHandler(this.CmbSoftwareVersion_SelectedIndexChanged);
            // 
            // lblLicenceType
            // 
            this.lblLicenceType.AutoSize = true;
            this.lblLicenceType.Location = new System.Drawing.Point(396, 86);
            this.lblLicenceType.Name = "lblLicenceType";
            this.lblLicenceType.Size = new System.Drawing.Size(76, 16);
            this.lblLicenceType.TabIndex = 5;
            this.lblLicenceType.Text = "Tip licence:";
            this.lblLicenceType.Click += new System.EventHandler(this.LblLicenceType_Click);
            // 
            // lblTotalSeats
            // 
            this.lblTotalSeats.AutoSize = true;
            this.lblTotalSeats.Location = new System.Drawing.Point(617, 86);
            this.lblTotalSeats.Name = "lblTotalSeats";
            this.lblTotalSeats.Size = new System.Drawing.Size(100, 16);
            this.lblTotalSeats.TabIndex = 8;
            this.lblTotalSeats.Text = "Ukupno mjesta:";
            this.lblTotalSeats.Click += new System.EventHandler(this.LblTotalSeats_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(822, 83);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(914, 85);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Uredi";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(914, 56);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Obriši";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(12, 576);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(77, 26);
            this.btnMain.TabIndex = 13;
            this.btnMain.Text = "Izbornik";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.BtnMain_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbxLogo.Image = global::LicenceApp.Properties.Resources.SafeSoft_logo;
            this.pbxLogo.Location = new System.Drawing.Point(12, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(162, 46);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 16;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.Click += new System.EventHandler(this.PbxLogo_Click);
            // 
            // cmbLicenceType
            // 
            this.cmbLicenceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLicenceType.FormattingEnabled = true;
            this.cmbLicenceType.Location = new System.Drawing.Point(478, 83);
            this.cmbLicenceType.Name = "cmbLicenceType";
            this.cmbLicenceType.Size = new System.Drawing.Size(133, 24);
            this.cmbLicenceType.TabIndex = 17;
            this.cmbLicenceType.SelectedIndexChanged += new System.EventHandler(this.CmbLicenceType_SelectedIndexChanged);
            // 
            // numTotalSeats
            // 
            this.numTotalSeats.Location = new System.Drawing.Point(723, 84);
            this.numTotalSeats.Name = "numTotalSeats";
            this.numTotalSeats.Size = new System.Drawing.Size(83, 22);
            this.numTotalSeats.TabIndex = 18;
            this.numTotalSeats.ValueChanged += new System.EventHandler(this.NumTotalSeats_ValueChanged);
            // 
            // dgvSoftwares
            // 
            this.dgvSoftwares.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSoftwares.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvSoftwares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoftwares.Location = new System.Drawing.Point(12, 127);
            this.dgvSoftwares.Name = "dgvSoftwares";
            this.dgvSoftwares.RowHeadersWidth = 51;
            this.dgvSoftwares.RowTemplate.Height = 24;
            this.dgvSoftwares.Size = new System.Drawing.Size(977, 443);
            this.dgvSoftwares.TabIndex = 19;
            this.dgvSoftwares.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSoftwares_CellContentClick);
            this.dgvSoftwares.SelectionChanged += new System.EventHandler(this.DgvSoftwares_SelectionChanged);
            // 
            // FrmSoftware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1021, 614);
            this.Controls.Add(this.dgvSoftwares);
            this.Controls.Add(this.numTotalSeats);
            this.Controls.Add(this.cmbLicenceType);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTotalSeats);
            this.Controls.Add(this.lblLicenceType);
            this.Controls.Add(this.cmbSoftwareVersion);
            this.Controls.Add(this.lblSoftwareVersion);
            this.Controls.Add(this.txtSoftwareName);
            this.Controls.Add(this.lblSoftwareName);
            this.Name = "FrmSoftware";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Softveri";
            this.Load += new System.EventHandler(this.FrmSoftware_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoftwares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblSoftwareName;
        private System.Windows.Forms.TextBox txtSoftwareName;
        private System.Windows.Forms.Label lblSoftwareVersion;
        private System.Windows.Forms.ComboBox cmbSoftwareVersion;
        private System.Windows.Forms.Label lblLicenceType;
        private System.Windows.Forms.Label lblTotalSeats;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.ComboBox cmbLicenceType;
        private System.Windows.Forms.NumericUpDown numTotalSeats;
        private System.Windows.Forms.DataGridView dgvSoftwares;
    }
}



























