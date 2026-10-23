
using System;
using System.Windows.Forms;
using PengajuanPrakerin.TRANSAKSI;

namespace PengajuanPrakerin
{
    public partial class FormDashboard : Form
    {
        private string loggedInUser;
        private string loggedInRole;

        public FormDashboard(string user, string role)
        {
            InitializeComponent();
            loggedInUser = user;
            loggedInRole = role;
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Selamat datang, {loggedInUser} ({loggedInRole})";
            tampilkanBeranda();
        }

        // Menampilkan Form ke dalam panel konten
        private void tampilkanKonten(Form konten)
        {
            panelKonten.Controls.Clear();
            konten.TopLevel = false;
            konten.FormBorderStyle = FormBorderStyle.None;
            konten.Dock = DockStyle.Fill;
            panelKonten.Controls.Add(konten);
            konten.Show();
        }

        private void tampilkanBeranda()
        {
            panelKonten.Controls.Clear();

            Label info = new Label();
            info.Dock = DockStyle.Fill;
            info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            info.Font = new System.Drawing.Font(
                "Microsoft Sans Serif",
                14F,
                System.Drawing.FontStyle.Bold
            );
            info.ForeColor = System.Drawing.Color.Gray;
            info.Text = "Pilih menu di sebelah kiri untuk mulai";

            panelKonten.Controls.Add(info);
        }

        private void btnSiswa_Click(object sender, EventArgs e)
        {
            tampilkanKonten(new FormSiswa());
        }

        private void btnPerusahaan_Click(object sender, EventArgs e)
        {
            tampilkanKonten(new FormPerusahaan());
        }

        private void btnGuru_Click(object sender, EventArgs e)
        {
            tampilkanKonten(new FormGuru());
        }

        private void btnPengajuan_Click(object sender, EventArgs e)
        {
            tampilkanKonten(new FormPengajuan());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            tampilkanKonten(new FormUsers());
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            tampilkanKonten(new FormRole());
        }

        // MENU PENEMPATAN PRAKERIN
        private void btnPenempatan_Click(object sender, EventArgs e)
        {
            tampilkanKonten(new Penempatan_Prakerin());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult hasil = MessageBox.Show(
                "Apakah Anda yakin ingin logout?",
                "Konfirmasi Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (hasil == DialogResult.Yes)
            {
                this.Hide();

                FormLogin login = new FormLogin();
                login.Show();
            }
        }

        private void FormDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panelKonten_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tampilkanKonten(new FormREPORT());
        }
    }
}
