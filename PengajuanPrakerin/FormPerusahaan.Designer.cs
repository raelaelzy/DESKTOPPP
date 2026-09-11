
namespace PengajuanPrakerin
{
    partial class FormPerusahaan
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
            this.lblNama = new System.Windows.Forms.Label();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.lblNoTelp = new System.Windows.Forms.Label();
            this.txtnotelp = new System.Windows.Forms.TextBox();
            this.lblPj = new System.Windows.Forms.Label();
            this.txtpj = new System.Windows.Forms.TextBox();
            this.lblBidang = new System.Windows.Forms.Label();
            this.txtbidang = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btntampil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoTelp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBidang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUbah = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lblTitle.Size = new System.Drawing.Size(209, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Data Perusahaan / DUDI";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(12, 42);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(95, 13);
            this.lblNama.TabIndex = 2;
            this.lblNama.Text = "Nama Perusahaan";
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(150, 39);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(220, 20);
            this.txtnama.TabIndex = 3;
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(12, 68);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(39, 13);
            this.lblAlamat.TabIndex = 4;
            this.lblAlamat.Text = "Alamat";
            // 
            // txtalamat
            // 
            this.txtalamat.Location = new System.Drawing.Point(150, 65);
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(220, 20);
            this.txtalamat.TabIndex = 5;
            // 
            // lblNoTelp
            // 
            this.lblNoTelp.AutoSize = true;
            this.lblNoTelp.Location = new System.Drawing.Point(12, 94);
            this.lblNoTelp.Name = "lblNoTelp";
            this.lblNoTelp.Size = new System.Drawing.Size(45, 13);
            this.lblNoTelp.TabIndex = 6;
            this.lblNoTelp.Text = "No Telp";
            // 
            // txtnotelp
            // 
            this.txtnotelp.Location = new System.Drawing.Point(150, 91);
            this.txtnotelp.Name = "txtnotelp";
            this.txtnotelp.Size = new System.Drawing.Size(220, 20);
            this.txtnotelp.TabIndex = 7;
            // 
            // lblPj
            // 
            this.lblPj.AutoSize = true;
            this.lblPj.Location = new System.Drawing.Point(400, 42);
            this.lblPj.Name = "lblPj";
            this.lblPj.Size = new System.Drawing.Size(102, 13);
            this.lblPj.TabIndex = 8;
            this.lblPj.Text = "Penanggung Jawab";
            // 
            // txtpj
            // 
            this.txtpj.Location = new System.Drawing.Point(500, 39);
            this.txtpj.Name = "txtpj";
            this.txtpj.Size = new System.Drawing.Size(160, 20);
            this.txtpj.TabIndex = 9;
            // 
            // lblBidang
            // 
            this.lblBidang.AutoSize = true;
            this.lblBidang.Location = new System.Drawing.Point(400, 68);
            this.lblBidang.Name = "lblBidang";
            this.lblBidang.Size = new System.Drawing.Size(74, 13);
            this.lblBidang.TabIndex = 10;
            this.lblBidang.Text = "Bidang Usaha";
            // 
            // txtbidang
            // 
            this.txtbidang.Location = new System.Drawing.Point(500, 65);
            this.txtbidang.Name = "txtbidang";
            this.txtbidang.Size = new System.Drawing.Size(160, 20);
            this.txtbidang.TabIndex = 11;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.LightCyan;
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(12, 130);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(90, 30);
            this.btnSimpan.TabIndex = 12;
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
            this.btnUbah.TabIndex = 13;
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
            this.btntampil.TabIndex = 14;
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
            this.colNama,
            this.colAlamat,
            this.colNoTelp,
            this.colPj,
            this.colBidang,
            this.colUbah,
            this.colHapus});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(700, 225);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            // 
            // colNama
            // 
            this.colNama.HeaderText = "Nama Perusahaan";
            this.colNama.Name = "colNama";
            // 
            // colAlamat
            // 
            this.colAlamat.HeaderText = "Alamat";
            this.colAlamat.Name = "colAlamat";
            // 
            // colNoTelp
            // 
            this.colNoTelp.HeaderText = "No Telp";
            this.colNoTelp.Name = "colNoTelp";
            // 
            // colPj
            // 
            this.colPj.HeaderText = "Penanggung Jawab";
            this.colPj.Name = "colPj";
            // 
            // colBidang
            // 
            this.colBidang.HeaderText = "Bidang Usaha";
            this.colBidang.Name = "colBidang";
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
            // FormPerusahaan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btntampil);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtbidang);
            this.Controls.Add(this.lblBidang);
            this.Controls.Add(this.txtpj);
            this.Controls.Add(this.lblPj);
            this.Controls.Add(this.txtnotelp);
            this.Controls.Add(this.lblNoTelp);
            this.Controls.Add(this.txtalamat);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.labelid);
            this.Name = "FormPerusahaan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Perusahaan / DUDI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPerusahaan_FormClosed);
            this.Load += new System.EventHandler(this.FormPerusahaan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.TextBox txtalamat;
        private System.Windows.Forms.Label lblNoTelp;
        private System.Windows.Forms.TextBox txtnotelp;
        private System.Windows.Forms.Label lblPj;
        private System.Windows.Forms.TextBox txtpj;
        private System.Windows.Forms.Label lblBidang;
        private System.Windows.Forms.TextBox txtbidang;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btntampil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoTelp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPj;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBidang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUbah;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHapus;
    }
}
