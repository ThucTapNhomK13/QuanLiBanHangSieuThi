using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Model
{
    public class KhachHang
    {
        public string makhachhang { get; set; }
        public string tenkhachhang { get; set; }
        public DateTime ngaysinh { get; set; }
        public string gioitinh { get; set; }
        public string cmtnd { get; set; }
        public string diachi { get; set; }
        public string sdt { get; set; }
        public KhachHang (string makhachhang , string tenkhachhang , DateTime ngaysinh , string gioitinh , string cmtnd , string diachi , string sdt)
        {
            this.makhachhang = makhachhang;
            this.tenkhachhang = tenkhachhang;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.cmtnd = cmtnd;
            this.diachi = diachi;
            this.sdt = sdt;
        }
    }
}
