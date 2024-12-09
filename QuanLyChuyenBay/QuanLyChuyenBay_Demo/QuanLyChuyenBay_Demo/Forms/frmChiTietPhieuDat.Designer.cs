namespace QuanLyChuyenBay_Demo.Forms
{
    partial class frmChiTietPhieuDat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietPhieuDat));
            this.lblVe = new System.Windows.Forms.Label();
            this.cboVe = new System.Windows.Forms.ComboBox();
            this.cboChuyenBay = new System.Windows.Forms.ComboBox();
            this.lblChuyenBay = new System.Windows.Forms.Label();
            this.rad6kg = new System.Windows.Forms.RadioButton();
            this.rad15kg = new System.Windows.Forms.RadioButton();
            this.rad10kg = new System.Windows.Forms.RadioButton();
            this.radCuaSo = new System.Windows.Forms.RadioButton();
            this.pnlTienIch = new System.Windows.Forms.Panel();
            this.groupBoxDichVu = new System.Windows.Forms.GroupBox();
            this.chkTroLyCaNhan = new System.Windows.Forms.CheckBox();
            this.chkTruyCapWf = new System.Windows.Forms.CheckBox();
            this.chkUuTienLenMB = new System.Windows.Forms.CheckBox();
            this.chkBuaAn = new System.Windows.Forms.CheckBox();
            this.groupBoxHanhLy = new System.Windows.Forms.GroupBox();
            this.groupBoxChoNgoi = new System.Windows.Forms.GroupBox();
            this.radGherong = new System.Windows.Forms.RadioButton();
            this.panelThongTinVe = new System.Windows.Forms.Panel();
            this.lblHanhKhach = new System.Windows.Forms.Label();
            this.cboHanhKhach = new System.Windows.Forms.ComboBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblLoTrinh = new System.Windows.Forms.Label();
            this.cboTenLoTrinh = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemVe = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.lblMaphieudat = new System.Windows.Forms.Label();
            this.dataGridViewChiTietPhieuDat = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTienIch.SuspendLayout();
            this.groupBoxDichVu.SuspendLayout();
            this.groupBoxHanhLy.SuspendLayout();
            this.groupBoxChoNgoi.SuspendLayout();
            this.panelThongTinVe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietPhieuDat)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVe
            // 
            this.lblVe.AutoSize = true;
            this.lblVe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVe.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblVe.Location = new System.Drawing.Point(8, 112);
            this.lblVe.Name = "lblVe";
            this.lblVe.Size = new System.Drawing.Size(38, 25);
            this.lblVe.TabIndex = 1;
            this.lblVe.Text = "Vé";
            // 
            // cboVe
            // 
            this.cboVe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVe.FormattingEnabled = true;
            this.cboVe.Location = new System.Drawing.Point(127, 109);
            this.cboVe.Name = "cboVe";
            this.cboVe.Size = new System.Drawing.Size(155, 33);
            this.cboVe.TabIndex = 2;
            // 
            // cboChuyenBay
            // 
            this.cboChuyenBay.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChuyenBay.FormattingEnabled = true;
            this.cboChuyenBay.Location = new System.Drawing.Point(636, 43);
            this.cboChuyenBay.Name = "cboChuyenBay";
            this.cboChuyenBay.Size = new System.Drawing.Size(79, 33);
            this.cboChuyenBay.TabIndex = 4;
            this.cboChuyenBay.SelectedIndexChanged += new System.EventHandler(this.cboChuyenBay_SelectedIndexChanged);
            // 
            // lblChuyenBay
            // 
            this.lblChuyenBay.AutoSize = true;
            this.lblChuyenBay.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuyenBay.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblChuyenBay.Location = new System.Drawing.Point(468, 46);
            this.lblChuyenBay.Name = "lblChuyenBay";
            this.lblChuyenBay.Size = new System.Drawing.Size(135, 25);
            this.lblChuyenBay.TabIndex = 3;
            this.lblChuyenBay.Text = "Chuyến Bay";
            // 
            // rad6kg
            // 
            this.rad6kg.AutoSize = true;
            this.rad6kg.Location = new System.Drawing.Point(23, 20);
            this.rad6kg.Name = "rad6kg";
            this.rad6kg.Size = new System.Drawing.Size(66, 21);
            this.rad6kg.TabIndex = 24;
            this.rad6kg.TabStop = true;
            this.rad6kg.Text = "+6Kg";
            this.rad6kg.UseVisualStyleBackColor = true;
            // 
            // rad15kg
            // 
            this.rad15kg.AutoSize = true;
            this.rad15kg.Location = new System.Drawing.Point(23, 89);
            this.rad15kg.Name = "rad15kg";
            this.rad15kg.Size = new System.Drawing.Size(74, 21);
            this.rad15kg.TabIndex = 28;
            this.rad15kg.TabStop = true;
            this.rad15kg.Text = "+15Kg";
            this.rad15kg.UseVisualStyleBackColor = true;
            // 
            // rad10kg
            // 
            this.rad10kg.AutoSize = true;
            this.rad10kg.Location = new System.Drawing.Point(23, 53);
            this.rad10kg.Name = "rad10kg";
            this.rad10kg.Size = new System.Drawing.Size(74, 21);
            this.rad10kg.TabIndex = 29;
            this.rad10kg.TabStop = true;
            this.rad10kg.Text = "+10Kg";
            this.rad10kg.UseVisualStyleBackColor = true;
            // 
            // radCuaSo
            // 
            this.radCuaSo.AutoSize = true;
            this.radCuaSo.Location = new System.Drawing.Point(13, 20);
            this.radCuaSo.Name = "radCuaSo";
            this.radCuaSo.Size = new System.Drawing.Size(109, 21);
            this.radCuaSo.TabIndex = 30;
            this.radCuaSo.TabStop = true;
            this.radCuaSo.Text = "Cạnh cửa sổ";
            this.radCuaSo.UseVisualStyleBackColor = true;
            // 
            // pnlTienIch
            // 
            this.pnlTienIch.Controls.Add(this.groupBoxDichVu);
            this.pnlTienIch.Controls.Add(this.groupBoxHanhLy);
            this.pnlTienIch.Controls.Add(this.groupBoxChoNgoi);
            this.pnlTienIch.Location = new System.Drawing.Point(752, 14);
            this.pnlTienIch.Name = "pnlTienIch";
            this.pnlTienIch.Size = new System.Drawing.Size(480, 173);
            this.pnlTienIch.TabIndex = 31;
            // 
            // groupBoxDichVu
            // 
            this.groupBoxDichVu.Controls.Add(this.chkTroLyCaNhan);
            this.groupBoxDichVu.Controls.Add(this.chkTruyCapWf);
            this.groupBoxDichVu.Controls.Add(this.chkUuTienLenMB);
            this.groupBoxDichVu.Controls.Add(this.chkBuaAn);
            this.groupBoxDichVu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDichVu.Location = new System.Drawing.Point(22, 3);
            this.groupBoxDichVu.Name = "groupBoxDichVu";
            this.groupBoxDichVu.Size = new System.Drawing.Size(154, 150);
            this.groupBoxDichVu.TabIndex = 41;
            this.groupBoxDichVu.TabStop = false;
            this.groupBoxDichVu.Text = "Dịch vụ";
            // 
            // chkTroLyCaNhan
            // 
            this.chkTroLyCaNhan.AutoSize = true;
            this.chkTroLyCaNhan.Location = new System.Drawing.Point(6, 118);
            this.chkTroLyCaNhan.Name = "chkTroLyCaNhan";
            this.chkTroLyCaNhan.Size = new System.Drawing.Size(121, 21);
            this.chkTroLyCaNhan.TabIndex = 3;
            this.chkTroLyCaNhan.Text = "Trợ lý cá nhân";
            this.chkTroLyCaNhan.UseVisualStyleBackColor = true;
            // 
            // chkTruyCapWf
            // 
            this.chkTruyCapWf.AutoSize = true;
            this.chkTruyCapWf.Location = new System.Drawing.Point(6, 86);
            this.chkTruyCapWf.Name = "chkTruyCapWf";
            this.chkTruyCapWf.Size = new System.Drawing.Size(112, 21);
            this.chkTruyCapWf.TabIndex = 2;
            this.chkTruyCapWf.Text = "Truy Cập Wf";
            this.chkTruyCapWf.UseVisualStyleBackColor = true;
            // 
            // chkUuTienLenMB
            // 
            this.chkUuTienLenMB.AutoSize = true;
            this.chkUuTienLenMB.Location = new System.Drawing.Point(6, 56);
            this.chkUuTienLenMB.Name = "chkUuTienLenMB";
            this.chkUuTienLenMB.Size = new System.Drawing.Size(130, 21);
            this.chkUuTienLenMB.TabIndex = 1;
            this.chkUuTienLenMB.Text = "Ưu tiên lên Mb";
            this.chkUuTienLenMB.UseVisualStyleBackColor = true;
            // 
            // chkBuaAn
            // 
            this.chkBuaAn.AutoSize = true;
            this.chkBuaAn.Location = new System.Drawing.Point(6, 24);
            this.chkBuaAn.Name = "chkBuaAn";
            this.chkBuaAn.Size = new System.Drawing.Size(80, 21);
            this.chkBuaAn.TabIndex = 0;
            this.chkBuaAn.Text = "Bữa ăn ";
            this.chkBuaAn.UseVisualStyleBackColor = true;
            // 
            // groupBoxHanhLy
            // 
            this.groupBoxHanhLy.Controls.Add(this.rad10kg);
            this.groupBoxHanhLy.Controls.Add(this.rad15kg);
            this.groupBoxHanhLy.Controls.Add(this.rad6kg);
            this.groupBoxHanhLy.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHanhLy.Location = new System.Drawing.Point(203, 3);
            this.groupBoxHanhLy.Name = "groupBoxHanhLy";
            this.groupBoxHanhLy.Size = new System.Drawing.Size(113, 150);
            this.groupBoxHanhLy.TabIndex = 40;
            this.groupBoxHanhLy.TabStop = false;
            this.groupBoxHanhLy.Text = "Hành Lý";
            // 
            // groupBoxChoNgoi
            // 
            this.groupBoxChoNgoi.Controls.Add(this.radGherong);
            this.groupBoxChoNgoi.Controls.Add(this.radCuaSo);
            this.groupBoxChoNgoi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChoNgoi.Location = new System.Drawing.Point(336, 3);
            this.groupBoxChoNgoi.Name = "groupBoxChoNgoi";
            this.groupBoxChoNgoi.Size = new System.Drawing.Size(136, 150);
            this.groupBoxChoNgoi.TabIndex = 39;
            this.groupBoxChoNgoi.TabStop = false;
            this.groupBoxChoNgoi.Text = "Chổ ngồi";
            // 
            // radGherong
            // 
            this.radGherong.AutoSize = true;
            this.radGherong.Location = new System.Drawing.Point(13, 53);
            this.radGherong.Name = "radGherong";
            this.radGherong.Size = new System.Drawing.Size(90, 21);
            this.radGherong.TabIndex = 31;
            this.radGherong.TabStop = true;
            this.radGherong.Text = "Ghế rộng";
            this.radGherong.UseVisualStyleBackColor = true;
            // 
            // panelThongTinVe
            // 
            this.panelThongTinVe.Controls.Add(this.lblHanhKhach);
            this.panelThongTinVe.Controls.Add(this.cboHanhKhach);
            this.panelThongTinVe.Controls.Add(this.lblLoTrinh);
            this.panelThongTinVe.Controls.Add(this.cboChuyenBay);
            this.panelThongTinVe.Controls.Add(this.cboTenLoTrinh);
            this.panelThongTinVe.Controls.Add(this.lblVe);
            this.panelThongTinVe.Controls.Add(this.cboVe);
            this.panelThongTinVe.Controls.Add(this.lblChuyenBay);
            this.panelThongTinVe.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panelThongTinVe.Location = new System.Drawing.Point(12, 14);
            this.panelThongTinVe.Name = "panelThongTinVe";
            this.panelThongTinVe.Size = new System.Drawing.Size(734, 173);
            this.panelThongTinVe.TabIndex = 32;
            // 
            // lblHanhKhach
            // 
            this.lblHanhKhach.AutoSize = true;
            this.lblHanhKhach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblHanhKhach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHanhKhach.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHanhKhach.Location = new System.Drawing.Point(309, 112);
            this.lblHanhKhach.Name = "lblHanhKhach";
            this.lblHanhKhach.Size = new System.Drawing.Size(135, 25);
            this.lblHanhKhach.TabIndex = 42;
            this.lblHanhKhach.Text = "Hành khách";
            // 
            // cboHanhKhach
            // 
            this.cboHanhKhach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cboHanhKhach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHanhKhach.FormattingEnabled = true;
            this.cboHanhKhach.Location = new System.Drawing.Point(473, 109);
            this.cboHanhKhach.Name = "cboHanhKhach";
            this.cboHanhKhach.Size = new System.Drawing.Size(242, 33);
            this.cboHanhKhach.TabIndex = 43;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.GhostWhite;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.Location = new System.Drawing.Point(762, 29);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(185, 46);
            this.btnLamMoi.TabIndex = 41;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // lblLoTrinh
            // 
            this.lblLoTrinh.AutoSize = true;
            this.lblLoTrinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoTrinh.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLoTrinh.Location = new System.Drawing.Point(8, 46);
            this.lblLoTrinh.Name = "lblLoTrinh";
            this.lblLoTrinh.Size = new System.Drawing.Size(95, 25);
            this.lblLoTrinh.TabIndex = 39;
            this.lblLoTrinh.Text = "Lộ trình";
            // 
            // cboTenLoTrinh
            // 
            this.cboTenLoTrinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenLoTrinh.FormattingEnabled = true;
            this.cboTenLoTrinh.Location = new System.Drawing.Point(127, 43);
            this.cboTenLoTrinh.Name = "cboTenLoTrinh";
            this.cboTenLoTrinh.Size = new System.Drawing.Size(317, 33);
            this.cboTenLoTrinh.TabIndex = 40;
            this.cboTenLoTrinh.SelectedIndexChanged += new System.EventHandler(this.cboTenLoTrinh_SelectedIndexChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.GhostWhite;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(242, 29);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(180, 46);
            this.btnXoa.TabIndex = 34;
            this.btnXoa.Text = "Xóa Vé";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemVe
            // 
            this.btnThemVe.BackColor = System.Drawing.Color.GhostWhite;
            this.btnThemVe.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemVe.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnThemVe.Image = ((System.Drawing.Image)(resources.GetObject("btnThemVe.Image")));
            this.btnThemVe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemVe.Location = new System.Drawing.Point(-4, 29);
            this.btnThemVe.Name = "btnThemVe";
            this.btnThemVe.Size = new System.Drawing.Size(181, 46);
            this.btnThemVe.TabIndex = 35;
            this.btnThemVe.Text = "Thêm Vé";
            this.btnThemVe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemVe.UseVisualStyleBackColor = false;
            this.btnThemVe.Click += new System.EventHandler(this.btnThemVe_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.GhostWhite;
            this.btnQuayLai.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnQuayLai.Image = ((System.Drawing.Image)(resources.GetObject("btnQuayLai.Image")));
            this.btnQuayLai.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuayLai.Location = new System.Drawing.Point(1028, 27);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(182, 50);
            this.btnQuayLai.TabIndex = 37;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(512, 29);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(179, 46);
            this.btnSua.TabIndex = 36;
            this.btnSua.Text = "Sửa Vé";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lblMaphieudat
            // 
            this.lblMaphieudat.AutoSize = true;
            this.lblMaphieudat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaphieudat.Location = new System.Drawing.Point(17, -2);
            this.lblMaphieudat.Name = "lblMaphieudat";
            this.lblMaphieudat.Size = new System.Drawing.Size(141, 25);
            this.lblMaphieudat.TabIndex = 35;
            this.lblMaphieudat.Text = "MaPhieuDat";
            // 
            // dataGridViewChiTietPhieuDat
            // 
            this.dataGridViewChiTietPhieuDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTietPhieuDat.Location = new System.Drawing.Point(12, 298);
            this.dataGridViewChiTietPhieuDat.Name = "dataGridViewChiTietPhieuDat";
            this.dataGridViewChiTietPhieuDat.RowHeadersWidth = 51;
            this.dataGridViewChiTietPhieuDat.RowTemplate.Height = 24;
            this.dataGridViewChiTietPhieuDat.Size = new System.Drawing.Size(1220, 183);
            this.dataGridViewChiTietPhieuDat.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThemVe);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnQuayLai);
            this.panel1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Location = new System.Drawing.Point(12, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 100);
            this.panel1.TabIndex = 37;
            // 
            // frmChiTietPhieuDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1236, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewChiTietPhieuDat);
            this.Controls.Add(this.lblMaphieudat);
            this.Controls.Add(this.panelThongTinVe);
            this.Controls.Add(this.pnlTienIch);
            this.Name = "frmChiTietPhieuDat";
            this.Text = "frmChiTietPhieuDat";
            this.Load += new System.EventHandler(this.frmChiTietPhieuDat_Load);
            this.pnlTienIch.ResumeLayout(false);
            this.groupBoxDichVu.ResumeLayout(false);
            this.groupBoxDichVu.PerformLayout();
            this.groupBoxHanhLy.ResumeLayout(false);
            this.groupBoxHanhLy.PerformLayout();
            this.groupBoxChoNgoi.ResumeLayout(false);
            this.groupBoxChoNgoi.PerformLayout();
            this.panelThongTinVe.ResumeLayout(false);
            this.panelThongTinVe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietPhieuDat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVe;
        private System.Windows.Forms.ComboBox cboVe;
        private System.Windows.Forms.ComboBox cboChuyenBay;
        private System.Windows.Forms.Label lblChuyenBay;
        private System.Windows.Forms.RadioButton rad6kg;
        private System.Windows.Forms.RadioButton rad15kg;
        private System.Windows.Forms.RadioButton rad10kg;
        private System.Windows.Forms.RadioButton radCuaSo;
        private System.Windows.Forms.Panel pnlTienIch;
        private System.Windows.Forms.Panel panelThongTinVe;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemVe;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lblMaphieudat;
        private System.Windows.Forms.GroupBox groupBoxChoNgoi;
        private System.Windows.Forms.GroupBox groupBoxDichVu;
        private System.Windows.Forms.CheckBox chkTroLyCaNhan;
        private System.Windows.Forms.CheckBox chkTruyCapWf;
        private System.Windows.Forms.CheckBox chkUuTienLenMB;
        private System.Windows.Forms.CheckBox chkBuaAn;
        private System.Windows.Forms.GroupBox groupBoxHanhLy;
        private System.Windows.Forms.DataGridView dataGridViewChiTietPhieuDat;
        private System.Windows.Forms.RadioButton radGherong;
        private System.Windows.Forms.Label lblLoTrinh;
        private System.Windows.Forms.ComboBox cboTenLoTrinh;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblHanhKhach;
        private System.Windows.Forms.ComboBox cboHanhKhach;
        private System.Windows.Forms.Panel panel1;
    }
}