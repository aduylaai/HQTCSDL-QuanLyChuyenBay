using System;
using System.Windows.Forms;

namespace QuanLyChuyenBay_Demo.Forms
{
    public partial class frmQuanLyHoaDon : Form
    {
        private DataGridView dataGridViewDanhSachHoaDon;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private TextBox txtMaPhieuDat;

        public frmQuanLyHoaDon()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDanhSachHoaDon = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMaPhieuDat = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.lblMaPhieuDat = new System.Windows.Forms.Label();
            this.lblMaHoaDonIP = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTongTienIP = new System.Windows.Forms.Label();
            this.btnTinhTongTien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDanhSachHoaDon
            // 
            this.dataGridViewDanhSachHoaDon.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDanhSachHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDanhSachHoaDon.ColumnHeadersHeight = 32;
            this.dataGridViewDanhSachHoaDon.Location = new System.Drawing.Point(101, 60);
            this.dataGridViewDanhSachHoaDon.Name = "dataGridViewDanhSachHoaDon";
            this.dataGridViewDanhSachHoaDon.RowHeadersWidth = 51;
            this.dataGridViewDanhSachHoaDon.Size = new System.Drawing.Size(576, 417);
            this.dataGridViewDanhSachHoaDon.TabIndex = 1;
            this.dataGridViewDanhSachHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhSachHoaDon_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(746, 128);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(129, 54);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm hóa đơn";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(746, 197);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(129, 54);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa hóa đơn";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(746, 268);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(129, 54);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa hóa đơn";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMaPhieuDat
            // 
            this.txtMaPhieuDat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuDat.Location = new System.Drawing.Point(438, 15);
            this.txtMaPhieuDat.Name = "txtMaPhieuDat";
            this.txtMaPhieuDat.Size = new System.Drawing.Size(197, 30);
            this.txtMaPhieuDat.TabIndex = 8;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(746, 406);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(129, 54);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(746, 337);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(129, 54);
            this.btnLamMoi.TabIndex = 10;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHoaDon.Location = new System.Drawing.Point(16, 18);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(120, 30);
            this.lblMaHoaDon.TabIndex = 11;
            this.lblMaHoaDon.Text = "Mã hóa đơn:";
            // 
            // lblMaPhieuDat
            // 
            this.lblMaPhieuDat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieuDat.Location = new System.Drawing.Point(300, 18);
            this.lblMaPhieuDat.Name = "lblMaPhieuDat";
            this.lblMaPhieuDat.Size = new System.Drawing.Size(132, 33);
            this.lblMaPhieuDat.TabIndex = 12;
            this.lblMaPhieuDat.Text = "Mã phiếu đặt:";
            // 
            // lblMaHoaDonIP
            // 
            this.lblMaHoaDonIP.AutoSize = true;
            this.lblMaHoaDonIP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHoaDonIP.Location = new System.Drawing.Point(142, 18);
            this.lblMaHoaDonIP.Name = "lblMaHoaDonIP";
            this.lblMaHoaDonIP.Size = new System.Drawing.Size(121, 23);
            this.lblMaHoaDonIP.TabIndex = 13;
            this.lblMaHoaDonIP.Text = "[MaHoaDon]";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(657, 18);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(103, 23);
            this.lblTongTien.TabIndex = 14;
            this.lblTongTien.Text = "Tổng Tiền:";
            // 
            // lblTongTienIP
            // 
            this.lblTongTienIP.AutoSize = true;
            this.lblTongTienIP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienIP.Location = new System.Drawing.Point(766, 18);
            this.lblTongTienIP.Name = "lblTongTienIP";
            this.lblTongTienIP.Size = new System.Drawing.Size(103, 23);
            this.lblTongTienIP.TabIndex = 15;
            this.lblTongTienIP.Text = "[TongTien]";
            // 
            // btnTinhTongTien
            // 
            this.btnTinhTongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTongTien.Location = new System.Drawing.Point(746, 60);
            this.btnTinhTongTien.Name = "btnTinhTongTien";
            this.btnTinhTongTien.Size = new System.Drawing.Size(129, 54);
            this.btnTinhTongTien.TabIndex = 16;
            this.btnTinhTongTien.Text = "Tính tiền tạm thời";
            this.btnTinhTongTien.Click += new System.EventHandler(this.btnTinhTongTien_Click);
            // 
            // frmQuanLyHoaDon
            // 
            this.ClientSize = new System.Drawing.Size(884, 495);
            this.Controls.Add(this.btnTinhTongTien);
            this.Controls.Add(this.lblTongTienIP);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblMaHoaDonIP);
            this.Controls.Add(this.lblMaPhieuDat);
            this.Controls.Add(this.lblMaHoaDon);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dataGridViewDanhSachHoaDon);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtMaPhieuDat);
            this.Name = "frmQuanLyHoaDon";
            this.Text = "frmQuanLyHoaDon";
            this.Load += new System.EventHandler(this.frmQuanLyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BtnAddInvoice_Click(object sender, EventArgs e)
        {
            // Logic for adding an invoice
            MessageBox.Show("Thêm hóa đơn mới!");
        }

        private void BtnEditInvoice_Click(object sender, EventArgs e)
        {
            // Logic for editing an invoice
            MessageBox.Show("Chỉnh sửa hóa đơn!");
        }

        private void BtnDeleteInvoice_Click(object sender, EventArgs e)
        {
            // Logic for deleting an invoice
            MessageBox.Show("Xóa hóa đơn!");
        }

        private void BtnSearchInvoice_Click(object sender, EventArgs e)
        {
            // Logic for searching an invoice
            MessageBox.Show($"Tìm kiếm hóa đơn với từ khóa: {txtMaPhieuDat.Text}");
        }
        private Button btnThoat;
        private Button btnLamMoi;
        private Label lblMaHoaDon;
        private Label lblMaPhieuDat;
        private Label lblMaHoaDonIP;
        private Label lblTongTien;
        private Label lblTongTienIP;
        private Button btnTinhTongTien;
    }
}
