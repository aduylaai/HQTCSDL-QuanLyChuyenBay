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
    public partial class frmQuanLyMayBay : Form
    {
        private DBConnect dbConn;
        public frmQuanLyMayBay(DBConnect dbConn)
        {
            InitializeComponent();
            this.dbConn = dbConn;
        }
    }
}
