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
            this.cmbKorisnik = new System.Windows.Forms.ComboBox();
            this.cmbSoftver = new System.Windows.Forms.ComboBox();
            this.cmbUredaj = new System.Windows.Forms.ComboBox();
            this.txtRazlog = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnNaprijed = new System.Windows.Forms.Button();
            this.btnGlavni = new System.Windows.Forms.Button();
            this.lstZahtjevi = new System.Windows.Forms.ListBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKorisnik
            // 
            this.cmbKorisnik.FormattingEnabled = true;
            this.cmbKorisnik.Location = new System.Drawing.Point(473, 160);
            this.cmbKorisnik.Name = "cmbKorisnik";
            this.cmbKorisnik.Size = new System.Drawing.Size(210, 24);
            this.cmbKorisnik.TabIndex = 1;
            // 
            // cmbSoftver
            // 
            this.cmbSoftver.FormattingEnabled = true;
            this.cmbSoftver.Location = new System.Drawing.Point(470, 220);
            this.cmbSoftver.Name = "cmbSoftver";
            this.cmbSoftver.Size = new System.Drawing.Size(210, 24);
            this.cmbSoftver.TabIndex = 2;
            // 
            // cmbUredaj
            // 
            this.cmbUredaj.FormattingEnabled = true;
            this.cmbUredaj.Location = new System.Drawing.Point(470, 190);
            this.cmbUredaj.Name = "cmbUredaj";
            this.cmbUredaj.Size = new System.Drawing.Size(210, 24);
            this.cmbUredaj.TabIndex = 3;
            // 
            // txtRazlog
            // 
            this.txtRazlog.Location = new System.Drawing.Point(470, 281);
            this.txtRazlog.MaxLength = 100;
            this.txtRazlog.Name = "txtRazlog";
            this.txtRazlog.Size = new System.Drawing.Size(210, 22);
            this.txtRazlog.TabIndex = 4;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(470, 250);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(210, 22);
            this.dtpDatum.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Softver:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Uređaj: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Korisnik:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Razlog korištenja:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Datum podnošenja:";
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(689, 220);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(75, 23);
            this.btnUredi.TabIndex = 13;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(689, 249);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 14;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(689, 180);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 15;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnNaprijed
            // 
            this.btnNaprijed.Location = new System.Drawing.Point(702, 307);
            this.btnNaprijed.Name = "btnNaprijed";
            this.btnNaprijed.Size = new System.Drawing.Size(50, 23);
            this.btnNaprijed.TabIndex = 16;
            this.btnNaprijed.Text = "→";
            this.btnNaprijed.UseVisualStyleBackColor = true;
            this.btnNaprijed.Click += new System.EventHandler(this.btnNaprijed_Click);
            // 
            // btnGlavni
            // 
            this.btnGlavni.Location = new System.Drawing.Point(689, 278);
            this.btnGlavni.Name = "btnGlavni";
            this.btnGlavni.Size = new System.Drawing.Size(75, 23);
            this.btnGlavni.TabIndex = 17;
            this.btnGlavni.Text = "Izbornik";
            this.btnGlavni.UseVisualStyleBackColor = true;
            this.btnGlavni.Click += new System.EventHandler(this.btnGlavni_Click);
            // 
            // lstZahtjevi
            // 
            this.lstZahtjevi.FormattingEnabled = true;
            this.lstZahtjevi.ItemHeight = 16;
            this.lstZahtjevi.Location = new System.Drawing.Point(34, 120);
            this.lstZahtjevi.Name = "lstZahtjevi";
            this.lstZahtjevi.Size = new System.Drawing.Size(308, 180);
            this.lstZahtjevi.TabIndex = 19;
            this.lstZahtjevi.SelectedIndexChanged += new System.EventHandler(this.lstZahtjevi_SelectedIndexChanged);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::LicenceApp.Properties.Resources.SafeSoft_logo;
            this.pbxLogo.Location = new System.Drawing.Point(470, 78);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(215, 61);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 20;
            this.pbxLogo.TabStop = false;
            // 
            // FrmZahtjev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.lstZahtjevi);
            this.Controls.Add(this.btnGlavni);
            this.Controls.Add(this.btnNaprijed);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.txtRazlog);
            this.Controls.Add(this.cmbUredaj);
            this.Controls.Add(this.cmbSoftver);
            this.Controls.Add(this.cmbKorisnik);
            this.Name = "FrmZahtjev";
            this.Text = "Zahtjevi";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox cmbKorisnik;
        private System.Windows.Forms.ComboBox cmbSoftver;
        private System.Windows.Forms.ComboBox cmbUredaj;
        private System.Windows.Forms.TextBox txtRazlog;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnNaprijed;
        private System.Windows.Forms.Button btnGlavni;
        private System.Windows.Forms.ListBox lstZahtjevi;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}