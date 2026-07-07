namespace LicenceApp
{
    partial class FrmUredaj
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
            this.txtDeviceLocation = new System.Windows.Forms.TextBox();
            this.txtDeviceType = new System.Windows.Forms.TextBox();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.lblDeviceLocation = new System.Windows.Forms.Label();
            this.lblDeviceType = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGoFoward = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.lstDevices = new System.Windows.Forms.ListBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Location = new System.Drawing.Point(533, 96);
            this.txtDeviceName.MaxLength = 20;
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(137, 22);
            this.txtDeviceName.TabIndex = 1;
            this.txtDeviceName.TextChanged += new System.EventHandler(this.txtDeviceName_TextChanged);
            // 
            // txtDeviceLocation
            // 
            this.txtDeviceLocation.Location = new System.Drawing.Point(533, 124);
            this.txtDeviceLocation.MaxLength = 20;
            this.txtDeviceLocation.Name = "txtDeviceLocation";
            this.txtDeviceLocation.Size = new System.Drawing.Size(137, 22);
            this.txtDeviceLocation.TabIndex = 2;
            this.txtDeviceLocation.TextChanged += new System.EventHandler(this.txtLokacija_TextChanged);
            // 
            // txtDeviceType
            // 
            this.txtDeviceType.Location = new System.Drawing.Point(533, 152);
            this.txtDeviceType.MaxLength = 10;
            this.txtDeviceType.Name = "txtDeviceType";
            this.txtDeviceType.Size = new System.Drawing.Size(137, 22);
            this.txtDeviceType.TabIndex = 3;
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Location = new System.Drawing.Point(428, 99);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(99, 16);
            this.lblDeviceName.TabIndex = 4;
            this.lblDeviceName.Text = "Naziv računala:";
            this.lblDeviceName.Click += new System.EventHandler(this.lbName_Click);
            // 
            // lblDeviceLocation
            // 
            this.lblDeviceLocation.AutoSize = true;
            this.lblDeviceLocation.Location = new System.Drawing.Point(466, 124);
            this.lblDeviceLocation.Name = "lblDeviceLocation";
            this.lblDeviceLocation.Size = new System.Drawing.Size(61, 16);
            this.lblDeviceLocation.TabIndex = 5;
            this.lblDeviceLocation.Text = "Lokacija:";
            this.lblDeviceLocation.Click += new System.EventHandler(this.lbLocation_Click);
            // 
            // lblDeviceType
            // 
            this.lblDeviceType.AutoSize = true;
            this.lblDeviceType.Location = new System.Drawing.Point(448, 152);
            this.lblDeviceType.Name = "lblDeviceType";
            this.lblDeviceType.Size = new System.Drawing.Size(79, 16);
            this.lblDeviceType.TabIndex = 6;
            this.lblDeviceType.Text = "Tip uređaja:";
            this.lblDeviceType.Click += new System.EventHandler(this.lbType_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(676, 152);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnDodaj_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(676, 96);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Uredi";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(676, 123);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Obriši";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // btnGoFoward
            // 
            this.btnGoFoward.Location = new System.Drawing.Point(676, 196);
            this.btnGoFoward.Name = "btnGoFoward";
            this.btnGoFoward.Size = new System.Drawing.Size(52, 23);
            this.btnGoFoward.TabIndex = 10;
            this.btnGoFoward.Text = "→";
            this.btnGoFoward.UseVisualStyleBackColor = true;
            this.btnGoFoward.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(76, 270);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(75, 23);
            this.btnMain.TabIndex = 11;
            this.btnMain.Text = "Izbornik";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(478, 196);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(49, 23);
            this.btnGoBack.TabIndex = 12;
            this.btnGoBack.Text = "←";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.Button3_Click);
            // 
            // lstDevices
            // 
            this.lstDevices.FormattingEnabled = true;
            this.lstDevices.ItemHeight = 16;
            this.lstDevices.Location = new System.Drawing.Point(76, 68);
            this.lstDevices.Name = "lstDevices";
            this.lstDevices.Size = new System.Drawing.Size(346, 196);
            this.lstDevices.TabIndex = 13;
            this.lstDevices.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::LicenceApp.Properties.Resources.SafeSoft_logo;
            this.pbxLogo.Location = new System.Drawing.Point(76, 27);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(113, 35);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 14;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.Click += new System.EventHandler(this.PbxLogo_Click);
            // 
            // FrmUredaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.lstDevices);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnGoFoward);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDeviceType);
            this.Controls.Add(this.lblDeviceLocation);
            this.Controls.Add(this.lblDeviceName);
            this.Controls.Add(this.txtDeviceType);
            this.Controls.Add(this.txtDeviceLocation);
            this.Controls.Add(this.txtDeviceName);
            this.Name = "FrmUredaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uređaji";
            this.Load += new System.EventHandler(this.FrmUredaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.TextBox txtDeviceLocation;
        private System.Windows.Forms.TextBox txtDeviceType;
        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.Label lblDeviceLocation;
        private System.Windows.Forms.Label lblDeviceType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGoFoward;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.ListBox lstDevices;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}