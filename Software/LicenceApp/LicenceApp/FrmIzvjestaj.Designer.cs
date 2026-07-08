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
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.btnRefreshReport = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.lblFrmReportTitle = new System.Windows.Forms.Label();
            this.lblTotalRequests = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDateTIl = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.btnFilterReport = new System.Windows.Forms.Button();
            this.dtpDateTil = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(6, 371);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(1006, 215);
            this.dgvReport.TabIndex = 0;
            this.dgvReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvReport_CellContentClick);
            // 
            // btnRefreshReport
            // 
            this.btnRefreshReport.Location = new System.Drawing.Point(922, 97);
            this.btnRefreshReport.Name = "btnRefreshReport";
            this.btnRefreshReport.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshReport.TabIndex = 1;
            this.btnRefreshReport.Text = "Osvježi";
            this.btnRefreshReport.UseVisualStyleBackColor = true;
            this.btnRefreshReport.Click += new System.EventHandler(this.BtnRefreshReport_Click);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(922, 36);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(75, 23);
            this.btnMain.TabIndex = 3;
            this.btnMain.Text = "Izbornik";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.BtnMain_Click);
            // 
            // lblFrmReportTitle
            // 
            this.lblFrmReportTitle.AutoSize = true;
            this.lblFrmReportTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblFrmReportTitle.Location = new System.Drawing.Point(401, 97);
            this.lblFrmReportTitle.Name = "lblFrmReportTitle";
            this.lblFrmReportTitle.Size = new System.Drawing.Size(197, 29);
            this.lblFrmReportTitle.TabIndex = 5;
            this.lblFrmReportTitle.Text = "Izvještaj zahtjeva ";
            this.lblFrmReportTitle.Click += new System.EventHandler(this.LblFrmReportTitle_Click);
            // 
            // lblTotalRequests
            // 
            this.lblTotalRequests.AutoSize = true;
            this.lblTotalRequests.Location = new System.Drawing.Point(466, 589);
            this.lblTotalRequests.Name = "lblTotalRequests";
            this.lblTotalRequests.Size = new System.Drawing.Size(120, 16);
            this.lblTotalRequests.TabIndex = 6;
            this.lblTotalRequests.Text = "Ukupno zahtjeva: 0";
            this.lblTotalRequests.Click += new System.EventHandler(this.LblTotalRequests_Click);
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Location = new System.Drawing.Point(89, 57);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(379, 22);
            this.dtpDateFrom.TabIndex = 7;
            this.dtpDateFrom.ValueChanged += new System.EventHandler(this.DtpDateFrom_ValueChanged);
            // 
            // lblDateTIl
            // 
            this.lblDateTIl.AutoSize = true;
            this.lblDateTIl.Location = new System.Drawing.Point(512, 63);
            this.lblDateTIl.Name = "lblDateTIl";
            this.lblDateTIl.Size = new System.Drawing.Size(28, 16);
            this.lblDateTIl.TabIndex = 8;
            this.lblDateTIl.Text = "Do:";
            this.lblDateTIl.Click += new System.EventHandler(this.LblDateTIl_Click);
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Location = new System.Drawing.Point(52, 62);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(31, 16);
            this.lblDateFrom.TabIndex = 9;
            this.lblDateFrom.Text = "Od: ";
            this.lblDateFrom.Click += new System.EventHandler(this.LblDateFrom_Click);
            // 
            // btnFilterReport
            // 
            this.btnFilterReport.Location = new System.Drawing.Point(922, 68);
            this.btnFilterReport.Name = "btnFilterReport";
            this.btnFilterReport.Size = new System.Drawing.Size(75, 23);
            this.btnFilterReport.TabIndex = 10;
            this.btnFilterReport.Text = "Filteraj";
            this.btnFilterReport.UseVisualStyleBackColor = true;
            this.btnFilterReport.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // dtpDateTil
            // 
            this.dtpDateTil.Location = new System.Drawing.Point(546, 58);
            this.dtpDateTil.Name = "dtpDateTil";
            this.dtpDateTil.Size = new System.Drawing.Size(338, 22);
            this.dtpDateTil.TabIndex = 11;
            this.dtpDateTil.ValueChanged += new System.EventHandler(this.DtpDateTil_ValueChanged);
            // 
            // FrmIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 614);
            this.Controls.Add(this.dtpDateTil);
            this.Controls.Add(this.btnFilterReport);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.lblDateTIl);
            this.Controls.Add(this.dtpDateFrom);
            this.Controls.Add(this.lblTotalRequests);
            this.Controls.Add(this.lblFrmReportTitle);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnRefreshReport);
            this.Controls.Add(this.dgvReport);
            this.Name = "FrmIzvjestaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izvještaji";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button btnRefreshReport;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Label lblFrmReportTitle;
        private System.Windows.Forms.Label lblTotalRequests;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label lblDateTIl;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Button btnFilterReport;
        private System.Windows.Forms.DateTimePicker dtpDateTil;
    }
}