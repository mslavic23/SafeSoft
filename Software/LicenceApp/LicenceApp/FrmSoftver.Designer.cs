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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVerzija = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTipLicence = new System.Windows.Forms.TextBox();
            this.txtUkupnoMjesta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnGlavni = new System.Windows.Forms.Button();
            this.btnNaprijed = new System.Windows.Forms.Button();
            this.lstSoftveri = new System.Windows.Forms.ListBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(536, 111);
            this.txtNaziv.MaxLength = 30;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(149, 22);
            this.txtNaziv.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Verzija:";
            // 
            // txtVerzija
            // 
            this.txtVerzija.Location = new System.Drawing.Point(536, 139);
            this.txtVerzija.MaxLength = 6;
            this.txtVerzija.Name = "txtVerzija";
            this.txtVerzija.Size = new System.Drawing.Size(149, 22);
            this.txtVerzija.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tip licence:";
            // 
            // txtTipLicence
            // 
            this.txtTipLicence.Location = new System.Drawing.Point(561, 167);
            this.txtTipLicence.MaxLength = 20;
            this.txtTipLicence.Name = "txtTipLicence";
            this.txtTipLicence.Size = new System.Drawing.Size(124, 22);
            this.txtTipLicence.TabIndex = 6;
            // 
            // txtUkupnoMjesta
            // 
            this.txtUkupnoMjesta.Location = new System.Drawing.Point(585, 195);
            this.txtUkupnoMjesta.MaxLength = 4;
            this.txtUkupnoMjesta.Name = "txtUkupnoMjesta";
            this.txtUkupnoMjesta.Size = new System.Drawing.Size(100, 22);
            this.txtUkupnoMjesta.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ukupno mjesta:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(715, 111);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click_1);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(715, 142);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(75, 23);
            this.btnUredi.TabIndex = 10;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.BtnUredi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(715, 173);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 11;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.BtnObrisi_Click_1);
            // 
            // btnGlavni
            // 
            this.btnGlavni.Location = new System.Drawing.Point(467, 245);
            this.btnGlavni.Name = "btnGlavni";
            this.btnGlavni.Size = new System.Drawing.Size(77, 26);
            this.btnGlavni.TabIndex = 13;
            this.btnGlavni.Text = "Izbornik";
            this.btnGlavni.UseVisualStyleBackColor = true;
            this.btnGlavni.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnNaprijed
            // 
            this.btnNaprijed.Location = new System.Drawing.Point(729, 247);
            this.btnNaprijed.Name = "btnNaprijed";
            this.btnNaprijed.Size = new System.Drawing.Size(61, 23);
            this.btnNaprijed.TabIndex = 14;
            this.btnNaprijed.Text = "→";
            this.btnNaprijed.UseVisualStyleBackColor = true;
            this.btnNaprijed.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // lstSoftveri
            // 
            this.lstSoftveri.FormattingEnabled = true;
            this.lstSoftveri.ItemHeight = 16;
            this.lstSoftveri.Location = new System.Drawing.Point(154, 91);
            this.lstSoftveri.Name = "lstSoftveri";
            this.lstSoftveri.Size = new System.Drawing.Size(307, 180);
            this.lstSoftveri.TabIndex = 15;
            this.lstSoftveri.SelectedIndexChanged += new System.EventHandler(this.LstSoftveri_SelectedIndexChanged_1);
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
            this.pbxLogo.Click += new System.EventHandler(this.pbxLogo_Click);
            // 
            // FrmSoftver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.lstSoftveri);
            this.Controls.Add(this.btnNaprijed);
            this.Controls.Add(this.btnGlavni);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUkupnoMjesta);
            this.Controls.Add(this.txtTipLicence);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVerzija);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Name = "FrmSoftver";
            this.Text = "Softveri";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVerzija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTipLicence;
        private System.Windows.Forms.TextBox txtUkupnoMjesta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnGlavni;
        private System.Windows.Forms.Button btnNaprijed;
        private System.Windows.Forms.ListBox lstSoftveri;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}