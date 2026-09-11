
using System;
using System.Data;
using System.Windows.Forms;

namespace PengajuanPrakerin
{
    public partial class FormRole : Form
    {
        public FormRole()
        {
            InitializeComponent();
        }

        private void FormRole_Load(object sender, EventArgs e)
        {
            tampildata();
            txtnamarole.Focus();
        }

        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            db.crud("SELECT * FROM role ORDER BY id_role;");
            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
                dataGridView1.Rows.Add("" + baris["id_role"], "" + baris["nama_role"], "" + baris["deskripsi"], "Ubah", "Hapus");
            }
        }

        private void bersihkan()
        {
            labelid.Text = "";
            txtnamarole.Clear();
            txtdeskripsi.Clear();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnamarole.Text))
            {
                MessageBox.Show("Nama role wajib diisi");
                return;
            }

            db.crud($"INSERT INTO role(nama_role, deskripsi) VALUES('{txtnamarole.Text}', '{txtdeskripsi.Text}')");

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

            db.crud($"UPDATE role SET nama_role='{txtnamarole.Text}', deskripsi='{txtdeskripsi.Text}' WHERE id_role='{labelid.Text}'");

            MessageBox.Show("Data role berhasil diubah");
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

            if (kolom == 3) // Ubah
            {
                db.crud($"SELECT * FROM role WHERE id_role = '{idnya}'");
                foreach (DataRow r in db.ds.Tables[0].Rows)
                {
                    labelid.Text = "" + r["id_role"];
                    txtnamarole.Text = "" + r["nama_role"];
                    txtdeskripsi.Text = "" + r["deskripsi"];
                }
            }

            if (kolom == 4) // Hapus
            {
                DialogResult hasil = MessageBox.Show("Apakah role ini mau dihapus?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (hasil == DialogResult.Yes)
                {
                    db.crud($"DELETE FROM role WHERE id_role = '{idnya}';");
                    tampildata();
                }
            }
        }

        private void FormRole_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
