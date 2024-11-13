
namespace QuanLyChuyenBay_Demo.Forms
{
    partial class frmQuanLyGiamGia
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblMucGiamGia = new System.Windows.Forms.Label();
            this.dataGridViewQLGiamGia = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MucGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboCode = new System.Windows.Forms.ComboBox();
            this.cboMucGiamGia = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLGiamGia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(55, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(337, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ GIẢM GIÁ";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(58, 144);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(58, 22);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Code:";
            // 
            // lblMucGiamGia
            // 
            this.lblMucGiamGia.AutoSize = true;
            this.lblMucGiamGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMucGiamGia.Location = new System.Drawing.Point(58, 236);
            this.lblMucGiamGia.Name = "lblMucGiamGia";
            this.lblMucGiamGia.Size = new System.Drawing.Size(125, 22);
            this.lblMucGiamGia.TabIndex = 2;
            this.lblMucGiamGia.Text = "Mức giảm giá:";
            // 
            // dataGridViewQLGiamGia
            // 
            this.dataGridViewQLGiamGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQLGiamGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.MucGiamGia});
            this.dataGridViewQLGiamGia.Location = new System.Drawing.Point(650, 46);
            this.dataGridViewQLGiamGia.Name = "dataGridViewQLGiamGia";
            this.dataGridViewQLGiamGia.RowHeadersWidth = 51;
            this.dataGridViewQLGiamGia.RowTemplate.Height = 24;
            this.dataGridViewQLGiamGia.Size = new System.Drawing.Size(304, 254);
            this.dataGridViewQLGiamGia.TabIndex = 5;
            this.dataGridViewQLGiamGia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQLGiamGia_CellContentClick);
            // 
            // Code
            // 
            this.Code.HeaderText = "Tên vocher";
            this.Code.MinimumWidth = 6;
            this.Code.Name = "Code";
            this.Code.Width = 125;
            // 
            // MucGiamGia
            // 
            this.MucGiamGia.HeaderText = "Mức giảm giá";
            this.MucGiamGia.MinimumWidth = 6;
            this.MucGiamGia.Name = "MucGiamGia";
            this.MucGiamGia.Width = 125;
            // 
            // cboCode
            // 
            this.cboCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCode.FormattingEnabled = true;
            this.cboCode.Location = new System.Drawing.Point(209, 141);
            this.cboCode.Name = "cboCode";
            this.cboCode.Size = new System.Drawing.Size(227, 30);
            this.cboCode.TabIndex = 6;
            // 
            // cboMucGiamGia
            // 
            this.cboMucGiamGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMucGiamGia.FormattingEnabled = true;
            this.cboMucGiamGia.Location = new System.Drawing.Point(209, 233);
            this.cboMucGiamGia.Name = "cboMucGiamGia";
            this.cboMucGiamGia.Size = new System.Drawing.Size(227, 30);
            this.cboMucGiamGia.TabIndex = 7;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.DarkRed;
            this.btnThoat.Location = new System.Drawing.Point(981, 263);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 46);
            this.btnThoat.TabIndex = 29;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSua.Location = new System.Drawing.Point(480, 107);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 46);
            this.btnSua.TabIndex = 28;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLammoi
            // 
            this.btnLammoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.ForeColor = System.Drawing.Color.DarkRed;
            this.btnLammoi.Location = new System.Drawing.Point(480, 254);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(103, 46);
            this.btnLammoi.TabIndex = 27;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.DarkRed;
            this.btnThem.Location = new System.Drawing.Point(480, 40);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 46);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.DarkRed;
            this.btnXoa.Location = new System.Drawing.Point(480, 184);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 46);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // frmQuanLyGiamGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 336);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.cboMucGiamGia);
            this.Controls.Add(this.cboCode);
            this.Controls.Add(this.dataGridViewQLGiamGia);
            this.Controls.Add(this.lblMucGiamGia);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmQuanLyGiamGia";
            this.Text = "frmQuanLyGiamGia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLGiamGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblMucGiamGia;
        private System.Windows.Forms.DataGridView dataGridViewQLGiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn MucGiamGia;
        private System.Windows.Forms.ComboBox cboCode;
        private System.Windows.Forms.ComboBox cboMucGiamGia;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
    }
}