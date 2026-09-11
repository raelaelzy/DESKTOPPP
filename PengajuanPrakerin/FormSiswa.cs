
using System;
using System.Data;
using System.Windows.Forms;

namespace PengajuanPrakerin
{
    public partial class FormSiswa : Form
    {
        public FormSiswa()
        {
            InitializeComponent();
        }

        private void FormSiswa_Load(object sender, EventArgs e)
        {
            tampildata();
            txtnis.Focus();
        }

        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            db.crud("SELECT * FROM siswa ORDER BY nama_siswa;");
            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
                string id = "" + baris["id_siswa"];
                string nis = "" + baris["nis"];
                string nama = "" + baris["nama_siswa"];
                string kelas = "" + baris["kelas"];
                string jurusan = "" + baris["jurusan"];
                string nohp = "" + baris["no_hp"];
                string alamat = "" + baris["alamat"];
                dataGridView1.Rows.Add(id, nis, nama, kelas, jurusan, nohp, alamat, "Ubah", "Hapus");
            }
        }

        private void bersihkan()
        {
            labelid.Text = "";
            txtnis.Clear();
            txtnama.Clear();
            txtkelas.Clear();
            txtjurusan.Clear();
            txtnohp.Clear();
            txtalamat.Clear();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnama.Text))
            {
                MessageBox.Show("Nama siswa wajib diisi");
                return;
            }

            db.crud($"INSERT INTO siswa(nis, nama_siswa, kelas, jurusan, no_hp, alamat) VALUES('{txtnis.Text}', '{txtnama.Text}', '{txtkelas.Text}', '{txtjurusan.Text}', '{txtnohp.Text}', '{txtalamat.Text}')");

            bersihkan();
            tampildata();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(labelid.Text))
            {
                MessageBox.Show("Pilih data pada tabel terlebih dahulu");
                return;
            }

            db.crud($"UPDATE siswa SET nis='{txtnis.Text}', nama_siswa='{txtnama.Text}', kelas='{txtkelas.Text}', jurusan='{txtjurusan.Text}', no_hp='{txtnohp.Text}', alamat='{txtalamat.Text}' WHERE id_siswa='{labelid.Text}'");

            MessageBox.Show("Data siswa berhasil diubah");
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

            if (kolom == 7) // Ubah
            {
                db.crud($"SELECT * FROM siswa WHERE id_siswa = '{idnya}'");
                foreach (DataRow r in db.ds.Tables[0].Rows)
                {
                    labelid.Text = "" + r["id_siswa"];
                    txtnis.Text = "" + r["nis"];
                    txtnama.Text = "" + r["nama_siswa"];
                    txtkelas.Text = "" + r["kelas"];
                    txtjurusan.Text = "" + r["jurusan"];
                    txtnohp.Text = "" + r["no_hp"];
                    txtalamat.Text = "" + r["alamat"];
                }
            }

            if (kolom == 8) // Hapus
            {
                DialogResult hasil = MessageBox.Show("Apakah data siswa ini mau dihapus?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (hasil == DialogResult.Yes)
                {
                    db.crud($"DELETE FROM siswa WHERE id_siswa = '{idnya}';");
                    tampildata();
                }
            }
        }

        private void FormSiswa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
