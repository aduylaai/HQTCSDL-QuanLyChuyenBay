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
        public string MaPhieuDat { get; set; }
        public int MaKhachHang { get; set; }
        public DateTime NgayDat { get; set; }
        public int SoLuongHanhKhach { get; set; }

        public PhieuDat(int maKhachHang, DateTime ngayDat)
        {
            MaKhachHang = maKhachHang;
            NgayDat = ngayDat;
            
        }

        public bool TaoPhieuDat(DBConnect dbConn)
        {
            try
            {
                // Tạo command để gọi stored procedure
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_TaoPhieuDat";
                    // Thêm các tham số vào proc
                    cmd.Parameters.AddWithValue("@MaKhachHang", MaKhachHang);
                    cmd.Parameters.AddWithValue("@NgayDat", NgayDat);

                    // Đầu ra cho mã phiếu đặt
                    SqlParameter outputMaPhieuDat = new SqlParameter("@MaPhieuDat", SqlDbType.NVarChar, 50)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputMaPhieuDat);

                    // Thực thi proc
                    cmd.ExecuteNonQuery();

                    // Lấy giá trị của MaPhieuDat từ output parameter
                    MaPhieuDat = outputMaPhieuDat.Value.ToString();

                    // Kiểm tra nếu mã phiếu đặt được tạo thành công
                    return !string.IsNullOrEmpty(MaPhieuDat);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tạo phiếu đặt: " + ex.Message);
            }
        }

        // Phương thức thêm vé vào phiếu đặt
        //public bool ThemVe(DBConnect dbConn, int maVe)
        //{
        //    try
        //    {
        //        dbConn.openConnect();
        //        using (SqlCommand cmd = new SqlCommand("sp_ThemVeVaoPhieuDat", dbConn.conn))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@MaPhieuDat", MaPhieuDat);
        //            cmd.Parameters.AddWithValue("@MaVe", maVe);

        //            // Thực thi lệnh để thêm vé vào phiếu đặt
        //            cmd.ExecuteNonQuery();

        //            // Cập nhật danh sách vé và số lượng hành khách
        //            DanhSachVe.Add(maVe);
        //            SoLuongHanhKhach++;
        //        }
        //        dbConn.closeConnect();
        //        return true;
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw new Exception("Lỗi khi thêm vé vào phiếu đặt: " + ex.Message);
        //    }
        //}

        //// Phương thức cập nhật phiếu đặt (cập nhật số lượng hành khách)
        //public bool CapNhatPhieuDat(DBConnect dbConn)
        //{
        //    try
        //    {
        //        dbConn.openConnect();
        //        using (SqlCommand cmd = new SqlCommand("sp_CapNhatPhieuDat", dbConn.conn))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@MaPhieuDat", MaPhieuDat);
        //            cmd.Parameters.AddWithValue("@SoLuongHanhKhach", SoLuongHanhKhach);

        //            // Thực thi lệnh cập nhật
        //            cmd.ExecuteNonQuery();
        //        }
        //        dbConn.closeConnect();
        //        return true;
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw new Exception("Lỗi khi cập nhật phiếu đặt: " + ex.Message);
        //    }
        //}
    }




}
