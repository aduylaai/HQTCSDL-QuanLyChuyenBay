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
       

    




        private void btnCapNhatPhieuDat_Click(object sender, EventArgs e)
        {
            
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
    }
}
