using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO_Model;
using DAO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_KhachHang
    {
        Connector connector = null;

        public BUS_KhachHang()
        {
            connector = new Connector();
        }

        public DataTable DSKhachHang()
        {
            DataTable tbl = new DataTable();
            try
            {
                tbl = connector.getDataTable("KhachHang");
                connector.closeConnection();
            }
            catch (Exception)
            {

                throw;
            }
            return tbl;
        }

        public bool ThemkH(List<string> kh)
        {
            try
            {
                string str = " '" + kh[0].ToString() + "' , N'" + kh[1].ToString() + "' , '" + kh[2].ToString() +
                    "' , N'" + kh[3].ToString() + "' , '" + kh[4].ToString() + "' , N'" + kh[5].ToString() +
                    "' , '" + kh[6].ToString() + "' ";
                
                connector.openConnection();
                connector.InsertsData("KhachHang", str);
                connector.closeConnection();
            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }

        public bool SuaKh(List<string> kh , string codeId)
        {
            try
            {
                string str = "tenkhachhang = N'" + kh[1].ToString() + "' , ngaysinh = '" + kh[2].ToString() + "' , gioitinh = N'" + kh[3].ToString() + 
                    "' , cmtnd = '" + kh[4].ToString() + "' , diachi = N'" + kh[5].ToString() + "' , sdt = '" + kh[6].ToString() + "' ";
                connector.openConnection();
                connector.ModifyData("KhachHang", str, " makhachhang = '" + codeId + "'");
                connector.closeConnection();
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }

        public bool XoaKh ( string codeId)
        {
            try
            {
                connector.openConnection();
                connector.DeleteData("KhachHang", " makhachhang = '" + codeId + "'");
                connector.closeConnection();
            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }
    }
}
