using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using LicenceApp.Repositories;

namespace LicenceApp
{
    public partial class FrmReport : Form
    {
        private readonly ReportRepository _reportRepository = new ReportRepository();

        private Chart chartRequestsByMonth;
        private Chart chartLicenceTypes;

        private const int ChartSpacing = 10;

        public FrmReport()
        {
            InitializeComponent();

            SetupCharts();

            dtpDateFrom.Value = DateTime.Now.AddMonths(-1);
            dtpDateTil.Value = DateTime.Now;

            RefreshReport();
        }

        private void SetupCharts()
        {
            const int MaxChartHeight = 150;
            const int MinChartSize = 50;

            int headerBottom = Math.Max(
                Math.Max(dtpDateFrom.Bottom, dtpDateTil.Bottom),
                Math.Max(lblFrmReportTitle.Bottom, Math.Max(btnFilterReport.Bottom, btnRefreshReport.Bottom))
            );

            int chartsTop = headerBottom + ChartSpacing;
            int tableBottom = dgvReport.Bottom;

            int chartHeight = Math.Max(MinChartSize, Math.Min(MaxChartHeight, dgvReport.Top - chartsTop - ChartSpacing));
            int chartWidth = Math.Max(MinChartSize, (dgvReport.Width - ChartSpacing) / 2);

            chartRequestsByMonth = new Chart
            {
                Location = new Point(dgvReport.Left, chartsTop),
                Size = new Size(chartWidth, chartHeight)
            };
            chartRequestsByMonth.ChartAreas.Add(new ChartArea("Main"));
            chartRequestsByMonth.Titles.Add("Zahtjevi po mjesecu");
            var monthlySeries = new Series("RequestsByMonth")
            {
                ChartType = SeriesChartType.Line,
                ChartArea = "Main",
                BorderWidth = 3,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 8
            };
            chartRequestsByMonth.Series.Add(monthlySeries);

            chartLicenceTypes = new Chart
            {
                Location = new Point(chartRequestsByMonth.Right + ChartSpacing, chartsTop),
                Size = new Size(chartWidth, chartHeight)
            };
            chartLicenceTypes.ChartAreas.Add(new ChartArea("Main"));
            chartLicenceTypes.Titles.Add("Vrste licenci prema zahtjevima");
            chartLicenceTypes.Legends.Add(new Legend("Legend"));
            var licenceSeries = new Series("LicenceTypes")
            {
                ChartType = SeriesChartType.Pie,
                ChartArea = "Main",
                Legend = "Legend",
                IsValueShownAsLabel = false
            };
            licenceSeries["PieLabelStyle"] = "Disabled";
            chartLicenceTypes.Series.Add(licenceSeries);

            this.Controls.Add(chartRequestsByMonth);
            this.Controls.Add(chartLicenceTypes);

            dgvReport.Top = chartRequestsByMonth.Bottom + ChartSpacing;
            dgvReport.Height = Math.Max(MinChartSize, tableBottom - dgvReport.Top);
        }

        private void RefreshReport()
        {
            var items = _reportRepository.GetReport();

            if (items.Count > 0)
            {
                dtpDateFrom.Value = items.Min(i => i.Date);
                dtpDateTil.Value = items.Max(i => i.Date);
            }

            DisplayReport(items);
        }

        private void DisplayReport(List<ReportLine> items)
        {
            dgvReport.DataSource = null;
            dgvReport.AutoGenerateColumns = true;
            dgvReport.DataSource = items;

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

            lblTotalRequests.Text = $"Ukupno zahtjeva: {items.Count}";

            UpdateCharts(items);
        }

        private void UpdateCharts(List<ReportLine> items)
        {
            var monthlySeries = chartRequestsByMonth.Series["RequestsByMonth"];
            monthlySeries.Points.Clear();

            var groupedByMonth = items
                .GroupBy(i => new { i.Date.Year, i.Date.Month })
                .OrderBy(g => g.Key.Year).ThenBy(g => g.Key.Month)
                .Select(g => new
                {
                    Label = new DateTime(g.Key.Year, g.Key.Month, 1).ToString("MM.yyyy"),
                    Count = g.Count()
                });

            foreach (var item in groupedByMonth)
            {
                monthlySeries.Points.AddXY(item.Label, item.Count);
            }

            var licenceSeries = chartLicenceTypes.Series["LicenceTypes"];
            licenceSeries.Points.Clear();

            var groupedByLicenceType = items
                .GroupBy(i => i.LicenceType)
                .Select(g => new { Type = g.Key, Count = g.Count() });

            foreach (var item in groupedByLicenceType)
            {
                licenceSeries.Points.AddXY(item.Type, item.Count);
            }
        }

        private void BtnRefreshReport_Click(object sender, EventArgs e)
        {
            RefreshReport();
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtpDateFrom.Value.Date;
            DateTime toDate = dtpDateTil.Value.Date.AddDays(1).AddTicks(-1);

            if (fromDate > toDate)
            {
                MessageBox.Show("Datum 'Od' ne može biti nakon datuma 'Do'!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var items = _reportRepository.GetReport(fromDate, toDate);
            DisplayReport(items);
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