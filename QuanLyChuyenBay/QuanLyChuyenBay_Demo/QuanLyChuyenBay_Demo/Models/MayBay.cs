using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay_Demo.Models
{
    public class MayBay
    {
        public string TenMayBay { get; set; }
        public int SucChuaToiDa { get; set; }
        public MayBay(string pTenMayBay, int pSucChuaToiDa)
        {
            TenMayBay = pTenMayBay;
            SucChuaToiDa = pSucChuaToiDa;
        }
    }
}
