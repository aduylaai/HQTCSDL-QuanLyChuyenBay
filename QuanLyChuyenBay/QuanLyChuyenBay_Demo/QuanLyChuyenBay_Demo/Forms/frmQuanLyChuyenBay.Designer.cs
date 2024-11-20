
namespace QuanLyChuyenBay_Demo.Forms
{
    partial class frmQuanLyChuyenBay
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
            this.dataGridViewDanhSachChuyenBay = new System.Windows.Forms.DataGridView();
            this.lblHangHangKhong = new System.Windows.Forms.Label();
            this.lblTrangThaiChuyenBay = new System.Windows.Forms.Label();
            this.lblTenmaybay = new System.Windows.Forms.Label();
            this.lblLotrinh = new System.Windows.Forms.Label();
            this.lblThongTinChuyenBay = new System.Windows.Forms.Label();
            this.cboHangHangKhong = new System.Windows.Forms.ComboBox();
            this.cboTenLoTrinh = new System.Windows.Forms.ComboBox();
            this.cboTenmaybay = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblMachuyenbay = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblGiabay = new System.Windows.Forms.Label();
            this.txtGiabay = new System.Windows.Forms.TextBox();
            this.lblMaChuyenBayIP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachChuyenBay)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDanhSachChuyenBay
            // 
            this.dataGridViewDanhSachChuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachChuyenBay.Location = new System.Drawing.Point(12, 308);
            this.dataGridViewDanhSachChuyenBay.Name = "dataGridViewDanhSachChuyenBay";
            this.dataGridViewDanhSachChuyenBay.RowHeadersWidth = 51;
            this.dataGridViewDanhSachChuyenBay.RowTemplate.Height = 24;
            this.dataGridViewDanhSachChuyenBay.Size = new System.Drawing.Size(801, 237);
            this.dataGridViewDanhSachChuyenBay.TabIndex = 4;
            this.dataGridViewDanhSachChuyenBay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhSachChuyenBay_CellClick);
            // 
            // lblHangHangKhong
            // 
            this.lblHangHangKhong.AutoSize = true;
            this.lblHangHangKhong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHangHangKhong.Location = new System.Drawing.Point(32, 93);
            this.lblHangHangKhong.Name = "lblHangHangKhong";
            this.lblHangHangKhong.Size = new System.Drawing.Size(143, 19);
            this.lblHangHangKhong.TabIndex = 5;
            this.lblHangHangKhong.Text = "Hãng Hàng Không";
            // 
            // lblTrangThaiChuyenBay
            // 
            this.lblTrangThaiChuyenBay.AutoSize = true;
            this.lblTrangThaiChuyenBay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThaiChuyenBay.Location = new System.Drawing.Point(33, 134);
            this.lblTrangThaiChuyenBay.Name = "lblTrangThaiChuyenBay";
            this.lblTrangThaiChuyenBay.Size = new System.Drawing.Size(89, 19);
            this.lblTrangThaiChuyenBay.TabIndex = 6;
            this.lblTrangThaiChuyenBay.Text = "Trạng Thái";
            // 
            // lblTenmaybay
            // 
            this.lblTenmaybay.AutoSize = true;
            this.lblTenmaybay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenmaybay.Location = new System.Drawing.Point(33, 225);
            this.lblTenmaybay.Name = "lblTenmaybay";
            this.lblTenmaybay.Size = new System.Drawing.Size(99, 19);
            this.lblTenmaybay.TabIndex = 7;
            this.lblTenmaybay.Text = "Tên máy bay";
            // 
            // lblLotrinh
            // 
            this.lblLotrinh.AutoSize = true;
            this.lblLotrinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLotrinh.Location = new System.Drawing.Point(33, 179);
            this.lblLotrinh.Name = "lblLotrinh";
            this.lblLotrinh.Size = new System.Drawing.Size(71, 19);
            this.lblLotrinh.TabIndex = 8;
            this.lblLotrinh.Text = "Lộ trình";
            // 
            // lblThongTinChuyenBay
            // 
            this.lblThongTinChuyenBay.AutoSize = true;
            this.lblThongTinChuyenBay.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinChuyenBay.ForeColor = System.Drawing.Color.Red;
            this.lblThongTinChuyenBay.Location = new System.Drawing.Point(230, 1);
            this.lblThongTinChuyenBay.Name = "lblThongTinChuyenBay";
            this.lblThongTinChuyenBay.Size = new System.Drawing.Size(432, 37);
            this.lblThongTinChuyenBay.TabIndex = 13;
            this.lblThongTinChuyenBay.Text = "THÔNG TIN CHUYẾN BAY";
            // 
            // cboHangHangKhong
            // 
            this.cboHangHangKhong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHangHangKhong.FormattingEnabled = true;
            this.cboHangHangKhong.Location = new System.Drawing.Point(237, 90);
            this.cboHangHangKhong.Name = "cboHangHangKhong";
            this.cboHangHangKhong.Size = new System.Drawing.Size(251, 27);
            this.cboHangHangKhong.TabIndex = 18;
            // 
            // cboTenLoTrinh
            // 
            this.cboTenLoTrinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenLoTrinh.FormattingEnabled = true;
            this.cboTenLoTrinh.Location = new System.Drawing.Point(237, 176);
            this.cboTenLoTrinh.Name = "cboTenLoTrinh";
            this.cboTenLoTrinh.Size = new System.Drawing.Size(251, 27);
            this.cboTenLoTrinh.TabIndex = 19;
            // 
            // cboTenmaybay
            // 
            this.cboTenmaybay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenmaybay.FormattingEnabled = true;
            this.cboTenmaybay.Location = new System.Drawing.Point(237, 222);
            this.cboTenmaybay.Name = "cboTenmaybay";
            this.cboTenmaybay.Size = new System.Drawing.Size(251, 27);
            this.cboTenmaybay.TabIndex = 20;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.DarkRed;
            this.btnThoat.Location = new System.Drawing.Point(1053, 62);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 46);
            this.btnThoat.TabIndex = 25;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSua.Location = new System.Drawing.Point(781, 62);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 46);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.DarkRed;
            this.btnLamMoi.Location = new System.Drawing.Point(923, 62);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(103, 46);
            this.btnLamMoi.TabIndex = 23;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.DarkRed;
            this.btnThem.Location = new System.Drawing.Point(501, 62);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 46);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.DarkRed;
            this.btnXoa.Location = new System.Drawing.Point(643, 62);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 46);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblMachuyenbay
            // 
            this.lblMachuyenbay.AutoSize = true;
            this.lblMachuyenbay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachuyenbay.Location = new System.Drawing.Point(33, 49);
            this.lblMachuyenbay.Name = "lblMachuyenbay";
            this.lblMachuyenbay.Size = new System.Drawing.Size(117, 19);
            this.lblMachuyenbay.TabIndex = 26;
            this.lblMachuyenbay.Text = "Mã chuyến bay";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(237, 131);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(251, 27);
            this.cboTrangThai.TabIndex = 28;
            // 
            // lblGiabay
            // 
            this.lblGiabay.AutoSize = true;
            this.lblGiabay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiabay.Location = new System.Drawing.Point(33, 272);
            this.lblGiabay.Name = "lblGiabay";
            this.lblGiabay.Size = new System.Drawing.Size(66, 19);
            this.lblGiabay.TabIndex = 29;
            this.lblGiabay.Text = "Giá bay";
            // 
            // txtGiabay
            // 
            this.txtGiabay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiabay.Location = new System.Drawing.Point(237, 269);
            this.txtGiabay.Name = "txtGiabay";
            this.txtGiabay.Size = new System.Drawing.Size(251, 27);
            this.txtGiabay.TabIndex = 30;
            // 
            // lblMaChuyenBayIP
            // 
            this.lblMaChuyenBayIP.AutoSize = true;
            this.lblMaChuyenBayIP.Location = new System.Drawing.Point(259, 52);
            this.lblMaChuyenBayIP.Name = "lblMaChuyenBayIP";
            this.lblMaChuyenBayIP.Size = new System.Drawing.Size(103, 16);
            this.lblMaChuyenBayIP.TabIndex = 31;
            this.lblMaChuyenBayIP.Text = "[MaChuyenBay]";
            // 
            // frmQuanLyChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 648);
            this.Controls.Add(this.lblMaChuyenBayIP);
            this.Controls.Add(this.txtGiabay);
            this.Controls.Add(this.lblGiabay);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.lblMachuyenbay);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.cboTenmaybay);
            this.Controls.Add(this.cboTenLoTrinh);
            this.Controls.Add(this.cboHangHangKhong);
            this.Controls.Add(this.lblThongTinChuyenBay);
            this.Controls.Add(this.lblLotrinh);
            this.Controls.Add(this.lblTenmaybay);
            this.Controls.Add(this.lblTrangThaiChuyenBay);
            this.Controls.Add(this.lblHangHangKhong);
            this.Controls.Add(this.dataGridViewDanhSachChuyenBay);
            this.Name = "frmQuanLyChuyenBay";
            this.Text = "frmQuanLyChuyenBay";
            this.Load += new System.EventHandler(this.frmQuanLyChuyenBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachChuyenBay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDanhSachChuyenBay;
        private System.Windows.Forms.Label lblHangHangKhong;
        private System.Windows.Forms.Label lblTrangThaiChuyenBay;
        private System.Windows.Forms.Label lblTenmaybay;
        private System.Windows.Forms.Label lblLotrinh;
        private System.Windows.Forms.Label lblThongTinChuyenBay;
        private System.Windows.Forms.ComboBox cboHangHangKhong;
        private System.Windows.Forms.ComboBox cboTenLoTrinh;
        private System.Windows.Forms.ComboBox cboTenmaybay;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblMachuyenbay;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label lblGiabay;
        private System.Windows.Forms.TextBox txtGiabay;
        private System.Windows.Forms.Label lblMaChuyenBayIP;
    }
}