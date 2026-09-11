
using System;
using System.Data;
using System.Windows.Forms;

namespace PengajuanPrakerin
{
    public partial class FormGuru : Form
    {
        public FormGuru()
        {
            InitializeComponent();
        }

        private void FormGuru_Load(object sender, EventArgs e)
        {
            tampildata();
            txtnip.Focus();
        }

        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            db.crud("SELECT * FROM guru ORDER BY nama_guru;");
            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
                dataGridView1.Rows.Add(
                    "" + baris["id_guru"],
                    "" + baris["nip"],
                    "" + baris["nama_guru"],
                    "" + baris["no_hp"],
                    "Ubah", "Hapus");
            }
        }

        private void bersihkan()
        {
            labelid.Text = "";
            txtnip.Clear();
            txtnama.Clear();
            txtnohp.Clear();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnama.Text))
            {
                MessageBox.Show("Nama guru wajib diisi");
                return;
            }

            db.crud($"INSERT INTO guru(nip, nama_guru, no_hp) VALUES('{txtnip.Text}', '{txtnama.Text}', '{txtnohp.Text}')");

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

            db.crud($"UPDATE guru SET nip='{txtnip.Text}', nama_guru='{txtnama.Text}', no_hp='{txtnohp.Text}' WHERE id_guru='{labelid.Text}'");

            MessageBox.Show("Data guru berhasil diubah");
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

            if (kolom == 4) // Ubah
            {
                db.crud($"SELECT * FROM guru WHERE id_guru = '{idnya}'");
                foreach (DataRow r in db.ds.Tables[0].Rows)
                {
                    labelid.Text = "" + r["id_guru"];
                    txtnip.Text = "" + r["nip"];
                    txtnama.Text = "" + r["nama_guru"];
                    txtnohp.Text = "" + r["no_hp"];
                }
            }

            if (kolom == 5) // Hapus
            {
                DialogResult hasil = MessageBox.Show("Apakah data guru ini mau dihapus?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (hasil == DialogResult.Yes)
                {
                    db.crud($"DELETE FROM guru WHERE id_guru = '{idnya}';");
                    tampildata();
                }
            }
        }

        private void FormGuru_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
