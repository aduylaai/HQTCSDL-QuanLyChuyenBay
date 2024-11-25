using QuanLyChuyenBay_Demo.Helpers;
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
    public partial class frmChiTietPhieuDat : Form
    {
        private DBConnect dbConn;

        public frmChiTietPhieuDat(DBConnect dbConn)
        {
            InitializeComponent();
            this.dbConn = dbConn;


        }
        

        private void frmChiTietPhieuDat_Load(object sender, EventArgs e)
        {
            loadCboTenLoTrinh();
        }
        private void loadCboTenLoTrinh()
        {
            dbConn.openConnect();
            string cauTruyVan = "SELECT tenlotrinh FROM lotrinh"; // Giả sử bảng lotrinh có cột tenlotrinh
            FIllData.fillDataCbo(cboTenLoTrinh, dbConn, cauTruyVan, "tenlotrinh", "tenlotrinh");
            dbConn.closeConnect();
        }

        
        private void loadCboMaChuyenBay(string tenLoTrinh)
        {
            dbConn.openConnect();

            // Sử dụng "tenlotrinh" để truy vấn bảng "chuyenbay" liên kết với "lotrinh"
            string cauTruyVan = "SELECT chuyenbay.machuyenbay " +
                                 "FROM chuyenbay " +
                                 "JOIN lotrinh ON chuyenbay.MaLoTrinh = lotrinh.MaLoTrinh " +
                                 "WHERE lotrinh.tenlotrinh = @tenLoTrinh";
            SqlCommand cmd = new SqlCommand(cauTruyVan, dbConn.conn);
            cmd.Parameters.AddWithValue("@tenLoTrinh", tenLoTrinh); // Thêm tham số để lọc theo tên lộ trình

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Clear và thêm các chuyến bay vào cboChuyenBay
            cboChuyenBay.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                cboChuyenBay.Items.Add(row["machuyenbay"].ToString());
            }

            dbConn.closeConnect();
        }
       

    




        

        private void cboTenLoTrinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenLoTrinh = cboTenLoTrinh.SelectedItem.ToString();
            loadCboMaChuyenBay(tenLoTrinh);
        }
        private void loadVeByChuyenBay(string maChuyenBay)
        {
            dbConn.openConnect();

            // Lấy vé thuộc mã chuyến bay từ bảng Ve
            string cauTruyVan = "SELECT ctv.mave FROM chitietve ctv JOIN ve v ON ctv.mave = v.mave  WHERE ctv.machuyenbay = @maChuyenBay  AND v.mattv = 1"; // Sửa cột "machuyenbay" thành "MaChuyenBay"
            SqlCommand cmd = new SqlCommand(cauTruyVan, dbConn.conn);
            cmd.Parameters.AddWithValue("@maChuyenBay", maChuyenBay); // Thêm tham số để lọc theo mã chuyến bay

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Clear và thêm vé vào cboVe
            cboVe.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                cboVe.Items.Add(row["mave"].ToString());
            }

            dbConn.closeConnect();
        }

        private void cboChuyenBay_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi chọn mã chuyến bay, load vé thuộc chuyến bay đó
            string maChuyenBay = cboChuyenBay.SelectedItem.ToString();
            loadVeByChuyenBay(maChuyenBay);
        }
        private void loadCboVe(string maChuyenBay)
        {
            dbConn.openConnect();
            string cauTruyVan = "SELECT ctv.mave FROM chitietve ctv JOIN ve v ON ctv.mave = v.mave  WHERE ctv.machuyenbay = @maChuyenBay  AND v.mattv = 1";
            SqlCommand cmd = new SqlCommand(cauTruyVan, dbConn.conn);
            cmd.Parameters.AddWithValue("@maChuyenBay", maChuyenBay); // Thêm tham số để lọc theo mã chuyến bay

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Clear và thêm các vé vào cboVe
            cboVe.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                cboVe.Items.Add(row["mave"].ToString());
            }
            dbConn.closeConnect();
        }
        public void SetMaPhieuDat(int maPhieuDat)
        {
            lblMaphieudat.Text = maPhieuDat.ToString(); // Gán giá trị cho label
            LoadChiTietPhieuDat(maPhieuDat);
        }

        private void btnThemVe_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboVe.SelectedItem == null)
                {
                    Notification_Helpers.ThongBaoLoi(this, "Vui lòng chọn vé.");
                    return;
                }

                if (string.IsNullOrEmpty(lblMaphieudat.Text))
                {
                    Notification_Helpers.ThongBaoLoi(this, "Mã phiếu đặt không hợp lệ.");
                    return;
                }

                int maPhieuDat = int.Parse(lblMaphieudat.Text);
                int maVe = int.Parse(cboVe.SelectedItem.ToString());

                // Kiểm tra nếu DataGridView chưa có cột thì thêm cột
                if (dataGridViewChiTietPhieuDat.Columns.Count == 0)
                {
                    dataGridViewChiTietPhieuDat.Columns.Add("MaPhieuDat", "Mã Phiếu Đặt");
                    dataGridViewChiTietPhieuDat.Columns.Add("MaVe", "Mã Vé");
                }

                // Thêm vé vào DataGridView
                dataGridViewChiTietPhieuDat.Rows.Add(maPhieuDat, maVe);

                // Tạo đối tượng PhieuDat và gọi phương thức TaoChiTietPhieuDat
                PhieuDat phieuDatMoi = new PhieuDat();
                phieuDatMoi.MaPhieuDat = maPhieuDat;
                phieuDatMoi.mave = maVe;

                if (phieuDatMoi.TaoChiTietPhieuDat(dbConn))
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Thêm vé vào chi tiết phiếu đặt thành công.");
                }
                else
                {
                    Notification_Helpers.ThongBaoLoi(this, "Thêm chi tiết phiếu đặt thất bại.");
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, "Lỗi: " + ex.Message);
            }
        }
        private void LoadChiTietPhieuDat(int maPhieuDat)
        {
            try
            {
                // Kiểm tra nếu DataGridView chưa có cột thì thêm cột
                if (dataGridViewChiTietPhieuDat.Columns.Count == 0)
                {
                    dataGridViewChiTietPhieuDat.Columns.Add("MaPhieuDat", "Mã Phiếu Đặt");
                    dataGridViewChiTietPhieuDat.Columns.Add("MaVe", "Mã Vé");
                }

                // Truy vấn chi tiết phiếu đặt từ cơ sở dữ liệu
                string query = @"SELECT cp.MaVe 
                         FROM ChiTietPhieuDat cp
                         WHERE cp.MaPhieuDat = @MaPhieuDat";

                SqlCommand cmd = new SqlCommand(query, dbConn.conn);
                cmd.Parameters.AddWithValue("@MaPhieuDat", maPhieuDat);

                dbConn.openConnect();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dbConn.closeConnect();

                // Hiển thị thông tin chi tiết phiếu đặt vào DataGridView
                dataGridViewChiTietPhieuDat.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    dataGridViewChiTietPhieuDat.Rows.Add(maPhieuDat, row["MaVe"]);
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, "Lỗi khi tải chi tiết phiếu đặt: " + ex.Message);
            }

        }
        private void ClearComboBoxes()
        {
            // Deselect any selected item in cboTenLoTrinh, if any
            cboTenLoTrinh.Text = "";

            // Deselect any selected item in cboChuyenBay, if any
            cboChuyenBay.Text = "";

            // Deselect any selected item in cboVe, if any
            cboVe.Text = "";
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            // Đóng form hiện tại
            this.Close();

            // Tạo một instance mới của form quản lý phiếu đặt
            frmQuanLyPhieuDat frmQLPhieuDat = new frmQuanLyPhieuDat(dbConn);

            // Hiển thị form quản lý phiếu đặt
            frmQLPhieuDat.Show();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearComboBoxes();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu dòng nào trong DataGridView được chọn
                if (dataGridViewChiTietPhieuDat.SelectedRows.Count == 0)
                {
                    Notification_Helpers.ThongBaoLoi(this, "Vui lòng chọn dòng để xóa.");
                    return;
                }

                // Lấy mã phiếu đặt và mã vé từ DataGridView (Giả sử cột "MaPhieuDat" và "MaVe" chứa thông tin cần thiết)
                int maPhieuDat = 0;
                int mave = 0;

                maPhieuDat = int.Parse(dataGridViewChiTietPhieuDat.SelectedRows[0].Cells["MaPhieuDat"].Value.ToString());
                mave = int.Parse(dataGridViewChiTietPhieuDat.SelectedRows[0].Cells["MaVe"].Value.ToString()); // Giả sử có cột MaVe

                // Kiểm tra mã phiếu đặt và mã vé hợp lệ
                if (maPhieuDat == 0 || mave == 0)
                {
                    Notification_Helpers.ThongBaoLoi(this, "Mã phiếu đặt hoặc mã vé không hợp lệ.");
                    return;
                }

                // Tạo đối tượng PhieuDat và gọi phương thức XoaVeTrongChiTietPhieuDat
                PhieuDat phieuDatMoi = new PhieuDat();
                phieuDatMoi.MaPhieuDat = maPhieuDat;

                // Xóa vé khỏi chi tiết phiếu đặt
                if (phieuDatMoi.XoaVeTrongChiTietPhieuDat(dbConn, maPhieuDat,mave)) // Gọi phương thức với mã vé
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Xóa vé thành công.");

                    // Nạp lại chi tiết phiếu đặt sau khi xóa vé (nếu cần)
                    LoadChiTietPhieuDat(maPhieuDat);
                }
                else
                {
                    Notification_Helpers.ThongBaoLoi(this, "Lỗi khi xóa vé.");
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, "Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra mã phiếu đặt
                int maPhieuDat;
                if (!int.TryParse(lblMaphieudat.Text, out maPhieuDat))
                {
                    Notification_Helpers.ThongBaoLoi(this, "Mã phiếu đặt không hợp lệ.");
                    return;
                }

                // Kiểm tra mã vé từ ComboBox cboVe
                if (cboVe.SelectedItem == null)
                {
                    Notification_Helpers.ThongBaoLoi(this, "Vui lòng chọn mã vé.");
                    return;
                }

                // Lấy mã vé từ ComboBox cboVe
                int maVe = int.Parse(cboVe.Text);

                // Tạo đối tượng PhieuDat
                PhieuDat phieuDat = new PhieuDat();

                // Gọi phương thức sửa vé trong phiếu đặt
                bool isSuccess = phieuDat.SuaVeTrongPhieuDat(dbConn, maPhieuDat,maVe); // Gọi phương thức sửa vé trong phiếu đặt

                // Kiểm tra kết quả
                if (isSuccess)
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Sửa vé thành công.");
                    LoadChiTietPhieuDat(maPhieuDat);

                }
                else
                {
                    Notification_Helpers.ThongBao(this, "Sửa vé thất bại.");
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }
    }
}
