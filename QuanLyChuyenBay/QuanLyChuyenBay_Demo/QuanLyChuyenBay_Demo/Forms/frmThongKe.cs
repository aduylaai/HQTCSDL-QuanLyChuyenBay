using QuanLyChuyenBay_Demo.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyChuyenBay_Demo.Models;
using System.Data.SqlClient;

namespace QuanLyChuyenBay_Demo.Forms
{
	public partial class frmThongKe : Form
    {
		private DBConnect dbConn;

		public frmThongKe(DBConnect dbConn)
        {
            InitializeComponent();
			this.dbConn = dbConn;
		}

		private void btnThongKe_Click(object sender, EventArgs e)
		{
			try
			{
				// Mở kết nối
				dbConn.openConnect();

				// Kiểm tra giá trị được chọn trong ComboBox cboThongKe
				string selectedThongKe = cboThongKe.SelectedItem.ToString();

				// Dựa trên lựa chọn, thực hiện thủ tục tương ứng
				using (SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = dbConn.conn;

					// Nếu chọn "Chuyến bay được bay nhiều nhất"
					if (selectedThongKe == "Chuyến bay được bay nhiều nhất")
					{
						cmd.CommandText = "sp_ChuyenBayDatNhieuNhat";
					}
					else if (selectedThongKe == "Hãng hàng không được bay nhiều nhất")
					{
						cmd.CommandText = "sp_ThongKeHangHangKhongDatNhieuNhat"; 
					}
					else if (selectedThongKe == "Máy bay được sử dụng để bay nhiều nhất")
					{
						cmd.CommandText = "sp_ThongKeMayBayDuocSuDungNhieuNhat"; 
					}
					else if (selectedThongKe == "Khách hàng có đặt vé nhiều nhất")
					{
						cmd.CommandText = "sp_KhachHangDatVeNhieuNhat";
					}
					else
					{
						cmd.CommandText = "sp_ThongKeLoTrinhBayNhieuNhat"; 
					}
					cmd.CommandType = CommandType.StoredProcedure;

					// Thực hiện thủ tục và lấy dữ liệu
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						DataTable dt = new DataTable();
						dt.Load(reader);

						if (dt.Rows.Count > 0)
						{
							// Hiển thị kết quả thống kê trong DataGridView
							dataGridViewThongKeDuLieu.DataSource = dt;
						}
						else
						{
							MessageBox.Show("Không tìm thấy dữ liệu thống kê.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				dbConn.closeConnect();
			}
		}
	}
}
