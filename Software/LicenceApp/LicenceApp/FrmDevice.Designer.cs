namespace LicenceApp
{
    partial class FrmDevice
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
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.lblDeviceLocation = new System.Windows.Forms.Label();
            this.lblDeviceType = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.lstDevices = new System.Windows.Forms.ListBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.cmbDeviceLocation = new System.Windows.Forms.ComboBox();
            this.cmbDeviceType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Location = new System.Drawing.Point(490, 228);
            this.txtDeviceName.MaxLength = 20;
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(364, 22);
            this.txtDeviceName.TabIndex = 1;
            this.txtDeviceName.TextChanged += new System.EventHandler(this.TxtDeviceName_TextChanged);
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Location = new System.Drawing.Point(385, 234);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(99, 16);
            this.lblDeviceName.TabIndex = 4;
            this.lblDeviceName.Text = "Naziv računala:";
            this.lblDeviceName.Click += new System.EventHandler(this.LblDeviceName_Click);
            // 
            // lblDeviceLocation
            // 
            this.lblDeviceLocation.AutoSize = true;
            this.lblDeviceLocation.Location = new System.Drawing.Point(423, 264);
            this.lblDeviceLocation.Name = "lblDeviceLocation";
            this.lblDeviceLocation.Size = new System.Drawing.Size(61, 16);
            this.lblDeviceLocation.TabIndex = 5;
            this.lblDeviceLocation.Text = "Lokacija:";
            this.lblDeviceLocation.Click += new System.EventHandler(this.LblDeviceLocation_Click);
            // 
            // lblDeviceType
            // 
            this.lblDeviceType.AutoSize = true;
            this.lblDeviceType.Location = new System.Drawing.Point(405, 289);
            this.lblDeviceType.Name = "lblDeviceType";
            this.lblDeviceType.Size = new System.Drawing.Size(79, 16);
            this.lblDeviceType.TabIndex = 6;
            this.lblDeviceType.Text = "Tip uređaja:";
            this.lblDeviceType.Click += new System.EventHandler(this.LblDeviceType_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(897, 290);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.Location = new System.Drawing.Point(897, 231);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Uredi";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(897, 261);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Obriši";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMain.Location = new System.Drawing.Point(24, 415);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(75, 23);
            this.btnMain.TabIndex = 11;
            this.btnMain.Text = "Izbornik";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.BtnMain_Click);
            // 
            // lstDevices
            // 
            this.lstDevices.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lstDevices.FormattingEnabled = true;
            this.lstDevices.ItemHeight = 16;
            this.lstDevices.Location = new System.Drawing.Point(24, 145);
            this.lstDevices.Name = "lstDevices";
            this.lstDevices.Size = new System.Drawing.Size(325, 260);
            this.lstDevices.TabIndex = 13;
            this.lstDevices.SelectedIndexChanged += new System.EventHandler(this.LstDevices_SelectedIndexChanged);
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pbxLogo.Image = global::LicenceApp.Properties.Resources.SafeSoft_logo;
            this.pbxLogo.Location = new System.Drawing.Point(12, 27);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(176, 48);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 14;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.Click += new System.EventHandler(this.PbxLogo_Click);
            // 
            // cmbDeviceLocation
            // 
            this.cmbDeviceLocation.FormattingEnabled = true;
            this.cmbDeviceLocation.Location = new System.Drawing.Point(490, 256);
            this.cmbDeviceLocation.Name = "cmbDeviceLocation";
            this.cmbDeviceLocation.Size = new System.Drawing.Size(364, 24);
            this.cmbDeviceLocation.TabIndex = 15;
            this.cmbDeviceLocation.SelectedIndexChanged += new System.EventHandler(this.CmbDeviceLocation_SelectedIndexChanged);
            // 
            // cmbDeviceType
            // 
            this.cmbDeviceType.FormattingEnabled = true;
            this.cmbDeviceType.Location = new System.Drawing.Point(490, 286);
            this.cmbDeviceType.Name = "cmbDeviceType";
            this.cmbDeviceType.Size = new System.Drawing.Size(364, 24);
            this.cmbDeviceType.TabIndex = 16;
            this.cmbDeviceType.SelectedIndexChanged += new System.EventHandler(this.CmbDeviceType_SelectedIndexChanged);
            // 
            // FrmDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1003, 567);
            this.Controls.Add(this.cmbDeviceType);
            this.Controls.Add(this.cmbDeviceLocation);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.lstDevices);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDeviceType);
            this.Controls.Add(this.lblDeviceLocation);
            this.Controls.Add(this.lblDeviceName);
            this.Controls.Add(this.txtDeviceName);
            this.Name = "FrmDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uređaji";
            this.Load += new System.EventHandler(this.FrmDevice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.Label lblDeviceLocation;
        private System.Windows.Forms.Label lblDeviceType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.ListBox lstDevices;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.ComboBox cmbDeviceLocation;
        private System.Windows.Forms.ComboBox cmbDeviceType;
    }
}