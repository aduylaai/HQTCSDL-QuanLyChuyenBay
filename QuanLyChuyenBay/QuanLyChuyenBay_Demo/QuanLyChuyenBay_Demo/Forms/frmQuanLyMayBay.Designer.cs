
namespace QuanLyChuyenBay_Demo.Forms
{
    partial class frmQuanLyMayBay
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
            this.dataGridViewDanhSachMayBay = new System.Windows.Forms.DataGridView();
            this.MaMayBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMayBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SucChuaToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMamaybay = new System.Windows.Forms.Label();
            this.lblTenmaybay = new System.Windows.Forms.Label();
            this.lblSucchua = new System.Windows.Forms.Label();
            this.cboMakhachhang = new System.Windows.Forms.ComboBox();
            this.txtTenmaybay = new System.Windows.Forms.TextBox();
            this.txtSucchua = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachMayBay)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDanhSachMayBay
            // 
            this.dataGridViewDanhSachMayBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachMayBay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMayBay,
            this.TenMayBay,
            this.SucChuaToiDa});
            this.dataGridViewDanhSachMayBay.Location = new System.Drawing.Point(68, 233);
            this.dataGridViewDanhSachMayBay.Name = "dataGridViewDanhSachMayBay";
            this.dataGridViewDanhSachMayBay.RowHeadersWidth = 51;
            this.dataGridViewDanhSachMayBay.RowTemplate.Height = 24;
            this.dataGridViewDanhSachMayBay.Size = new System.Drawing.Size(428, 206);
            this.dataGridViewDanhSachMayBay.TabIndex = 0;
            // 
            // MaMayBay
            // 
            this.MaMayBay.HeaderText = "Mã máy bay";
            this.MaMayBay.MinimumWidth = 6;
            this.MaMayBay.Name = "MaMayBay";
            this.MaMayBay.Width = 125;
            // 
            // TenMayBay
            // 
            this.TenMayBay.HeaderText = "Tên máy bay";
            this.TenMayBay.MinimumWidth = 6;
            this.TenMayBay.Name = "TenMayBay";
            this.TenMayBay.Width = 125;
            // 
            // SucChuaToiDa
            // 
            this.SucChuaToiDa.HeaderText = "Sức chứa";
            this.SucChuaToiDa.MinimumWidth = 6;
            this.SucChuaToiDa.Name = "SucChuaToiDa";
            this.SucChuaToiDa.Width = 125;
            // 
            // lblMamaybay
            // 
            this.lblMamaybay.AutoSize = true;
            this.lblMamaybay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMamaybay.Location = new System.Drawing.Point(65, 25);
            this.lblMamaybay.Name = "lblMamaybay";
            this.lblMamaybay.Size = new System.Drawing.Size(109, 19);
            this.lblMamaybay.TabIndex = 1;
            this.lblMamaybay.Text = "Mã khách hàng";
            // 
            // lblTenmaybay
            // 
            this.lblTenmaybay.AutoSize = true;
            this.lblTenmaybay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenmaybay.Location = new System.Drawing.Point(65, 84);
            this.lblTenmaybay.Name = "lblTenmaybay";
            this.lblTenmaybay.Size = new System.Drawing.Size(93, 19);
            this.lblTenmaybay.TabIndex = 2;
            this.lblTenmaybay.Text = "Tên máy bay";
            // 
            // lblSucchua
            // 
            this.lblSucchua.AutoSize = true;
            this.lblSucchua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucchua.Location = new System.Drawing.Point(65, 151);
            this.lblSucchua.Name = "lblSucchua";
            this.lblSucchua.Size = new System.Drawing.Size(71, 19);
            this.lblSucchua.TabIndex = 3;
            this.lblSucchua.Text = "Sức chứa";
            // 
            // cboMakhachhang
            // 
            this.cboMakhachhang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMakhachhang.FormattingEnabled = true;
            this.cboMakhachhang.Location = new System.Drawing.Point(234, 16);
            this.cboMakhachhang.Name = "cboMakhachhang";
            this.cboMakhachhang.Size = new System.Drawing.Size(262, 27);
            this.cboMakhachhang.TabIndex = 4;
            // 
            // txtTenmaybay
            // 
            this.txtTenmaybay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenmaybay.Location = new System.Drawing.Point(234, 84);
            this.txtTenmaybay.Name = "txtTenmaybay";
            this.txtTenmaybay.Size = new System.Drawing.Size(262, 27);
            this.txtTenmaybay.TabIndex = 5;
            // 
            // txtSucchua
            // 
            this.txtSucchua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSucchua.Location = new System.Drawing.Point(234, 151);
            this.txtSucchua.Name = "txtSucchua";
            this.txtSucchua.Size = new System.Drawing.Size(262, 27);
            this.txtSucchua.TabIndex = 6;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.DarkRed;
            this.btnThoat.Location = new System.Drawing.Point(1107, 25);
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
            this.btnSua.Location = new System.Drawing.Point(835, 25);
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
            this.btnLammoi.Location = new System.Drawing.Point(972, 25);
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
            this.btnThem.Location = new System.Drawing.Point(555, 25);
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
            this.btnXoa.Location = new System.Drawing.Point(697, 25);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 46);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // frmQuanLyMayBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 503);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtSucchua);
            this.Controls.Add(this.txtTenmaybay);
            this.Controls.Add(this.cboMakhachhang);
            this.Controls.Add(this.lblSucchua);
            this.Controls.Add(this.lblTenmaybay);
            this.Controls.Add(this.lblMamaybay);
            this.Controls.Add(this.dataGridViewDanhSachMayBay);
            this.Name = "frmQuanLyMayBay";
            this.Text = "frmQuanLyMayBay";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachMayBay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDanhSachMayBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMayBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMayBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SucChuaToiDa;
        private System.Windows.Forms.Label lblMamaybay;
        private System.Windows.Forms.Label lblTenmaybay;
        private System.Windows.Forms.Label lblSucchua;
        private System.Windows.Forms.ComboBox cboMakhachhang;
        private System.Windows.Forms.TextBox txtTenmaybay;
        private System.Windows.Forms.TextBox txtSucchua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
    }
}