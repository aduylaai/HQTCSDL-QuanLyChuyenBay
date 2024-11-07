
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
            this.dataGridViewChuyenBay = new System.Windows.Forms.DataGridView();
            this.lblHangHangKhong = new System.Windows.Forms.Label();
            this.lblTrangThaiChuyenBay = new System.Windows.Forms.Label();
            this.lblTenmaybay = new System.Windows.Forms.Label();
            this.lblMalotrinh = new System.Windows.Forms.Label();
            this.lblThongTinChuyenBay = new System.Windows.Forms.Label();
            this.cboHangHangKhong = new System.Windows.Forms.ComboBox();
            this.cboSanBayDi = new System.Windows.Forms.ComboBox();
            this.cboTenmaybay = new System.Windows.Forms.ComboBox();
            this.MaChuyenBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHangHangKhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTrangThaiChuyenBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMayBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cboMachuyenbay = new System.Windows.Forms.ComboBox();
            this.lblMachuyenbay = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblGiabay = new System.Windows.Forms.Label();
            this.txtGiabay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChuyenBay)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewChuyenBay
            // 
            this.dataGridViewChuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChuyenBay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChuyenBay,
            this.TenHangHangKhong,
            this.TenTrangThaiChuyenBay,
            this.MaLoTrinh,
            this.TenMayBay,
            this.GiaBay});
            this.dataGridViewChuyenBay.Location = new System.Drawing.Point(12, 308);
            this.dataGridViewChuyenBay.Name = "dataGridViewChuyenBay";
            this.dataGridViewChuyenBay.RowHeadersWidth = 51;
            this.dataGridViewChuyenBay.RowTemplate.Height = 24;
            this.dataGridViewChuyenBay.Size = new System.Drawing.Size(801, 237);
            this.dataGridViewChuyenBay.TabIndex = 4;
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
            // lblMalotrinh
            // 
            this.lblMalotrinh.AutoSize = true;
            this.lblMalotrinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMalotrinh.Location = new System.Drawing.Point(33, 179);
            this.lblMalotrinh.Name = "lblMalotrinh";
            this.lblMalotrinh.Size = new System.Drawing.Size(94, 19);
            this.lblMalotrinh.TabIndex = 8;
            this.lblMalotrinh.Text = "Mã lộ trình";
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
            this.cboHangHangKhong.Location = new System.Drawing.Point(237, 93);
            this.cboHangHangKhong.Name = "cboHangHangKhong";
            this.cboHangHangKhong.Size = new System.Drawing.Size(205, 27);
            this.cboHangHangKhong.TabIndex = 18;
            // 
            // cboSanBayDi
            // 
            this.cboSanBayDi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSanBayDi.FormattingEnabled = true;
            this.cboSanBayDi.Location = new System.Drawing.Point(237, 179);
            this.cboSanBayDi.Name = "cboSanBayDi";
            this.cboSanBayDi.Size = new System.Drawing.Size(205, 27);
            this.cboSanBayDi.TabIndex = 19;
            // 
            // cboTenmaybay
            // 
            this.cboTenmaybay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenmaybay.FormattingEnabled = true;
            this.cboTenmaybay.Location = new System.Drawing.Point(237, 225);
            this.cboTenmaybay.Name = "cboTenmaybay";
            this.cboTenmaybay.Size = new System.Drawing.Size(205, 27);
            this.cboTenmaybay.TabIndex = 20;
            // 
            // MaChuyenBay
            // 
            this.MaChuyenBay.HeaderText = "Mã chuyến bay";
            this.MaChuyenBay.MinimumWidth = 6;
            this.MaChuyenBay.Name = "MaChuyenBay";
            this.MaChuyenBay.Width = 125;
            // 
            // TenHangHangKhong
            // 
            this.TenHangHangKhong.HeaderText = "Hãng Hàng Không";
            this.TenHangHangKhong.MinimumWidth = 6;
            this.TenHangHangKhong.Name = "TenHangHangKhong";
            this.TenHangHangKhong.Width = 125;
            // 
            // TenTrangThaiChuyenBay
            // 
            this.TenTrangThaiChuyenBay.HeaderText = "Trạng Thái";
            this.TenTrangThaiChuyenBay.MinimumWidth = 6;
            this.TenTrangThaiChuyenBay.Name = "TenTrangThaiChuyenBay";
            this.TenTrangThaiChuyenBay.Width = 125;
            // 
            // MaLoTrinh
            // 
            this.MaLoTrinh.HeaderText = "Mã lộ trình";
            this.MaLoTrinh.MinimumWidth = 6;
            this.MaLoTrinh.Name = "MaLoTrinh";
            this.MaLoTrinh.Width = 125;
            // 
            // TenMayBay
            // 
            this.TenMayBay.HeaderText = "Tên máy bay";
            this.TenMayBay.MinimumWidth = 6;
            this.TenMayBay.Name = "TenMayBay";
            this.TenMayBay.Width = 125;
            // 
            // GiaBay
            // 
            this.GiaBay.HeaderText = "Giá bay";
            this.GiaBay.MinimumWidth = 6;
            this.GiaBay.Name = "GiaBay";
            this.GiaBay.Width = 125;
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
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(781, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 46);
            this.button1.TabIndex = 24;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.Location = new System.Drawing.Point(922, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 46);
            this.button2.TabIndex = 23;
            this.button2.Text = "Làm mới";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkRed;
            this.button3.Location = new System.Drawing.Point(501, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 46);
            this.button3.TabIndex = 22;
            this.button3.Text = "Thêm";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkRed;
            this.button4.Location = new System.Drawing.Point(643, 62);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 46);
            this.button4.TabIndex = 21;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // cboMachuyenbay
            // 
            this.cboMachuyenbay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMachuyenbay.FormattingEnabled = true;
            this.cboMachuyenbay.Location = new System.Drawing.Point(237, 49);
            this.cboMachuyenbay.Name = "cboMachuyenbay";
            this.cboMachuyenbay.Size = new System.Drawing.Size(205, 27);
            this.cboMachuyenbay.TabIndex = 27;
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
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(237, 134);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(205, 27);
            this.comboBox2.TabIndex = 28;
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
            this.txtGiabay.Location = new System.Drawing.Point(237, 272);
            this.txtGiabay.Name = "txtGiabay";
            this.txtGiabay.Size = new System.Drawing.Size(205, 27);
            this.txtGiabay.TabIndex = 30;
            // 
            // frmQuanLyChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 648);
            this.Controls.Add(this.txtGiabay);
            this.Controls.Add(this.lblGiabay);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cboMachuyenbay);
            this.Controls.Add(this.lblMachuyenbay);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cboTenmaybay);
            this.Controls.Add(this.cboSanBayDi);
            this.Controls.Add(this.cboHangHangKhong);
            this.Controls.Add(this.lblThongTinChuyenBay);
            this.Controls.Add(this.lblMalotrinh);
            this.Controls.Add(this.lblTenmaybay);
            this.Controls.Add(this.lblTrangThaiChuyenBay);
            this.Controls.Add(this.lblHangHangKhong);
            this.Controls.Add(this.dataGridViewChuyenBay);
            this.Name = "frmQuanLyChuyenBay";
            this.Text = "frmQuanLyChuyenBay";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChuyenBay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewChuyenBay;
        private System.Windows.Forms.Label lblHangHangKhong;
        private System.Windows.Forms.Label lblTrangThaiChuyenBay;
        private System.Windows.Forms.Label lblTenmaybay;
        private System.Windows.Forms.Label lblMalotrinh;
        private System.Windows.Forms.Label lblThongTinChuyenBay;
        private System.Windows.Forms.ComboBox cboHangHangKhong;
        private System.Windows.Forms.ComboBox cboSanBayDi;
        private System.Windows.Forms.ComboBox cboTenmaybay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChuyenBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHangHangKhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTrangThaiChuyenBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMayBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBay;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cboMachuyenbay;
        private System.Windows.Forms.Label lblMachuyenbay;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblGiabay;
        private System.Windows.Forms.TextBox txtGiabay;
    }
}