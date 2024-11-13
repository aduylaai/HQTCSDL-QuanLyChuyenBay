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
            loadCboMaPhieuDat();
            loadCboMaKhachHang();
            loadCboMaVe();
        }
        private void loadAllData()
        {
           
            FIllData.fillDataGridView(dataGridViewDanhSachPhieuDat, dbConn, "select p.MaPhieuDat /*as N'Mã phiếu đặt'*/,k.HoTen /*as N'Họ tên khách hàng'*/,p.NgayDat /*as N'Ngày đặt'*/,p.SoLuongHanhKhach /*as N'Số lượng hành khách'*/  from PhieuDat p,KhachHang k where p.MaKhachHang=k.MaKhachHang", "PhieuDat");
        }
        private void loadCboMaPhieuDat()
        {
            dbConn.openConnect();
            string cauTruyVan = "SELECT maphieudat, maphieudat FROM PhieuDat"; // Câu truy vấn lấy mã phiếu đặt
            FIllData.fillDataCbo(cboMaphieudat, dbConn, cauTruyVan, "maphieudat", "maphieudat");
            dbConn.closeConnect();

        }
        private void loadCboMaKhachHang()
        {
            dbConn.openConnect();
            string cauTruyVan = "SELECT hoten, hoten FROM KhachHang"; // Câu truy vấn lấy mã phiếu đặt
            FIllData.fillDataCbo(cboTenKhachHang, dbConn, cauTruyVan, "hoten", "hoten");
            dbConn.closeConnect();

        }
        private void loadCboMaVe()
        {
            dbConn.openConnect();
            string cauTruyVan = "select mave from ve where MaTTV=1"; // Câu truy vấn lấy mã phiếu đặt
            FIllData.fillDataCbo(cboMave, dbConn, cauTruyVan, "mave", "mave");
            dbConn.closeConnect();

        }
        private void fillData(DataGridViewRow rows)
        {
            cboMaphieudat.Text = FIllData.GetValueDGVRows(rows, "MaPhieuDat");

            cboTenKhachHang.Text = FIllData.GetValueDGVRows(rows, "HoTen");

            //txtTaiKhoan.Text = FIllData.GetValueDGVRows(rows, "TenTaiKhoan");
            // Lấy giá trị từ DataGridView (giả sử giá trị này là một chuỗi hợp lệ)
            string ngayDatValue = FIllData.GetValueDGVRows(rows, "NgayDat");

            // Chuyển đổi giá trị từ string sang DateTime và gán vào DateTimePicker
            dateTimePickerNgaydat.Value = Convert.ToDateTime(ngayDatValue);
            int soLuong = Convert.ToInt32(FIllData.GetValueDGVRows(rows, "SoLuongHanhKhach")); // Lấy giá trị từ cột "SoLuong"
            numericUpDownSoluongkhachhang.Value = soLuong; // Gán giá

        }

        private void dataGridViewDanhSachPhieuDat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fillData(dataGridViewDanhSachPhieuDat.Rows[e.RowIndex]);
        }
    }
}