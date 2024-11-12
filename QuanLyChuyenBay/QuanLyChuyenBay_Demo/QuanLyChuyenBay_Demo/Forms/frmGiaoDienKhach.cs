using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyChuyenBay_Demo.Forms.User;
using QuanLyChuyenBay_Demo.Helpers;

namespace QuanLyChuyenBay_Demo.Forms
{
    public partial class frmGiaoDienKhach : Form
    {
        frmThongTinCaNhan frm_thongTinCaNhan;
        public frmGiaoDienKhach()
        {
            InitializeComponent();
            // Đảm bảo flowLayoutPanel2 nằm dọc bên trái và chiếm toàn bộ chiều cao
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.AutoSize = false;
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new System.Drawing.Size(1115, 580); // Kích thước mong muốn
            this.MaximumSize = new System.Drawing.Size(1115, 580); // Kích thước mong muốn
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Notification_Helpers.ThongBaoThoat(this);
        }

        bool sidebar_Expand = true;
        private void sidebarTrans_Tick(object sender, EventArgs e)
        {
            if (sidebar_Expand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 59)
                {
                    sidebar_Expand = false;
                    sidebarTrans.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 225)
                {
                    sidebar_Expand = true;
                    sidebarTrans.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTrans.Start();
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            if (frm_thongTinCaNhan == null)
            {
                frm_thongTinCaNhan = new frmThongTinCaNhan();
                frm_thongTinCaNhan.FormClosed += frm_thongTinCaNhan_FormClose;
                frm_thongTinCaNhan.MdiParent = this;
                frm_thongTinCaNhan.Dock = DockStyle.Fill;
                frm_thongTinCaNhan.Show();
            }
            else
            {
                frm_thongTinCaNhan.Activate();
            }
        }

        private void frm_thongTinCaNhan_FormClose(object sender, FormClosedEventArgs e)
        {
            frm_thongTinCaNhan = null;
        }
    }
}
