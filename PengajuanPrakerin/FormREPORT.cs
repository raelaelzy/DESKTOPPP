
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace PengajuanPrakerin
{
    public partial class FormREPORT : Form
    {
        private string reportFileName;

        public FormREPORT() : this("LAPORAN_DATA_SISWA.rpt")
        {
        }

        public FormREPORT(string fileName)
        {
            InitializeComponent();
            this.reportFileName = fileName;
            this.Load += FormREPORT_Load;
        }

        public FormREPORT(ReportDocument rpt)
        {
            InitializeComponent();
            SetReport(rpt);
        }

        public void SetReport(ReportDocument rpt)
        {
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

        private void FormREPORT_Load(object sender, EventArgs e)
        {
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(reportFileName))
            {
                TampilReport(reportFileName);
            }
        }

        public void TampilReport(string namaFile)
        {
            try
            {
                string reportPath = Path.Combine(
                    Application.StartupPath,
                    namaFile
                );

                if (!File.Exists(reportPath))
                {
                    MessageBox.Show(
                        "File tidak ditemukan!\n\n" +
                        "Nama file: " + namaFile + "\n" +
                        "Lokasi aplikasi: " + Application.StartupPath + "\n" +
                        "Lokasi yang dicari: " + reportPath
                    );
                    return;
                }

                if (!File.Exists(reportPath))
                {
                    MessageBox.Show("File Laporan tidak ditemukan");
                    return;
                }

                ReportDocument rpt = new ReportDocument();
                rpt.Load(reportPath);

                ConnectionInfo crConn = new ConnectionInfo();
                crConn.ServerName = "localhost";
                crConn.DatabaseName = "db_prakerin";
                crConn.UserID = "root";
                crConn.Password = "";

                foreach (Table crTabel in rpt.Database.Tables)
                {
                    TableLogOnInfo crlogon = crTabel.LogOnInfo;
                    crlogon.ConnectionInfo = crConn;
                    crTabel.ApplyLogOnInfo(crlogon);
                }
                SetReport(rpt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menampilkan laporan: " + ex.Message);
            }
        }
    }
}
