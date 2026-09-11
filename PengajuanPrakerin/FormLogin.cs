
using System;
using System.Data;
using System.Windows.Forms;

namespace PengajuanPrakerin
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string user = txtusername.Text.Trim();
            string pw = txtpassword.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pw))
            {
                MessageBox.Show("Username dan password wajib diisi");
                return;
            }

            db.crud($"SELECT users.*, role.nama_role FROM users LEFT JOIN role ON users.role_id = role.id_role WHERE user = '{user}' AND password = MD5('{pw}')");
            int jumlahBaris = db.ds.Tables[0].Rows.Count;

            if (jumlahBaris == 1)
            {
                DataRow baris = db.ds.Tables[0].Rows[0];
                string namaRole = "" + baris["nama_role"];

                FormDashboard dashboard = new FormDashboard(user, namaRole);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username / password salah");
            }
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtusername.Focus();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }
    }
}
