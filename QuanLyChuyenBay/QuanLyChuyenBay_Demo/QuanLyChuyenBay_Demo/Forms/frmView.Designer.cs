namespace QuanLyChuyenBay_Demo.Forms
{
    partial class frmView
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
			this.dataGridViewDanhSachLoad = new System.Windows.Forms.DataGridView();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachLoad)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewDanhSachLoad
			// 
			this.dataGridViewDanhSachLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDanhSachLoad.Location = new System.Drawing.Point(130, 243);
			this.dataGridViewDanhSachLoad.Name = "dataGridViewDanhSachLoad";
			this.dataGridViewDanhSachLoad.RowHeadersWidth = 51;
			this.dataGridViewDanhSachLoad.RowTemplate.Height = 24;
			this.dataGridViewDanhSachLoad.Size = new System.Drawing.Size(863, 248);
			this.dataGridViewDanhSachLoad.TabIndex = 0;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(130, 33);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(190, 24);
			this.comboBox1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(377, 23);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(150, 42);
			this.button1.TabIndex = 2;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// frmView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1205, 503);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.dataGridViewDanhSachLoad);
			this.Name = "frmView";
			this.Text = "View";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachLoad)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewDanhSachLoad;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
	}
}