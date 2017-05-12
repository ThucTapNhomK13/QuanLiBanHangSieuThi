using System;
using System.Collections.Generic;
using System.Data;
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

        public KhachHang() { }

        public KhachHang(DataRow row)
        {
            makhachhang = row["makhachhang"].ToString();
            tenkhachhang = row["tenkhachhang"].ToString();
            ngaysinh = DateTime.Parse(row["ngaysinh"].ToString());
            gioitinh = row["gioitinh"].ToString();
            cmtnd = row["cmtnd"].ToString();
            diachi = row["diachi"].ToString();
            sdt = row["sdt"].ToString();

        }
    }
}
