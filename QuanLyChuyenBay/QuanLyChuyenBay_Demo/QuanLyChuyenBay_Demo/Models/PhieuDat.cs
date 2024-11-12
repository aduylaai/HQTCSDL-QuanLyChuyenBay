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
        public string MaKhachHang { get; set; }
        public string NgayDat { get; set; }
        public int SoLuongHanhKhach { get; set; }

        public PhieuDat(string pMaKhachHang,string pNgayDat,int pSoLuongHanhKhach) 
        {
            MaKhachHang= pMaKhachHang;
            NgayDat= pNgayDat;
            SoLuongHanhKhach = pSoLuongHanhKhach;
        }
        public bool TaoPhieuDat(DBConnect dbConn, DataTable danhSachVe, DataTable danhSachTienIch)
        {
            try
            {
                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand("sp_TaoPhieuDat", dbConn.conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaKhachHang", MaKhachHang);
                    cmd.Parameters.AddWithValue("@NgayDat", NgayDat);
                    cmd.Parameters.AddWithValue("@SoLuongHanhKhach", SoLuongHanhKhach);

                    SqlParameter danhSachVeParam = cmd.Parameters.AddWithValue("@DanhSachVe", danhSachVe);
                    danhSachVeParam.SqlDbType = SqlDbType.Structured;
                    danhSachVeParam.TypeName = "DanhSachVeType";

                    SqlParameter danhSachTienIchParam = cmd.Parameters.AddWithValue("@DanhSachTienIch", danhSachTienIch);
                    danhSachTienIchParam.SqlDbType = SqlDbType.Structured;
                    danhSachTienIchParam.TypeName = "DanhSachTienIchType";

                    cmd.ExecuteNonQuery();
                    dbConn.closeConnect();
                    return true;
                }
            }
            catch (SqlException)
            {
                dbConn.closeConnect();
                throw;
            }
            catch (Exception)
            {
                dbConn.closeConnect();
                throw;
            }
        }

        public bool XoaPhieuDat(DBConnect dbConn)
        {
            try
            {
                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand("sp_XoaPhieuDat", dbConn.conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhieuDat", MaPhieuDat);

                    cmd.ExecuteNonQuery();
                    dbConn.closeConnect();
                    return true;
                }
            }
            catch (SqlException)
            {
                dbConn.closeConnect();
                throw;
            }
            catch (Exception)
            {
                dbConn.closeConnect();
                throw;
            }
        }

        public bool SuaPhieuDat(DBConnect dbConn, string maKhachHang, string ngayDat, int soLuongHanhKhach, DataTable danhSachVe, DataTable danhSachTienIch)
        {
            try
            {
                dbConn.openConnect();
                using (SqlCommand cmd = new SqlCommand("sp_SuaPhieuDat", dbConn.conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaPhieuDat", MaPhieuDat);
                    cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                    cmd.Parameters.AddWithValue("@NgayDat", ngayDat);
                    cmd.Parameters.AddWithValue("@SoLuongHanhKhach", soLuongHanhKhach);

                    SqlParameter danhSachVeParam = cmd.Parameters.AddWithValue("@DanhSachVe", danhSachVe);
                    danhSachVeParam.SqlDbType = SqlDbType.Structured;
                    danhSachVeParam.TypeName = "DanhSachVeType";

                    SqlParameter danhSachTienIchParam = cmd.Parameters.AddWithValue("@DanhSachTienIch", danhSachTienIch);
                    danhSachTienIchParam.SqlDbType = SqlDbType.Structured;
                    danhSachTienIchParam.TypeName = "DanhSachTienIchType";

                    cmd.ExecuteNonQuery();
                    dbConn.closeConnect();
                    return true;
                }
            }
            catch (SqlException)
            {
                dbConn.closeConnect();
                throw;
            }
            catch (Exception)
            {
                dbConn.closeConnect();
                throw;
            }
        }

    }
}
