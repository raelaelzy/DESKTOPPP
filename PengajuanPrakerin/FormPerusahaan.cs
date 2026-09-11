
using System;
using System.Data;
using System.Windows.Forms;

namespace PengajuanPrakerin
{
    public partial class FormPerusahaan : Form
    {
        public FormPerusahaan()
        {
            InitializeComponent();
        }

        private void FormPerusahaan_Load(object sender, EventArgs e)
        {
            tampildata();
            txtnama.Focus();
        }

        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            db.crud("SELECT * FROM perusahaan ORDER BY nama_perusahaan;");
            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
                dataGridView1.Rows.Add(
                    "" + baris["id_perusahaan"],
                    "" + baris["nama_perusahaan"],
                    "" + baris["alamat"],
                    "" + baris["no_telp"],
                    "" + baris["penanggung_jawab"],
                    "" + baris["bidang_usaha"],
                    "Ubah", "Hapus");
            }
        }

        private void bersihkan()
        {
            labelid.Text = "";
            txtnama.Clear();
            txtalamat.Clear();
            txtnotelp.Clear();
            txtpj.Clear();
            txtbidang.Clear();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnama.Text))
            {
                MessageBox.Show("Nama perusahaan wajib diisi");
                return;
            }

            db.crud($"INSERT INTO perusahaan(nama_perusahaan, alamat, no_telp, penanggung_jawab, bidang_usaha) VALUES('{txtnama.Text}', '{txtalamat.Text}', '{txtnotelp.Text}', '{txtpj.Text}', '{txtbidang.Text}')");

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

            db.crud($"UPDATE perusahaan SET nama_perusahaan='{txtnama.Text}', alamat='{txtalamat.Text}', no_telp='{txtnotelp.Text}', penanggung_jawab='{txtpj.Text}', bidang_usaha='{txtbidang.Text}' WHERE id_perusahaan='{labelid.Text}'");

            MessageBox.Show("Data perusahaan berhasil diubah");
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

            if (kolom == 6) // Ubah
            {
                db.crud($"SELECT * FROM perusahaan WHERE id_perusahaan = '{idnya}'");
                foreach (DataRow r in db.ds.Tables[0].Rows)
                {
                    labelid.Text = "" + r["id_perusahaan"];
                    txtnama.Text = "" + r["nama_perusahaan"];
                    txtalamat.Text = "" + r["alamat"];
                    txtnotelp.Text = "" + r["no_telp"];
                    txtpj.Text = "" + r["penanggung_jawab"];
                    txtbidang.Text = "" + r["bidang_usaha"];
                }
            }

            if (kolom == 7) // Hapus
            {
                DialogResult hasil = MessageBox.Show("Apakah data perusahaan ini mau dihapus?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (hasil == DialogResult.Yes)
                {
                    db.crud($"DELETE FROM perusahaan WHERE id_perusahaan = '{idnya}';");
                    tampildata();
                }
            }
        }

        private void FormPerusahaan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
