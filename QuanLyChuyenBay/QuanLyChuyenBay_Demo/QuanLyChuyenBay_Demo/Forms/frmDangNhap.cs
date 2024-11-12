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

namespace QuanLyChuyenBay_Demo.Forms
{
    public partial class frmDangNhap : Form
    {
        DBConnect dbConn = new DBConnect("ADUYLAAI","QuanLyChuyenBay");
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Notification_Helpers.ThongBaoThoat(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }
    }
}
