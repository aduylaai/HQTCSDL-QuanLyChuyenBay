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

namespace QuanLyChuyenBay_Demo.Forms.User
{
    public partial class frmHoaDonUser : Form
    {
        DBConnect dbConn;
        public frmHoaDonUser(DBConnect _dbConn)
        {
            InitializeComponent();

            dbConn = _dbConn;
        }

        //Cac chuc nang: xem danh sach hoa don
        //Thanh toan hoa don

    }
}
