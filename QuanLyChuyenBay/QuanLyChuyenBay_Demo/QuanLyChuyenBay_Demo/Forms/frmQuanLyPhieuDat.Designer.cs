
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
            this.lblMaphieudat = new System.Windows.Forms.Label();
            this.btnXoaPhieuDat = new System.Windows.Forms.Button();
            this.btnTaoPhieuDat = new System.Windows.Forms.Button();
            this.btnSuaPhieuDat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSuaChiTiet = new System.Windows.Forms.Button();
            this.dateTimePickerNgayDat = new System.Windows.Forms.DateTimePicker();
            this.lblNgayDat = new System.Windows.Forms.Label();
            this.cboTenKhachHang = new System.Windows.Forms.ComboBox();
            this.lblTenkhachhang = new System.Windows.Forms.Label();
            this.dataGridViewDanhSachChiTietPhieuDat = new System.Windows.Forms.DataGridView();
            this.lblChiTietPhieuDat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachPhieuDat)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachChiTietPhieuDat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDanhSachPhieuDat
            // 
            this.dataGridViewDanhSachPhieuDat.AllowUserToAddRows = false;
            this.dataGridViewDanhSachPhieuDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachPhieuDat.Location = new System.Drawing.Point(24, 241);
            this.dataGridViewDanhSachPhieuDat.Name = "dataGridViewDanhSachPhieuDat";
            this.dataGridViewDanhSachPhieuDat.RowHeadersWidth = 51;
            this.dataGridViewDanhSachPhieuDat.RowTemplate.Height = 24;
            this.dataGridViewDanhSachPhieuDat.Size = new System.Drawing.Size(616, 250);
            this.dataGridViewDanhSachPhieuDat.TabIndex = 6;
            this.dataGridViewDanhSachPhieuDat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhSachPhieuDat_CellDoubleClick);
            // 
            // lblMaphieudat
            // 
            this.lblMaphieudat.AutoSize = true;
            this.lblMaphieudat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaphieudat.Location = new System.Drawing.Point(13, -3);
            this.lblMaphieudat.Name = "lblMaphieudat";
            this.lblMaphieudat.Size = new System.Drawing.Size(141, 25);
            this.lblMaphieudat.TabIndex = 7;
            this.lblMaphieudat.Text = "MaPhieuDat";
            // 
            // btnXoaPhieuDat
            // 
            this.btnXoaPhieuDat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhieuDat.ForeColor = System.Drawing.Color.Black;
            this.btnXoaPhieuDat.Location = new System.Drawing.Point(302, 32);
            this.btnXoaPhieuDat.Name = "btnXoaPhieuDat";
            this.btnXoaPhieuDat.Size = new System.Drawing.Size(145, 46);
            this.btnXoaPhieuDat.TabIndex = 15;
            this.btnXoaPhieuDat.Text = "Xóa Phiếu Đặt";
            this.btnXoaPhieuDat.UseVisualStyleBackColor = true;
            this.btnXoaPhieuDat.Click += new System.EventHandler(this.btnXoaPhieuDat_Click);
            // 
            // btnTaoPhieuDat
            // 
            this.btnTaoPhieuDat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoPhieuDat.ForeColor = System.Drawing.Color.Black;
            this.btnTaoPhieuDat.Location = new System.Drawing.Point(8, 32);
            this.btnTaoPhieuDat.Name = "btnTaoPhieuDat";
            this.btnTaoPhieuDat.Size = new System.Drawing.Size(107, 46);
            this.btnTaoPhieuDat.TabIndex = 16;
            this.btnTaoPhieuDat.Text = "Tạo Phiếu";
            this.btnTaoPhieuDat.UseVisualStyleBackColor = true;
            this.btnTaoPhieuDat.Click += new System.EventHandler(this.btnTaoPhieuDat_Click);
            // 
            // btnSuaPhieuDat
            // 
            this.btnSuaPhieuDat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaPhieuDat.ForeColor = System.Drawing.Color.Black;
            this.btnSuaPhieuDat.Location = new System.Drawing.Point(137, 32);
            this.btnSuaPhieuDat.Name = "btnSuaPhieuDat";
            this.btnSuaPhieuDat.Size = new System.Drawing.Size(148, 46);
            this.btnSuaPhieuDat.TabIndex = 18;
            this.btnSuaPhieuDat.Text = "Sửa Phiếu Đặt";
            this.btnSuaPhieuDat.UseVisualStyleBackColor = true;
            this.btnSuaPhieuDat.Click += new System.EventHandler(this.btnSuaPhieuDat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(453, 92);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(160, 46);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSuaChiTiet);
            this.panel1.Controls.Add(this.dateTimePickerNgayDat);
            this.panel1.Controls.Add(this.lblNgayDat);
            this.panel1.Controls.Add(this.cboTenKhachHang);
            this.panel1.Controls.Add(this.lblTenkhachhang);
            this.panel1.Controls.Add(this.btnXoaPhieuDat);
            this.panel1.Controls.Add(this.btnTaoPhieuDat);
            this.panel1.Controls.Add(this.lblMaphieudat);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnSuaPhieuDat);
            this.panel1.Location = new System.Drawing.Point(24, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 206);
            this.panel1.TabIndex = 27;
            // 
            // btnSuaChiTiet
            // 
            this.btnSuaChiTiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaChiTiet.ForeColor = System.Drawing.Color.Black;
            this.btnSuaChiTiet.Location = new System.Drawing.Point(453, 32);
            this.btnSuaChiTiet.Name = "btnSuaChiTiet";
            this.btnSuaChiTiet.Size = new System.Drawing.Size(160, 46);
            this.btnSuaChiTiet.TabIndex = 45;
            this.btnSuaChiTiet.Text = "Sửa Chi Tiết ";
            this.btnSuaChiTiet.UseVisualStyleBackColor = true;
            this.btnSuaChiTiet.Click += new System.EventHandler(this.btnSuaChiTiet_Click);
            // 
            // dateTimePickerNgayDat
            // 
            this.dateTimePickerNgayDat.CustomFormat = "";
            this.dateTimePickerNgayDat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayDat.Location = new System.Drawing.Point(182, 152);
            this.dateTimePickerNgayDat.Name = "dateTimePickerNgayDat";
            this.dateTimePickerNgayDat.Size = new System.Drawing.Size(224, 28);
            this.dateTimePickerNgayDat.TabIndex = 44;
            // 
            // lblNgayDat
            // 
            this.lblNgayDat.AutoSize = true;
            this.lblNgayDat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDat.Location = new System.Drawing.Point(23, 154);
            this.lblNgayDat.Name = "lblNgayDat";
            this.lblNgayDat.Size = new System.Drawing.Size(74, 20);
            this.lblNgayDat.TabIndex = 43;
            this.lblNgayDat.Text = "Ngày đặt";
            // 
            // cboTenKhachHang
            // 
            this.cboTenKhachHang.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenKhachHang.FormattingEnabled = true;
            this.cboTenKhachHang.Location = new System.Drawing.Point(182, 103);
            this.cboTenKhachHang.Name = "cboTenKhachHang";
            this.cboTenKhachHang.Size = new System.Drawing.Size(224, 28);
            this.cboTenKhachHang.TabIndex = 42;
            // 
            // lblTenkhachhang
            // 
            this.lblTenkhachhang.AutoSize = true;
            this.lblTenkhachhang.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenkhachhang.Location = new System.Drawing.Point(22, 102);
            this.lblTenkhachhang.Name = "lblTenkhachhang";
            this.lblTenkhachhang.Size = new System.Drawing.Size(125, 20);
            this.lblTenkhachhang.TabIndex = 41;
            this.lblTenkhachhang.Text = "Tên khách hàng";
            // 
            // dataGridViewDanhSachChiTietPhieuDat
            // 
            this.dataGridViewDanhSachChiTietPhieuDat.AllowUserToAddRows = false;
            this.dataGridViewDanhSachChiTietPhieuDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachChiTietPhieuDat.Location = new System.Drawing.Point(666, 46);
            this.dataGridViewDanhSachChiTietPhieuDat.Name = "dataGridViewDanhSachChiTietPhieuDat";
            this.dataGridViewDanhSachChiTietPhieuDat.RowHeadersWidth = 51;
            this.dataGridViewDanhSachChiTietPhieuDat.RowTemplate.Height = 24;
            this.dataGridViewDanhSachChiTietPhieuDat.Size = new System.Drawing.Size(704, 445);
            this.dataGridViewDanhSachChiTietPhieuDat.TabIndex = 30;
            // 
            // lblChiTietPhieuDat
            // 
            this.lblChiTietPhieuDat.AutoSize = true;
            this.lblChiTietPhieuDat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietPhieuDat.ForeColor = System.Drawing.Color.Black;
            this.lblChiTietPhieuDat.Location = new System.Drawing.Point(898, 9);
            this.lblChiTietPhieuDat.Name = "lblChiTietPhieuDat";
            this.lblChiTietPhieuDat.Size = new System.Drawing.Size(250, 25);
            this.lblChiTietPhieuDat.TabIndex = 31;
            this.lblChiTietPhieuDat.Text = "CHI TIẾT PHIẾU ĐẶT";
            // 
            // frmQuanLyPhieuDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 503);
            this.Controls.Add(this.lblChiTietPhieuDat);
            this.Controls.Add(this.dataGridViewDanhSachChiTietPhieuDat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewDanhSachPhieuDat);
            this.Name = "frmQuanLyPhieuDat";
            this.Text = "frmQuanLyPhieuDat";
            this.Load += new System.EventHandler(this.frmQuanLyPhieuDat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachPhieuDat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachChiTietPhieuDat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDanhSachPhieuDat;
        private System.Windows.Forms.Label lblMaphieudat;
        private System.Windows.Forms.Button btnXoaPhieuDat;
        private System.Windows.Forms.Button btnTaoPhieuDat;
        private System.Windows.Forms.Button btnSuaPhieuDat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewDanhSachChiTietPhieuDat;
        private System.Windows.Forms.Label lblChiTietPhieuDat;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayDat;
        private System.Windows.Forms.Label lblNgayDat;
        private System.Windows.Forms.ComboBox cboTenKhachHang;
        private System.Windows.Forms.Label lblTenkhachhang;
        private System.Windows.Forms.Button btnSuaChiTiet;
    }
}