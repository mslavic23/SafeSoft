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
            this.btnSoftveri = new System.Windows.Forms.Button();
            this.btnZahtjevi = new System.Windows.Forms.Button();
            this.btnUredaji = new System.Windows.Forms.Button();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            this.btnKorisnici = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSoftveri
            // 
            this.btnSoftveri.Location = new System.Drawing.Point(237, 156);
            this.btnSoftveri.Name = "btnSoftveri";
            this.btnSoftveri.Size = new System.Drawing.Size(145, 62);
            this.btnSoftveri.TabIndex = 0;
            this.btnSoftveri.Text = "Softveri";
            this.btnSoftveri.UseVisualStyleBackColor = true;
            this.btnSoftveri.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnZahtjevi
            // 
            this.btnZahtjevi.Location = new System.Drawing.Point(237, 237);
            this.btnZahtjevi.Name = "btnZahtjevi";
            this.btnZahtjevi.Size = new System.Drawing.Size(145, 65);
            this.btnZahtjevi.TabIndex = 1;
            this.btnZahtjevi.Text = "Zahtjevi";
            this.btnZahtjevi.UseVisualStyleBackColor = true;
            this.btnZahtjevi.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnUredaji
            // 
            this.btnUredaji.Location = new System.Drawing.Point(416, 156);
            this.btnUredaji.Name = "btnUredaji";
            this.btnUredaji.Size = new System.Drawing.Size(143, 62);
            this.btnUredaji.TabIndex = 2;
            this.btnUredaji.Text = "Uređaji";
            this.btnUredaji.UseVisualStyleBackColor = true;
            this.btnUredaji.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.Location = new System.Drawing.Point(416, 240);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(143, 62);
            this.btnIzvjestaj.TabIndex = 3;
            this.btnIzvjestaj.Text = "Izvještaj";
            this.btnIzvjestaj.UseVisualStyleBackColor = true;
            this.btnIzvjestaj.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btnKorisnici
            // 
            this.btnKorisnici.Location = new System.Drawing.Point(237, 322);
            this.btnKorisnici.Name = "btnKorisnici";
            this.btnKorisnici.Size = new System.Drawing.Size(322, 26);
            this.btnKorisnici.TabIndex = 5;
            this.btnKorisnici.Text = "KORISNICI";
            this.btnKorisnici.UseVisualStyleBackColor = true;
            this.btnKorisnici.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(12, 12);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(75, 23);
            this.btnOdjava.TabIndex = 6;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.BtnOdjava_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnKorisnici);
            this.Controls.Add(this.btnIzvjestaj);
            this.Controls.Add(this.btnUredaji);
            this.Controls.Add(this.btnZahtjevi);
            this.Controls.Add(this.btnSoftveri);
            this.Name = "FrmMain";
            this.Text = "SafeSoft";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnSoftveri;
        private System.Windows.Forms.Button btnZahtjevi;
        private System.Windows.Forms.Button btnUredaji;
        private System.Windows.Forms.Button btnIzvjestaj;
        private System.Windows.Forms.Button btnKorisnici;
        private System.Windows.Forms.Button btnOdjava;
    }
}