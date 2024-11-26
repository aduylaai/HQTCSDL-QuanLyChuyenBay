
namespace QuanLyChuyenBay_Demo.Forms
{
    partial class frmQuanLyHanhKhach
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
            this.dataGridViewDanhSachHangKhach = new System.Windows.Forms.DataGridView();
            this.MaHanhKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuocTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD_Passport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblMahanhkhach = new System.Windows.Forms.Label();
            this.lblGioitinh = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblQuoctich = new System.Windows.Forms.Label();
            this.lblSodienthoai = new System.Windows.Forms.Label();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.lblCccd = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblHoten = new System.Windows.Forms.Label();
            this.lblMakhachhang = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtQuoctich = new System.Windows.Forms.TextBox();
            this.txtCCCD_Passport = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSodienthoai = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.cboMahanhkhach = new System.Windows.Forms.ComboBox();
            this.cboMakhachhang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachHangKhach)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDanhSachHangKhach
            // 
            this.dataGridViewDanhSachHangKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachHangKhach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHanhKhach,
            this.HoTen,
            this.DiaChi,
            this.GioiTinh,
            this.QuocTich,
            this.NgaySinh,
            this.SoDienThoai,
            this.Email,
            this.CCCD_Passport,
            this.MaKhachHang});
            this.dataGridViewDanhSachHangKhach.Location = new System.Drawing.Point(32, 278);
            this.dataGridViewDanhSachHangKhach.Name = "dataGridViewDanhSachHangKhach";
            this.dataGridViewDanhSachHangKhach.RowHeadersWidth = 51;
            this.dataGridViewDanhSachHangKhach.RowTemplate.Height = 24;
            this.dataGridViewDanhSachHangKhach.Size = new System.Drawing.Size(1152, 213);
            this.dataGridViewDanhSachHangKhach.TabIndex = 0;
            // 
            // MaHanhKhach
            // 
            this.MaHanhKhach.HeaderText = "Mã hành khách";
            this.MaHanhKhach.MinimumWidth = 6;
            this.MaHanhKhach.Name = "MaHanhKhach";
            this.MaHanhKhach.Width = 50;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Dia chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 125;
            // 
            // QuocTich
            // 
            this.QuocTich.HeaderText = "Quốc tịch";
            this.QuocTich.MinimumWidth = 6;
            this.QuocTich.Name = "QuocTich";
            this.QuocTich.Width = 125;
            // 
            // NgaySinh
            // 
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 125;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.HeaderText = "Số điện thoại";
            this.SoDienThoai.MinimumWidth = 6;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // CCCD_Passport
            // 
            this.CCCD_Passport.HeaderText = "CCCD_Passport";
            this.CCCD_Passport.MinimumWidth = 6;
            this.CCCD_Passport.Name = "CCCD_Passport";
            this.CCCD_Passport.Width = 125;
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.HeaderText = "Mã khách hàng";
            this.MaKhachHang.MinimumWidth = 6;
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.Width = 50;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.DarkRed;
            this.btnThoat.Location = new System.Drawing.Point(999, 110);
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
            this.btnSua.Location = new System.Drawing.Point(831, 195);
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
            this.btnLammoi.Location = new System.Drawing.Point(999, 24);
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
            this.btnThem.Location = new System.Drawing.Point(831, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 46);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.DarkRed;
            this.btnXoa.Location = new System.Drawing.Point(831, 110);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 46);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // lblMahanhkhach
            // 
            this.lblMahanhkhach.AutoSize = true;
            this.lblMahanhkhach.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMahanhkhach.Location = new System.Drawing.Point(28, 24);
            this.lblMahanhkhach.Name = "lblMahanhkhach";
            this.lblMahanhkhach.Size = new System.Drawing.Size(109, 19);
            this.lblMahanhkhach.TabIndex = 25;
            this.lblMahanhkhach.Text = "Mã hành khách";
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioitinh.Location = new System.Drawing.Point(28, 175);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(70, 19);
            this.lblGioitinh.TabIndex = 26;
            this.lblGioitinh.Text = "Giới tính";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiachi.Location = new System.Drawing.Point(28, 127);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(58, 19);
            this.lblDiachi.TabIndex = 27;
            this.lblDiachi.Text = "Địa chỉ";
            // 
            // lblQuoctich
            // 
            this.lblQuoctich.AutoSize = true;
            this.lblQuoctich.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuoctich.Location = new System.Drawing.Point(28, 222);
            this.lblQuoctich.Name = "lblQuoctich";
            this.lblQuoctich.Size = new System.Drawing.Size(76, 19);
            this.lblQuoctich.TabIndex = 28;
            this.lblQuoctich.Text = "Quốc tịch";
            // 
            // lblSodienthoai
            // 
            this.lblSodienthoai.AutoSize = true;
            this.lblSodienthoai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSodienthoai.Location = new System.Drawing.Point(404, 22);
            this.lblSodienthoai.Name = "lblSodienthoai";
            this.lblSodienthoai.Size = new System.Drawing.Size(99, 19);
            this.lblSodienthoai.TabIndex = 29;
            this.lblSodienthoai.Text = "Số điện thoại";
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaysinh.Location = new System.Drawing.Point(408, 176);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(76, 19);
            this.lblNgaysinh.TabIndex = 30;
            this.lblNgaysinh.Text = "Ngày sinh";
            // 
            // lblCccd
            // 
            this.lblCccd.AutoSize = true;
            this.lblCccd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCccd.Location = new System.Drawing.Point(404, 125);
            this.lblCccd.Name = "lblCccd";
            this.lblCccd.Size = new System.Drawing.Size(122, 19);
            this.lblCccd.TabIndex = 31;
            this.lblCccd.Text = "CCCD_Passport";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(404, 68);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 19);
            this.lblEmail.TabIndex = 32;
            this.lblEmail.Text = "Email";
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoten.Location = new System.Drawing.Point(28, 70);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(55, 19);
            this.lblHoten.TabIndex = 33;
            this.lblHoten.Text = "Họ tên";
            // 
            // lblMakhachhang
            // 
            this.lblMakhachhang.AutoSize = true;
            this.lblMakhachhang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakhachhang.Location = new System.Drawing.Point(404, 234);
            this.lblMakhachhang.Name = "lblMakhachhang";
            this.lblMakhachhang.Size = new System.Drawing.Size(109, 19);
            this.lblMakhachhang.TabIndex = 34;
            this.lblMakhachhang.Text = "Mã khách hàng";
            // 
            // txtHoten
            // 
            this.txtHoten.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoten.Location = new System.Drawing.Point(155, 70);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(175, 27);
            this.txtHoten.TabIndex = 35;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.Location = new System.Drawing.Point(155, 126);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(175, 27);
            this.txtDiachi.TabIndex = 36;
            // 
            // txtQuoctich
            // 
            this.txtQuoctich.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuoctich.Location = new System.Drawing.Point(155, 222);
            this.txtQuoctich.Name = "txtQuoctich";
            this.txtQuoctich.Size = new System.Drawing.Size(175, 27);
            this.txtQuoctich.TabIndex = 37;
            // 
            // txtCCCD_Passport
            // 
            this.txtCCCD_Passport.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD_Passport.Location = new System.Drawing.Point(571, 125);
            this.txtCCCD_Passport.Name = "txtCCCD_Passport";
            this.txtCCCD_Passport.Size = new System.Drawing.Size(161, 27);
            this.txtCCCD_Passport.TabIndex = 38;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(571, 67);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(161, 27);
            this.txtEmail.TabIndex = 39;
            // 
            // txtSodienthoai
            // 
            this.txtSodienthoai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSodienthoai.Location = new System.Drawing.Point(571, 19);
            this.txtSodienthoai.Name = "txtSodienthoai";
            this.txtSodienthoai.Size = new System.Drawing.Size(161, 27);
            this.txtSodienthoai.TabIndex = 40;
            // 
            // dateTimePickerNgaysinh
            // 
            this.dateTimePickerNgaysinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgaysinh.Location = new System.Drawing.Point(535, 176);
            this.dateTimePickerNgaysinh.Name = "dateTimePickerNgaysinh";
            this.dateTimePickerNgaysinh.Size = new System.Drawing.Size(175, 27);
            this.dateTimePickerNgaysinh.TabIndex = 41;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNam.Location = new System.Drawing.Point(155, 175);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(62, 23);
            this.radNam.TabIndex = 42;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNu.Location = new System.Drawing.Point(251, 176);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(51, 23);
            this.radNu.TabIndex = 43;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // cboMahanhkhach
            // 
            this.cboMahanhkhach.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMahanhkhach.FormattingEnabled = true;
            this.cboMahanhkhach.Location = new System.Drawing.Point(155, 20);
            this.cboMahanhkhach.Name = "cboMahanhkhach";
            this.cboMahanhkhach.Size = new System.Drawing.Size(175, 27);
            this.cboMahanhkhach.TabIndex = 44;
            // 
            // cboMakhachhang
            // 
            this.cboMakhachhang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMakhachhang.FormattingEnabled = true;
            this.cboMakhachhang.Location = new System.Drawing.Point(571, 235);
            this.cboMakhachhang.Name = "cboMakhachhang";
            this.cboMakhachhang.Size = new System.Drawing.Size(161, 27);
            this.cboMakhachhang.TabIndex = 45;
            // 
            // frmQuanLyHanhKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 503);
            this.Controls.Add(this.cboMakhachhang);
            this.Controls.Add(this.cboMahanhkhach);
            this.Controls.Add(this.radNu);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.dateTimePickerNgaysinh);
            this.Controls.Add(this.txtSodienthoai);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCCCD_Passport);
            this.Controls.Add(this.txtQuoctich);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.lblMakhachhang);
            this.Controls.Add(this.lblHoten);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCccd);
            this.Controls.Add(this.lblNgaysinh);
            this.Controls.Add(this.lblSodienthoai);
            this.Controls.Add(this.lblQuoctich);
            this.Controls.Add(this.lblDiachi);
            this.Controls.Add(this.lblGioitinh);
            this.Controls.Add(this.lblMahanhkhach);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dataGridViewDanhSachHangKhach);
            this.Name = "frmQuanLyHanhKhach";
            this.Text = "frmQuanLyHanhKhach";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachHangKhach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDanhSachHangKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHanhKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuocTich;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD_Passport;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblMahanhkhach;
        private System.Windows.Forms.Label lblGioitinh;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblQuoctich;
        private System.Windows.Forms.Label lblSodienthoai;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.Label lblCccd;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.Label lblMakhachhang;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtQuoctich;
        private System.Windows.Forms.TextBox txtCCCD_Passport;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSodienthoai;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaysinh;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.ComboBox cboMahanhkhach;
        private System.Windows.Forms.ComboBox cboMakhachhang;
    }
}