
namespace QuanLyChuyenBay_Demo.Forms
{
    partial class frmQuanLyTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyTaiKhoan));
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnCapQuyen = new System.Windows.Forms.Button();
            this.btnGoQuyen = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnTaoTaiKhoan = new System.Windows.Forms.Button();
            this.btnLoadTaiKhoan = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaTaiKhoan = new System.Windows.Forms.Label();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.lblTitle);
            this.pnlBody.Controls.Add(this.btnCapQuyen);
            this.pnlBody.Controls.Add(this.btnGoQuyen);
            this.pnlBody.Controls.Add(this.btnXoa);
            this.pnlBody.Controls.Add(this.btnCapNhat);
            this.pnlBody.Controls.Add(this.btnTaoTaiKhoan);
            this.pnlBody.Controls.Add(this.btnLoadTaiKhoan);
            this.pnlBody.Controls.Add(this.txtMatKhau);
            this.pnlBody.Controls.Add(this.label3);
            this.pnlBody.Controls.Add(this.txtTaiKhoan);
            this.pnlBody.Controls.Add(this.label2);
            this.pnlBody.Controls.Add(this.label1);
            this.pnlBody.Controls.Add(this.lblMaTaiKhoan);
            this.pnlBody.Controls.Add(this.dgvTaiKhoan);
            this.pnlBody.Location = new System.Drawing.Point(12, 12);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1208, 489);
            this.pnlBody.TabIndex = 2;
            // 
            // btnCapQuyen
            // 
            this.btnCapQuyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapQuyen.Location = new System.Drawing.Point(381, 400);
            this.btnCapQuyen.Name = "btnCapQuyen";
            this.btnCapQuyen.Size = new System.Drawing.Size(212, 38);
            this.btnCapQuyen.TabIndex = 16;
            this.btnCapQuyen.Text = "Cấp quyền member";
            this.btnCapQuyen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapQuyen.UseVisualStyleBackColor = true;
            this.btnCapQuyen.Click += new System.EventHandler(this.btnCapQuyen_Click);
            // 
            // btnGoQuyen
            // 
            this.btnGoQuyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoQuyen.Location = new System.Drawing.Point(76, 400);
            this.btnGoQuyen.Name = "btnGoQuyen";
            this.btnGoQuyen.Size = new System.Drawing.Size(212, 38);
            this.btnGoQuyen.TabIndex = 15;
            this.btnGoQuyen.Text = "Gỡ quyền";
            this.btnGoQuyen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoQuyen.UseVisualStyleBackColor = true;
            this.btnGoQuyen.Click += new System.EventHandler(this.btnGoQuyen_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(381, 330);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(212, 38);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa tài khoản";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.Location = new System.Drawing.Point(76, 330);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(212, 38);
            this.btnCapNhat.TabIndex = 13;
            this.btnCapNhat.Text = "Cập nhật tài khoản";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoTaiKhoan.Image")));
            this.btnTaoTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoTaiKhoan.Location = new System.Drawing.Point(381, 255);
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.Size = new System.Drawing.Size(212, 38);
            this.btnTaoTaiKhoan.TabIndex = 12;
            this.btnTaoTaiKhoan.Text = "Tạo tài khoản";
            this.btnTaoTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaoTaiKhoan.Click += new System.EventHandler(this.btnTaoTaiKhoan_Click);
            // 
            // btnLoadTaiKhoan
            // 
            this.btnLoadTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadTaiKhoan.Image")));
            this.btnLoadTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadTaiKhoan.Location = new System.Drawing.Point(76, 255);
            this.btnLoadTaiKhoan.Name = "btnLoadTaiKhoan";
            this.btnLoadTaiKhoan.Size = new System.Drawing.Size(212, 38);
            this.btnLoadTaiKhoan.TabIndex = 11;
            this.btnLoadTaiKhoan.Text = "Load dữ liệu";
            this.btnLoadTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadTaiKhoan.UseVisualStyleBackColor = true;
            this.btnLoadTaiKhoan.Click += new System.EventHandler(this.btnLoadTaiKhoan_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(265, 181);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(195, 30);
            this.txtMatKhau.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mật khẩu:";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(265, 134);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(195, 30);
            this.txtTaiKhoan.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tài khoản:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã Tài Khoản:";
            // 
            // lblMaTaiKhoan
            // 
            this.lblMaTaiKhoan.AutoSize = true;
            this.lblMaTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaTaiKhoan.Location = new System.Drawing.Point(307, 88);
            this.lblMaTaiKhoan.Name = "lblMaTaiKhoan";
            this.lblMaTaiKhoan.Size = new System.Drawing.Size(127, 22);
            this.lblMaTaiKhoan.TabIndex = 5;
            this.lblMaTaiKhoan.Text = "[MaTaiKhoan]";
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(659, 65);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersWidth = 51;
            this.dgvTaiKhoan.RowTemplate.Height = 24;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(515, 373);
            this.dgvTaiKhoan.TabIndex = 4;
            this.dgvTaiKhoan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellDoubleClick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(119, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(446, 45);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // frmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 503);
            this.Controls.Add(this.pnlBody);
            this.Name = "frmQuanLyTaiKhoan";
            this.Text = "frmQuanLyTaiKhoan";
            this.Load += new System.EventHandler(this.frmQuanLyTaiKhoan_Load);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaTaiKhoan;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnTaoTaiKhoan;
        private System.Windows.Forms.Button btnLoadTaiKhoan;
        private System.Windows.Forms.Button btnGoQuyen;
        private System.Windows.Forms.Button btnCapQuyen;
        private System.Windows.Forms.Label lblTitle;
    }
}