
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyMayBay));
            this.dataGridViewDanhSachMayBay = new System.Windows.Forms.DataGridView();
            this.lblMamaybay = new System.Windows.Forms.Label();
            this.lblTenmaybay = new System.Windows.Forms.Label();
            this.lblSucchua = new System.Windows.Forms.Label();
            this.txtTenmaybay = new System.Windows.Forms.TextBox();
            this.txtSucchua = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblMamaybayIP = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachMayBay)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDanhSachMayBay
            // 
            this.dataGridViewDanhSachMayBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachMayBay.Location = new System.Drawing.Point(538, 98);
            this.dataGridViewDanhSachMayBay.Name = "dataGridViewDanhSachMayBay";
            this.dataGridViewDanhSachMayBay.RowHeadersWidth = 51;
            this.dataGridViewDanhSachMayBay.RowTemplate.Height = 24;
            this.dataGridViewDanhSachMayBay.Size = new System.Drawing.Size(544, 393);
            this.dataGridViewDanhSachMayBay.TabIndex = 0;
            this.dataGridViewDanhSachMayBay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhSachMayBay_CellClick);
            // 
            // lblMamaybay
            // 
            this.lblMamaybay.AutoSize = true;
            this.lblMamaybay.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMamaybay.Location = new System.Drawing.Point(71, 126);
            this.lblMamaybay.Name = "lblMamaybay";
            this.lblMamaybay.Size = new System.Drawing.Size(100, 20);
            this.lblMamaybay.TabIndex = 1;
            this.lblMamaybay.Text = "Mã máy bay";
            // 
            // lblTenmaybay
            // 
            this.lblTenmaybay.AutoSize = true;
            this.lblTenmaybay.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenmaybay.Location = new System.Drawing.Point(71, 185);
            this.lblTenmaybay.Name = "lblTenmaybay";
            this.lblTenmaybay.Size = new System.Drawing.Size(105, 20);
            this.lblTenmaybay.TabIndex = 2;
            this.lblTenmaybay.Text = "Tên máy bay";
            // 
            // lblSucchua
            // 
            this.lblSucchua.AutoSize = true;
            this.lblSucchua.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucchua.Location = new System.Drawing.Point(71, 252);
            this.lblSucchua.Name = "lblSucchua";
            this.lblSucchua.Size = new System.Drawing.Size(77, 20);
            this.lblSucchua.TabIndex = 3;
            this.lblSucchua.Text = "Sức chứa";
            // 
            // txtTenmaybay
            // 
            this.txtTenmaybay.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenmaybay.Location = new System.Drawing.Point(240, 185);
            this.txtTenmaybay.Name = "txtTenmaybay";
            this.txtTenmaybay.Size = new System.Drawing.Size(262, 28);
            this.txtTenmaybay.TabIndex = 5;
            // 
            // txtSucchua
            // 
            this.txtSucchua.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSucchua.Location = new System.Drawing.Point(240, 252);
            this.txtSucchua.Name = "txtSucchua";
            this.txtSucchua.Size = new System.Drawing.Size(262, 28);
            this.txtSucchua.TabIndex = 6;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.DarkRed;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(1099, 445);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(121, 46);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(335, 333);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(141, 46);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
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
            this.btnLammoi.Location = new System.Drawing.Point(335, 432);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(141, 46);
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
            this.btnThem.Location = new System.Drawing.Point(75, 333);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(141, 46);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
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
            this.btnXoa.Location = new System.Drawing.Point(72, 433);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(141, 46);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblMamaybayIP
            // 
            this.lblMamaybayIP.AutoSize = true;
            this.lblMamaybayIP.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMamaybayIP.Location = new System.Drawing.Point(254, 126);
            this.lblMamaybayIP.Name = "lblMamaybayIP";
            this.lblMamaybayIP.Size = new System.Drawing.Size(107, 20);
            this.lblMamaybayIP.TabIndex = 25;
            this.lblMamaybayIP.Text = "[MaMayBay]";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(349, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 45);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "QUẢN LÝ MÁY BAY";
            // 
            // frmQuanLyMayBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 503);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMamaybayIP);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtSucchua);
            this.Controls.Add(this.txtTenmaybay);
            this.Controls.Add(this.lblSucchua);
            this.Controls.Add(this.lblTenmaybay);
            this.Controls.Add(this.lblMamaybay);
            this.Controls.Add(this.dataGridViewDanhSachMayBay);
            this.Name = "frmQuanLyMayBay";
            this.Text = "frmQuanLyMayBay";
            this.Load += new System.EventHandler(this.frmQuanLyMayBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachMayBay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDanhSachMayBay;
        private System.Windows.Forms.Label lblMamaybay;
        private System.Windows.Forms.Label lblTenmaybay;
        private System.Windows.Forms.Label lblSucchua;
        private System.Windows.Forms.TextBox txtTenmaybay;
        private System.Windows.Forms.TextBox txtSucchua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblMamaybayIP;
        private System.Windows.Forms.Label lblTitle;
    }
}