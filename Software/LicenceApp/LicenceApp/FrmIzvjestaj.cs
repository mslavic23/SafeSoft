using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LicenceApp.Repositories;

namespace LicenceApp
{
    public partial class FrmIzvjestaj : Form
    {
        private readonly IzvjestajRepository _izvjestajRepository = new IzvjestajRepository();

        public FrmIzvjestaj()
        {
            InitializeComponent();
            dtpDateFrom.Value = DateTime.Now.AddMonths(-1);
            dtpDateTil.Value = DateTime.Now;
            RefreshReport();
        }

        private void RefreshReport()
        {
            var stavke = _izvjestajRepository.GetReport();
            PrikaziIzvjestaj(stavke);
        }

        private void PrikaziIzvjestaj(List<IzvjestajStavka> stavke)
        {
            dgvReport.DataSource = null;
            dgvReport.AutoGenerateColumns = true;
            dgvReport.DataSource = stavke;

            if (dgvReport.Columns.Contains("Korisnik"))
                dgvReport.Columns["Korisnik"].HeaderText = "Korisnik";
            if (dgvReport.Columns.Contains("Softver"))
                dgvReport.Columns["Softver"].HeaderText = "Softver";
            if (dgvReport.Columns.Contains("Verzija"))
                dgvReport.Columns["Verzija"].HeaderText = "Verzija";
            if (dgvReport.Columns.Contains("Uredaj"))
                dgvReport.Columns["Uredaj"].HeaderText = "Uređaj";
            if (dgvReport.Columns.Contains("Lokacija"))
                dgvReport.Columns["Lokacija"].HeaderText = "Lokacija";
            if (dgvReport.Columns.Contains("Razlog"))
                dgvReport.Columns["Razlog"].HeaderText = "Razlog korištenja";
            if (dgvReport.Columns.Contains("Datum"))
                dgvReport.Columns["Datum"].HeaderText = "Datum podnošenja";
            if (dgvReport.Columns.Contains("UkupnoMjesta"))
                dgvReport.Columns["UkupnoMjesta"].HeaderText = "Ukupno mjesta";
            if (dgvReport.Columns.Contains("ZauzetaMjesta"))
                dgvReport.Columns["ZauzetaMjesta"].HeaderText = "Zauzeta mjesta";
            if (dgvReport.Columns.Contains("SlobodnaMjesta"))
                dgvReport.Columns["SlobodnaMjesta"].HeaderText = "Slobodna mjesta";
            if (dgvReport.Columns.Contains("ID"))
                dgvReport.Columns["ID"].Visible = false;

            lblTotalRequests.Text = $"Ukupno zahtjeva: {stavke.Count}";
        }

        private void BtnRefreshReport_Click(object sender, EventArgs e)
        {
            RefreshReport();
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            DateTime od = dtpDateFrom.Value.Date;
            DateTime doDatuma = dtpDateTil.Value.Date.AddDays(1).AddTicks(-1);

            if (od > doDatuma)
            {
                MessageBox.Show("Datum 'Od' ne može biti nakon datuma 'Do'!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var stavke = _izvjestajRepository.GetReport(od, doDatuma);
            PrikaziIzvjestaj(stavke);
        }

        private void DtpDateFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DtpDateTil_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnMain_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();
        }

        private void LblFrmReportTitle_Click(object sender, EventArgs e)
        {

        }

        private void LblTotalRequests_Click(object sender, EventArgs e)
        {

        }

        private void LblDateTIl_Click(object sender, EventArgs e)
        {

        }

        private void LblDateFrom_Click(object sender, EventArgs e)
        {

        }

        private void DgvReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}