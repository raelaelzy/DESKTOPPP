
namespace PengajuanPrakerin
{
    partial class FormSiswa
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
            this.lblNis = new System.Windows.Forms.Label();
            this.txtnis = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.lblKelas = new System.Windows.Forms.Label();
            this.txtkelas = new System.Windows.Forms.TextBox();
            this.lblJurusan = new System.Windows.Forms.Label();
            this.txtjurusan = new System.Windows.Forms.TextBox();
            this.lblNoHp = new System.Windows.Forms.Label();
            this.txtnohp = new System.Windows.Forms.TextBox();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btntampil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJurusan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoHp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUbah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHapus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
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
            this.lblTitle.Size = new System.Drawing.Size(100, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Data Siswa";
            // 
            // lblNis
            // 
            this.lblNis.AutoSize = true;
            this.lblNis.Location = new System.Drawing.Point(12, 42);
            this.lblNis.Name = "lblNis";
            this.lblNis.Size = new System.Drawing.Size(25, 13);
            this.lblNis.TabIndex = 2;
            this.lblNis.Text = "NIS";
            // 
            // txtnis
            // 
            this.txtnis.Location = new System.Drawing.Point(110, 39);
            this.txtnis.Name = "txtnis";
            this.txtnis.Size = new System.Drawing.Size(150, 20);
            this.txtnis.TabIndex = 3;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(12, 68);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(66, 13);
            this.lblNama.TabIndex = 4;
            this.lblNama.Text = "Nama Siswa";
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(110, 65);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(220, 20);
            this.txtnama.TabIndex = 5;
            // 
            // lblKelas
            // 
            this.lblKelas.AutoSize = true;
            this.lblKelas.Location = new System.Drawing.Point(12, 94);
            this.lblKelas.Name = "lblKelas";
            this.lblKelas.Size = new System.Drawing.Size(33, 13);
            this.lblKelas.TabIndex = 6;
            this.lblKelas.Text = "Kelas";
            // 
            // txtkelas
            // 
            this.txtkelas.Location = new System.Drawing.Point(110, 91);
            this.txtkelas.Name = "txtkelas";
            this.txtkelas.Size = new System.Drawing.Size(150, 20);
            this.txtkelas.TabIndex = 7;
            // 
            // lblJurusan
            // 
            this.lblJurusan.AutoSize = true;
            this.lblJurusan.Location = new System.Drawing.Point(350, 42);
            this.lblJurusan.Name = "lblJurusan";
            this.lblJurusan.Size = new System.Drawing.Size(44, 13);
            this.lblJurusan.TabIndex = 8;
            this.lblJurusan.Text = "Jurusan";
            // 
            // txtjurusan
            // 
            this.txtjurusan.Location = new System.Drawing.Point(430, 39);
            this.txtjurusan.Name = "txtjurusan";
            this.txtjurusan.Size = new System.Drawing.Size(180, 20);
            this.txtjurusan.TabIndex = 9;
            // 
            // lblNoHp
            // 
            this.lblNoHp.AutoSize = true;
            this.lblNoHp.Location = new System.Drawing.Point(350, 68);
            this.lblNoHp.Name = "lblNoHp";
            this.lblNoHp.Size = new System.Drawing.Size(39, 13);
            this.lblNoHp.TabIndex = 10;
            this.lblNoHp.Text = "No HP";
            // 
            // txtnohp
            // 
            this.txtnohp.Location = new System.Drawing.Point(430, 65);
            this.txtnohp.Name = "txtnohp";
            this.txtnohp.Size = new System.Drawing.Size(180, 20);
            this.txtnohp.TabIndex = 11;
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(350, 94);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(39, 13);
            this.lblAlamat.TabIndex = 12;
            this.lblAlamat.Text = "Alamat";
            // 
            // txtalamat
            // 
            this.txtalamat.Location = new System.Drawing.Point(430, 91);
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(180, 20);
            this.txtalamat.TabIndex = 13;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.LightCyan;
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(12, 130);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(90, 30);
            this.btnSimpan.TabIndex = 14;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.LightCyan;
            this.btnUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbah.Location = new System.Drawing.Point(108, 130);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(90, 30);
            this.btnUbah.TabIndex = 15;
            this.btnUbah.Text = "Ubah Data";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btntampil
            // 
            this.btntampil.BackColor = System.Drawing.Color.LightCyan;
            this.btntampil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntampil.Location = new System.Drawing.Point(204, 130);
            this.btntampil.Name = "btntampil";
            this.btntampil.Size = new System.Drawing.Size(90, 30);
            this.btntampil.TabIndex = 16;
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
            this.colNis,
            this.colNama,
            this.colKelas,
            this.colJurusan,
            this.colNoHp,
            this.colAlamat,
            this.colUbah,
            this.colHapus});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 225);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            // 
            // colNis
            // 
            this.colNis.HeaderText = "NIS";
            this.colNis.Name = "colNis";
            // 
            // colNama
            // 
            this.colNama.HeaderText = "Nama Siswa";
            this.colNama.Name = "colNama";
            // 
            // colKelas
            // 
            this.colKelas.HeaderText = "Kelas";
            this.colKelas.Name = "colKelas";
            // 
            // colJurusan
            // 
            this.colJurusan.HeaderText = "Jurusan";
            this.colJurusan.Name = "colJurusan";
            // 
            // colNoHp
            // 
            this.colNoHp.HeaderText = "No HP";
            this.colNoHp.Name = "colNoHp";
            // 
            // colAlamat
            // 
            this.colAlamat.HeaderText = "Alamat";
            this.colAlamat.Name = "colAlamat";
            // 
            // colUbah
            // 
            this.colUbah.HeaderText = "";
            this.colUbah.Name = "colUbah";
            // 
            // colHapus
            // 
            this.colHapus.HeaderText = "";
            this.colHapus.Name = "colHapus";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(300, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cetak";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btntampil);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtalamat);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.txtnohp);
            this.Controls.Add(this.lblNoHp);
            this.Controls.Add(this.txtjurusan);
            this.Controls.Add(this.lblJurusan);
            this.Controls.Add(this.txtkelas);
            this.Controls.Add(this.lblKelas);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.txtnis);
            this.Controls.Add(this.lblNis);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.labelid);
            this.Name = "FormSiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Siswa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSiswa_FormClosed);
            this.Load += new System.EventHandler(this.FormSiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNis;
        private System.Windows.Forms.TextBox txtnis;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Label lblKelas;
        private System.Windows.Forms.TextBox txtkelas;
        private System.Windows.Forms.Label lblJurusan;
        private System.Windows.Forms.TextBox txtjurusan;
        private System.Windows.Forms.Label lblNoHp;
        private System.Windows.Forms.TextBox txtnohp;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.TextBox txtalamat;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btntampil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJurusan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoHp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUbah;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHapus;
        private System.Windows.Forms.Button button1;
    }
}
