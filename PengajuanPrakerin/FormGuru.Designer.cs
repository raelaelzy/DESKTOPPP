
namespace PengajuanPrakerin
{
    partial class FormGuru
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
            this.lblNip = new System.Windows.Forms.Label();
            this.txtnip = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.lblNoHp = new System.Windows.Forms.Label();
            this.txtnohp = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btntampil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoHp = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lblTitle.Size = new System.Drawing.Size(195, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Data Guru Pembimbing";
            // 
            // lblNip
            // 
            this.lblNip.AutoSize = true;
            this.lblNip.Location = new System.Drawing.Point(12, 42);
            this.lblNip.Name = "lblNip";
            this.lblNip.Size = new System.Drawing.Size(25, 13);
            this.lblNip.TabIndex = 2;
            this.lblNip.Text = "NIP";
            // 
            // txtnip
            // 
            this.txtnip.Location = new System.Drawing.Point(110, 39);
            this.txtnip.Name = "txtnip";
            this.txtnip.Size = new System.Drawing.Size(150, 20);
            this.txtnip.TabIndex = 3;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(12, 68);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(61, 13);
            this.lblNama.TabIndex = 4;
            this.lblNama.Text = "Nama Guru";
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(110, 65);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(220, 20);
            this.txtnama.TabIndex = 5;
            // 
            // lblNoHp
            // 
            this.lblNoHp.AutoSize = true;
            this.lblNoHp.Location = new System.Drawing.Point(12, 94);
            this.lblNoHp.Name = "lblNoHp";
            this.lblNoHp.Size = new System.Drawing.Size(39, 13);
            this.lblNoHp.TabIndex = 6;
            this.lblNoHp.Text = "No HP";
            // 
            // txtnohp
            // 
            this.txtnohp.Location = new System.Drawing.Point(110, 91);
            this.txtnohp.Name = "txtnohp";
            this.txtnohp.Size = new System.Drawing.Size(150, 20);
            this.txtnohp.TabIndex = 7;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.LightCyan;
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(12, 130);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(90, 30);
            this.btnSimpan.TabIndex = 8;
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
            this.btnUbah.TabIndex = 9;
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
            this.btntampil.TabIndex = 10;
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
            this.colNip,
            this.colNama,
            this.colNoHp,
            this.colUbah,
            this.colHapus});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 225);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            // 
            // colNip
            // 
            this.colNip.HeaderText = "NIP";
            this.colNip.Name = "colNip";
            // 
            // colNama
            // 
            this.colNama.HeaderText = "Nama Guru";
            this.colNama.Name = "colNama";
            // 
            // colNoHp
            // 
            this.colNoHp.HeaderText = "No HP";
            this.colNoHp.Name = "colNoHp";
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
            // FormGuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btntampil);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtnohp);
            this.Controls.Add(this.lblNoHp);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.txtnip);
            this.Controls.Add(this.lblNip);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.labelid);
            this.Name = "FormGuru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Guru Pembimbing";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGuru_FormClosed);
            this.Load += new System.EventHandler(this.FormGuru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNip;
        private System.Windows.Forms.TextBox txtnip;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Label lblNoHp;
        private System.Windows.Forms.TextBox txtnohp;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btntampil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNip;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoHp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUbah;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHapus;
    }
}
