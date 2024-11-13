
namespace QuanLyChuyenBay_Demo.Forms
{
    partial class frmQuanLyVe
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
            this.dataGridViewDanhSachVe = new System.Windows.Forms.DataGridView();
            this.MaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMave = new System.Windows.Forms.Label();
            this.lblTrangthaive = new System.Windows.Forms.Label();
            this.lblTenkhachhang = new System.Windows.Forms.Label();
            this.cboMave = new System.Windows.Forms.ComboBox();
            this.cboTrangthaive = new System.Windows.Forms.ComboBox();
            this.dataGridViewChiTietVe = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChuyenBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHangGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cboTenHanhKhach = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachVe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietVe)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDanhSachVe
            // 
            this.dataGridViewDanhSachVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachVe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaVe,
            this.TenKhachHang,
            this.TenTTV});
            this.dataGridViewDanhSachVe.Location = new System.Drawing.Point(35, 256);
            this.dataGridViewDanhSachVe.Name = "dataGridViewDanhSachVe";
            this.dataGridViewDanhSachVe.RowHeadersWidth = 51;
            this.dataGridViewDanhSachVe.RowTemplate.Height = 24;
            this.dataGridViewDanhSachVe.Size = new System.Drawing.Size(452, 235);
            this.dataGridViewDanhSachVe.TabIndex = 0;
            // 
            // MaVe
            // 
            this.MaVe.HeaderText = "Mã vé";
            this.MaVe.MinimumWidth = 6;
            this.MaVe.Name = "MaVe";
            this.MaVe.Width = 50;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.HeaderText = "Tên khách hàng";
            this.TenKhachHang.MinimumWidth = 6;
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.Width = 200;
            // 
            // TenTTV
            // 
            this.TenTTV.HeaderText = "Trạng thái vé";
            this.TenTTV.MinimumWidth = 6;
            this.TenTTV.Name = "TenTTV";
            this.TenTTV.Width = 150;
            // 
            // lblMave
            // 
            this.lblMave.AutoSize = true;
            this.lblMave.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMave.Location = new System.Drawing.Point(42, 44);
            this.lblMave.Name = "lblMave";
            this.lblMave.Size = new System.Drawing.Size(50, 19);
            this.lblMave.TabIndex = 1;
            this.lblMave.Text = "Mã vé";
            this.lblMave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTrangthaive
            // 
            this.lblTrangthaive.AutoSize = true;
            this.lblTrangthaive.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangthaive.Location = new System.Drawing.Point(42, 159);
            this.lblTrangthaive.Name = "lblTrangthaive";
            this.lblTrangthaive.Size = new System.Drawing.Size(98, 19);
            this.lblTrangthaive.TabIndex = 2;
            this.lblTrangthaive.Text = "Trạng  thái vé";
            // 
            // lblTenkhachhang
            // 
            this.lblTenkhachhang.AutoSize = true;
            this.lblTenkhachhang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenkhachhang.Location = new System.Drawing.Point(42, 99);
            this.lblTenkhachhang.Name = "lblTenkhachhang";
            this.lblTenkhachhang.Size = new System.Drawing.Size(112, 19);
            this.lblTenkhachhang.TabIndex = 3;
            this.lblTenkhachhang.Text = "Tên hành khách";
            // 
            // cboMave
            // 
            this.cboMave.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMave.FormattingEnabled = true;
            this.cboMave.Location = new System.Drawing.Point(182, 35);
            this.cboMave.Name = "cboMave";
            this.cboMave.Size = new System.Drawing.Size(189, 27);
            this.cboMave.TabIndex = 4;
            // 
            // cboTrangthaive
            // 
            this.cboTrangthaive.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangthaive.FormattingEnabled = true;
            this.cboTrangthaive.Location = new System.Drawing.Point(182, 159);
            this.cboTrangthaive.Name = "cboTrangthaive";
            this.cboTrangthaive.Size = new System.Drawing.Size(189, 27);
            this.cboTrangthaive.TabIndex = 5;
            // 
            // dataGridViewChiTietVe
            // 
            this.dataGridViewChiTietVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTietVe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.MaChuyenBay,
            this.NgayDi,
            this.NgayDen,
            this.MaHangGhe});
            this.dataGridViewChiTietVe.Location = new System.Drawing.Point(560, 256);
            this.dataGridViewChiTietVe.Name = "dataGridViewChiTietVe";
            this.dataGridViewChiTietVe.RowHeadersWidth = 51;
            this.dataGridViewChiTietVe.RowTemplate.Height = 24;
            this.dataGridViewChiTietVe.Size = new System.Drawing.Size(626, 235);
            this.dataGridViewChiTietVe.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã vé";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // MaChuyenBay
            // 
            this.MaChuyenBay.HeaderText = "Mã chuyến bay";
            this.MaChuyenBay.MinimumWidth = 6;
            this.MaChuyenBay.Name = "MaChuyenBay";
            this.MaChuyenBay.Width = 150;
            // 
            // NgayDi
            // 
            this.NgayDi.HeaderText = "Ngày đi";
            this.NgayDi.MinimumWidth = 6;
            this.NgayDi.Name = "NgayDi";
            this.NgayDi.Width = 125;
            // 
            // NgayDen
            // 
            this.NgayDen.HeaderText = "Ngày đến";
            this.NgayDen.MinimumWidth = 6;
            this.NgayDen.Name = "NgayDen";
            this.NgayDen.Width = 125;
            // 
            // MaHangGhe
            // 
            this.MaHangGhe.HeaderText = "Mã hàng ghế";
            this.MaHangGhe.MinimumWidth = 6;
            this.MaHangGhe.Name = "MaHangGhe";
            this.MaHangGhe.Width = 125;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.DarkRed;
            this.btnThoat.Location = new System.Drawing.Point(1095, 26);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 46);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSua.Location = new System.Drawing.Point(823, 26);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 46);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLammoi
            // 
            this.btnLammoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.ForeColor = System.Drawing.Color.DarkRed;
            this.btnLammoi.Location = new System.Drawing.Point(960, 26);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(103, 46);
            this.btnLammoi.TabIndex = 22;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.DarkRed;
            this.btnThem.Location = new System.Drawing.Point(543, 26);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 46);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.DarkRed;
            this.btnXoa.Location = new System.Drawing.Point(685, 26);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 46);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // cboTenHanhKhach
            // 
            this.cboTenHanhKhach.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenHanhKhach.FormattingEnabled = true;
            this.cboTenHanhKhach.Location = new System.Drawing.Point(182, 96);
            this.cboTenHanhKhach.Name = "cboTenHanhKhach";
            this.cboTenHanhKhach.Size = new System.Drawing.Size(189, 27);
            this.cboTenHanhKhach.TabIndex = 25;
            // 
            // frmQuanLyVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 503);
            this.Controls.Add(this.cboTenHanhKhach);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dataGridViewChiTietVe);
            this.Controls.Add(this.cboTrangthaive);
            this.Controls.Add(this.cboMave);
            this.Controls.Add(this.lblTenkhachhang);
            this.Controls.Add(this.lblTrangthaive);
            this.Controls.Add(this.lblMave);
            this.Controls.Add(this.dataGridViewDanhSachVe);
            this.Name = "frmQuanLyVe";
            this.Text = "frmQuanLyVe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachVe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDanhSachVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTTV;
        private System.Windows.Forms.Label lblMave;
        private System.Windows.Forms.Label lblTrangthaive;
        private System.Windows.Forms.Label lblTenkhachhang;
        private System.Windows.Forms.ComboBox cboMave;
        private System.Windows.Forms.ComboBox cboTrangthaive;
        private System.Windows.Forms.DataGridView dataGridViewChiTietVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChuyenBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHangGhe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cboTenHanhKhach;
    }
}