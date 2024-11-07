using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay_Demo.Models
{
    public class KhachHang
    {
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string NgaySinh { get; set; }
        public string SDT { get; set; }

        public KhachHang(string pHoTen, string pDiaChi, string pEmail, string pNgaySinh, string pSDT)
        {
            HoTen = pHoTen;
            DiaChi = pDiaChi;
            Email = pEmail;
            NgaySinh = pNgaySinh;
            SDT = pSDT;
        }
    }
}
