
namespace PengajuanPrakerin
{
    partial class FormDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnRole = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnPengajuan = new System.Windows.Forms.Button();
            this.btnGuru = new System.Windows.Forms.Button();
            this.btnPerusahaan = new System.Windows.Forms.Button();
            this.btnSiswa = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelKonten = new System.Windows.Forms.Panel();
            this.btnPenempatan = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMenu.Controls.Add(this.btnPenempatan);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnRole);
            this.panelMenu.Controls.Add(this.btnUsers);
            this.panelMenu.Controls.Add(this.btnPengajuan);
            this.panelMenu.Controls.Add(this.btnGuru);
            this.panelMenu.Controls.Add(this.btnPerusahaan);
            this.panelMenu.Controls.Add(this.btnSiswa);
            this.panelMenu.Controls.Add(this.lblWelcome);
            this.panelMenu.Controls.Add(this.lblTitle);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 650);
            this.panelMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightPink;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(15, 590);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(200, 36);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnRole
            // 
            this.btnRole.BackColor = System.Drawing.Color.LightCyan;
            this.btnRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRole.Location = new System.Drawing.Point(15, 330);
            this.btnRole.Name = "btnRole";
            this.btnRole.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRole.Size = new System.Drawing.Size(200, 36);
            this.btnRole.TabIndex = 8;
            this.btnRole.Text = "Data Role";
            this.btnRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRole.UseVisualStyleBackColor = false;
            this.btnRole.Click += new System.EventHandler(this.btnRole_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.LightCyan;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Location = new System.Drawing.Point(15, 286);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(200, 36);
            this.btnUsers.TabIndex = 7;
            this.btnUsers.Text = "Data User";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnPengajuan
            // 
            this.btnPengajuan.BackColor = System.Drawing.Color.LightGreen;
            this.btnPengajuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPengajuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPengajuan.Location = new System.Drawing.Point(15, 242);
            this.btnPengajuan.Name = "btnPengajuan";
            this.btnPengajuan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPengajuan.Size = new System.Drawing.Size(200, 36);
            this.btnPengajuan.TabIndex = 6;
            this.btnPengajuan.Text = "Pengajuan Prakerin";
            this.btnPengajuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPengajuan.UseVisualStyleBackColor = false;
            this.btnPengajuan.Click += new System.EventHandler(this.btnPengajuan_Click);
            // 
            // btnGuru
            // 
            this.btnGuru.BackColor = System.Drawing.Color.LightCyan;
            this.btnGuru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuru.Location = new System.Drawing.Point(15, 198);
            this.btnGuru.Name = "btnGuru";
            this.btnGuru.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGuru.Size = new System.Drawing.Size(200, 36);
            this.btnGuru.TabIndex = 5;
            this.btnGuru.Text = "Data Guru Pembimbing";
            this.btnGuru.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuru.UseVisualStyleBackColor = false;
            this.btnGuru.Click += new System.EventHandler(this.btnGuru_Click);
            // 
            // btnPerusahaan
            // 
            this.btnPerusahaan.BackColor = System.Drawing.Color.LightCyan;
            this.btnPerusahaan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerusahaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerusahaan.Location = new System.Drawing.Point(15, 154);
            this.btnPerusahaan.Name = "btnPerusahaan";
            this.btnPerusahaan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPerusahaan.Size = new System.Drawing.Size(200, 36);
            this.btnPerusahaan.TabIndex = 4;
            this.btnPerusahaan.Text = "Data Perusahaan / DUDI";
            this.btnPerusahaan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerusahaan.UseVisualStyleBackColor = false;
            this.btnPerusahaan.Click += new System.EventHandler(this.btnPerusahaan_Click);
            // 
            // btnSiswa
            // 
            this.btnSiswa.BackColor = System.Drawing.Color.LightCyan;
            this.btnSiswa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiswa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiswa.Location = new System.Drawing.Point(15, 110);
            this.btnSiswa.Name = "btnSiswa";
            this.btnSiswa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSiswa.Size = new System.Drawing.Size(200, 36);
            this.btnSiswa.TabIndex = 3;
            this.btnSiswa.Text = "Data Siswa";
            this.btnSiswa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiswa.UseVisualStyleBackColor = false;
            this.btnSiswa.Click += new System.EventHandler(this.btnSiswa_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.ForeColor = System.Drawing.Color.Gray;
            this.lblWelcome.Location = new System.Drawing.Point(15, 62);
            this.lblWelcome.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(81, 13);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Selamat datang";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(15, 18);
            this.lblTitle.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(186, 22);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Pengajuan Prakerin";
            // 
            // panelKonten
            // 
            this.panelKonten.BackColor = System.Drawing.Color.White;
            this.panelKonten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKonten.Location = new System.Drawing.Point(230, 0);
            this.panelKonten.Name = "panelKonten";
            this.panelKonten.Padding = new System.Windows.Forms.Padding(10);
            this.panelKonten.Size = new System.Drawing.Size(870, 650);
            this.panelKonten.TabIndex = 1;
            this.panelKonten.Paint += new System.Windows.Forms.PaintEventHandler(this.panelKonten_Paint);
            // 
            // btnPenempatan
            // 
            this.btnPenempatan.BackColor = System.Drawing.Color.LightGreen;
            this.btnPenempatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPenempatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenempatan.Location = new System.Drawing.Point(15, 374);
            this.btnPenempatan.Name = "btnPenempatan";
            this.btnPenempatan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPenempatan.Size = new System.Drawing.Size(200, 36);
            this.btnPenempatan.TabIndex = 10;
            this.btnPenempatan.Text = "Penempatan Prakerin";
            this.btnPenempatan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPenempatan.UseVisualStyleBackColor = false;
            this.btnPenempatan.Click += new System.EventHandler(this.btnPenempatan_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.panelKonten);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard - Pengajuan Prakerin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDashboard_FormClosed);
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnRole;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnPengajuan;
        private System.Windows.Forms.Button btnGuru;
        private System.Windows.Forms.Button btnPerusahaan;
        private System.Windows.Forms.Button btnSiswa;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelKonten;
        private System.Windows.Forms.Button btnPenempatan;
    }
}
