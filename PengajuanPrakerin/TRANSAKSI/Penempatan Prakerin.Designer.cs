
namespace PengajuanPrakerin.TRANSAKSI
{
    partial class Penempatan_Prakerin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNama = new System.Windows.Forms.Label();
            this.txtIdPenempatan = new System.Windows.Forms.TextBox();
            this.cmbSiswa = new System.Windows.Forms.ComboBox();
            this.cmbPerusahaan = new System.Windows.Forms.ComboBox();
            this.lblPerusahaan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGuru = new System.Windows.Forms.ComboBox();
            this.Guru = new System.Windows.Forms.Label();
            this.dtpSelesai = new System.Windows.Forms.DateTimePicker();
            this.lblTglSelesai = new System.Windows.Forms.Label();
            this.dtpMulai = new System.Windows.Forms.DateTimePicker();
            this.lblTglPengajuan = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblKeterangan = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.dgvPenempatan = new System.Windows.Forms.DataGridView();
            this.colIdPenempatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamaSiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPerusahaan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTanggalMulai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtKeterangan = new System.Windows.Forms.RichTextBox();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenempatan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(32, 82);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(81, 13);
            this.lblNama.TabIndex = 3;
            this.lblNama.Text = "ID Penempatan";
            // 
            // txtIdPenempatan
            // 
            this.txtIdPenempatan.Location = new System.Drawing.Point(140, 82);
            this.txtIdPenempatan.Name = "txtIdPenempatan";
            this.txtIdPenempatan.ReadOnly = true;
            this.txtIdPenempatan.Size = new System.Drawing.Size(131, 20);
            this.txtIdPenempatan.TabIndex = 4;
            // 
            // cmbSiswa
            // 
            this.cmbSiswa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSiswa.FormattingEnabled = true;
            this.cmbSiswa.Location = new System.Drawing.Point(140, 123);
            this.cmbSiswa.Name = "cmbSiswa";
            this.cmbSiswa.Size = new System.Drawing.Size(131, 21);
            this.cmbSiswa.TabIndex = 5;
            // 
            // cmbPerusahaan
            // 
            this.cmbPerusahaan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerusahaan.FormattingEnabled = true;
            this.cmbPerusahaan.Location = new System.Drawing.Point(140, 167);
            this.cmbPerusahaan.Name = "cmbPerusahaan";
            this.cmbPerusahaan.Size = new System.Drawing.Size(131, 21);
            this.cmbPerusahaan.TabIndex = 6;
            // 
            // lblPerusahaan
            // 
            this.lblPerusahaan.AutoSize = true;
            this.lblPerusahaan.Location = new System.Drawing.Point(32, 131);
            this.lblPerusahaan.Name = "lblPerusahaan";
            this.lblPerusahaan.Size = new System.Drawing.Size(66, 13);
            this.lblPerusahaan.TabIndex = 7;
            this.lblPerusahaan.Text = "Nama Siswa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Perusahaan";
            // 
            // cmbGuru
            // 
            this.cmbGuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGuru.FormattingEnabled = true;
            this.cmbGuru.Location = new System.Drawing.Point(140, 217);
            this.cmbGuru.Name = "cmbGuru";
            this.cmbGuru.Size = new System.Drawing.Size(131, 21);
            this.cmbGuru.TabIndex = 9;
            // 
            // Guru
            // 
            this.Guru.AutoSize = true;
            this.Guru.Location = new System.Drawing.Point(32, 225);
            this.Guru.Name = "Guru";
            this.Guru.Size = new System.Drawing.Size(90, 13);
            this.Guru.TabIndex = 10;
            this.Guru.Text = "Guru Pembimbing";
            // 
            // dtpSelesai
            // 
            this.dtpSelesai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSelesai.Location = new System.Drawing.Point(416, 125);
            this.dtpSelesai.Name = "dtpSelesai";
            this.dtpSelesai.Size = new System.Drawing.Size(160, 20);
            this.dtpSelesai.TabIndex = 17;
            // 
            // lblTglSelesai
            // 
            this.lblTglSelesai.AutoSize = true;
            this.lblTglSelesai.Location = new System.Drawing.Point(316, 128);
            this.lblTglSelesai.Name = "lblTglSelesai";
            this.lblTglSelesai.Size = new System.Drawing.Size(83, 13);
            this.lblTglSelesai.TabIndex = 16;
            this.lblTglSelesai.Text = "Tanggal Selesai";
            // 
            // dtpMulai
            // 
            this.dtpMulai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMulai.Location = new System.Drawing.Point(416, 82);
            this.dtpMulai.Name = "dtpMulai";
            this.dtpMulai.Size = new System.Drawing.Size(160, 20);
            this.dtpMulai.TabIndex = 15;
            // 
            // lblTglPengajuan
            // 
            this.lblTglPengajuan.AutoSize = true;
            this.lblTglPengajuan.Location = new System.Drawing.Point(316, 85);
            this.lblTglPengajuan.Name = "lblTglPengajuan";
            this.lblTglPengajuan.Size = new System.Drawing.Size(74, 13);
            this.lblTglPengajuan.TabIndex = 14;
            this.lblTglPengajuan.Text = "Tanggal Mulai";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Enabled = false;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(416, 167);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(160, 21);
            this.cmbStatus.TabIndex = 19;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(336, 175);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "Status";
            // 
            // lblKeterangan
            // 
            this.lblKeterangan.AutoSize = true;
            this.lblKeterangan.Location = new System.Drawing.Point(316, 217);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(62, 13);
            this.lblKeterangan.TabIndex = 20;
            this.lblKeterangan.Text = "Keterangan";
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.LightCyan;
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(136, 264);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(90, 30);
            this.btnSimpan.TabIndex = 22;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.LightCyan;
            this.btnUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbah.Location = new System.Drawing.Point(252, 264);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(90, 30);
            this.btnUbah.TabIndex = 23;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.LightCyan;
            this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.Location = new System.Drawing.Point(373, 264);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(90, 30);
            this.btnHapus.TabIndex = 24;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.LightCyan;
            this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.Location = new System.Drawing.Point(492, 264);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(90, 30);
            this.btnBatal.TabIndex = 25;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // dgvPenempatan
            // 
            this.dgvPenempatan.AllowUserToAddRows = false;
            this.dgvPenempatan.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvPenempatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPenempatan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdPenempatan,
            this.colNamaSiswa,
            this.colPerusahaan,
            this.colGuru,
            this.colTanggalMulai,
            this.colStatus});
            this.dgvPenempatan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPenempatan.Location = new System.Drawing.Point(0, 314);
            this.dgvPenempatan.Name = "dgvPenempatan";
            this.dgvPenempatan.Size = new System.Drawing.Size(800, 136);
            this.dgvPenempatan.TabIndex = 26;
            this.dgvPenempatan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPenempatan_CellClick);
            this.dgvPenempatan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPenempatan_CellContentClick);
            // 
            // colIdPenempatan
            // 
            this.colIdPenempatan.DataPropertyName = "id_penempatan";
            this.colIdPenempatan.HeaderText = "ID Penempatan";
            this.colIdPenempatan.Name = "colIdPenempatan";
            // 
            // colNamaSiswa
            // 
            this.colNamaSiswa.DataPropertyName = "nama_siswa";
            this.colNamaSiswa.HeaderText = "Nama Siswa";
            this.colNamaSiswa.Name = "colNamaSiswa";
            // 
            // colPerusahaan
            // 
            this.colPerusahaan.DataPropertyName = "nama_perusahaan";
            this.colPerusahaan.HeaderText = "Perusahaan";
            this.colPerusahaan.Name = "colPerusahaan";
            // 
            // colGuru
            // 
            this.colGuru.DataPropertyName = "nama_guru";
            this.colGuru.HeaderText = "Guru";
            this.colGuru.Name = "colGuru";
            // 
            // colTanggalMulai
            // 
            this.colTanggalMulai.DataPropertyName = "tanggal_mulai";
            this.colTanggalMulai.HeaderText = "Tanggal Mulai";
            this.colTanggalMulai.Name = "colTanggalMulai";
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Location = new System.Drawing.Point(416, 202);
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(166, 36);
            this.txtKeterangan.TabIndex = 27;
            this.txtKeterangan.Text = "";
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(657, 274);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(131, 20);
            this.txtCari.TabIndex = 28;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(614, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Cari";
            // 
            // Penempatan_Prakerin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.dgvPenempatan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.lblKeterangan);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dtpSelesai);
            this.Controls.Add(this.lblTglSelesai);
            this.Controls.Add(this.dtpMulai);
            this.Controls.Add(this.lblTglPengajuan);
            this.Controls.Add(this.Guru);
            this.Controls.Add(this.cmbGuru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPerusahaan);
            this.Controls.Add(this.cmbPerusahaan);
            this.Controls.Add(this.cmbSiswa);
            this.Controls.Add(this.txtIdPenempatan);
            this.Controls.Add(this.lblNama);
            this.Name = "Penempatan_Prakerin";
            this.Text = "Penempatan_Prakerin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Penempatan_Prakerin_FormClosing);
            this.Load += new System.EventHandler(this.Penempatan_Prakerin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenempatan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtIdPenempatan;
        private System.Windows.Forms.ComboBox cmbSiswa;
        private System.Windows.Forms.ComboBox cmbPerusahaan;
        private System.Windows.Forms.Label lblPerusahaan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGuru;
        private System.Windows.Forms.Label Guru;
        private System.Windows.Forms.DateTimePicker dtpSelesai;
        private System.Windows.Forms.Label lblTglSelesai;
        private System.Windows.Forms.DateTimePicker dtpMulai;
        private System.Windows.Forms.Label lblTglPengajuan;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblKeterangan;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.DataGridView dgvPenempatan;
        private System.Windows.Forms.RichTextBox txtKeterangan;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdPenempatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamaSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPerusahaan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTanggalMulai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}