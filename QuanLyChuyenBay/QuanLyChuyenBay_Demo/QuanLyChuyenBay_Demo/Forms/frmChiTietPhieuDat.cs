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


namespace QuanLyChuyenBay_Demo.Forms
{
    public partial class frmChiTietPhieuDat : Form
    {
        private DBConnect dbConn;
        private PhieuDat phieuDat;

        public frmChiTietPhieuDat(DBConnect dbConn)
        {
            InitializeComponent();
            this.dbConn = dbConn;


        }
        

        private void frmChiTietPhieuDat_Load(object sender, EventArgs e)
        {
            loadCboMaVe();
            loadCboMaChuyenBay();
        }
        

        private void loadCboMaVe()
        {
            dbConn.openConnect();
            string cauTruyVan = "select mave from ve where mattv=1";
            FIllData.fillDataCbo(cboVe, dbConn,cauTruyVan,"mave","mave");
            dbConn.closeConnect();
        }
        private void loadCboMaChuyenBay()
        {
            dbConn.openConnect();
            string cauTruyVan = "select machuyenbay from chuyenbay ";
            FIllData.fillDataCbo(cboChuyenBay, dbConn, cauTruyVan, "machuyenbay", "machuyenbay");
            dbConn.closeConnect();
        }
        private bool KiemTraThongTin()
        {
            if (cboChuyenBay.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn chuyến bay!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboVe.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn vé!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnThemVe_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCapNhatPhieuDat_Click(object sender, EventArgs e)
        {
            
        }
    }
}
