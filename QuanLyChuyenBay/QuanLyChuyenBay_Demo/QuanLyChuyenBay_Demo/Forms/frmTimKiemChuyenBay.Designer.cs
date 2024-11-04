
using System.Windows.Forms;
using System;

namespace QuanLyChuyenBay_Demo.Forms
{
    public partial class frmTimKiemChuyenBay : Form
    {
        private Label lblThoigian;
        private Label lblDiemdi;
        private DateTimePicker datePicker;
        private ComboBox cmbDestination;
        private Button btnTimkiem;
        private DataGridView dataGridView;
        private Button btnBook;

        private void InitializeComponent()
        {
            this.lblThoigian = new System.Windows.Forms.Label();
            this.lblDiemdi = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.cmbDestination = new System.Windows.Forms.ComboBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnBook = new System.Windows.Forms.Button();
            this.lblDiemden = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBookColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThoigian
            // 
            this.lblThoigian.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoigian.Location = new System.Drawing.Point(20, 20);
            this.lblThoigian.Name = "lblThoigian";
            this.lblThoigian.Size = new System.Drawing.Size(74, 20);
            this.lblThoigian.TabIndex = 0;
            this.lblThoigian.Text = "Thời gian:";
            // 
            // lblDiemdi
            // 
            this.lblDiemdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemdi.Location = new System.Drawing.Point(319, 20);
            this.lblDiemdi.Name = "lblDiemdi";
            this.lblDiemdi.Size = new System.Drawing.Size(55, 22);
            this.lblDiemdi.TabIndex = 2;
            this.lblDiemdi.Text = "Điểm đi:";
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(100, 19);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 22);
            this.datePicker.TabIndex = 1;
            // 
            // cmbDestination
            // 
            this.cmbDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDestination.Items.AddRange(new object[] {
            "Khánh Hòa",
            "Cần Thơ"});
            this.cmbDestination.Location = new System.Drawing.Point(380, 17);
            this.cmbDestination.Name = "cmbDestination";
            this.cmbDestination.Size = new System.Drawing.Size(150, 24);
            this.cmbDestination.TabIndex = 3;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Location = new System.Drawing.Point(804, 9);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(104, 36);
            this.btnTimkiem.TabIndex = 4;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeight = 29;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.btnBookColumn});
            this.dataGridView.Location = new System.Drawing.Point(13, 50);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(922, 401);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(0, 0);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 23);
            this.btnBook.TabIndex = 0;
            // 
            // lblDiemden
            // 
            this.lblDiemden.AutoSize = true;
            this.lblDiemden.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemden.Location = new System.Drawing.Point(545, 20);
            this.lblDiemden.Name = "lblDiemden";
            this.lblDiemden.Size = new System.Drawing.Size(67, 16);
            this.lblDiemden.TabIndex = 6;
            this.lblDiemden.Text = "Điểm đến:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.Location = new System.Drawing.Point(628, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã chuyến bay";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 7;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Sân bay cất cánh";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nơi cất cánh";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Sân bay hạ cánh";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Nơi hạ cánh";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Thời gian";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Ghế trống";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Ghế đã đặt";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // btnBookColumn
            // 
            this.btnBookColumn.HeaderText = "Thao tác";
            this.btnBookColumn.MinimumWidth = 6;
            this.btnBookColumn.Name = "btnBookColumn";
            this.btnBookColumn.Text = "Đặt vé";
            this.btnBookColumn.UseColumnTextForButtonValue = true;
            // 
            // frmTimKiemChuyenBay
            // 
            this.ClientSize = new System.Drawing.Size(947, 463);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblDiemden);
            this.Controls.Add(this.lblThoigian);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.lblDiemdi);
            this.Controls.Add(this.cmbDestination);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.dataGridView);
            this.Name = "frmTimKiemChuyenBay";
            this.Text = "Tìm Kiếm Chuyến Bay";
            this.Load += new System.EventHandler(this.frmTimKiemChuyenBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            // Logic for search button click
            // Add sample data to the DataGridView as a demonstration
            dataGridView.Rows.Clear();
            dataGridView.Rows.Add("FL0071", "Sân bay Cam Ranh", "Khánh Hòa", "Sân bay Cần Thơ", "Cần Thơ", "12:55-14:55", "60", "0");
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewButtonColumn btnBookColumn;
        private Label lblDiemden;
        private ComboBox comboBox1;
    }
}