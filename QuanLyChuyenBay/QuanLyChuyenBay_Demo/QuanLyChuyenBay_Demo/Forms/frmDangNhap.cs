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
    public partial class frmDangNhap : Form
    {
        DBConnect dbConn = new DBConnect("ADUYLAAI","QuanLyChuyenBay");
        TaiKhoan tk;
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
            try
            {
                //Viet ham kiem tra tai khoan o day
                tk = new TaiKhoan(txtUser.Text,txtPass.Text);

                DBConnect conn = new DBConnect("ADUYLAAI", "QuanLyBanVeMayBay",tk.taiKhoan,tk.MatKhau);

                Form form;
                if (tk.taiKhoan == "Admin" || tk.taiKhoan == "sa")
                {
                    form = new frmMain(conn);
                }
                else
                {
                    form = new frmGiaoDienKhach(tk,conn);
                }

                form.Show();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        // Kiem tra dang nhap ==> neu la admin thi ref toi form main.
        // Neu la user thi ref toi frmGiaoDienKhachHang
    }
}
