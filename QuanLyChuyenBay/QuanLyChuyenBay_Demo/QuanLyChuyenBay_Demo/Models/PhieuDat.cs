using QuanLyChuyenBay_Demo.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChuyenBay_Demo.Helpers;
using System.Data;

namespace QuanLyChuyenBay_Demo.Models
{
    internal class PhieuDat
    {
        public int MaPhieuDat { get; set; }
        public int MaKhachHang { get; set; }
        public DateTime NgayDat { get; set; }
        public int SoLuongHanhKhach { get; set; }
        public int mave { get; set; }
        public PhieuDat() { }

        public PhieuDat(int maKhachHang, DateTime ngayDat)
        {
            MaKhachHang = maKhachHang;
            NgayDat = ngayDat;
        }

      


        public bool TaoPhieuDat(DBConnect dbConn)
        {
            try
            {
                dbConn.openConnect(); // Mở kết nối với cơ sở dữ liệu

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_TaoPhieuDat"; // Gọi stored procedure tạo phiếu đặt
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số vào stored procedure
                    cmd.Parameters.AddWithValue("@MaKhachHang", MaKhachHang); // Mã khách hàng
                    cmd.Parameters.AddWithValue("@NgayDat", NgayDat); // Ngày đặt vé

                    // Sử dụng OUTPUT để lấy mã phiếu đặt sau khi thực thi
                    SqlParameter outputParameter = new SqlParameter("@MaPhieuDat", SqlDbType.Int);
                    outputParameter.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputParameter);

                    try
                    {
                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();

                        // Lấy mã phiếu đặt từ output parameter
                        MaPhieuDat = Convert.ToInt32(outputParameter.Value);

                        dbConn.closeConnect(); // Đóng kết nối

                        // Kiểm tra nếu mã phiếu đặt được tạo thành công
                        return true;
                    }
                    catch (SqlException sqlEx)
                    {
                        // Nếu có lỗi SQL, ném lỗi ra ngoài
                        throw new Exception("Lỗi khi tạo phiếu đặt: " + sqlEx.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                // Nếu có lỗi khác, ném lỗi ra ngoài
                throw new Exception("Lỗi khi thực thi tạo phiếu đặt: " + ex.Message);
            }
        }

        public bool TaoChiTietPhieuDat(DBConnect dbConn)
        {
            try
            {
                dbConn.openConnect(); // Mở kết nối với cơ sở dữ liệu

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_TaoChiTietPhieuDat"; // Gọi stored procedure tạo chi tiết phiếu đặt
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số vào stored procedure
                    cmd.Parameters.AddWithValue("@MaPhieuDat", MaPhieuDat); // Mã phiếu đặt
                    cmd.Parameters.AddWithValue("@MaVe",mave ); // Mã vé

                    try
                    {
                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
                        dbConn.closeConnect(); // Đóng kết nối
                        return true; // Trả về true nếu thực thi thành công
                    }
                    catch (SqlException sqlEx)
                    {
                        // Nếu có lỗi SQL, ném lỗi ra ngoài
                        throw new Exception("Lỗi khi tạo chi tiết phiếu đặt: " + sqlEx.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                // Nếu có lỗi khác, ném lỗi ra ngoài
                throw new Exception("Lỗi khi thực thi tạo chi tiết phiếu đặt: " + ex.Message);
            }
        }
        public bool KiemTraPhiuDatCoHoaDon(DBConnect dbConn)
        {
            try
            {
                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "dbo.fn_KiemTraPhiuDatCoHoaDon"; // Gọi function kiểm tra phiếu đặt có hóa đơn
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuDat", MaPhieuDat);

                    object result = cmd.ExecuteScalar(); // Trả về kết quả kiểm tra (1 hoặc 0)
                    dbConn.closeConnect();
                    return Convert.ToBoolean(result); // Nếu có hóa đơn liên kết, trả về true
                }
            }
            catch (Exception ex)
            {
                dbConn.closeConnect();
                throw new Exception("Lỗi khi kiểm tra hóa đơn: " + ex.Message);
            }
        }

        // Kiểm tra phiếu đặt có liên kết với tiện ích
        public bool KiemTraPhiuDatCoTienIch(DBConnect dbConn)
        {
            try
            {
                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "dbo.fn_KiemTraPhiuDatCoTienIch"; // Gọi function kiểm tra phiếu đặt có tiện ích
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuDat", MaPhieuDat);

                    object result = cmd.ExecuteScalar(); // Trả về kết quả kiểm tra (1 hoặc 0)
                    dbConn.closeConnect();
                    return Convert.ToBoolean(result); // Nếu có tiện ích liên kết, trả về true
                }
            }
            catch (Exception ex)
            {
                dbConn.closeConnect();
                throw new Exception("Lỗi khi kiểm tra tiện ích: " + ex.Message);
            }
        }
        public bool XoaPhieuDat(DBConnect dbConn)
        {
            try
            {
                // Gọi stored procedure xóa phiếu đặt
                SqlCommand cmd = new SqlCommand("sp_XoaPhieuDat", dbConn.conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhieuDat", MaPhieuDat);

                // Kiểm tra phiếu đặt có liên kết với hóa đơn và tiện ích trước khi xóa
                if (KiemTraPhiuDatCoHoaDon(dbConn))
                {
                    Notification_Helpers.ThongBaoLoi(null, "Không thể xóa phiếu đặt vì đã có hóa đơn.");
                    return false;
                }

                if (KiemTraPhiuDatCoTienIch(dbConn))
                {
                    Notification_Helpers.ThongBaoLoi(null, "Không thể xóa phiếu đặt vì đã có tiện ích.");
                    return false;
                }

                dbConn.openConnect();
                cmd.ExecuteNonQuery();
                dbConn.closeConnect();

                return true; // Trả về true nếu xóa thành công
            }
            catch (Exception ex)
            {
                dbConn.closeConnect();
                throw new Exception("Lỗi khi xóa phiếu đặt: " + ex.Message);
            }
        }
        public bool SuaPhieuDat(DBConnect dbConn, int maPhieuDat)
        {
            try
            {
                // Mở kết nối với cơ sở dữ liệu
                dbConn.openConnect();

                // Sử dụng SqlCommand để gọi stored procedure
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_SuaPhieuDat";  // Stored procedure sửa phiếu đặt
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Thêm tham số vào stored procedure
                    cmd.Parameters.AddWithValue("@MaPhieuDat", maPhieuDat);  // Mã phiếu đặt cần sửa
                    cmd.Parameters.AddWithValue("@MaKhachHang", MaKhachHang); // Mã khách hàng mới
                    cmd.Parameters.AddWithValue("@NgayDat", NgayDat);         // Ngày đặt mới

                    // Thực thi stored procedure
                    cmd.ExecuteNonQuery();

                    // Đóng kết nối
                    dbConn.closeConnect();

                    return true;  // Trả về true nếu sửa thành công
                }
            }
            catch (Exception ex)
            {
                // Đóng kết nối và ném lỗi nếu có
                dbConn.closeConnect();
                throw new Exception("Lỗi khi sửa phiếu đặt: " + ex.Message);
            }
        }




    }




}
