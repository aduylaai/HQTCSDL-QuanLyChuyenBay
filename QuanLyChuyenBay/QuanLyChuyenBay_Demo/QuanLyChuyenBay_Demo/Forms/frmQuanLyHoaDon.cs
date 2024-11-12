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
    public partial class frmQuanLyHoaDon : Form
    {
        private DBConnect dbConn;
        public frmQuanLyHoaDon(DBConnect dbConn)
        {
            InitializeComponent();
            this.dbConn = dbConn;
        }

        private void frmQuanLyHoaDon_Load(object sender, EventArgs e)
        {

        }
        private void dgvInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

    }
}
