using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using LicenceApp.Repositories;

namespace LicenceApp
{
    public partial class FrmIzvjestaj : Form
    {
        private readonly IzvjestajRepository _izvjestajRepository = new IzvjestajRepository();

        private Chart chartZahtjeviPoMjesecu;
        private Chart chartTipoviLicenci;

        private const int RazmakGrafova = 10;

        public FrmIzvjestaj()
        {
            InitializeComponent();

            SetupCharts();

            dtpDateFrom.Value = DateTime.Now.AddMonths(-1);
            dtpDateTil.Value = DateTime.Now;

            RefreshReport();
        }

        private void SetupCharts()
        {
            const int MaxVisinaGrafova = 150;

            int dnoZaglavlja = Math.Max(
                Math.Max(dtpDateFrom.Bottom, dtpDateTil.Bottom),
                Math.Max(lblFrmReportTitle.Bottom, Math.Max(btnMain.Bottom, Math.Max(btnFilterReport.Bottom, btnRefreshReport.Bottom)))
            );

            int vrhGrafova = dnoZaglavlja + RazmakGrafova;
            int dnoTablice = dgvReport.Bottom;

            int visinaGrafova = Math.Min(MaxVisinaGrafova, dgvReport.Top - vrhGrafova - RazmakGrafova);
            int sirinaSvakogGrafa = (dgvReport.Width - RazmakGrafova) / 2;

            chartZahtjeviPoMjesecu = new Chart
            {
                Location = new Point(dgvReport.Left, vrhGrafova),
                Size = new Size(sirinaSvakogGrafa, visinaGrafova)
            };
            chartZahtjeviPoMjesecu.ChartAreas.Add(new ChartArea("Glavno"));
            chartZahtjeviPoMjesecu.Titles.Add("Zahtjevi po mjesecu");
            var serijaMjeseci = new Series("ZahtjeviPoMjesecu")
            {
                ChartType = SeriesChartType.Line,
                ChartArea = "Glavno",
                BorderWidth = 3,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 8
            };
            chartZahtjeviPoMjesecu.Series.Add(serijaMjeseci);

            chartTipoviLicenci = new Chart
            {
                Location = new Point(chartZahtjeviPoMjesecu.Right + RazmakGrafova, vrhGrafova),
                Size = new Size(dgvReport.Width - sirinaSvakogGrafa - RazmakGrafova, visinaGrafova)
            };
            chartTipoviLicenci.ChartAreas.Add(new ChartArea("Glavno"));
            chartTipoviLicenci.Titles.Add("Vrste licenci prema zahtjevima");
            chartTipoviLicenci.Legends.Add(new Legend("Legenda"));
            var serijaLicenci = new Series("TipoviLicenci")
            {
                ChartType = SeriesChartType.Pie,
                ChartArea = "Glavno",
                Legend = "Legenda",
                IsValueShownAsLabel = false
            };
            serijaLicenci["PieLabelStyle"] = "Disabled";
            chartTipoviLicenci.Series.Add(serijaLicenci);

            this.Controls.Add(chartZahtjeviPoMjesecu);
            this.Controls.Add(chartTipoviLicenci);

            dgvReport.Top = chartZahtjeviPoMjesecu.Bottom + RazmakGrafova;
            dgvReport.Height = dnoTablice - dgvReport.Top;
        }

        private void RefreshReport()
        {
            var stavke = _izvjestajRepository.GetReport();
            DisplayReport(stavke);
        }

        private void DisplayReport(List<ReportLine> stavke)
        {
            dgvReport.DataSource = null;
            dgvReport.AutoGenerateColumns = true;
            dgvReport.DataSource = stavke;

            if (dgvReport.Columns.Contains("User"))
                dgvReport.Columns["User"].HeaderText = "Korisnik";
            if (dgvReport.Columns.Contains("Software"))
                dgvReport.Columns["Software"].HeaderText = "Softver";
            if (dgvReport.Columns.Contains("Version"))
                dgvReport.Columns["Version"].HeaderText = "Verzija";
            if (dgvReport.Columns.Contains("LicenceType"))
                dgvReport.Columns["LicenceType"].HeaderText = "Tip licence";
            if (dgvReport.Columns.Contains("Device"))
                dgvReport.Columns["Device"].HeaderText = "Uređaj";
            if (dgvReport.Columns.Contains("Location"))
                dgvReport.Columns["Location"].HeaderText = "Lokacija";
            if (dgvReport.Columns.Contains("Reason"))
                dgvReport.Columns["Reason"].HeaderText = "Razlog korištenja";
            if (dgvReport.Columns.Contains("Date"))
                dgvReport.Columns["Date"].HeaderText = "Datum podnošenja";
            if (dgvReport.Columns.Contains("TotalSeats"))
                dgvReport.Columns["TotalSeats"].HeaderText = "Ukupno mjesta";
            if (dgvReport.Columns.Contains("OccupiedSeats"))
                dgvReport.Columns["OccupiedSeats"].HeaderText = "Zauzeta mjesta";
            if (dgvReport.Columns.Contains("AvailableSeats"))
                dgvReport.Columns["AvailableSeats"].HeaderText = "Slobodna mjesta";
            if (dgvReport.Columns.Contains("Id"))
                dgvReport.Columns["Id"].Visible = false;

            lblTotalRequests.Text = $"Ukupno zahtjeva: {stavke.Count}";

            UpdateCharts(stavke);
        }

        private void UpdateCharts(List<ReportLine> stavke)
        {
            var serijaMjeseci = chartZahtjeviPoMjesecu.Series["ZahtjeviPoMjesecu"];
            serijaMjeseci.Points.Clear();

            var poMjesecu = stavke
                .GroupBy(s => new { s.Date.Year, s.Date.Month })
                .OrderBy(g => g.Key.Year).ThenBy(g => g.Key.Month)
                .Select(g => new
                {
                    Oznaka = new DateTime(g.Key.Year, g.Key.Month, 1).ToString("MM.yyyy"),
                    Broj = g.Count()
                });

            foreach (var stavka in poMjesecu)
            {
                serijaMjeseci.Points.AddXY(stavka.Oznaka, stavka.Broj);
            }

            var serijaLicenci = chartTipoviLicenci.Series["TipoviLicenci"];
            serijaLicenci.Points.Clear();

            var poTipuLicence = stavke
                .GroupBy(s => s.LicenceType)
                .Select(g => new { Tip = g.Key, Broj = g.Count() });

            foreach (var stavka in poTipuLicence)
            {
                serijaLicenci.Points.AddXY(stavka.Tip, stavka.Broj);
            }
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
            DisplayReport(stavke);
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