using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Model
{
    class ChiTietHoaDon
    {
        public string mahoadon { get; set; }
        public string mathangma { get; set; }
        public int soluong { get; set; }
        public string gia { get; set; }
        public ChiTietHoaDon(string mahoadon , string mathangma , int soluong , string gia)
        {
            this.mahoadon = mahoadon;
            this.mathangma = mathangma;
            this.soluong = soluong;
            this.gia = gia;
        }
    }
}
