
namespace PengajuanPrakerin
{
    partial class FormRole
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
            this.lblNamaRole = new System.Windows.Forms.Label();
            this.txtnamarole = new System.Windows.Forms.TextBox();
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.txtdeskripsi = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btntampil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamaRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeskripsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lblTitle.Size = new System.Drawing.Size(90, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Data Role";
            // 
            // lblNamaRole
            // 
            this.lblNamaRole.AutoSize = true;
            this.lblNamaRole.Location = new System.Drawing.Point(12, 42);
            this.lblNamaRole.Name = "lblNamaRole";
            this.lblNamaRole.Size = new System.Drawing.Size(60, 13);
            this.lblNamaRole.TabIndex = 2;
            this.lblNamaRole.Text = "Nama Role";
            // 
            // txtnamarole
            // 
            this.txtnamarole.Location = new System.Drawing.Point(110, 39);
            this.txtnamarole.Name = "txtnamarole";
            this.txtnamarole.Size = new System.Drawing.Size(220, 20);
            this.txtnamarole.TabIndex = 3;
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Location = new System.Drawing.Point(12, 68);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(50, 13);
            this.lblDeskripsi.TabIndex = 4;
            this.lblDeskripsi.Text = "Deskripsi";
            // 
            // txtdeskripsi
            // 
            this.txtdeskripsi.Location = new System.Drawing.Point(110, 65);
            this.txtdeskripsi.Name = "txtdeskripsi";
            this.txtdeskripsi.Size = new System.Drawing.Size(300, 20);
            this.txtdeskripsi.TabIndex = 5;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.LightCyan;
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(12, 100);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(90, 30);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.LightCyan;
            this.btnUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbah.Location = new System.Drawing.Point(108, 100);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(90, 30);
            this.btnUbah.TabIndex = 7;
            this.btnUbah.Text = "Ubah Data";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btntampil
            // 
            this.btntampil.BackColor = System.Drawing.Color.LightCyan;
            this.btntampil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntampil.Location = new System.Drawing.Point(204, 100);
            this.btntampil.Name = "btntampil";
            this.btntampil.Size = new System.Drawing.Size(90, 30);
            this.btntampil.TabIndex = 8;
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
            this.colNamaRole,
            this.colDeskripsi,
            this.colUbah,
            this.colHapus});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 200);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            // 
            // colNamaRole
            // 
            this.colNamaRole.HeaderText = "Nama Role";
            this.colNamaRole.Name = "colNamaRole";
            // 
            // colDeskripsi
            // 
            this.colDeskripsi.HeaderText = "Deskripsi";
            this.colDeskripsi.Name = "colDeskripsi";
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
            // FormRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 345);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btntampil);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtdeskripsi);
            this.Controls.Add(this.lblDeskripsi);
            this.Controls.Add(this.txtnamarole);
            this.Controls.Add(this.lblNamaRole);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.labelid);
            this.Name = "FormRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Role";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRole_FormClosed);
            this.Load += new System.EventHandler(this.FormRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNamaRole;
        private System.Windows.Forms.TextBox txtnamarole;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.TextBox txtdeskripsi;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btntampil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamaRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeskripsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUbah;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHapus;
    }
}
