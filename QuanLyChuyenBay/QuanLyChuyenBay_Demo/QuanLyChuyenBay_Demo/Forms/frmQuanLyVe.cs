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
            FIllData.fillDataGridView(dataGridViewDanhSachVe, dbConn, "SELECT v.MaVe, ISNULL(h.HoTen, 'Chưa có hành khách') AS HoTen, t.TenTTV FROM Ve v LEFT JOIN HanhKhach h ON v.MaHanhKhach = h.MaHanhKhach LEFT JOIN TrangThaiVe t ON v.MaTTV = t.MaTTV;\r\n", "Ve");
            FIllData.fillDataGridView(dataGridViewChiTietVe, dbConn, " SELECT v.MaVe, ctv.MaChuyenBay, ctv.MaHangGhe, hg.TenHangGhe, cb.NgayGioDi, cb.NgayGioDen, hhk.TenHangHangKhong FROM Ve v JOIN ChiTietVe ctv ON v.MaVe = ctv.MaVe JOIN ChuyenBay cb ON ctv.MaChuyenBay = cb.MaChuyenBay JOIN HangHangKhong hhk ON cb.MaHangHangKhong = hhk.MaHangHangKhong JOIN HangGhe hg ON ctv.MaHangGhe = hg.MaHangGhe", "ChiTietVe");



        }
        
        private void LoadCBO()
        {
            // Load dữ liệu cho cboHangHangKhong từ bảng HangHangKhong
            FIllData.fillDataCbo(cboMaChuyenBay, dbConn, "SELECT * FROM ChuyenBay", "MaChuyenBay", "MaChuyenBay");

            // Load dữ liệu cho cboTrangThai từ bảng TrangThaiChuyenBay
            FIllData.fillDataCbo(cboMaHangGhe, dbConn, "SELECT * FROM HangGhe", "TenHangGhe", "MaHangGhe");

            // Load dữ liệu cho cboTenLoTrinh từ bảng LoTrinh
            FIllData.fillDataCbo(cboTenHanhKhach, dbConn, "SELECT * FROM HanhKhach", "HoTen", "MaHanhKhach");
            // Thêm giá trị "Chưa có hành khách" vào ComboBox
            if (!cboTenHanhKhach.Items.Contains("Chưa có hành khách"))
            {
                cboTenHanhKhach.Items.Insert(0, "Chưa có hành khách");
            }
            // Load dữ liệu cho cboTenmaybay từ bảng MayBay
            FIllData.fillDataCbo(cboTrangthaive, dbConn, "SELECT * FROM TrangThaiVe", "TenTTV", "MaTTV");

        }

       

        private void dataGridViewDanhSachVe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra chắc chắn rằng không click vào header
            {
                ClearControls(); // Xóa dữ liệu hiện tại

                // Lấy mã vé từ dòng được chọn
                int maVe = Convert.ToInt32(dataGridViewDanhSachVe.Rows[e.RowIndex].Cells["MaVe"].Value);

                // Mở kết nối
                dbConn.openConnect();

                // Truy vấn thông tin vé (bao gồm cả hành khách và trạng thái vé)
                string cauTruyVan = @"SELECT v.MaVe, 
                              ISNULL(h.HoTen, 'Chưa có hành khách') AS HoTen, 
                              t.TenTTV
                       FROM Ve v 
                       LEFT JOIN HanhKhach h ON v.MaHanhKhach = h.MaHanhKhach 
                       LEFT JOIN TrangThaiVe t ON v.MaTTV = t.MaTTV
                       WHERE v.MaVe = @MaVe"; // Sử dụng điều kiện WHERE để lọc theo MaVe

                SqlCommand cmd = new SqlCommand(cauTruyVan, dbConn.conn);
                cmd.Parameters.AddWithValue("@MaVe", maVe);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) // Nếu có dữ liệu trả về
                {
                    // Gán Mã vé vào label
                    lblMaVeoutput.Text = reader["MaVe"].ToString();

                    // Gán tên hành khách vào ComboBox
                    string hoTen = reader["HoTen"].ToString();

                    // Kiểm tra nếu tên hành khách là "Chưa có hành khách"
                    if (hoTen == "Chưa có hành khách")
                    {
                        // Nếu "Chưa có hành khách", chọn nó trong ComboBox
                        if (!cboTenHanhKhach.Items.Contains("Chưa có hành khách"))
                        {
                            cboTenHanhKhach.Items.Insert(0, "Chưa có hành khách");
                        }
                        cboTenHanhKhach.SelectedIndex = cboTenHanhKhach.Items.IndexOf("Chưa có hành khách");
                    }
                    else
                    {
                        // Nếu có hành khách, tìm tên hành khách và chọn trong ComboBox
                        int indexTenHK = cboTenHanhKhach.FindStringExact(hoTen);
                        if (indexTenHK >= 0)
                        {
                            cboTenHanhKhach.SelectedIndex = indexTenHK; // Gán tên hành khách vào ComboBox
                        }
                    }

                    // Gán trạng thái vé vào ComboBox
                    string tenTTV = reader["TenTTV"].ToString();
                    int indexTTV = cboTrangthaive.FindStringExact(tenTTV);
                    if (indexTTV >= 0)
                    {
                        cboTrangthaive.SelectedIndex = indexTTV;  // Gán trạng thái vé vào ComboBox
                    }
                }
                reader.Close();

                // Truy vấn chi tiết vé để hiển thị vào DataGridView "Chi Tiết Vé"
                string chiTietCauTruyVan = @"SELECT ctv.MaVe, ctv.MaChuyenBay, ctv.MaHangGhe, hg.TenHangGhe, cb.NgayGioDi, cb.NgayGioDen, hhk.TenHangHangKhong
                              FROM ChiTietVe ctv
                              JOIN ChuyenBay cb ON ctv.MaChuyenBay = cb.MaChuyenBay
                              JOIN HangHangKhong hhk ON cb.MaHangHangKhong = hhk.MaHangHangKhong
                              JOIN HangGhe hg ON ctv.MaHangGhe = hg.MaHangGhe
                              WHERE ctv.MaVe = @MaVe";

                SqlDataAdapter adapter = new SqlDataAdapter(chiTietCauTruyVan, dbConn.conn);
                adapter.SelectCommand.Parameters.AddWithValue("@MaVe", maVe);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewChiTietVe.DataSource = dt;

                dbConn.closeConnect();
            }
        }






        private void dataGridViewChiTietVe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra chắc chắn rằng không click vào header
            {
                // Lấy thông tin từ dòng được chọn
                DataGridViewRow selectedRow = dataGridViewChiTietVe.Rows[e.RowIndex];
                string maChuyenBay = selectedRow.Cells["MaChuyenBay"].Value.ToString();
                string tenHangGhe = selectedRow.Cells["TenHangGhe"].Value.ToString();

                // Gán thông tin vào các ComboBox
                int indexMaCB = cboMaChuyenBay.FindStringExact(maChuyenBay);
                if (indexMaCB >= 0) cboMaChuyenBay.SelectedIndex = indexMaCB;

                int indexHangGhe = cboMaHangGhe.FindStringExact(tenHangGhe);
                if (indexHangGhe >= 0) cboMaHangGhe.SelectedIndex = indexHangGhe;
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
           
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

       

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu nhập vào (chỉ kiểm tra các trường bắt buộc khác ngoài MaHanhKhach)
                if (cboMaChuyenBay.SelectedIndex == -1 || cboMaHangGhe.SelectedIndex == -1)
                {
                    Notification_Helpers.ThongBaoLoi(this, "Vui lòng điền đầy đủ thông tin bắt buộc (Chuyến bay và Hạng ghế).");
                    return;
                }

                // Lấy mã hành khách (có thể null)
                int? maHK = null;  // Khai báo maHK là kiểu int? để có thể chứa null
                if (cboTenHanhKhach.SelectedIndex != -1)
                {
                    maHK = Convert.ToInt32(FIllData.GetRealDataOfComboBox(cboTenHanhKhach));
                }

                // Lấy mã chuyến bay và mã hạng ghế
                int maChuyenBay = Convert.ToInt32(FIllData.GetRealDataOfComboBox(cboMaChuyenBay));
                int maHangGhe = Convert.ToInt32(FIllData.GetRealDataOfComboBox(cboMaHangGhe));

                // Tạo đối tượng Vé
                Ve veMoi = new Ve(maHK, maChuyenBay, maHangGhe);

                // Thực hiện thêm vé
                if (veMoi.TaoVe(dbConn))
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Thêm vé thành công.");
                    ClearControls();
                    loadAllData();
                }
                else
                {
                    Notification_Helpers.ThongBao(this, "Thêm vé thất bại.");
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
             
                int mave = 0;
                if (lblMaVeoutput.Text != "[Mã vé]")
                {
                    mave = int.Parse(CacHamKiemTra.KiemTraChuoiRong(lblMaVeoutput.Text));
                }
                
                

                Ve veMoi = new Ve();

                if (veMoi.XoaVe(dbConn, mave))
                {
                    Notification_Helpers.ThongBaoThanhCong(this, "Xóa vé");
                    ClearControls();
                    loadAllData();
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }
       

        //private void dataGridViewDanhSachVe_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    ClearControls();
        //    fillData(dataGridViewDanhSachVe.Rows[e.RowIndex]);
        //}
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
           

                // Tạo đối tượng Ve
                Ve veMoi = new Ve(maHK, maChuyenBay, maHangGhe);
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

