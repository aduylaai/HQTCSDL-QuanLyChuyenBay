using QuanLyChuyenBay_Demo.Helpers;
using QuanLyChuyenBay_Demo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChuyenBay_Demo.Forms
{
    public partial class frmTimKiemChuyenBay : Form
    {
        private DBConnect dbConn;

        public frmTimKiemChuyenBay(DBConnect dbConn)
        {
            InitializeComponent();
            this.dbConn = dbConn;
        }

        private void loadAllData()
        {
            LoadCBO();
            FIllData.fillDataGridView(dataGridViewDanhSachChuyenBay, dbConn, "SELECT c.MaChuyenBay, h.TenHangHangKhong, t.TenTrangThaiChuyenBay, l.TenLoTrinh, m.TenMayBay, c.GiaBay, c.NgayGioDi, c.NgayGioDen FROM ChuyenBay c, HangHangKhong h, TrangThaiChuyenBay t, LoTrinh l, MayBay m WHERE c.MaHangHangKhong = h.MaHangHangKhong AND c.MaTrangThaiChuyenBay = t.MaTrangThaiChuyenBay AND c.MaLoTrinh = l.MaLoTrinh AND c.MaMayBay = m.MaMayBay", "ChuyenBay");
        }

        private void LoadCBO()
        {
            // Load dữ liệu cho cboHangHangKhong từ bảng HangHangKhong
            FIllData.fillDataCbo(cboHangHangKhong, dbConn, "SELECT * FROM HangHangKhong", "TenHangHangKhong", "MaHangHangKhong");

            // Load dữ liệu cho cboTrangThai từ bảng TrangThaiChuyenBay
            FIllData.fillDataCbo(cboTrangThai, dbConn, "SELECT * FROM TrangThaiChuyenBay", "TenTrangThaiChuyenBay", "MaTrangThaiChuyenBay");

            // Load dữ liệu cho cboTenLoTrinh từ bảng LoTrinh
            FIllData.fillDataCbo(cboLoTrinh, dbConn, "SELECT * FROM LoTrinh", "TenLoTrinh", "MaLoTrinh");

            // Load dữ liệu cho cboTenmaybay từ bảng MayBay
            FIllData.fillDataCbo(cboTenMayBay, dbConn, "SELECT * FROM MayBay", "TenMayBay", "MaMayBay");
        }

        private void frmTimKiemChuyenBay_Load(object sender, EventArgs e)
        {
            loadAllData();
        }

        private string GetRealDataOfComboBox(ComboBox cbo)
        {
            ComboBoxItem cbi = (ComboBoxItem)cbo.SelectedItem;
            return cbi.Value.ToString();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            // Lấy giá trị thực từ các ComboBox
            int? maHangHangKhong = null;
            int? maTrangThaiChuyenBay = null;
            int? maLoTrinh = null;
            int? maMayBay = null;
            DateTime? ngayDi = null;

            // Kiểm tra các ComboBox đã được chọn hay chưa và gán giá trị
            if (cboHangHangKhong.SelectedItem != null)
                maHangHangKhong = int.Parse(GetRealDataOfComboBox(cboHangHangKhong));

            if (cboTrangThai.SelectedItem != null)
                maTrangThaiChuyenBay = int.Parse(GetRealDataOfComboBox(cboTrangThai));

            if (cboLoTrinh.SelectedItem != null)
                maLoTrinh = int.Parse(GetRealDataOfComboBox(cboLoTrinh));

            if (cboTenMayBay.SelectedItem != null)
                maMayBay = int.Parse(GetRealDataOfComboBox(cboTenMayBay));

            // Nếu người dùng đã chọn ngày, gán giá trị
            if (dTPNgayDi.Checked)
                ngayDi = dTPNgayDi.Value;

            // Tìm kiếm chuyến bay với các tham số đã chọn
            ChuyenBay chuyenBay = new ChuyenBay(0, 0, 0, 0, 0, DateTime.MinValue, DateTime.MinValue);
            List<ChuyenBay> listChuyenBay = chuyenBay.TimKiemChuyenBay(dbConn, maHangHangKhong, maTrangThaiChuyenBay, maLoTrinh, maMayBay, ngayDi);

            // Hiển thị kết quả tìm kiếm trong DataGridView
            dataGridViewDanhSachChuyenBay.DataSource = listChuyenBay;
        }
    }
}
