
using System;
using System.Data;
using System.Windows.Forms;

namespace PengajuanPrakerin
{
    public partial class FormPengajuan : Form
    {
        public FormPengajuan()
        {
            InitializeComponent();
        }

        private void FormPengajuan_Load(object sender, EventArgs e)
        {
            muatSiswa();
            muatPerusahaan();
            muatGuru();
            cmbstatus.Items.Clear();
            cmbstatus.Items.AddRange(new object[] { "Diajukan", "Disetujui", "Ditolak" });
            cmbstatus.SelectedIndex = 0;
            tampildata();
        }

        private void muatSiswa()
        {
            cmbsiswa.Items.Clear();
            db.crud("SELECT * FROM siswa ORDER BY nama_siswa;");
            foreach (DataRow r in db.ds.Tables[0].Rows)
            {
                cmbsiswa.Items.Add(new ComboItem { Id = Convert.ToInt32(r["id_siswa"]), Text = "" + r["nama_siswa"] });
            }
            cmbsiswa.DisplayMember = "Text";
        }

        private void muatPerusahaan()
        {
            cmbperusahaan.Items.Clear();
            db.crud("SELECT * FROM perusahaan ORDER BY nama_perusahaan;");
            foreach (DataRow r in db.ds.Tables[0].Rows)
            {
                cmbperusahaan.Items.Add(new ComboItem { Id = Convert.ToInt32(r["id_perusahaan"]), Text = "" + r["nama_perusahaan"] });
            }
            cmbperusahaan.DisplayMember = "Text";
        }

        private void muatGuru()
        {
            cmbguru.Items.Clear();
            cmbguru.Items.Add(new ComboItem { Id = 0, Text = "(Belum ditentukan)" });
            db.crud("SELECT * FROM guru ORDER BY nama_guru;");
            foreach (DataRow r in db.ds.Tables[0].Rows)
            {
                cmbguru.Items.Add(new ComboItem { Id = Convert.ToInt32(r["id_guru"]), Text = "" + r["nama_guru"] });
            }
            cmbguru.DisplayMember = "Text";
            cmbguru.SelectedIndex = 0;
        }

        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            string sql = @"SELECT p.id_pengajuan, s.nama_siswa, pr.nama_perusahaan, g.nama_guru,
                                   p.tanggal_pengajuan, p.tanggal_mulai, p.tanggal_selesai, p.status, p.keterangan
                            FROM pengajuan p
                            JOIN siswa s ON p.siswa_id = s.id_siswa
                            JOIN perusahaan pr ON p.perusahaan_id = pr.id_perusahaan
                            LEFT JOIN guru g ON p.guru_id = g.id_guru
                            ORDER BY p.id_pengajuan DESC;";
            db.crud(sql);
            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
                dataGridView1.Rows.Add(
                    "" + baris["id_pengajuan"],
                    "" + baris["nama_siswa"],
                    "" + baris["nama_perusahaan"],
                    "" + baris["nama_guru"],
                    Convert.ToDateTime(baris["tanggal_pengajuan"]).ToString("yyyy-MM-dd"),
                    baris["tanggal_mulai"] == DBNull.Value ? "" : Convert.ToDateTime(baris["tanggal_mulai"]).ToString("yyyy-MM-dd"),
                    baris["tanggal_selesai"] == DBNull.Value ? "" : Convert.ToDateTime(baris["tanggal_selesai"]).ToString("yyyy-MM-dd"),
                    "" + baris["status"],
                    "" + baris["keterangan"],
                    "Setujui", "Tolak", "Hapus");
            }
        }

        private void bersihkan()
        {
            labelid.Text = "";
            txtketerangan.Clear();
            cmbstatus.SelectedIndex = 0;
            dtpmulai.Value = DateTime.Today;
            dtpselesai.Value = DateTime.Today;
            dtppengajuan.Value = DateTime.Today;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cmbsiswa.SelectedItem == null || cmbperusahaan.SelectedItem == null)
            {
                MessageBox.Show("Pilih siswa dan perusahaan terlebih dahulu");
                return;
            }

            int idSiswa = ((ComboItem)cmbsiswa.SelectedItem).Id;
            int idPerusahaan = ((ComboItem)cmbperusahaan.SelectedItem).Id;
            int idGuru = cmbguru.SelectedItem != null ? ((ComboItem)cmbguru.SelectedItem).Id : 0;
            string guruSql = idGuru == 0 ? "NULL" : idGuru.ToString();

            string tglPengajuan = dtppengajuan.Value.ToString("yyyy-MM-dd");
            string tglMulai = dtpmulai.Value.ToString("yyyy-MM-dd");
            string tglSelesai = dtpselesai.Value.ToString("yyyy-MM-dd");

            db.crud($@"INSERT INTO pengajuan(siswa_id, perusahaan_id, guru_id, tanggal_pengajuan, tanggal_mulai, tanggal_selesai, status, keterangan)
                       VALUES('{idSiswa}', '{idPerusahaan}', {guruSql}, '{tglPengajuan}', '{tglMulai}', '{tglSelesai}', 'Diajukan', '{txtketerangan.Text}')");

            bersihkan();
            tampildata();
        }

        private void btntampil_Click(object sender, EventArgs e)
        {
            tampildata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;
            string idnya = dataGridView1.Rows[baris].Cells[0].Value.ToString();

            if (kolom == 9) // Setujui
            {
                db.crud($"UPDATE pengajuan SET status='Disetujui' WHERE id_pengajuan='{idnya}'");
                tampildata();
            }

            if (kolom == 10) // Tolak
            {
                db.crud($"UPDATE pengajuan SET status='Ditolak' WHERE id_pengajuan='{idnya}'");
                tampildata();
            }

            if (kolom == 11) // Hapus
            {
                DialogResult hasil = MessageBox.Show("Apakah pengajuan ini mau dihapus?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (hasil == DialogResult.Yes)
                {
                    db.crud($"DELETE FROM pengajuan WHERE id_pengajuan = '{idnya}';");
                    tampildata();
                }
            }
        }

        private void FormPengajuan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cmbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void txtketerangan_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblKeterangan_Click(object sender, EventArgs e)
        {

        }
    }
}
