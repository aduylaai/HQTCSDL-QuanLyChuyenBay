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
    public partial class frmThongTinCaNhan : Form
    {
        DBConnect dbConn;
        public frmThongTinCaNhan(DBConnect _dbConn)
        {
            InitializeComponent();

            dbConn = _dbConn;
        }
    }

    //Load thong tin khach hang len day.
    // Nho Apply phan quyen ==>  Dang nhap bang tai khoan duoc cap ==> phan quyen trong sql
    // Cac chuc nang: xem thong tin, sua thong tin, xem thong tin hanhkhach da dat cho boi user nay
   

}
