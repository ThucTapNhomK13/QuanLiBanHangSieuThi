using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Model
{
    public class NhanVien
    {
        public string manhanvien { get; set; }
        public string hoten { get; set; }
        public string quequan { get; set; }
        public string diachi { get; set; }
        public string gioitinh { get; set; }
        public string tongiao { get; set; }
        public string cmtnd { get; set; }
        public DateTime ngaysinh { get; set; }   
        public string luong { get; set; } 
        public string chucvu { get; set; }
        public string gianhangma { get; set; }    
        public string sdt { get; set; }
        public NhanVien(string manhanvien , string hoten , string quequan , string diachi ,
            string gioitinh , string tongiao ,string cmtnd , DateTime ngaysinh , string luon ,
            string chucvu, string gianhangma , string sdt)
        {
            this.manhanvien = manhanvien;
            this.hoten = hoten;
            this.quequan = quequan;
            this.diachi = diachi;
            this.gioitinh = gioitinh;
            this.tongiao = tongiao;
            this.cmtnd = cmtnd;
            this.ngaysinh = ngaysinh;
            this.luong = luong;
            this.chucvu = chucvu;
            this.gianhangma = gianhangma;
            this.sdt = sdt;

        }
    }
}
