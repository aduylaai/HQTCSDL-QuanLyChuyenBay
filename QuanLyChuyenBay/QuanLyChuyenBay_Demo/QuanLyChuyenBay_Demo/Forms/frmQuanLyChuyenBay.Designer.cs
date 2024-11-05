
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
            this.TenHangHangKhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTrangThaiChuyenBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHangHangKhong = new System.Windows.Forms.Label();
            this.lblTrangThaiChuyenBay = new System.Windows.Forms.Label();
            this.lblSanBayDen = new System.Windows.Forms.Label();
            this.lblSanBayDi = new System.Windows.Forms.Label();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.lblThongTinChuyenBay = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.cboHangHangKhong = new System.Windows.Forms.ComboBox();
            this.cboSanBayDi = new System.Windows.Forms.ComboBox();
            this.cboSanBayDen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChuyenBay)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewChuyenBay
            // 
            this.dataGridViewChuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChuyenBay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenHangHangKhong,
            this.TenTrangThaiChuyenBay,
            this.TenSanBay});
            this.dataGridViewChuyenBay.Location = new System.Drawing.Point(37, 386);
            this.dataGridViewChuyenBay.Name = "dataGridViewChuyenBay";
            this.dataGridViewChuyenBay.RowHeadersWidth = 51;
            this.dataGridViewChuyenBay.RowTemplate.Height = 24;
            this.dataGridViewChuyenBay.Size = new System.Drawing.Size(641, 237);
            this.dataGridViewChuyenBay.TabIndex = 4;
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
            // TenSanBay
            // 
            this.TenSanBay.HeaderText = "Lộ Trình";
            this.TenSanBay.MinimumWidth = 6;
            this.TenSanBay.Name = "TenSanBay";
            this.TenSanBay.Width = 125;
            // 
            // lblHangHangKhong
            // 
            this.lblHangHangKhong.AutoSize = true;
            this.lblHangHangKhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHangHangKhong.Location = new System.Drawing.Point(33, 167);
            this.lblHangHangKhong.Name = "lblHangHangKhong";
            this.lblHangHangKhong.Size = new System.Drawing.Size(164, 23);
            this.lblHangHangKhong.TabIndex = 5;
            this.lblHangHangKhong.Text = "Hãng Hàng Không";
            // 
            // lblTrangThaiChuyenBay
            // 
            this.lblTrangThaiChuyenBay.AutoSize = true;
            this.lblTrangThaiChuyenBay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThaiChuyenBay.Location = new System.Drawing.Point(33, 213);
            this.lblTrangThaiChuyenBay.Name = "lblTrangThaiChuyenBay";
            this.lblTrangThaiChuyenBay.Size = new System.Drawing.Size(103, 23);
            this.lblTrangThaiChuyenBay.TabIndex = 6;
            this.lblTrangThaiChuyenBay.Text = "Trạng Thái";
            // 
            // lblSanBayDen
            // 
            this.lblSanBayDen.AutoSize = true;
            this.lblSanBayDen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanBayDen.Location = new System.Drawing.Point(33, 309);
            this.lblSanBayDen.Name = "lblSanBayDen";
            this.lblSanBayDen.Size = new System.Drawing.Size(118, 23);
            this.lblSanBayDen.TabIndex = 7;
            this.lblSanBayDen.Text = "Sân Bay Đến";
            // 
            // lblSanBayDi
            // 
            this.lblSanBayDi.AutoSize = true;
            this.lblSanBayDi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanBayDi.Location = new System.Drawing.Point(33, 261);
            this.lblSanBayDi.Name = "lblSanBayDi";
            this.lblSanBayDi.Size = new System.Drawing.Size(103, 23);
            this.lblSanBayDi.TabIndex = 8;
            this.lblSanBayDi.Text = "Sân Bay Đi";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangThai.Location = new System.Drawing.Point(238, 208);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(150, 30);
            this.txtTrangThai.TabIndex = 12;
            // 
            // lblThongTinChuyenBay
            // 
            this.lblThongTinChuyenBay.AutoSize = true;
            this.lblThongTinChuyenBay.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinChuyenBay.ForeColor = System.Drawing.Color.Red;
            this.lblThongTinChuyenBay.Location = new System.Drawing.Point(40, 84);
            this.lblThongTinChuyenBay.Name = "lblThongTinChuyenBay";
            this.lblThongTinChuyenBay.Size = new System.Drawing.Size(432, 37);
            this.lblThongTinChuyenBay.TabIndex = 13;
            this.lblThongTinChuyenBay.Text = "THÔNG TIN CHUYẾN BAY";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Blue;
            this.btnThem.Location = new System.Drawing.Point(556, 103);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(122, 56);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Blue;
            this.btnXoa.Location = new System.Drawing.Point(728, 107);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(122, 56);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Blue;
            this.btnSua.Location = new System.Drawing.Point(903, 107);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(122, 56);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLammoi
            // 
            this.btnLammoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.ForeColor = System.Drawing.Color.Blue;
            this.btnLammoi.Location = new System.Drawing.Point(1078, 107);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(122, 56);
            this.btnLammoi.TabIndex = 17;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            // 
            // cboHangHangKhong
            // 
            this.cboHangHangKhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHangHangKhong.FormattingEnabled = true;
            this.cboHangHangKhong.Location = new System.Drawing.Point(238, 160);
            this.cboHangHangKhong.Name = "cboHangHangKhong";
            this.cboHangHangKhong.Size = new System.Drawing.Size(150, 30);
            this.cboHangHangKhong.TabIndex = 18;
            // 
            // cboSanBayDi
            // 
            this.cboSanBayDi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSanBayDi.FormattingEnabled = true;
            this.cboSanBayDi.Location = new System.Drawing.Point(238, 261);
            this.cboSanBayDi.Name = "cboSanBayDi";
            this.cboSanBayDi.Size = new System.Drawing.Size(150, 30);
            this.cboSanBayDi.TabIndex = 19;
            // 
            // cboSanBayDen
            // 
            this.cboSanBayDen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSanBayDen.FormattingEnabled = true;
            this.cboSanBayDen.Location = new System.Drawing.Point(238, 309);
            this.cboSanBayDen.Name = "cboSanBayDen";
            this.cboSanBayDen.Size = new System.Drawing.Size(150, 30);
            this.cboSanBayDen.TabIndex = 20;
            // 
            // frmQuanLyChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 648);
            this.Controls.Add(this.cboSanBayDen);
            this.Controls.Add(this.cboSanBayDi);
            this.Controls.Add(this.cboHangHangKhong);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblThongTinChuyenBay);
            this.Controls.Add(this.txtTrangThai);
            this.Controls.Add(this.lblSanBayDi);
            this.Controls.Add(this.lblSanBayDen);
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
        private System.Windows.Forms.Label lblSanBayDen;
        private System.Windows.Forms.Label lblSanBayDi;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label lblThongTinChuyenBay;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.ComboBox cboHangHangKhong;
        private System.Windows.Forms.ComboBox cboSanBayDi;
        private System.Windows.Forms.ComboBox cboSanBayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHangHangKhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTrangThaiChuyenBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanBay;
    }
}