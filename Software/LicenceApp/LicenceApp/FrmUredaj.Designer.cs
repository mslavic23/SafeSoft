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
            this.txtNazivRacunala = new System.Windows.Forms.TextBox();
            this.txtLokacija = new System.Windows.Forms.TextBox();
            this.txtTipUredaja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnNaprijed = new System.Windows.Forms.Button();
            this.btnGlavni = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.lstUredaji = new System.Windows.Forms.ListBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNazivRacunala
            // 
            this.txtNazivRacunala.Location = new System.Drawing.Point(533, 96);
            this.txtNazivRacunala.MaxLength = 20;
            this.txtNazivRacunala.Name = "txtNazivRacunala";
            this.txtNazivRacunala.Size = new System.Drawing.Size(137, 22);
            this.txtNazivRacunala.TabIndex = 1;
            // 
            // txtLokacija
            // 
            this.txtLokacija.Location = new System.Drawing.Point(533, 124);
            this.txtLokacija.MaxLength = 20;
            this.txtLokacija.Name = "txtLokacija";
            this.txtLokacija.Size = new System.Drawing.Size(137, 22);
            this.txtLokacija.TabIndex = 2;
            // 
            // txtTipUredaja
            // 
            this.txtTipUredaja.Location = new System.Drawing.Point(533, 152);
            this.txtTipUredaja.MaxLength = 10;
            this.txtTipUredaja.Name = "txtTipUredaja";
            this.txtTipUredaja.Size = new System.Drawing.Size(137, 22);
            this.txtTipUredaja.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naziv računala:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lokacija:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tip uređaja:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(676, 152);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click_1);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(676, 96);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(75, 23);
            this.btnUredi.TabIndex = 8;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(676, 123);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 9;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // btnNaprijed
            // 
            this.btnNaprijed.Location = new System.Drawing.Point(676, 196);
            this.btnNaprijed.Name = "btnNaprijed";
            this.btnNaprijed.Size = new System.Drawing.Size(52, 23);
            this.btnNaprijed.TabIndex = 10;
            this.btnNaprijed.Text = "→";
            this.btnNaprijed.UseVisualStyleBackColor = true;
            this.btnNaprijed.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // btnGlavni
            // 
            this.btnGlavni.Location = new System.Drawing.Point(76, 270);
            this.btnGlavni.Name = "btnGlavni";
            this.btnGlavni.Size = new System.Drawing.Size(75, 23);
            this.btnGlavni.TabIndex = 11;
            this.btnGlavni.Text = "Izbornik";
            this.btnGlavni.UseVisualStyleBackColor = true;
            this.btnGlavni.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(478, 196);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(49, 23);
            this.btnNatrag.TabIndex = 12;
            this.btnNatrag.Text = "←";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.Button3_Click);
            // 
            // lstUredaji
            // 
            this.lstUredaji.FormattingEnabled = true;
            this.lstUredaji.ItemHeight = 16;
            this.lstUredaji.Location = new System.Drawing.Point(76, 68);
            this.lstUredaji.Name = "lstUredaji";
            this.lstUredaji.Size = new System.Drawing.Size(346, 196);
            this.lstUredaji.TabIndex = 13;
            this.lstUredaji.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
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
            this.Controls.Add(this.lstUredaji);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnGlavni);
            this.Controls.Add(this.btnNaprijed);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTipUredaja);
            this.Controls.Add(this.txtLokacija);
            this.Controls.Add(this.txtNazivRacunala);
            this.Name = "FrmUredaj";
            this.Text = "Uređaji";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtNazivRacunala;
        private System.Windows.Forms.TextBox txtLokacija;
        private System.Windows.Forms.TextBox txtTipUredaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnNaprijed;
        private System.Windows.Forms.Button btnGlavni;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.ListBox lstUredaji;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}