using System;
using System.Windows.Forms;

namespace LicenceApp
{
    public partial class FrmIzvjestaj : Form
    {
        public FrmIzvjestaj()
        {
            InitializeComponent();
        }

        private void BtnRefreshReport_Click(object sender, EventArgs e)
        {

        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {

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