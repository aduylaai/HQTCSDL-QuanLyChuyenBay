using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay_Demo.Models
{
    public class ChuyenBay
    {
        public float GiaBay { get; set; }
        public ChuyenBay(float pGiaBay)
        {
            GiaBay = pGiaBay;
        }
    }
}
