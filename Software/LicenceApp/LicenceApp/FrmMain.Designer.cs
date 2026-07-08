namespace LicenceApp
{
    partial class FrmMain
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
            this.btnSoftwares = new System.Windows.Forms.Button();
            this.btnRequestApp = new System.Windows.Forms.Button();
            this.btnDevices = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSoftwares
            // 
            this.btnSoftwares.Location = new System.Drawing.Point(237, 156);
            this.btnSoftwares.Name = "btnSoftwares";
            this.btnSoftwares.Size = new System.Drawing.Size(145, 62);
            this.btnSoftwares.TabIndex = 0;
            this.btnSoftwares.Text = "Softveri";
            this.btnSoftwares.UseVisualStyleBackColor = true;
            this.btnSoftwares.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnRequestApp
            // 
            this.btnRequestApp.Location = new System.Drawing.Point(237, 237);
            this.btnRequestApp.Name = "btnRequestApp";
            this.btnRequestApp.Size = new System.Drawing.Size(145, 65);
            this.btnRequestApp.TabIndex = 1;
            this.btnRequestApp.Text = "Zahtjevi";
            this.btnRequestApp.UseVisualStyleBackColor = true;
            this.btnRequestApp.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnDevices
            // 
            this.btnDevices.Location = new System.Drawing.Point(416, 156);
            this.btnDevices.Name = "btnDevices";
            this.btnDevices.Size = new System.Drawing.Size(143, 62);
            this.btnDevices.TabIndex = 2;
            this.btnDevices.Text = "Uređaji";
            this.btnDevices.UseVisualStyleBackColor = true;
            this.btnDevices.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(416, 240);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(143, 62);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Izvještaj";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(237, 322);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(322, 26);
            this.btnUsers.TabIndex = 5;
            this.btnUsers.Text = "KORISNICI";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Odjava";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnOdjava_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::LicenceApp.Properties.Resources.SafeSoft_logo;
            this.pbxLogo.Location = new System.Drawing.Point(161, 45);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(471, 96);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 7;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.Click += new System.EventHandler(this.PbxLogo_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnDevices);
            this.Controls.Add(this.btnRequestApp);
            this.Controls.Add(this.btnSoftwares);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SafeSoft";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnSoftwares;
        private System.Windows.Forms.Button btnRequestApp;
        private System.Windows.Forms.Button btnDevices;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}