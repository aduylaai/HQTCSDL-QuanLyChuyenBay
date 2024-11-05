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
    public partial class frmQuanLyTaiKhoan : Form
    {
        private DBConnect dbConn;
        public frmQuanLyTaiKhoan(DBConnect dbConn)
        {
            InitializeComponent();
            this.dbConn = dbConn;
        }
    }
}
