using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyChuyenBay_Demo.Helpers;
using QuanLyChuyenBay_Demo.Models;
using static System.ComponentModel.Design.ObjectSelectorEditor;


namespace QuanLyChuyenBay_Demo.Forms
{
    public partial class frmQuanLyVe : Form
    {
        private DBConnect dbConn;
        public frmQuanLyVe(DBConnect dbConn)
        {
            InitializeComponent();
            this.dbConn = dbConn;
        }

        private void frmQuanLyVe_Load(object sender, EventArgs e)
        {
            loadAllData();
            
        }

        private void loadAllData()
        {
            LoadCBO();
            FIllData.fillDataGridView(dataGridViewDanhSachVe, dbConn, "select MaVe,h.HoTen,t.TenTTV from trangthaive t, ve v,HanhKhach h where v.MaHanhKhach=h.MaHanhKhach and v.mattv=t.mattv", "Ve");
            FIllData.fillDataGridView(dataGridViewChiTietVe, dbConn, " SELECT cv.MaVe, cv.MaChuyenBay, cv.NgayDi, cv.NgayDen, hg.TenHangGhe FROM ChiTietVe cv JOIN HangGhe hg ON cv.MaHangGhe = hg.MaHangGhe ", "ChiTietVe");



        }
        
        private void LoadCBO()
        {
            // Load dữ liệu cho cboHangHangKhong từ bảng HangHangKhong
            FIllData.fillDataCbo(cboMaChuyenBay, dbConn, "SELECT * FROM ChuyenBay", "MaChuyenBay", "MaChuyenBay");

            // Load dữ liệu cho cboTrangThai từ bảng TrangThaiChuyenBay
            FIllData.fillDataCbo(cboMaHangGhe, dbConn, "SELECT * FROM HangGhe", "TenHangGhe", "MaHangGhe");

            // Load dữ liệu cho cboTenLoTrinh từ bảng LoTrinh
            FIllData.fillDataCbo(cboTenHanhKhach, dbConn, "SELECT * FROM HanhKhach", "HoTen", "MaHanhKhach");

            // Load dữ liệu cho cboTenmaybay từ bảng MayBay
            FIllData.fillDataCbo(cboTrangthaive, dbConn, "SELECT * FROM TrangThaiVe", "TenTTV", "MaTTV");
        }
        private void dataGridViewDanhSachVe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra chắc chắn rằng chúng ta không click header
            {
                ClearControls();
                // Lấy mã vé từ cột đầu tiên của dòng đã chọn (ví dụ: "MaVe")
                int maVe = Convert.ToInt32(dataGridViewDanhSachVe.Rows[e.RowIndex].Cells["MaVe"].Value);

                // Truy vấn và cập nhật thông tin mã vé lên các điều khiển
                dbConn.openConnect();

                // Lấy thông tin vé để điền vào các controls
                string cauTruyVan = @"SELECT v.MaVe, h.HoTen, t.TenTTV 
                               FROM Ve v
                               JOIN HanhKhach h ON v.MaHanhKhach = h.MaHanhKhach
                               JOIN TrangThaiVe t ON v.MaTTV = t.MaTTV
                               WHERE v.MaVe = @MaVe";

                SqlCommand cmd = new SqlCommand(cauTruyVan, dbConn.conn);
                cmd.Parameters.AddWithValue("@MaVe", maVe);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Cập nhật thông tin lên các điều khiển
                    lblMaVeoutput.Text = reader["MaVe"].ToString();

                    // Gán tên khách hàng vào cboTenHanhKhach
                    string hoTen = reader["HoTen"].ToString();
                    int index = cboTenHanhKhach.FindStringExact(hoTen);  // Tìm kiếm chính xác trong ComboBox
                    if (index >= 0)
                    {
                        cboTenHanhKhach.SelectedIndex = index;
                    }

                    // Gán trạng thái vé vào cboTrangthaive
                    string tenTrangThaiVe = reader["TenTTV"].ToString();
                    int trangThaiIndex = cboTrangthaive.FindStringExact(tenTrangThaiVe);  // Tìm kiếm chính xác trong ComboBox
                    if (trangThaiIndex >= 0)
                    {
                        cboTrangthaive.SelectedIndex = trangThaiIndex;
                    }
                }

                reader.Close();

                // Cập nhật dữ liệu chi tiết vé vào DataGridView ChiTietVe
                string chiTietCauTruyVan = @"SELECT cv.MaVe, cv.MaChuyenBay, cv.NgayDi, cv.NgayDen, hg.TenHangGhe
                                    FROM ChiTietVe cv
                                    JOIN HangGhe hg ON cv.MaHangGhe = hg.MaHangGhe
                                    WHERE cv.MaVe = @MaVe";

                SqlDataAdapter adapter = new SqlDataAdapter(chiTietCauTruyVan, dbConn.conn);
                adapter.SelectCommand.Parameters.AddWithValue("@MaVe", maVe);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Gán dữ liệu vào DataGridView ChiTietVe
                dataGridViewChiTietVe.DataSource = dt;

                dbConn.closeConnect();
            }
        }

        private void dataGridViewChiTietVe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra chắc chắn rằng chúng ta không click vào header
            {
                // Lấy mã vé từ cột đầu tiên của dòng đã chọn (ví dụ: "MaVe")
                int maVe = Convert.ToInt32(dataGridViewChiTietVe.Rows[e.RowIndex].Cells["MaVe"].Value);

                // Truy vấn và cập nhật thông tin chi tiết vé lên các điều khiển
                dbConn.openConnect();

                // Lấy thông tin chuyến bay và hạng ghế từ dòng chi tiết vé đã chọn
                string cauTruyVan = @"SELECT cv.MaChuyenBay, cv.NgayDi, cv.NgayDen, hg.TenHangGhe
                               FROM ChiTietVe cv
                               JOIN HangGhe hg ON cv.MaHangGhe = hg.MaHangGhe
                               WHERE cv.MaVe = @MaVe";

                SqlCommand cmd = new SqlCommand(cauTruyVan, dbConn.conn);
                cmd.Parameters.AddWithValue("@MaVe", maVe);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Gán tên khách hàng vào cboTenHanhKhach
                    string maCB = reader["MaChuyenBay"].ToString();
                    int index = cboMaChuyenBay.FindStringExact(maCB);  // Tìm kiếm chính xác trong ComboBox
                    if (index >= 0)
                    {
                        cboMaChuyenBay.SelectedIndex = index;
                    }

                    // Gán trạng thái vé vào cboTrangthaive
                    string Hangghe = reader["TenHangGhe"].ToString();
                    int trangThaiIndex = cboMaHangGhe.FindStringExact(Hangghe);  // Tìm kiếm chính xác trong ComboBox
                    if (trangThaiIndex >= 0)
                    {
                        cboMaHangGhe.SelectedIndex = trangThaiIndex;
                    }


                    // Cập nhật Ngày Đi và Ngày Đến
                    dTPNgayDi.Value = Convert.ToDateTime(reader["NgayDi"]);
                    dTPNgayDen.Value = Convert.ToDateTime(reader["NgayDen"]);

                    // Cập nhật Hạng Ghế

                }

                reader.Close();
                dbConn.closeConnect();
            }
        }
        private void ClearControls()
        {
            // Xóa dữ liệu trên các điều khiển
            lblMaVeoutput.Text = string.Empty;
            cboTenHanhKhach.SelectedIndex = -1; // Reset ComboBox TenHanhKhach
            cboTrangthaive.SelectedIndex = -1; // Reset ComboBox TrangThaiVe
            cboMaChuyenBay.SelectedIndex = -1; // Reset ComboBox MaChuyenBay
            cboMaHangGhe.SelectedIndex = -1; // Reset ComboBox HangGhe
            dTPNgayDi.Value = DateTime.Now; // Reset DateTimePicker NgayDi
            dTPNgayDen.Value = DateTime.Now; // Reset DateTimePicker NgayDen
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu nhập vào
                if (cboTenHanhKhach.SelectedIndex == -1 ||
                    cboMaChuyenBay.SelectedIndex == -1 ||
                    cboMaHangGhe.SelectedIndex == -1)
                {
                    Notification_Helpers.ThongBaoLoi(this, "Vui lòng điền đầy đủ thông tin.");
                    return;
                }

                // Lấy dữ liệu từ ComboBox
                int maHK = Convert.ToInt32(FIllData.GetRealDataOfComboBox(cboTenHanhKhach));
                int maChuyenBay = Convert.ToInt32(FIllData.GetRealDataOfComboBox(cboMaChuyenBay));
                int maHangGhe = Convert.ToInt32(FIllData.GetRealDataOfComboBox(cboMaHangGhe));
                DateTime ngayDi = dTPNgayDi.Value;
                DateTime ngayDen = dTPNgayDen.Value;

                // Tạo đối tượng Ve
                Ve veMoi = new Ve(maHK, maChuyenBay, ngayDi, ngayDen, maHangGhe);

                // Gọi phương thức TaoVe để tạo vé và kiểm tra kết quả
                //bool result = veMoi.TaoVe(dbConn);
                if(veMoi.TaoVe(dbConn))
                    {
                    Notification_Helpers.ThongBaoThanhCong(this, "Thêm ve");
                    ClearControls();
                    loadAllData();
                }
                else
                {
                    Notification_Helpers.ThongBao(this, "Thêm chuyến bay thất bại");
                }
               
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ ComboBox
                int maHK = Convert.ToInt32(FIllData.GetRealDataOfComboBox(cboTenHanhKhach));
                int maChuyenBay = Convert.ToInt32(FIllData.GetRealDataOfComboBox(cboMaChuyenBay));
                int maHangGhe = Convert.ToInt32(FIllData.GetRealDataOfComboBox(cboMaHangGhe));
                DateTime ngayDi = dTPNgayDi.Value;
                DateTime ngayDen = dTPNgayDen.Value;

                // Tạo đối tượng Ve
                Ve veMoi = new Ve(maHK, maChuyenBay, ngayDi, ngayDen, maHangGhe);
                int mave = 0;
                if (lblMaVeoutput.Text != "[Mã vé]")
                {
                    mave = int.Parse(CacHamKiemTra.KiemTraChuoiRong(lblMaVeoutput.Text));
                }
                else
                {
                    Notification_Helpers.ThongBaoLoi(this, "Vui lòng chọn chuyến bay để xóa");
                }

                if (veMoi.XoaVe(dbConn, mave))
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Xóa chuyến bay");
                    ClearControls();
                    loadAllData();
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }
       

        private void dataGridViewDanhSachVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearControls();
            fillData(dataGridViewDanhSachVe.Rows[e.RowIndex]);
        }
        private void fillData(DataGridViewRow rows)
        {
            lblMaVeoutput.Text = FIllData.GetValueDGVRows(rows, "MaVe");



            cboTenHanhKhach.Text = FIllData.GetValueDGVRows(rows, "HoTen");

            cboTrangthaive.Text = FIllData.GetValueDGVRows(rows, "TenTTV");

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            { // Lấy dữ liệu từ ComboBox

                int maHK = Convert.ToInt32(FIllData.GetRealDataOfComboBox(cboTenHanhKhach));
                int maChuyenBay = Convert.ToInt32(FIllData.GetRealDataOfComboBox(cboMaChuyenBay));
                int maHangGhe = Convert.ToInt32(FIllData.GetRealDataOfComboBox(cboMaHangGhe));
                DateTime ngayDi = dTPNgayDi.Value;
                DateTime ngayDen = dTPNgayDen.Value;

                // Tạo đối tượng Ve
                Ve veMoi = new Ve(maHK, maChuyenBay, ngayDi, ngayDen, maHangGhe);
                int mave = int.Parse(lblMaVeoutput.Text);
                if (veMoi.SuaTTVe(dbConn, mave))
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Sua ve");
                    ClearControls();
                    loadAllData();
                }
                else
                {
                    Notification_Helpers.ThongBao(this, "Sua ve thất bại");
                }
            }
            
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }
    }
    
}

