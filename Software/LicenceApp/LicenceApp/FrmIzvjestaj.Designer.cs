namespace LicenceApp
{
    partial class FrmIzvjestaj
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
            this.dgvIzvjestaj = new System.Windows.Forms.DataGridView();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.btnGlavni = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblUkupno = new System.Windows.Forms.Label();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIzvjestaj
            // 
            this.dgvIzvjestaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzvjestaj.Location = new System.Drawing.Point(12, 110);
            this.dgvIzvjestaj.Name = "dgvIzvjestaj";
            this.dgvIzvjestaj.RowHeadersWidth = 51;
            this.dgvIzvjestaj.RowTemplate.Height = 24;
            this.dgvIzvjestaj.Size = new System.Drawing.Size(776, 191);
            this.dgvIzvjestaj.TabIndex = 0;
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.Location = new System.Drawing.Point(511, 350);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(75, 23);
            this.btnOsvjezi.TabIndex = 1;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.UseVisualStyleBackColor = true;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // btnGlavni
            // 
            this.btnGlavni.Location = new System.Drawing.Point(713, 320);
            this.btnGlavni.Name = "btnGlavni";
            this.btnGlavni.Size = new System.Drawing.Size(75, 23);
            this.btnGlavni.TabIndex = 3;
            this.btnGlavni.Text = "Izbornik";
            this.btnGlavni.UseVisualStyleBackColor = true;
            this.btnGlavni.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(28, 318);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(51, 23);
            this.btnNatrag.TabIndex = 4;
            this.btnNatrag.Text = "←";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblNaslov.Location = new System.Drawing.Point(221, 67);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(304, 29);
            this.lblNaslov.TabIndex = 5;
            this.lblNaslov.Text = "Izvještaj zahtjeva za licence";
            this.lblNaslov.Click += new System.EventHandler(this.lblNaslov_Click);
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Location = new System.Drawing.Point(289, 401);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(120, 16);
            this.lblUkupno.TabIndex = 6;
            this.lblUkupno.Text = "Ukupno zahtjeva: 0";
            this.lblUkupno.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpOd
            // 
            this.dtpOd.Location = new System.Drawing.Point(274, 320);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(200, 22);
            this.dtpOd.TabIndex = 7;
            this.dtpOd.ValueChanged += new System.EventHandler(this.dtpOd_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Do:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Od: ";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(511, 320);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 10;
            this.btnFilter.Text = "Filteraj";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dtpDo
            // 
            this.dtpDo.Location = new System.Drawing.Point(274, 353);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(200, 22);
            this.dtpDo.TabIndex = 11;
            this.dtpDo.ValueChanged += new System.EventHandler(this.dtpDo_ValueChanged);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::LicenceApp.Properties.Resources.SafeSoft_logo;
            this.pbxLogo.Location = new System.Drawing.Point(12, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(103, 29);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 21;
            this.pbxLogo.TabStop = false;
            // 
            // FrmIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.dtpDo);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpOd);
            this.Controls.Add(this.lblUkupno);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnGlavni);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.dgvIzvjestaj);
            this.Name = "FrmIzvjestaj";
            this.Text = "Izvještaji";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvIzvjestaj;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.Button btnGlavni;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblUkupno;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}