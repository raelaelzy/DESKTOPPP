
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PengajuanPrakerin.TRANSAKSI
{
    public partial class Penempatan_Prakerin : Form
    {
        public Penempatan_Prakerin()
        {
            InitializeComponent();
        }

        // ID OTOMATIS: PT001, PT002, PT003
        void IdOtomatis()
        {
            string sql = "SELECT id_penempatan FROM penempatan_prakerin " +
                         "WHERE id_penempatan LIKE 'PT%' " +
                         "ORDER BY id_penempatan DESC LIMIT 1";

            db.crud(sql);

            int nomor = 1;

            if (db.ds.Tables[0].Rows.Count > 0)
            {
                string idTerakhir = db.ds.Tables[0].Rows[0]["id_penempatan"].ToString();

                nomor = int.Parse(idTerakhir.Substring(2)) + 1;
            }

            txtIdPenempatan.Text = "PT" + nomor.ToString("D3");
        }

        // MENAMPILKAN DATA SISWA
        void TampilSiswa()
        {
            string sql = "SELECT id_siswa, nama_siswa FROM siswa";

            db.crud(sql);

            cmbSiswa.DataSource = db.ds.Tables[0];
            cmbSiswa.DisplayMember = "nama_siswa";
            cmbSiswa.ValueMember = "id_siswa";
        }

        // MENAMPILKAN DATA PERUSAHAAN
        void TampilPerusahaan()
        {
            string sql = "SELECT id_perusahaan, nama_perusahaan FROM perusahaan";

            db.crud(sql);

            cmbPerusahaan.DataSource = db.ds.Tables[0];
            cmbPerusahaan.DisplayMember = "nama_perusahaan";
            cmbPerusahaan.ValueMember = "id_perusahaan";
        }

        // MENAMPILKAN DATA GURU
        void TampilGuru()
        {
            string sql = "SELECT id_guru, nama_guru FROM guru";

            db.crud(sql);

            cmbGuru.DataSource = db.ds.Tables[0];
            cmbGuru.DisplayMember = "nama_guru";
            cmbGuru.ValueMember = "id_guru";
        }

        // MENAMPILKAN DATA KE DATAGRIDVIEW
        void TampilData()
        {
            string sql = "SELECT " +
                         "p.id_penempatan, " +
                         "s.nama_siswa, " +
                         "pr.nama_perusahaan, " +
                         "g.nama_guru, " +
                         "p.tanggal_mulai, " +
                         "p.status " +
                         "FROM penempatan_prakerin p " +
                         "JOIN siswa s ON p.id_siswa = s.id_siswa " +
                         "JOIN perusahaan pr ON p.id_perusahaan = pr.id_perusahaan " +
                         "JOIN guru g ON p.id_guru = g.id_guru";

            db.crud(sql);

            dgvPenempatan.DataSource = db.ds.Tables[0];
        }

        private void Penempatan_Prakerin_Load(object sender, EventArgs e)
        {
            dgvPenempatan.AutoGenerateColumns = true;

            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Aktif");
            cmbStatus.Items.Add("Selesai");
            cmbStatus.SelectedIndex = 0;

            TampilSiswa();
            TampilPerusahaan();
            TampilGuru();

            IdOtomatis();
            TampilData();

            txtIdPenempatan.ReadOnly = true;
        }

        // SIMPAN
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cmbSiswa.SelectedValue == null ||
                cmbPerusahaan.SelectedValue == null ||
                cmbGuru.SelectedValue == null)
            {
                MessageBox.Show("Mohon lengkapi data terlebih dahulu!");
                return;
            }

            string sql = "INSERT INTO penempatan_prakerin " +
                         "(id_penempatan, id_siswa, id_perusahaan, id_guru, tanggal_mulai, tanggal_selesai, status, keterangan) VALUES (" +
                         "'" + txtIdPenempatan.Text + "'," +
                         "'" + cmbSiswa.SelectedValue + "'," +
                         "'" + cmbPerusahaan.SelectedValue + "'," +
                         "'" + cmbGuru.SelectedValue + "'," +
                         "'" + dtpMulai.Value.ToString("yyyy-MM-dd") + "'," +
                         "'" + dtpSelesai.Value.ToString("yyyy-MM-dd") + "'," +
                         "'" + cmbStatus.Text + "'," +
                         "'" + txtKeterangan.Text + "')";

            db.crud(sql);

            MessageBox.Show("Data berhasil disimpan!");

            TampilData();
            IdOtomatis();
        }

        // SAAT DATA DIKLIK
        private void dgvPenempatan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtIdPenempatan.Text =
                    dgvPenempatan.Rows[e.RowIndex].Cells[0].Value.ToString();

                cmbStatus.Text =
                    dgvPenempatan.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }


        // UPDATE
        private void btnUbah_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE penempatan_prakerin SET " +
                         "id_siswa='" + cmbSiswa.SelectedValue + "', " +
                         "id_perusahaan='" + cmbPerusahaan.SelectedValue + "', " +
                         "id_guru='" + cmbGuru.SelectedValue + "', " +
                         "tanggal_mulai='" + dtpMulai.Value.ToString("yyyy-MM-dd") + "', " +
                         "tanggal_selesai='" + dtpSelesai.Value.ToString("yyyy-MM-dd") + "', " +
                         "status='" + cmbStatus.Text + "', " +
                         "keterangan='" + txtKeterangan.Text + "' " +
                         "WHERE id_penempatan='" + txtIdPenempatan.Text + "'";

            db.crud(sql);

            MessageBox.Show("Data berhasil diubah!");

            TampilData();
        }

        // HAPUS
        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult hasil = MessageBox.Show(
                "Yakin ingin menghapus data?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (hasil == DialogResult.Yes)
            {
                string sql = "DELETE FROM penempatan_prakerin WHERE id_penempatan='" +
                             txtIdPenempatan.Text + "'";

                db.crud(sql);

                MessageBox.Show("Data berhasil dihapus!");

                TampilData();
                IdOtomatis();
            }
        }

        // BATAL
        private void btnBatal_Click(object sender, EventArgs e)
        {
            cmbSiswa.SelectedIndex = -1;
            cmbPerusahaan.SelectedIndex = -1;
            cmbGuru.SelectedIndex = -1;
            cmbStatus.SelectedIndex = 0;

            txtKeterangan.Clear();

            dtpMulai.Value = DateTime.Now;
            dtpSelesai.Value = DateTime.Now;

            IdOtomatis();
        }

        // CARI
        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT " +
                         "p.id_penempatan, " +
                         "s.nama_siswa, " +
                         "pr.nama_perusahaan, " +
                         "g.nama_guru, " +
                         "p.tanggal_mulai, " +
                         "p.status " +
                         "FROM penempatan_prakerin p " +
                         "JOIN siswa s ON p.id_siswa = s.id_siswa " +
                         "JOIN perusahaan pr ON p.id_perusahaan = pr.id_perusahaan " +
                         "JOIN guru g ON p.id_guru = g.id_guru " +
                         "WHERE s.nama_siswa LIKE '%" + txtCari.Text + "%'";

            db.crud(sql);

            dgvPenempatan.DataSource = db.ds.Tables[0];
        }

        private void dgvPenempatan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Penempatan_Prakerin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
