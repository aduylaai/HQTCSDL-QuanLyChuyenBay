
namespace QuanLyChuyenBay_Demo.Forms
{
    partial class frmQuanLyTienIch
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
            this.dataGridViewDanhSachTienIch = new System.Windows.Forms.DataGridView();
            this.txtTentienich = new System.Windows.Forms.TextBox();
            this.lblTenkhachhang = new System.Windows.Forms.Label();
            this.lblTrangthaive = new System.Windows.Forms.Label();
            this.lblMatienich = new System.Windows.Forms.Label();
            this.txtGiatienich = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblMatienichIP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachTienIch)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDanhSachTienIch
            // 
            this.dataGridViewDanhSachTienIch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachTienIch.Location = new System.Drawing.Point(39, 222);
            this.dataGridViewDanhSachTienIch.Name = "dataGridViewDanhSachTienIch";
            this.dataGridViewDanhSachTienIch.RowHeadersWidth = 51;
            this.dataGridViewDanhSachTienIch.RowTemplate.Height = 24;
            this.dataGridViewDanhSachTienIch.Size = new System.Drawing.Size(505, 255);
            this.dataGridViewDanhSachTienIch.TabIndex = 0;
            this.dataGridViewDanhSachTienIch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhSachTienIch_CellClick);
            // 
            // txtTentienich
            // 
            this.txtTentienich.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTentienich.Location = new System.Drawing.Point(184, 90);
            this.txtTentienich.Name = "txtTentienich";
            this.txtTentienich.Size = new System.Drawing.Size(305, 27);
            this.txtTentienich.TabIndex = 12;
            // 
            // lblTenkhachhang
            // 
            this.lblTenkhachhang.AutoSize = true;
            this.lblTenkhachhang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenkhachhang.Location = new System.Drawing.Point(44, 97);
            this.lblTenkhachhang.Name = "lblTenkhachhang";
            this.lblTenkhachhang.Size = new System.Drawing.Size(89, 19);
            this.lblTenkhachhang.TabIndex = 9;
            this.lblTenkhachhang.Text = "Tên tiện ích";
            // 
            // lblTrangthaive
            // 
            this.lblTrangthaive.AutoSize = true;
            this.lblTrangthaive.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangthaive.Location = new System.Drawing.Point(44, 157);
            this.lblTrangthaive.Name = "lblTrangthaive";
            this.lblTrangthaive.Size = new System.Drawing.Size(88, 19);
            this.lblTrangthaive.TabIndex = 8;
            this.lblTrangthaive.Text = "Giá tiện ích";
            // 
            // lblMatienich
            // 
            this.lblMatienich.AutoSize = true;
            this.lblMatienich.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatienich.Location = new System.Drawing.Point(44, 42);
            this.lblMatienich.Name = "lblMatienich";
            this.lblMatienich.Size = new System.Drawing.Size(86, 19);
            this.lblMatienich.TabIndex = 7;
            this.lblMatienich.Text = "Mã tiện ích";
            this.lblMatienich.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtGiatienich
            // 
            this.txtGiatienich.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiatienich.Location = new System.Drawing.Point(184, 157);
            this.txtGiatienich.Name = "txtGiatienich";
            this.txtGiatienich.Size = new System.Drawing.Size(305, 27);
            this.txtGiatienich.TabIndex = 13;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.DarkRed;
            this.btnThoat.Location = new System.Drawing.Point(1101, 27);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 46);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSua.Location = new System.Drawing.Point(829, 27);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 46);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.ForeColor = System.Drawing.Color.DarkRed;
            this.btnLammoi.Location = new System.Drawing.Point(966, 27);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(103, 46);
            this.btnLammoi.TabIndex = 22;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.DarkRed;
            this.btnThem.Location = new System.Drawing.Point(549, 27);
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
            this.btnXoa.Location = new System.Drawing.Point(691, 27);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 46);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblMatienichIP
            // 
            this.lblMatienichIP.AutoSize = true;
            this.lblMatienichIP.Location = new System.Drawing.Point(221, 42);
            this.lblMatienichIP.Name = "lblMatienichIP";
            this.lblMatienichIP.Size = new System.Drawing.Size(78, 16);
            this.lblMatienichIP.TabIndex = 25;
            this.lblMatienichIP.Text = "[MaTienIch]";
            // 
            // frmQuanLyTienIch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 503);
            this.Controls.Add(this.lblMatienichIP);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtGiatienich);
            this.Controls.Add(this.txtTentienich);
            this.Controls.Add(this.lblTenkhachhang);
            this.Controls.Add(this.lblTrangthaive);
            this.Controls.Add(this.lblMatienich);
            this.Controls.Add(this.dataGridViewDanhSachTienIch);
            this.Name = "frmQuanLyTienIch";
            this.Text = "frmQuanLyTienIch";
            this.Load += new System.EventHandler(this.frmQuanLyTienIch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachTienIch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDanhSachTienIch;
        private System.Windows.Forms.TextBox txtTentienich;
        private System.Windows.Forms.Label lblTenkhachhang;
        private System.Windows.Forms.Label lblTrangthaive;
        private System.Windows.Forms.Label lblMatienich;
        private System.Windows.Forms.TextBox txtGiatienich;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblMatienichIP;
    }
}