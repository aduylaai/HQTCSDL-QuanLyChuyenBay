
using System.Windows.Forms;
using System;

namespace QuanLyChuyenBay_Demo.Forms
{
    public partial class frmTimKiemChuyenBay : Form
    {
        private Button btnTimkiem;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiemChuyenBay));
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.lblTenHangHangKhong = new System.Windows.Forms.Label();
            this.cboHangHangKhong = new System.Windows.Forms.ComboBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboLoTrinh = new System.Windows.Forms.ComboBox();
            this.lblLoTrinh = new System.Windows.Forms.Label();
            this.cboTenMayBay = new System.Windows.Forms.ComboBox();
            this.lblTenMayBay = new System.Windows.Forms.Label();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridViewDanhSachChuyenBay = new System.Windows.Forms.DataGridView();
            this.dTPNgayDi = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachChuyenBay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.White;
            this.btnTimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.Image")));
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.Location = new System.Drawing.Point(946, 281);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(170, 36);
            this.btnTimkiem.TabIndex = 4;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // lblTenHangHangKhong
            // 
            this.lblTenHangHangKhong.AutoSize = true;
            this.lblTenHangHangKhong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHangHangKhong.Location = new System.Drawing.Point(18, 119);
            this.lblTenHangHangKhong.Name = "lblTenHangHangKhong";
            this.lblTenHangHangKhong.Size = new System.Drawing.Size(169, 19);
            this.lblTenHangHangKhong.TabIndex = 5;
            this.lblTenHangHangKhong.Text = "Tên hãng hàng không:";
            // 
            // cboHangHangKhong
            // 
            this.cboHangHangKhong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHangHangKhong.FormattingEnabled = true;
            this.cboHangHangKhong.Location = new System.Drawing.Point(205, 116);
            this.cboHangHangKhong.Name = "cboHangHangKhong";
            this.cboHangHangKhong.Size = new System.Drawing.Size(183, 27);
            this.cboHangHangKhong.TabIndex = 6;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(565, 115);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(187, 27);
            this.cboTrangThai.TabIndex = 8;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(461, 119);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(91, 19);
            this.lblTrangThai.TabIndex = 7;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // cboLoTrinh
            // 
            this.cboLoTrinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoTrinh.FormattingEnabled = true;
            this.cboLoTrinh.Location = new System.Drawing.Point(946, 115);
            this.cboLoTrinh.Name = "cboLoTrinh";
            this.cboLoTrinh.Size = new System.Drawing.Size(182, 27);
            this.cboLoTrinh.TabIndex = 10;
            // 
            // lblLoTrinh
            // 
            this.lblLoTrinh.AutoSize = true;
            this.lblLoTrinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoTrinh.Location = new System.Drawing.Point(834, 119);
            this.lblLoTrinh.Name = "lblLoTrinh";
            this.lblLoTrinh.Size = new System.Drawing.Size(77, 19);
            this.lblLoTrinh.TabIndex = 9;
            this.lblLoTrinh.Text = "Lộ trình:";
            // 
            // cboTenMayBay
            // 
            this.cboTenMayBay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenMayBay.FormattingEnabled = true;
            this.cboTenMayBay.Location = new System.Drawing.Point(205, 211);
            this.cboTenMayBay.Name = "cboTenMayBay";
            this.cboTenMayBay.Size = new System.Drawing.Size(183, 27);
            this.cboTenMayBay.TabIndex = 12;
            // 
            // lblTenMayBay
            // 
            this.lblTenMayBay.AutoSize = true;
            this.lblTenMayBay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMayBay.Location = new System.Drawing.Point(41, 216);
            this.lblTenMayBay.Name = "lblTenMayBay";
            this.lblTenMayBay.Size = new System.Drawing.Size(105, 19);
            this.lblTenMayBay.TabIndex = 11;
            this.lblTenMayBay.Text = "Tên máy bay:";
            // 
            // lblNgayDi
            // 
            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDi.Location = new System.Drawing.Point(461, 213);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(71, 19);
            this.lblNgayDi.TabIndex = 13;
            this.lblNgayDi.Text = "Ngày đi:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(408, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(348, 32);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "TÌM KIẾM CHUYẾN BAY";
            // 
            // dataGridViewDanhSachChuyenBay
            // 
            this.dataGridViewDanhSachChuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachChuyenBay.Location = new System.Drawing.Point(22, 350);
            this.dataGridViewDanhSachChuyenBay.Name = "dataGridViewDanhSachChuyenBay";
            this.dataGridViewDanhSachChuyenBay.RowHeadersWidth = 51;
            this.dataGridViewDanhSachChuyenBay.RowTemplate.Height = 24;
            this.dataGridViewDanhSachChuyenBay.Size = new System.Drawing.Size(1106, 220);
            this.dataGridViewDanhSachChuyenBay.TabIndex = 18;
            // 
            // dTPNgayDi
            // 
            this.dTPNgayDi.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dTPNgayDi.CalendarFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPNgayDi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPNgayDi.Location = new System.Drawing.Point(565, 211);
            this.dTPNgayDi.Name = "dTPNgayDi";
            this.dTPNgayDi.Size = new System.Drawing.Size(260, 27);
            this.dTPNgayDi.TabIndex = 19;
            // 
            // frmTimKiemChuyenBay
            // 
            this.ClientSize = new System.Drawing.Size(1169, 648);
            this.Controls.Add(this.dTPNgayDi);
            this.Controls.Add(this.dataGridViewDanhSachChuyenBay);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblNgayDi);
            this.Controls.Add(this.cboTenMayBay);
            this.Controls.Add(this.lblTenMayBay);
            this.Controls.Add(this.cboLoTrinh);
            this.Controls.Add(this.lblLoTrinh);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.cboHangHangKhong);
            this.Controls.Add(this.lblTenHangHangKhong);
            this.Controls.Add(this.btnTimkiem);
            this.Name = "frmTimKiemChuyenBay";
            this.Text = "Tìm Kiếm Chuyến Bay";
            this.Load += new System.EventHandler(this.frmTimKiemChuyenBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachChuyenBay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private Label lblTenHangHangKhong;
        private ComboBox cboHangHangKhong;
        private ComboBox cboTrangThai;
        private Label lblTrangThai;
        private ComboBox cboLoTrinh;
        private Label lblLoTrinh;
        private ComboBox cboTenMayBay;
        private Label lblTenMayBay;
        private Label lblNgayDi;
        private Label lblTitle;
        private DataGridView dataGridViewDanhSachChuyenBay;
        private DateTimePicker dTPNgayDi;
    }
}