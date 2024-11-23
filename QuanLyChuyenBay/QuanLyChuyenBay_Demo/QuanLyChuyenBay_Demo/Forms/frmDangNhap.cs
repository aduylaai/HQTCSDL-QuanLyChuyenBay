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
        //DBConnect dbConn = new DBConnect("ADUYLAAI", "QuanLyChuyenBay","sa","123");
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
                tk = new TaiKhoan(txtUser.Text, txtPass.Text);

                DBConnect conn = new DBConnect("ADUYLAAI", "QuanLyBanVeMayBay", "Admin", "Admin@123"); //Thay bằng user chỉ kiểm tra TaiKhoan

                Form form;
                if (tk.taiKhoan == "sa")
                {
                    conn = new DBConnect("ADUYLAAI", "QuanLyBanVeMayBay", "sa", "123");
                    form = new frmMain(conn);
                    form.Show();
                }
                if (tk.taiKhoan == "Admin")
                {
                    if (conn.ktraTaiKhoan("TaiKhoan", tk.taiKhoan, tk.MatKhau))
                    {
                        form = new frmMain(conn);
                        form.Show();

                    }
                    else
                    {
                        Notification_Helpers.ThongBao(this, "Sai Mật Khẩu");
                    }
                }
                else
                {
                    if (conn.ktraTaiKhoan("TaiKhoan", tk.taiKhoan, tk.MatKhau))
                    {
                        conn = new DBConnect("ADUYLAAI", "QuanLyBanVeMayBay",tk.taiKhoan ,tk.MatKhau );
                        form = new frmGiaoDienKhach(tk, conn);
                        form.Show();

                    }
                    else
                    {
                        Notification_Helpers.ThongBao(this, "Sai Mật Khẩu");
                    }
                }
            }
            catch (Exception ex)
            {
                Notification_Helpers.ThongBaoLoi(this, ex.Message);
            }
        }

        // Kiem tra dang nhap ==> neu la admin thi ref toi form main.
        // Neu la user thi ref toi frmGiaoDienKhachHang
    }
}
