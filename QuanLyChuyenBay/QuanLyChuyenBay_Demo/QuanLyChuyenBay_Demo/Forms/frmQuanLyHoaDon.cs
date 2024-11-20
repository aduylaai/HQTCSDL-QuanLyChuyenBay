using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using QuanLyChuyenBay_Demo.Helpers;
using QuanLyChuyenBay_Demo.Models;

namespace QuanLyChuyenBay_Demo.Forms
{
    public partial class frmQuanLyHoaDon : Form
    {
        private DBConnect dbConn;
        public frmQuanLyHoaDon(DBConnect dbConn)
        {
            InitializeComponent();
            this.dbConn = dbConn;
        }
        private void emptyData()
        {
            lblMaHoaDonIP.Text = "[MaHoaDon]";
            txtMaPhieuDat.Clear();
            lblTongTienIP.Text = "[TongTien]";
            txtMaPhieuDat.Focus();
        }
        private void frmQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            loadAllData();
        }
        private void loadAllData()
        {
            FIllData.fillDataGridView(dataGridViewDanhSachHoaDon, dbConn, "select * from HoaDon", "HoaDon");
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDon tmp = new HoaDon(int.Parse(CacHamKiemTra.KiemTraChuoiRong(txtMaPhieuDat.Text)));

                if (tmp.ThemHoaDon(dbConn))
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Thêm hóa đơn thành công");
                    emptyData();
                    loadAllData();
                }
                else
                {
                    Notification_Helpers.ThongBao(this, "Thêm hóa đơn thất bại");
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }

        private void fillData(DataGridViewRow rows)
        {
            lblMaHoaDonIP.Text = FIllData.GetValueDGVRows(rows, "MaHoaDon");

            txtMaPhieuDat.Text = FIllData.GetValueDGVRows(rows, "MaPhieuDat");

            lblTongTienIP.Text = FIllData.GetValueDGVRows(rows, "TongTien");
        }
        private void dataGridViewDanhSachHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            emptyData();
            fillData(dataGridViewDanhSachHoaDon.Rows[e.RowIndex]);
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            emptyData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDon tmp = new HoaDon(int.Parse(CacHamKiemTra.KiemTraChuoiRong(txtMaPhieuDat.Text)));
                string maHoaDon = "";
                if (lblMaHoaDonIP.Text != "[MaHoaDon]")
                {
                    maHoaDon = CacHamKiemTra.KiemTraChuoiRong(lblMaHoaDonIP.Text);
                }
                else
                {
                    Notification_Helpers.ThongBaoLoi(this, "Vui lòng chọn hóa đơn để xóa");
                }

                if (tmp.XoaHoaDon(dbConn, maHoaDon))
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Xóa hóa đơn");
                    emptyData();
                    loadAllData();
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã phiếu đặt mới
                int? maPhieuDatMoi = null;
                if (!string.IsNullOrWhiteSpace(txtMaPhieuDat.Text))
                {
                    maPhieuDatMoi = int.Parse(txtMaPhieuDat.Text);
                }

                // Lấy mã hóa đơn hiện tại
                string maHoaDon = lblMaHoaDonIP.Text;

                // Kiểm tra nếu mã hóa đơn đã được chọn
                if (maHoaDon == "[MaHoaDon]")
                {
                    Notification_Helpers.ThongBaoLoi(this, "Vui lòng chọn hóa đơn để sửa");
                    return;
                }

                // Tạo đối tượng HoaDon và gọi hàm sửa
                HoaDon tmp = new HoaDon(maPhieuDatMoi.GetValueOrDefault()); // Chỉ truyền maPhieuDatMoi nếu có
                bool result = tmp.SuaHoaDon(dbConn, maHoaDon, maPhieuDatMoi);

                if (result)
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Sửa hóa đơn thành công");
                    emptyData();
                    loadAllData(); // Tải lại dữ liệu sau khi sửa thành công
                }
                else
                {
                    Notification_Helpers.ThongBaoLoi(this, "Không thể sửa hóa đơn");
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void btnTinhTongTien_Click(object sender, EventArgs e)
        {
            // Lấy mã phiếu đặt từ textbox
            int maPhieuDat;
            if (!int.TryParse(txtMaPhieuDat.Text, out maPhieuDat))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu đặt hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Khởi tạo đối tượng DBConnect và HoaDon
                DBConnect dbConn = new DBConnect();
                HoaDon hoaDon = new HoaDon(maPhieuDat);

                // Gọi hàm tính tổng tiền tạm thời
                decimal tongTienTamThoi = hoaDon.TinhTongTienTamThoi(dbConn);

                // Hiển thị tổng tiền tạm thời trên label
                lblTongTienIP.Text = tongTienTamThoi.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaPhieuDat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
