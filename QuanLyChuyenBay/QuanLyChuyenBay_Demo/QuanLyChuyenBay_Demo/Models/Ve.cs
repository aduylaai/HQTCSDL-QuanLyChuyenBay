using QuanLyChuyenBay_Demo.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay_Demo.Models
{
    public class Ve
    {
        public int MaVe { get; set; }
        public int MaHanhKhach { get; set; }
        public int MaChuyenBay { get; set; }
        public DateTime NgayDi { get; set; }
        public DateTime NgayDen { get; set; }
        public int MaHangGhe { get; set; }
        public int MaTTV { get; set; } // Ticket Status (1 = Đã đặt)

        // Constructor
        public Ve(int maHanhKhach, int maChuyenBay, DateTime ngayDi, DateTime ngayDen, int maHangGhe)
        {
            MaHanhKhach = maHanhKhach;
            MaChuyenBay = maChuyenBay;
            NgayDi = ngayDi;
            NgayDen = ngayDen;
            MaHangGhe = maHangGhe;
            MaTTV = 1; // Default MaTTV to "Đã đặt" (Status = 1)
        }

        

        public bool TaoVe(DBConnect dbConn)
        {
            try
            {

                

                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_TaoVe";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@MaHK", MaHanhKhach);
                    cmd.Parameters.AddWithValue("@MaChuyenBay", MaChuyenBay);
                    cmd.Parameters.AddWithValue("@NgayDi", NgayDi);
                    cmd.Parameters.AddWithValue("@NgayDen", NgayDen);
                    cmd.Parameters.AddWithValue("@MaHangGhe", MaHangGhe);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        dbConn.closeConnect();
                        return true;
                    }
                    catch (SqlException sqlEx)
                    {
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Thêm chi tiết vé vào bảng ChiTietVe
        public void ThemChiTietVe(DBConnect dbConn, int maVe, int maChuyenBay, DateTime ngayDi, DateTime ngayDen, int maHangGhe)
        {
            string query = @"INSERT INTO ChiTietVe (MaVe, MaChuyenBay, NgayDi, NgayDen, MaHangGhe) 
                         VALUES (@MaVe, @MaChuyenBay, @NgayDi, @NgayDen, @MaHangGhe)";
            using (SqlCommand cmd = new SqlCommand(query, dbConn.conn))
            {
                cmd.Parameters.AddWithValue("@MaVe", maVe);
                cmd.Parameters.AddWithValue("@MaChuyenBay", maChuyenBay);
                cmd.Parameters.AddWithValue("@NgayDi", ngayDi);
                cmd.Parameters.AddWithValue("@NgayDen", ngayDen);
                cmd.Parameters.AddWithValue("@MaHangGhe", maHangGhe);

                try
                {
                    cmd.ExecuteNonQuery(); // Thực thi lệnh SQL
                    Console.WriteLine("Chi tiết vé đã được thêm.");
                }
                catch (SqlException ex)
                {
                    throw new Exception("Lỗi khi thêm chi tiết vé: " + ex.Message);
                }
            }
        }

        // Lấy vé theo mã
        public static Ve GetVeById(DBConnect dbConn, int maVe)
        {
            Ve ve = null;

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Ve WHERE MaVe = @MaVe", dbConn.conn);
                cmd.Parameters.AddWithValue("@MaVe", maVe);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    ve = new Ve(
                        Convert.ToInt32(reader["MaHanhKhach"]),
                        Convert.ToInt32(reader["MaChuyenBay"]),
                        Convert.ToDateTime(reader["NgayDi"]),
                        Convert.ToDateTime(reader["NgayDen"]),
                        Convert.ToInt32(reader["MaHangGhe"])
                    )
                    {
                        MaVe = Convert.ToInt32(reader["MaVe"]),
                        MaTTV = Convert.ToInt32(reader["MaTTV"]) // Trạng thái vé
                    };
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi khi lấy vé: " + ex.Message);
            }

            return ve;
        }

        public bool XoaVe(DBConnect dbConn, int mave)
        {
            try
            {
                // Kiểm tra xem chuyến bay đã bán vé hay chưa
                if (KiemTraVeCoDuocDat(dbConn, mave))
                {
                    throw new Exception("Ves này đa được đặt không thể xóa!");
                }
                

                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_XoaVe";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Truyền tham số cho stored procedure
                    cmd.Parameters.AddWithValue("@MaVe", mave);

                    cmd.ExecuteNonQuery();
                    dbConn.closeConnect();
                    return true;
                }
            }
            catch (Exception ex)
            {
                dbConn.closeConnect();
                throw;
            }
        }
        public bool KiemTraVeCoDuocDat(DBConnect dbConn, int MaVe)
        {
            try
            {
                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "SELECT dbo.fn_KiemTraVeTrongPhieuDat(@MaVe)";
                    cmd.CommandType = System.Data.CommandType.Text;

                    // Truyền tham số cho hàm kiểm tra
                    cmd.Parameters.AddWithValue("@MaVe", MaVe);

                    // Thực hiện kiểm tra
                    bool exists = (bool)cmd.ExecuteScalar();
                    dbConn.closeConnect();
                    return exists;
                }
            }
            catch (Exception ex)
            {
                dbConn.closeConnect();
                throw;
            }
        }

        public bool SuaTTVe(DBConnect dbConn, int mave)
        {
            try
            {

                

                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = dbConn.conn;
                    cmd.CommandText = "sp_SuaVeVaChiTiet";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    // Truyền tham số cho stored procedure
                    cmd.Parameters.AddWithValue("@MaVe", mave);

                    cmd.Parameters.AddWithValue("@MaHK", MaHanhKhach);
                    cmd.Parameters.AddWithValue("@MaTTV", MaTTV);
                    cmd.Parameters.AddWithValue("@MaChuyenBay", MaChuyenBay);
                    cmd.Parameters.AddWithValue("@NgayDi", NgayDi);
                    cmd.Parameters.AddWithValue("@NgayDen", NgayDen);
                    cmd.Parameters.AddWithValue("@MaHangGhe", MaHangGhe);

                    cmd.ExecuteNonQuery();
                    dbConn.closeConnect();
                    return true;
                }
            }
            catch (Exception ex)
            {
                dbConn.closeConnect();
                throw;
            }
        }

    }
}
   

