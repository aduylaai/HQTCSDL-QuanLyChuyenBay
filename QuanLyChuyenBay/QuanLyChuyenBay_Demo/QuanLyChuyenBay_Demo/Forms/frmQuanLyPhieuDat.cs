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

            FIllData.fillDataGridView(dataGridViewDanhSachPhieuDat, dbConn, "select p.MaPhieuDat ,k.HoTen ,p.NgayDat ,p.SoLuongHanhKhach from PhieuDat p,KhachHang k where p.MaKhachHang=k.MaKhachHang", "PhieuDat");
        
        }
       
        
        


        


        private void dataGridViewDanhSachPhieuDat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maPhieuDat = dataGridViewDanhSachPhieuDat.Rows[e.RowIndex].Cells["MaPhieuDat"].Value.ToString();

                
                string cauTruyVan = $"SELECT p.MaPhieuDat, cp.MaVe, c.MaChuyenBay, c.NgayDi, c.NgayDen, c.MaHangGhe, d.MaTienIch " +
                     $"FROM PhieuDat p, ChiTietPhieuDat cp, Ve v, ChiTietVe c, DatTienIch d, TienIch t " +
                     $"WHERE p.MaPhieuDat = cp.MaPhieuDat " +
                     $"AND cp.MaVe = v.MaVe " +
                     $"AND v.MaVe = c.MaVe " +
                     $"AND t.MaTienIch = d.MaTienIch " +
                     $"AND d.MaPhieuDat = p.MaPhieuDat " +
                     $"AND p.MaPhieuDat = '{maPhieuDat}'";

                // Điền dữ liệu vào dataGridViewDanhSachChiTietPhieuDat
                FIllData.fillDataGridView(dataGridViewDanhSachChiTietPhieuDat, dbConn, cauTruyVan, "ChiTietPhieuDat");

            }
        }
        private void loadCboTenKhachHang()
        {
            dbConn.openConnect();
            string cauTruyVan = "select hoten from khachhang ";
            FIllData.fillDataCbo(cboTenKhachHang, dbConn, cauTruyVan, "hoten", "hoten");
            dbConn.closeConnect();
        }


        private bool KiemTraKhachHangVaNgayDat()
        {
            if (cboTenKhachHang.SelectedItem == null)
            {
                Notification_Helpers.ThongBaoLoi(this, "Vui lòng chọn khách hàng.");
                return false;
            }
            if (dateTimePickerNgayDat.Value.Date < DateTime.Now.Date)
            {
                Notification_Helpers.ThongBaoLoi(this, "Ngày đặt phải lớn hơn hoặc bằng ngày hiện tại.");
                return false;
            }
            return true;
        }

        private void btnTaoPhieuDat_Click(object sender, EventArgs e)
        {
            frmChiTietPhieuDat chiTietPhieuDatForm = new frmChiTietPhieuDat(dbConn);
            chiTietPhieuDatForm.Show();
            this.Hide();
            if (KiemTraKhachHangVaNgayDat())
            {
                int maKhachHang = Convert.ToInt32(cboTenKhachHang.SelectedValue);
                DateTime ngayDat = dateTimePickerNgayDat.Value.Date;

                PhieuDat phieuDat = new PhieuDat(maKhachHang, ngayDat);
                if (phieuDat.TaoPhieuDat(dbConn))
                {
                    // Hiển thị mã phiếu đặt mới lên label
                    lblMaphieudat.Text = phieuDat.MaPhieuDat;

                    // Chuyển sang form Chi Tiết Phiếu Đặt
                    //frmChiTietPhieuDat chiTietPhieuDatForm = new frmChiTietPhieuDat(dbConn);
                    //chiTietPhieuDatForm.Show();
                    //this.Hide();
                }
                else
                {
                    Notification_Helpers.ThongBaoLoi(this, "Tạo phiếu đặt thất bại.");
                }
            }
        }
        
    }
}