
namespace QuanLyChuyenBay_Demo.Forms
{
    partial class frmQuanLyGiamGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyGiamGia));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblMucGiamGia = new System.Windows.Forms.Label();
            this.dataGridViewDanhSachGiamGia = new System.Windows.Forms.DataGridView();
            this.cboCode = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cboMucGiamGia = new System.Windows.Forms.ComboBox();
            this.lblMaGiamGia = new System.Windows.Forms.Label();
            this.lblMaGiamGiaIP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachGiamGia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(37, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(414, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ GIẢM GIÁ";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(40, 178);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(66, 25);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Code:";
            // 
            // lblMucGiamGia
            // 
            this.lblMucGiamGia.AutoSize = true;
            this.lblMucGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMucGiamGia.Location = new System.Drawing.Point(40, 267);
            this.lblMucGiamGia.Name = "lblMucGiamGia";
            this.lblMucGiamGia.Size = new System.Drawing.Size(134, 25);
            this.lblMucGiamGia.TabIndex = 2;
            this.lblMucGiamGia.Text = "Mức giảm giá:";
            // 
            // dataGridViewDanhSachGiamGia
            // 
            this.dataGridViewDanhSachGiamGia.AllowUserToAddRows = false;
            this.dataGridViewDanhSachGiamGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachGiamGia.Location = new System.Drawing.Point(470, 46);
            this.dataGridViewDanhSachGiamGia.Name = "dataGridViewDanhSachGiamGia";
            this.dataGridViewDanhSachGiamGia.RowHeadersWidth = 51;
            this.dataGridViewDanhSachGiamGia.RowTemplate.Height = 24;
            this.dataGridViewDanhSachGiamGia.Size = new System.Drawing.Size(611, 478);
            this.dataGridViewDanhSachGiamGia.TabIndex = 5;
            this.dataGridViewDanhSachGiamGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhSachGiamGia_CellClick);
            // 
            // cboCode
            // 
            this.cboCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCode.FormattingEnabled = true;
            this.cboCode.Location = new System.Drawing.Point(200, 175);
            this.cboCode.Name = "cboCode";
            this.cboCode.Size = new System.Drawing.Size(227, 33);
            this.cboCode.TabIndex = 6;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.DarkRed;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(1087, 449);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(118, 64);
            this.btnThoat.TabIndex = 29;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(259, 348);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(133, 55);
            this.btnSua.TabIndex = 28;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.ForeColor = System.Drawing.Color.DarkRed;
            this.btnLammoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLammoi.Image")));
            this.btnLammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLammoi.Location = new System.Drawing.Point(259, 449);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(133, 55);
            this.btnLammoi.TabIndex = 27;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.DarkRed;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(41, 348);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(133, 55);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.DarkRed;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(41, 449);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(133, 55);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cboMucGiamGia
            // 
            this.cboMucGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMucGiamGia.FormattingEnabled = true;
            this.cboMucGiamGia.Location = new System.Drawing.Point(200, 267);
            this.cboMucGiamGia.Name = "cboMucGiamGia";
            this.cboMucGiamGia.Size = new System.Drawing.Size(227, 33);
            this.cboMucGiamGia.TabIndex = 7;
            // 
            // lblMaGiamGia
            // 
            this.lblMaGiamGia.AutoSize = true;
            this.lblMaGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaGiamGia.Location = new System.Drawing.Point(40, 111);
            this.lblMaGiamGia.Name = "lblMaGiamGia";
            this.lblMaGiamGia.Size = new System.Drawing.Size(124, 25);
            this.lblMaGiamGia.TabIndex = 30;
            this.lblMaGiamGia.Text = "Mã giảm giá:";
            // 
            // lblMaGiamGiaIP
            // 
            this.lblMaGiamGiaIP.AutoSize = true;
            this.lblMaGiamGiaIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaGiamGiaIP.Location = new System.Drawing.Point(210, 111);
            this.lblMaGiamGiaIP.Name = "lblMaGiamGiaIP";
            this.lblMaGiamGiaIP.Size = new System.Drawing.Size(128, 25);
            this.lblMaGiamGiaIP.TabIndex = 31;
            this.lblMaGiamGiaIP.Text = "[MaGiamGia]";
            // 
            // frmQuanLyGiamGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 536);
            this.Controls.Add(this.lblMaGiamGiaIP);
            this.Controls.Add(this.lblMaGiamGia);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.cboMucGiamGia);
            this.Controls.Add(this.cboCode);
            this.Controls.Add(this.dataGridViewDanhSachGiamGia);
            this.Controls.Add(this.lblMucGiamGia);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmQuanLyGiamGia";
            this.Text = "frmQuanLyGiamGia";
            this.Load += new System.EventHandler(this.frmQuanLyGiamGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachGiamGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblMucGiamGia;
        private System.Windows.Forms.DataGridView dataGridViewDanhSachGiamGia;
        private System.Windows.Forms.ComboBox cboCode;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cboMucGiamGia;
        private System.Windows.Forms.Label lblMaGiamGia;
        private System.Windows.Forms.Label lblMaGiamGiaIP;
    }
}