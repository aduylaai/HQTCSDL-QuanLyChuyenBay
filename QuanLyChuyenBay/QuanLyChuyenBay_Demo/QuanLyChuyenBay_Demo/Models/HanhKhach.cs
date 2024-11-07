using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay_Demo.Models
{
    public class HanhKhach
    {
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public string QuocTich { get; set; }
        public string NgaySinh { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string CCCD_Passport { get; set; }
        public HanhKhach(string pHoTen, string pDiaChi, string pGioTinh, string pQuocTich, string pNgaySinh, string pSDT, string pEmail, string pCCCD_Passport)
        {
            HoTen = pHoTen;
            DiaChi = pDiaChi;
            GioiTinh = pGioTinh;
            QuocTich = pQuocTich;
            NgaySinh = pNgaySinh;
            SDT = pSDT;
            Email = pEmail;
            CCCD_Passport = pCCCD_Passport;
        }
    }
}
