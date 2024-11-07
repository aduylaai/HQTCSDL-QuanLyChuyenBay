
namespace QuanLyChuyenBay_Demo.Forms
{
    partial class frmQuanLyPhieuDat
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
            this.dataGridViewDanhSachPhieuDat = new System.Windows.Forms.DataGridView();
            this.MaPhieuDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongHanhKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMaphieudat = new System.Windows.Forms.Label();
            this.lblSoluonghanhkhach = new System.Windows.Forms.Label();
            this.lblNgaydat = new System.Windows.Forms.Label();
            this.lblTenkhachhang = new System.Windows.Forms.Label();
            this.cboMaphieudat = new System.Windows.Forms.ComboBox();
            this.numericUpDownSoluongkhachhang = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerNgaydat = new System.Windows.Forms.DateTimePicker();
            this.txtTenkhachhang = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dataGridViewChiTietPhieuDat = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachPhieuDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoluongkhachhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietPhieuDat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDanhSachPhieuDat
            // 
            this.dataGridViewDanhSachPhieuDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachPhieuDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuDat,
            this.TenKhachHang,
            this.NgayDat,
            this.SoLuongHanhKhach});
            this.dataGridViewDanhSachPhieuDat.Location = new System.Drawing.Point(37, 238);
            this.dataGridViewDanhSachPhieuDat.Name = "dataGridViewDanhSachPhieuDat";
            this.dataGridViewDanhSachPhieuDat.RowHeadersWidth = 51;
            this.dataGridViewDanhSachPhieuDat.RowTemplate.Height = 24;
            this.dataGridViewDanhSachPhieuDat.Size = new System.Drawing.Size(556, 253);
            this.dataGridViewDanhSachPhieuDat.TabIndex = 6;
            // 
            // MaPhieuDat
            // 
            this.MaPhieuDat.HeaderText = "Mã phiếu đặt";
            this.MaPhieuDat.MinimumWidth = 6;
            this.MaPhieuDat.Name = "MaPhieuDat";
            this.MaPhieuDat.Width = 125;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.HeaderText = "Tên khách hàng";
            this.TenKhachHang.MinimumWidth = 6;
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.Width = 125;
            // 
            // NgayDat
            // 
            this.NgayDat.HeaderText = "Ngày đặt";
            this.NgayDat.MinimumWidth = 6;
            this.NgayDat.Name = "NgayDat";
            this.NgayDat.Width = 125;
            // 
            // SoLuongHanhKhach
            // 
            this.SoLuongHanhKhach.HeaderText = "Số lượng hành khách";
            this.SoLuongHanhKhach.MinimumWidth = 6;
            this.SoLuongHanhKhach.Name = "SoLuongHanhKhach";
            this.SoLuongHanhKhach.Width = 125;
            // 
            // lblMaphieudat
            // 
            this.lblMaphieudat.AutoSize = true;
            this.lblMaphieudat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaphieudat.Location = new System.Drawing.Point(78, 30);
            this.lblMaphieudat.Name = "lblMaphieudat";
            this.lblMaphieudat.Size = new System.Drawing.Size(97, 19);
            this.lblMaphieudat.TabIndex = 7;
            this.lblMaphieudat.Text = "Mã phiếu đặt";
            // 
            // lblSoluonghanhkhach
            // 
            this.lblSoluonghanhkhach.AutoSize = true;
            this.lblSoluonghanhkhach.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoluonghanhkhach.Location = new System.Drawing.Point(78, 181);
            this.lblSoluonghanhkhach.Name = "lblSoluonghanhkhach";
            this.lblSoluonghanhkhach.Size = new System.Drawing.Size(148, 19);
            this.lblSoluonghanhkhach.TabIndex = 8;
            this.lblSoluonghanhkhach.Text = "Số lượng khách hàng";
            // 
            // lblNgaydat
            // 
            this.lblNgaydat.AutoSize = true;
            this.lblNgaydat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaydat.Location = new System.Drawing.Point(78, 128);
            this.lblNgaydat.Name = "lblNgaydat";
            this.lblNgaydat.Size = new System.Drawing.Size(69, 19);
            this.lblNgaydat.TabIndex = 9;
            this.lblNgaydat.Text = "Ngày đặt";
            // 
            // lblTenkhachhang
            // 
            this.lblTenkhachhang.AutoSize = true;
            this.lblTenkhachhang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenkhachhang.Location = new System.Drawing.Point(78, 83);
            this.lblTenkhachhang.Name = "lblTenkhachhang";
            this.lblTenkhachhang.Size = new System.Drawing.Size(112, 19);
            this.lblTenkhachhang.TabIndex = 10;
            this.lblTenkhachhang.Text = "Tên khách hàng";
            // 
            // cboMaphieudat
            // 
            this.cboMaphieudat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaphieudat.FormattingEnabled = true;
            this.cboMaphieudat.Location = new System.Drawing.Point(268, 30);
            this.cboMaphieudat.Name = "cboMaphieudat";
            this.cboMaphieudat.Size = new System.Drawing.Size(214, 27);
            this.cboMaphieudat.TabIndex = 11;
            // 
            // numericUpDownSoluongkhachhang
            // 
            this.numericUpDownSoluongkhachhang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSoluongkhachhang.Location = new System.Drawing.Point(269, 181);
            this.numericUpDownSoluongkhachhang.Name = "numericUpDownSoluongkhachhang";
            this.numericUpDownSoluongkhachhang.Size = new System.Drawing.Size(213, 27);
            this.numericUpDownSoluongkhachhang.TabIndex = 12;
            // 
            // dateTimePickerNgaydat
            // 
            this.dateTimePickerNgaydat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgaydat.Location = new System.Drawing.Point(269, 128);
            this.dateTimePickerNgaydat.Name = "dateTimePickerNgaydat";
            this.dateTimePickerNgaydat.Size = new System.Drawing.Size(213, 27);
            this.dateTimePickerNgaydat.TabIndex = 13;
            // 
            // txtTenkhachhang
            // 
            this.txtTenkhachhang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenkhachhang.Location = new System.Drawing.Point(269, 83);
            this.txtTenkhachhang.Name = "txtTenkhachhang";
            this.txtTenkhachhang.Size = new System.Drawing.Size(213, 27);
            this.txtTenkhachhang.TabIndex = 14;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.DarkRed;
            this.btnXoa.Location = new System.Drawing.Point(707, 20);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 46);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.DarkRed;
            this.btnThem.Location = new System.Drawing.Point(565, 20);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 46);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnLammoi
            // 
            this.btnLammoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.ForeColor = System.Drawing.Color.DarkRed;
            this.btnLammoi.Location = new System.Drawing.Point(982, 20);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(103, 46);
            this.btnLammoi.TabIndex = 17;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSua.Location = new System.Drawing.Point(845, 20);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 46);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.DarkRed;
            this.btnThoat.Location = new System.Drawing.Point(1117, 20);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 46);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // dataGridViewChiTietPhieuDat
            // 
            this.dataGridViewChiTietPhieuDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTietPhieuDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.MaVe});
            this.dataGridViewChiTietPhieuDat.Location = new System.Drawing.Point(707, 97);
            this.dataGridViewChiTietPhieuDat.Name = "dataGridViewChiTietPhieuDat";
            this.dataGridViewChiTietPhieuDat.RowHeadersWidth = 51;
            this.dataGridViewChiTietPhieuDat.RowTemplate.Height = 24;
            this.dataGridViewChiTietPhieuDat.Size = new System.Drawing.Size(452, 394);
            this.dataGridViewChiTietPhieuDat.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã phiếu đặt";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // MaVe
            // 
            this.MaVe.HeaderText = "Mã vé";
            this.MaVe.MinimumWidth = 6;
            this.MaVe.Name = "MaVe";
            this.MaVe.Width = 200;
            // 
            // frmQuanLyPhieuDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 503);
            this.Controls.Add(this.dataGridViewChiTietPhieuDat);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtTenkhachhang);
            this.Controls.Add(this.dateTimePickerNgaydat);
            this.Controls.Add(this.numericUpDownSoluongkhachhang);
            this.Controls.Add(this.cboMaphieudat);
            this.Controls.Add(this.lblTenkhachhang);
            this.Controls.Add(this.lblNgaydat);
            this.Controls.Add(this.lblSoluonghanhkhach);
            this.Controls.Add(this.lblMaphieudat);
            this.Controls.Add(this.dataGridViewDanhSachPhieuDat);
            this.Name = "frmQuanLyPhieuDat";
            this.Text = "frmQuanLyPhieuDat";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachPhieuDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoluongkhachhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietPhieuDat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDanhSachPhieuDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongHanhKhach;
        private System.Windows.Forms.Label lblMaphieudat;
        private System.Windows.Forms.Label lblSoluonghanhkhach;
        private System.Windows.Forms.Label lblNgaydat;
        private System.Windows.Forms.Label lblTenkhachhang;
        private System.Windows.Forms.ComboBox cboMaphieudat;
        private System.Windows.Forms.NumericUpDown numericUpDownSoluongkhachhang;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaydat;
        private System.Windows.Forms.TextBox txtTenkhachhang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dataGridViewChiTietPhieuDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVe;
    }
}