using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyChuyenBay_Demo.Helpers;
using QuanLyChuyenBay_Demo.Models;
using System.Data.SqlClient;

namespace QuanLyChuyenBay_Demo.Forms
{
    public partial class frmQuanLyPhieuDat : Form
    {
        private DBConnect dbConn;
        TaiKhoan taiKhoan;

        public frmQuanLyPhieuDat(DBConnect dbConn, TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.dbConn = dbConn;
            this.taiKhoan = taiKhoan;
        }

        public frmQuanLyPhieuDat(DBConnect dbConn)
        {
            InitializeComponent();
            this.dbConn = dbConn;
        }

        private void frmQuanLyPhieuDat_Load(object sender, EventArgs e)
        {

            loadAllData();
            loadCboTenKhachHang();

        }
        private void loadAllData()
        {
            if (taiKhoan == null)
            {
            FIllData.fillDataGridView(dataGridViewDanhSachPhieuDat, dbConn, "select p.MaPhieuDat ,k.HoTen ,p.NgayDat ,p.SoLuongHanhKhach from PhieuDat p,KhachHang k where p.MaKhachHang=k.MaKhachHang", "PhieuDat");

            }
            else
            {
                FIllData.fillDataGridView(dataGridViewDanhSachPhieuDat, dbConn, "	select p.MaPhieuDat ,k.HoTen ,p.NgayDat ,p.SoLuongHanhKhach from PhieuDat p,KhachHang k, TaiKhoan tk where p.MaKhachHang=k.MaKhachHang and tk.MaTaiKhoan = k.MaTaiKhoan and tk.TenTaiKhoan = '" + taiKhoan.taiKhoan + "'", "PhieuDat");

            }
        }


        private void dataGridViewDanhSachPhieuDat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy mã phiếu đặt từ dòng đang chọn
                string maPhieuDat = dataGridViewDanhSachPhieuDat.Rows[e.RowIndex].Cells["MaPhieuDat"].Value.ToString();

                // Lấy thông tin khách hàng và ngày đặt
                string cauTruyVan = $"SELECT p.MaPhieuDat, k.HoTen, p.NgayDat " +
                                     $"FROM PhieuDat p " +
                                     $"JOIN KhachHang k ON p.MaKhachHang = k.MaKhachHang " +
                                     $"WHERE p.MaPhieuDat = '{maPhieuDat}'";

                SqlCommand cmd = new SqlCommand(cauTruyVan, dbConn.conn);
                dbConn.openConnect();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Cập nhật tên khách hàng, ngày đặt và mã phiếu đặt
                    cboTenKhachHang.Text = reader["HoTen"].ToString();
                    dateTimePickerNgayDat.Value = Convert.ToDateTime(reader["NgayDat"]);  // Sử dụng Value cho DateTimePicker
                    lblMaphieudat.Text = reader["MaPhieuDat"].ToString();  // Cập nhật mã phiếu đặt
                }
                reader.Close();
                dbConn.closeConnect();

                // Truy vấn và điền dữ liệu chi tiết phiếu đặt vào dataGridViewDanhSachChiTietPhieuDat
                string chiTietQuery = $@"
            SELECT 
                cp.MaPhieuDat, 
                cp.MaVe, 
                c.MaChuyenBay, 
                l.TenLoTrinh, 
                h.TenHangGhe, 
                t.TenTienIch
            FROM 
                PhieuDat p
            JOIN 
                ChiTietPhieuDat cp ON p.MaPhieuDat = cp.MaPhieuDat
            JOIN 
                Ve v ON cp.MaVe = v.MaVe
            JOIN 
                ChiTietVe c ON v.MaVe = c.MaVe
            JOIN 
                ChuyenBay cb ON c.MaChuyenBay = cb.MaChuyenBay
            JOIN 
                LoTrinh l ON cb.MaLoTrinh = l.MaLoTrinh
            JOIN 
                HangGhe h ON c.MaHangGhe = h.MaHangGhe
            JOIN 
                DatTienIch d ON p.MaPhieuDat = d.MaPhieuDat
            JOIN 
                TienIch t ON d.MaTienIch = t.MaTienIch
            WHERE 
                p.MaPhieuDat = '{maPhieuDat}'";

                FIllData.fillDataGridView(dataGridViewDanhSachChiTietPhieuDat, dbConn, chiTietQuery, "ChiTietPhieuDat");
            }
        }

        private void loadCboTenKhachHang()
        {
            if (taiKhoan == null)
            {
                dbConn.openConnect();
                string cauTruyVan = "select hoten from khachhang ";
                FIllData.fillDataCbo(cboTenKhachHang, dbConn, cauTruyVan, "hoten", "hoten");
                dbConn.closeConnect();
            }
            else
            {
                dbConn.openConnect();
                string cauTruyVan = "select hoten from KhachHang kh join TaiKhoan tk on tk.MaTaiKhoan = kh.MaTaiKhoan where tk.TenTaiKhoan = '" + taiKhoan.taiKhoan + "'";
                FIllData.fillDataCbo(cboTenKhachHang, dbConn, cauTruyVan, "hoten", "hoten");
                dbConn.closeConnect();
            }
           
            //dbConn.openConnect();
            //string cauTruyVan = "SELECT MaKhachHang, HoTen FROM KhachHang";
            //FIllData.fillDataCbo(cboTenKhachHang, dbConn, cauTruyVan, "HoTen", "MaKhachHang");
            //dbConn.closeConnect();
        }

        private void btnTaoPhieuDat_Click(object sender, EventArgs e)
        {
            try
            {

                // Kiểm tra dữ liệu nhập vào
                if (cboTenKhachHang.SelectedIndex == -1)
                {
                    Notification_Helpers.ThongBaoLoi(this, "Vui lòng chọn tên khách hàng.");
                    return;
                }

                // Kiểm tra ngày đặt có lớn hơn hoặc bằng ngày hiện tại không
                if (dateTimePickerNgayDat.Value.Date < DateTime.Now.Date)
                {
                    Notification_Helpers.ThongBaoLoi(this, "Ngày đặt phải lớn hơn hoặc bằng ngày hiện tại.");
                    return;
                }

                // Lấy tên khách hàng đã chọn từ cboTenKhachHang
                string tenKhachHang = FIllData.GetRealDataOfComboBox(cboTenKhachHang);

                // Truy vấn mã khách hàng từ tên khách hàng
                int maKhachHang = -1;
                string query = "SELECT MaKhachHang FROM KhachHang WHERE HoTen = @HoTen";
                SqlCommand cmd = new SqlCommand(query, dbConn.conn);
                cmd.Parameters.AddWithValue("@HoTen", tenKhachHang);
                dbConn.openConnect();


                object result = cmd.ExecuteScalar(); // Lấy một giá trị duy nhất (mã khách hàng)
                dbConn.closeConnect();  // Đóng kết nối ngay sau khi thực hiện truy vấn

                if (result != null)
                {
                    maKhachHang = Convert.ToInt32(result); // Chuyển đổi thành số nguyên
                }
                else
                {
                    Notification_Helpers.ThongBaoLoi(this, "Không tìm thấy mã khách hàng.");
                    return;
                }

                // Lấy ngày đặt từ DateTimePicker
                DateTime ngayDat = dateTimePickerNgayDat.Value;

                // Tạo đối tượng PhieuDat
                PhieuDat phieuDatMoi = new PhieuDat(maKhachHang, ngayDat);
                dbConn.openConnect();

                // Thực hiện tạo phiếu đặt
                if (phieuDatMoi.TaoPhieuDat(dbConn))
                {
                    int maPhieuDat = phieuDatMoi.MaPhieuDat;
                    Notification_Helpers.ThongBaoThanhCong(this, "Tạo phiếu đặt thành công.");

                    // Mở form chi tiết phiếu đặt
                    frmChiTietPhieuDat chiTietPhieuDatForm = new frmChiTietPhieuDat(dbConn);
                    chiTietPhieuDatForm.SetMaPhieuDat(maPhieuDat); // Gửi mã phiếu đặt qua form

                    chiTietPhieuDatForm.Show();

                    // Ẩn form quản lý phiếu đặt
                    this.Hide();
                }
                else
                {
                    Notification_Helpers.ThongBao(this, "Tạo phiếu đặt thất bại.");
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }

        private void btnXoaPhieuDat_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã phiếu đặt từ label
                int maPhieuDat = 0;
                if (lblMaphieudat.Text != "[Mã phiếu đặt]")
                {
                    maPhieuDat = int.Parse(CacHamKiemTra.KiemTraChuoiRong(lblMaphieudat.Text));
                }

                // Kiểm tra nếu mã phiếu đặt hợp lệ
                if (maPhieuDat == 0)
                {
                    Notification_Helpers.ThongBaoLoi(this, "Mã phiếu đặt không hợp lệ.");
                    return;
                }

                // Tạo đối tượng PhieuDat
                PhieuDat phieuDatMoi = new PhieuDat();
                phieuDatMoi.MaPhieuDat = maPhieuDat;

                // Xóa phiếu đặt
                if (phieuDatMoi.XoaPhieuDat(dbConn))
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Xóa phiếu đặt thành công.");
                    loadAllData(); // Nạp lại dữ liệu sau khi xóa
                }
                else
                {
                    Notification_Helpers.ThongBaoLoi(this, "Không thể xóa phiếu đặt.");
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }

        private void btnSuaPhieuDat_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào: đảm bảo các trường bắt buộc được điền đầy đủ
                if (cboTenKhachHang.SelectedIndex == -1 || dateTimePickerNgayDat.Value == null)
                {
                    Notification_Helpers.ThongBaoLoi(this, "Vui lòng điền đầy đủ thông tin (Khách hàng và Ngày đặt).");
                    return;
                }

                // Kiểm tra mã khách hàng từ ComboBox
                string tenKhachHang = FIllData.GetRealDataOfComboBox(cboTenKhachHang);
                if (string.IsNullOrEmpty(tenKhachHang))
                {
                    Notification_Helpers.ThongBaoLoi(this, "Vui lòng chọn tên khách hàng.");
                    return;
                }

                // Truy vấn mã khách hàng từ tên khách hàng
                int maKhachHang = -1;
                string query = "SELECT MaKhachHang FROM KhachHang WHERE HoTen = @HoTen";
                SqlCommand cmd = new SqlCommand(query, dbConn.conn);
                cmd.Parameters.AddWithValue("@HoTen", tenKhachHang);
                dbConn.openConnect();

                object result = cmd.ExecuteScalar();
                dbConn.closeConnect();

                if (result != null)
                {
                    maKhachHang = Convert.ToInt32(result);
                }
                else
                {
                    Notification_Helpers.ThongBaoLoi(this, "Không tìm thấy mã khách hàng.");
                    return;
                }

                // Kiểm tra ngày đặt
                DateTime ngayDat = dateTimePickerNgayDat.Value;
                if (ngayDat < DateTime.Now)
                {
                    Notification_Helpers.ThongBaoLoi(this, "Ngày đặt phải lớn hơn hoặc bằng ngày hiện tại.");
                    return;
                }

                // Kiểm tra mã phiếu đặt
                int maPhieuDat;
                if (!int.TryParse(lblMaphieudat.Text, out maPhieuDat))
                {
                    Notification_Helpers.ThongBaoLoi(this, "Mã phiếu đặt không hợp lệ.");
                    return;
                }

                // Tạo đối tượng PhieuDat mới với các thông tin vừa lấy
                PhieuDat phieuDatMoi = new PhieuDat(maKhachHang, ngayDat);

                // Thực hiện cập nhật phiếu đặt trong cơ sở dữ liệu
                if (phieuDatMoi.SuaPhieuDat(dbConn, maPhieuDat))
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Sửa phiếu đặt thành công.");
                    loadAllData();   // Load lại dữ liệu
                }
                else
                {
                    Notification_Helpers.ThongBao(this, "Sửa phiếu đặt thất bại.");
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }

        private void btnSuaChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(lblMaphieudat.Text) || lblMaphieudat.Text == "[Mã phiếu đặt]")
                {
                    Notification_Helpers.ThongBaoLoi(this, "Vui lòng chọn phiếu đặt để sửa.");
                    return;
                }

                int maPhieuDat = int.Parse(lblMaphieudat.Text);

                // Mở form Chi Tiết Phiếu Đặt và truyền mã phiếu đặt
                frmChiTietPhieuDat chiTietPhieuDatForm = new frmChiTietPhieuDat(dbConn);
                chiTietPhieuDatForm.SetMaPhieuDat(maPhieuDat);  // Gửi mã phiếu đặt qua form chi tiết
                chiTietPhieuDatForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }
    }
}
