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
           
            FIllData.fillDataGridView(dataGridViewDanhSachPhieuDat, dbConn, "select p.MaPhieuDat,k.HoTen,p.NgayDat,p.SoLuongHanhKhach  from PhieuDat p,KhachHang k where p.MaKhachHang=k.MaKhachHang", "PhieuDat");
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




    }
}