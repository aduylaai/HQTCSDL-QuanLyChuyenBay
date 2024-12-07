namespace QuanLyChuyenBay_Demo.Forms
{
    partial class frmThongKe
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
            this.dataGridViewThongKeDuLieu = new System.Windows.Forms.DataGridView();
            this.cboThongKe = new System.Windows.Forms.ComboBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongKeDuLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewThongKeDuLieu
            // 
            this.dataGridViewThongKeDuLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongKeDuLieu.Location = new System.Drawing.Point(12, 87);
            this.dataGridViewThongKeDuLieu.Name = "dataGridViewThongKeDuLieu";
            this.dataGridViewThongKeDuLieu.RowHeadersWidth = 51;
            this.dataGridViewThongKeDuLieu.RowTemplate.Height = 24;
            this.dataGridViewThongKeDuLieu.Size = new System.Drawing.Size(863, 248);
            this.dataGridViewThongKeDuLieu.TabIndex = 0;
            // 
            // cboThongKe
            // 
            this.cboThongKe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThongKe.FormattingEnabled = true;
            this.cboThongKe.Items.AddRange(new object[] {
            "Chuyến bay được bay nhiều nhất",
            "Lộ trình được bay nhiều nhất",
            "Khách hàng mua vé nhiều nhất",
            "Hãng hàng không được bay nhiều nhất",
            "Máy bay được sử dụng để bay nhiều nhất"});
            this.cboThongKe.Location = new System.Drawing.Point(41, 33);
            this.cboThongKe.Name = "cboThongKe";
            this.cboThongKe.Size = new System.Drawing.Size(363, 31);
            this.cboThongKe.TabIndex = 1;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(428, 26);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(150, 42);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 367);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.cboThongKe);
            this.Controls.Add(this.dataGridViewThongKeDuLieu);
            this.Name = "frmThongKe";
            this.Text = "Thống Kê";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongKeDuLieu)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewThongKeDuLieu;
		private System.Windows.Forms.ComboBox cboThongKe;
		private System.Windows.Forms.Button btnThongKe;
	}
}