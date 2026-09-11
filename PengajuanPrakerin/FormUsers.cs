
using System;
using System.Data;
using System.Windows.Forms;

namespace PengajuanPrakerin
{
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            muatRole();
            tampildata();
            txtuser.Focus();
        }

        private void muatRole()
        {
            cmbrole.Items.Clear();
            db.crud("SELECT * FROM role ORDER BY nama_role;");
            foreach (DataRow r in db.ds.Tables[0].Rows)
            {
                cmbrole.Items.Add(new ComboItem { Id = Convert.ToInt32(r["id_role"]), Text = "" + r["nama_role"] });
            }
            cmbrole.DisplayMember = "Text";
        }

        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            db.crud("SELECT users.id, users.user, role.nama_role FROM users LEFT JOIN role ON users.role_id = role.id_role ORDER BY users.id;");
            foreach (DataRow baris in db.ds.Tables[0].Rows)
            {
                dataGridView1.Rows.Add("" + baris["id"], "" + baris["user"], "" + baris["nama_role"], "Ubah", "Hapus");
            }
        }

        private void bersihkan()
        {
            labelid.Text = "";
            txtuser.Clear();
            txtpassword.Clear();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtuser.Text) || string.IsNullOrWhiteSpace(txtpassword.Text) || cmbrole.SelectedItem == null)
            {
                MessageBox.Show("Username, password, dan role wajib diisi");
                return;
            }

            int idRole = ((ComboItem)cmbrole.SelectedItem).Id;
            db.crud($"INSERT INTO users(user, password, role_id) VALUES('{txtuser.Text}', MD5('{txtpassword.Text}'), '{idRole}')");

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
            if (cmbrole.SelectedItem == null)
            {
                MessageBox.Show("Pilih role terlebih dahulu");
                return;
            }

            int idRole = ((ComboItem)cmbrole.SelectedItem).Id;

            if (!string.IsNullOrWhiteSpace(txtpassword.Text))
            {
                db.crud($"UPDATE users SET user='{txtuser.Text}', password=MD5('{txtpassword.Text}'), role_id='{idRole}' WHERE id='{labelid.Text}'");
            }
            else
            {
                db.crud($"UPDATE users SET user='{txtuser.Text}', role_id='{idRole}' WHERE id='{labelid.Text}'");
            }

            MessageBox.Show("Data user berhasil diubah");
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
                db.crud($"SELECT * FROM users WHERE id = '{idnya}'");
                foreach (DataRow r in db.ds.Tables[0].Rows)
                {
                    labelid.Text = "" + r["id"];
                    txtuser.Text = "" + r["user"];
                    txtpassword.Text = "";

                    int roleId = r["role_id"] == DBNull.Value ? -1 : Convert.ToInt32(r["role_id"]);
                    foreach (var item in cmbrole.Items)
                    {
                        if (((ComboItem)item).Id == roleId)
                        {
                            cmbrole.SelectedItem = item;
                            break;
                        }
                    }
                }
            }

            if (kolom == 4) // Hapus
            {
                DialogResult hasil = MessageBox.Show("Apakah akun user ini mau dihapus?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (hasil == DialogResult.Yes)
                {
                    db.crud($"DELETE FROM users WHERE id = '{idnya}';");
                    tampildata();
                }
            }
        }

        private void FormUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
