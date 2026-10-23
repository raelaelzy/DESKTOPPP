
namespace PengajuanPrakerin
{
    partial class FormPengajuan
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
            this.labelid = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSiswa = new System.Windows.Forms.Label();
            this.cmbsiswa = new System.Windows.Forms.ComboBox();
            this.lblPerusahaan = new System.Windows.Forms.Label();
            this.cmbperusahaan = new System.Windows.Forms.ComboBox();
            this.lblGuru = new System.Windows.Forms.Label();
            this.cmbguru = new System.Windows.Forms.ComboBox();
            this.lblTglPengajuan = new System.Windows.Forms.Label();
            this.dtppengajuan = new System.Windows.Forms.DateTimePicker();
            this.lblTglMulai = new System.Windows.Forms.Label();
            this.dtpmulai = new System.Windows.Forms.DateTimePicker();
            this.lblTglSelesai = new System.Windows.Forms.Label();
            this.dtpselesai = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.lblKeterangan = new System.Windows.Forms.Label();
            this.txtketerangan = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btntampil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPerusahaan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTglPengajuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTglMulai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTglSelesai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKeterangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSetujui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTolak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHapus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(12, 9);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(0, 13);
            this.labelid.TabIndex = 0;
            this.labelid.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(165, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Pengajuan Prakerin";
            // 
            // lblSiswa
            // 
            this.lblSiswa.AutoSize = true;
            this.lblSiswa.Location = new System.Drawing.Point(12, 42);
            this.lblSiswa.Name = "lblSiswa";
            this.lblSiswa.Size = new System.Drawing.Size(35, 13);
            this.lblSiswa.TabIndex = 2;
            this.lblSiswa.Text = "Siswa";
            // 
            // cmbsiswa
            // 
            this.cmbsiswa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsiswa.FormattingEnabled = true;
            this.cmbsiswa.Location = new System.Drawing.Point(140, 39);
            this.cmbsiswa.Name = "cmbsiswa";
            this.cmbsiswa.Size = new System.Drawing.Size(200, 21);
            this.cmbsiswa.TabIndex = 3;
            // 
            // lblPerusahaan
            // 
            this.lblPerusahaan.AutoSize = true;
            this.lblPerusahaan.Location = new System.Drawing.Point(12, 69);
            this.lblPerusahaan.Name = "lblPerusahaan";
            this.lblPerusahaan.Size = new System.Drawing.Size(64, 13);
            this.lblPerusahaan.TabIndex = 4;
            this.lblPerusahaan.Text = "Perusahaan";
            // 
            // cmbperusahaan
            // 
            this.cmbperusahaan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbperusahaan.FormattingEnabled = true;
            this.cmbperusahaan.Location = new System.Drawing.Point(140, 66);
            this.cmbperusahaan.Name = "cmbperusahaan";
            this.cmbperusahaan.Size = new System.Drawing.Size(200, 21);
            this.cmbperusahaan.TabIndex = 5;
            // 
            // lblGuru
            // 
            this.lblGuru.AutoSize = true;
            this.lblGuru.Location = new System.Drawing.Point(12, 96);
            this.lblGuru.Name = "lblGuru";
            this.lblGuru.Size = new System.Drawing.Size(90, 13);
            this.lblGuru.TabIndex = 6;
            this.lblGuru.Text = "Guru Pembimbing";
            // 
            // cmbguru
            // 
            this.cmbguru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbguru.FormattingEnabled = true;
            this.cmbguru.Location = new System.Drawing.Point(140, 93);
            this.cmbguru.Name = "cmbguru";
            this.cmbguru.Size = new System.Drawing.Size(200, 21);
            this.cmbguru.TabIndex = 7;
            // 
            // lblTglPengajuan
            // 
            this.lblTglPengajuan.AutoSize = true;
            this.lblTglPengajuan.Location = new System.Drawing.Point(370, 42);
            this.lblTglPengajuan.Name = "lblTglPengajuan";
            this.lblTglPengajuan.Size = new System.Drawing.Size(100, 13);
            this.lblTglPengajuan.TabIndex = 8;
            this.lblTglPengajuan.Text = "Tanggal Pengajuan";
            // 
            // dtppengajuan
            // 
            this.dtppengajuan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtppengajuan.Location = new System.Drawing.Point(470, 39);
            this.dtppengajuan.Name = "dtppengajuan";
            this.dtppengajuan.Size = new System.Drawing.Size(160, 20);
            this.dtppengajuan.TabIndex = 9;
            // 
            // lblTglMulai
            // 
            this.lblTglMulai.AutoSize = true;
            this.lblTglMulai.Location = new System.Drawing.Point(370, 69);
            this.lblTglMulai.Name = "lblTglMulai";
            this.lblTglMulai.Size = new System.Drawing.Size(74, 13);
            this.lblTglMulai.TabIndex = 10;
            this.lblTglMulai.Text = "Tanggal Mulai";
            // 
            // dtpmulai
            // 
            this.dtpmulai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpmulai.Location = new System.Drawing.Point(470, 66);
            this.dtpmulai.Name = "dtpmulai";
            this.dtpmulai.Size = new System.Drawing.Size(160, 20);
            this.dtpmulai.TabIndex = 11;
            // 
            // lblTglSelesai
            // 
            this.lblTglSelesai.AutoSize = true;
            this.lblTglSelesai.Location = new System.Drawing.Point(370, 96);
            this.lblTglSelesai.Name = "lblTglSelesai";
            this.lblTglSelesai.Size = new System.Drawing.Size(83, 13);
            this.lblTglSelesai.TabIndex = 12;
            this.lblTglSelesai.Text = "Tanggal Selesai";
            // 
            // dtpselesai
            // 
            this.dtpselesai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpselesai.Location = new System.Drawing.Point(470, 93);
            this.dtpselesai.Name = "dtpselesai";
            this.dtpselesai.Size = new System.Drawing.Size(160, 20);
            this.dtpselesai.TabIndex = 13;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 123);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Status";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // cmbstatus
            // 
            this.cmbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbstatus.Enabled = false;
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Location = new System.Drawing.Point(140, 120);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(200, 21);
            this.cmbstatus.TabIndex = 15;
            this.cmbstatus.SelectedIndexChanged += new System.EventHandler(this.cmbstatus_SelectedIndexChanged);
            // 
            // lblKeterangan
            // 
            this.lblKeterangan.AutoSize = true;
            this.lblKeterangan.Location = new System.Drawing.Point(370, 123);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(62, 13);
            this.lblKeterangan.TabIndex = 16;
            this.lblKeterangan.Text = "Keterangan";
            this.lblKeterangan.Click += new System.EventHandler(this.lblKeterangan_Click);
            // 
            // txtketerangan
            // 
            this.txtketerangan.Location = new System.Drawing.Point(470, 120);
            this.txtketerangan.Name = "txtketerangan";
            this.txtketerangan.Size = new System.Drawing.Size(160, 20);
            this.txtketerangan.TabIndex = 17;
            this.txtketerangan.TextChanged += new System.EventHandler(this.txtketerangan_TextChanged);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.LightCyan;
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(12, 155);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(140, 30);
            this.btnSimpan.TabIndex = 18;
            this.btnSimpan.Text = "Ajukan Prakerin";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btntampil
            // 
            this.btntampil.BackColor = System.Drawing.Color.LightCyan;
            this.btntampil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntampil.Location = new System.Drawing.Point(158, 155);
            this.btntampil.Name = "btntampil";
            this.btntampil.Size = new System.Drawing.Size(110, 30);
            this.btntampil.TabIndex = 19;
            this.btntampil.Text = "Tampil Data";
            this.btntampil.UseVisualStyleBackColor = false;
            this.btntampil.Click += new System.EventHandler(this.btntampil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colSiswa,
            this.colPerusahaan,
            this.colGuru,
            this.colTglPengajuan,
            this.colTglMulai,
            this.colTglSelesai,
            this.colStatus,
            this.colKeterangan,
            this.colSetujui,
            this.colTolak,
            this.colHapus});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(947, 260);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            // 
            // colSiswa
            // 
            this.colSiswa.HeaderText = "Siswa";
            this.colSiswa.Name = "colSiswa";
            // 
            // colPerusahaan
            // 
            this.colPerusahaan.HeaderText = "Perusahaan";
            this.colPerusahaan.Name = "colPerusahaan";
            // 
            // colGuru
            // 
            this.colGuru.HeaderText = "Guru Pembimbing";
            this.colGuru.Name = "colGuru";
            // 
            // colTglPengajuan
            // 
            this.colTglPengajuan.HeaderText = "Tgl Pengajuan";
            this.colTglPengajuan.Name = "colTglPengajuan";
            // 
            // colTglMulai
            // 
            this.colTglMulai.HeaderText = "Tgl Mulai";
            this.colTglMulai.Name = "colTglMulai";
            // 
            // colTglSelesai
            // 
            this.colTglSelesai.HeaderText = "Tgl Selesai";
            this.colTglSelesai.Name = "colTglSelesai";
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // colKeterangan
            // 
            this.colKeterangan.HeaderText = "Keterangan";
            this.colKeterangan.Name = "colKeterangan";
            // 
            // colSetujui
            // 
            this.colSetujui.HeaderText = "";
            this.colSetujui.Name = "colSetujui";
            // 
            // colTolak
            // 
            this.colTolak.HeaderText = "";
            this.colTolak.Name = "colTolak";
            // 
            // colHapus
            // 
            this.colHapus.HeaderText = "";
            this.colHapus.Name = "colHapus";
            // 
            // FormPengajuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 460);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btntampil);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtketerangan);
            this.Controls.Add(this.lblKeterangan);
            this.Controls.Add(this.cmbstatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dtpselesai);
            this.Controls.Add(this.lblTglSelesai);
            this.Controls.Add(this.dtpmulai);
            this.Controls.Add(this.lblTglMulai);
            this.Controls.Add(this.dtppengajuan);
            this.Controls.Add(this.lblTglPengajuan);
            this.Controls.Add(this.cmbguru);
            this.Controls.Add(this.lblGuru);
            this.Controls.Add(this.cmbperusahaan);
            this.Controls.Add(this.lblPerusahaan);
            this.Controls.Add(this.cmbsiswa);
            this.Controls.Add(this.lblSiswa);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.labelid);
            this.Name = "FormPengajuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pengajuan Prakerin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPengajuan_FormClosed);
            this.Load += new System.EventHandler(this.FormPengajuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSiswa;
        private System.Windows.Forms.ComboBox cmbsiswa;
        private System.Windows.Forms.Label lblPerusahaan;
        private System.Windows.Forms.ComboBox cmbperusahaan;
        private System.Windows.Forms.Label lblGuru;
        private System.Windows.Forms.ComboBox cmbguru;
        private System.Windows.Forms.Label lblTglPengajuan;
        private System.Windows.Forms.DateTimePicker dtppengajuan;
        private System.Windows.Forms.Label lblTglMulai;
        private System.Windows.Forms.DateTimePicker dtpmulai;
        private System.Windows.Forms.Label lblTglSelesai;
        private System.Windows.Forms.DateTimePicker dtpselesai;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.Label lblKeterangan;
        private System.Windows.Forms.TextBox txtketerangan;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btntampil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPerusahaan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTglPengajuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTglMulai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTglSelesai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKeterangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSetujui;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTolak;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHapus;
    }
}
