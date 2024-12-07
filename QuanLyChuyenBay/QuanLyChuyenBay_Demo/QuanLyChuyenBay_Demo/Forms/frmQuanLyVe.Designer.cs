
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyVe));
            this.dataGridViewDanhSachVe = new System.Windows.Forms.DataGridView();
            this.lblMaChuyenBay = new System.Windows.Forms.Label();
            this.lblTrangthaive = new System.Windows.Forms.Label();
            this.lblTenkhachhang = new System.Windows.Forms.Label();
            this.cboMaChuyenBay = new System.Windows.Forms.ComboBox();
            this.cboTrangthaive = new System.Windows.Forms.ComboBox();
            this.dataGridViewChiTietVe = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cboTenHanhKhach = new System.Windows.Forms.ComboBox();
            this.lblMaHangGhe = new System.Windows.Forms.Label();
            this.cboMaHangGhe = new System.Windows.Forms.ComboBox();
            this.panelThongTin = new System.Windows.Forms.Panel();
            this.lblMaVeoutput = new System.Windows.Forms.Label();
            this.lblMaVett = new System.Windows.Forms.Label();
            this.lblMaVe = new System.Windows.Forms.Label();
            this.panelNut = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachVe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietVe)).BeginInit();
            this.panelThongTin.SuspendLayout();
            this.panelNut.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDanhSachVe
            // 
            this.dataGridViewDanhSachVe.AllowUserToAddRows = false;
            this.dataGridViewDanhSachVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachVe.Location = new System.Drawing.Point(35, 256);
            this.dataGridViewDanhSachVe.Name = "dataGridViewDanhSachVe";
            this.dataGridViewDanhSachVe.RowHeadersWidth = 51;
            this.dataGridViewDanhSachVe.RowTemplate.Height = 24;
            this.dataGridViewDanhSachVe.Size = new System.Drawing.Size(505, 235);
            this.dataGridViewDanhSachVe.TabIndex = 0;
            this.dataGridViewDanhSachVe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhSachVe_CellDoubleClick);
            // 
            // lblMaChuyenBay
            // 
            this.lblMaChuyenBay.AutoSize = true;
            this.lblMaChuyenBay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaChuyenBay.Location = new System.Drawing.Point(15, 147);
            this.lblMaChuyenBay.Name = "lblMaChuyenBay";
            this.lblMaChuyenBay.Size = new System.Drawing.Size(110, 19);
            this.lblMaChuyenBay.TabIndex = 1;
            this.lblMaChuyenBay.Text = "Mã chuyến bay";
            this.lblMaChuyenBay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTrangthaive
            // 
            this.lblTrangthaive.AutoSize = true;
            this.lblTrangthaive.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangthaive.Location = new System.Drawing.Point(11, 84);
            this.lblTrangthaive.Name = "lblTrangthaive";
            this.lblTrangthaive.Size = new System.Drawing.Size(98, 19);
            this.lblTrangthaive.TabIndex = 2;
            this.lblTrangthaive.Text = "Trạng  thái vé";
            // 
            // lblTenkhachhang
            // 
            this.lblTenkhachhang.AutoSize = true;
            this.lblTenkhachhang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenkhachhang.Location = new System.Drawing.Point(11, 35);
            this.lblTenkhachhang.Name = "lblTenkhachhang";
            this.lblTenkhachhang.Size = new System.Drawing.Size(112, 19);
            this.lblTenkhachhang.TabIndex = 3;
            this.lblTenkhachhang.Text = "Tên hành khách";
            // 
            // cboMaChuyenBay
            // 
            this.cboMaChuyenBay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaChuyenBay.FormattingEnabled = true;
            this.cboMaChuyenBay.Location = new System.Drawing.Point(151, 147);
            this.cboMaChuyenBay.Name = "cboMaChuyenBay";
            this.cboMaChuyenBay.Size = new System.Drawing.Size(160, 27);
            this.cboMaChuyenBay.TabIndex = 4;
            // 
            // cboTrangthaive
            // 
            this.cboTrangthaive.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangthaive.FormattingEnabled = true;
            this.cboTrangthaive.Location = new System.Drawing.Point(151, 84);
            this.cboTrangthaive.Name = "cboTrangthaive";
            this.cboTrangthaive.Size = new System.Drawing.Size(160, 27);
            this.cboTrangthaive.TabIndex = 5;
            // 
            // dataGridViewChiTietVe
            // 
            this.dataGridViewChiTietVe.AllowUserToAddRows = false;
            this.dataGridViewChiTietVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTietVe.Location = new System.Drawing.Point(560, 256);
            this.dataGridViewChiTietVe.Name = "dataGridViewChiTietVe";
            this.dataGridViewChiTietVe.RowHeadersWidth = 51;
            this.dataGridViewChiTietVe.RowTemplate.Height = 24;
            this.dataGridViewChiTietVe.Size = new System.Drawing.Size(626, 235);
            this.dataGridViewChiTietVe.TabIndex = 7;
            this.dataGridViewChiTietVe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChiTietVe_CellDoubleClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.DarkRed;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(230, 118);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(123, 46);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(294, 34);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(123, 46);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa vé";
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
            this.btnLammoi.Location = new System.Drawing.Point(79, 118);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(123, 46);
            this.btnLammoi.TabIndex = 22;
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
            this.btnThem.Location = new System.Drawing.Point(15, 34);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(123, 46);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Tạo vé";
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
            this.btnXoa.Location = new System.Drawing.Point(148, 34);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(123, 46);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa vé";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cboTenHanhKhach
            // 
            this.cboTenHanhKhach.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenHanhKhach.FormattingEnabled = true;
            this.cboTenHanhKhach.Location = new System.Drawing.Point(151, 32);
            this.cboTenHanhKhach.Name = "cboTenHanhKhach";
            this.cboTenHanhKhach.Size = new System.Drawing.Size(160, 27);
            this.cboTenHanhKhach.TabIndex = 25;
            // 
            // lblMaHangGhe
            // 
            this.lblMaHangGhe.AutoSize = true;
            this.lblMaHangGhe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHangGhe.Location = new System.Drawing.Point(345, 150);
            this.lblMaHangGhe.Name = "lblMaHangGhe";
            this.lblMaHangGhe.Size = new System.Drawing.Size(72, 19);
            this.lblMaHangGhe.TabIndex = 30;
            this.lblMaHangGhe.Text = "Hàng ghế";
            // 
            // cboMaHangGhe
            // 
            this.cboMaHangGhe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaHangGhe.FormattingEnabled = true;
            this.cboMaHangGhe.Location = new System.Drawing.Point(425, 147);
            this.cboMaHangGhe.Name = "cboMaHangGhe";
            this.cboMaHangGhe.Size = new System.Drawing.Size(200, 27);
            this.cboMaHangGhe.TabIndex = 31;
            // 
            // panelThongTin
            // 
            this.panelThongTin.Controls.Add(this.lblMaVeoutput);
            this.panelThongTin.Controls.Add(this.lblMaVett);
            this.panelThongTin.Controls.Add(this.lblMaVe);
            this.panelThongTin.Controls.Add(this.cboMaChuyenBay);
            this.panelThongTin.Controls.Add(this.cboMaHangGhe);
            this.panelThongTin.Controls.Add(this.lblMaHangGhe);
            this.panelThongTin.Controls.Add(this.lblMaChuyenBay);
            this.panelThongTin.Controls.Add(this.lblTrangthaive);
            this.panelThongTin.Controls.Add(this.lblTenkhachhang);
            this.panelThongTin.Controls.Add(this.cboTrangthaive);
            this.panelThongTin.Controls.Add(this.cboTenHanhKhach);
            this.panelThongTin.Location = new System.Drawing.Point(5, 7);
            this.panelThongTin.Name = "panelThongTin";
            this.panelThongTin.Size = new System.Drawing.Size(663, 232);
            this.panelThongTin.TabIndex = 32;
            // 
            // lblMaVeoutput
            // 
            this.lblMaVeoutput.AutoSize = true;
            this.lblMaVeoutput.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaVeoutput.Location = new System.Drawing.Point(305, 10);
            this.lblMaVeoutput.Name = "lblMaVeoutput";
            this.lblMaVeoutput.Size = new System.Drawing.Size(60, 19);
            this.lblMaVeoutput.TabIndex = 36;
            this.lblMaVeoutput.Text = "[Mã vé]";
            // 
            // lblMaVett
            // 
            this.lblMaVett.AutoSize = true;
            this.lblMaVett.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaVett.Location = new System.Drawing.Point(160, 10);
            this.lblMaVett.Name = "lblMaVett";
            this.lblMaVett.Size = new System.Drawing.Size(50, 19);
            this.lblMaVett.TabIndex = 35;
            this.lblMaVett.Text = "Mã vé";
            // 
            // lblMaVe
            // 
            this.lblMaVe.AutoSize = true;
            this.lblMaVe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaVe.Location = new System.Drawing.Point(15, 0);
            this.lblMaVe.Name = "lblMaVe";
            this.lblMaVe.Size = new System.Drawing.Size(72, 25);
            this.lblMaVe.TabIndex = 34;
            this.lblMaVe.Text = "MaVe";
            // 
            // panelNut
            // 
            this.panelNut.Controls.Add(this.btnThem);
            this.panelNut.Controls.Add(this.btnXoa);
            this.panelNut.Controls.Add(this.btnThoat);
            this.panelNut.Controls.Add(this.btnSua);
            this.panelNut.Controls.Add(this.btnLammoi);
            this.panelNut.Location = new System.Drawing.Point(727, 17);
            this.panelNut.Name = "panelNut";
            this.panelNut.Size = new System.Drawing.Size(459, 222);
            this.panelNut.TabIndex = 33;
            // 
            // frmQuanLyVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 503);
            this.Controls.Add(this.panelNut);
            this.Controls.Add(this.panelThongTin);
            this.Controls.Add(this.dataGridViewChiTietVe);
            this.Controls.Add(this.dataGridViewDanhSachVe);
            this.Name = "frmQuanLyVe";
            this.Text = "frmQuanLyVe";
            this.Load += new System.EventHandler(this.frmQuanLyVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachVe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietVe)).EndInit();
            this.panelThongTin.ResumeLayout(false);
            this.panelThongTin.PerformLayout();
            this.panelNut.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDanhSachVe;
        private System.Windows.Forms.Label lblMaChuyenBay;
        private System.Windows.Forms.Label lblTrangthaive;
        private System.Windows.Forms.Label lblTenkhachhang;
        private System.Windows.Forms.ComboBox cboMaChuyenBay;
        private System.Windows.Forms.ComboBox cboTrangthaive;
        private System.Windows.Forms.DataGridView dataGridViewChiTietVe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cboTenHanhKhach;
        private System.Windows.Forms.Label lblMaHangGhe;
        private System.Windows.Forms.ComboBox cboMaHangGhe;
        private System.Windows.Forms.Panel panelThongTin;
        private System.Windows.Forms.Label lblMaVe;
        private System.Windows.Forms.Panel panelNut;
        private System.Windows.Forms.Label lblMaVeoutput;
        private System.Windows.Forms.Label lblMaVett;
    }
}