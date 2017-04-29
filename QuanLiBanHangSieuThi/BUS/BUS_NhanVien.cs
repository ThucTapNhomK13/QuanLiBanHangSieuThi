using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAO;
using DTO_Model;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
     public class BUS_NhanVien
    {
        Connector connector = null;

        public BUS_NhanVien()
        {
            connector = new Connector();
        }
        public DataTable DSNhanVien()
        {
            DataTable tbl = new DataTable();
            try
            {
                tbl = connector.getDataTable("NhanVien");
                connector.closeConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }            
            return tbl;
        }

        public bool ThemNv(List<string> nv)
        {
            try
            {          
                string str = " '"+nv[0].ToString()+ "' , N'" + nv[1].ToString() + "', N'" + nv[2].ToString() + 
                    "', N'" + nv[3].ToString() + "', N'" + nv[4].ToString() + "', N'" + nv[5].ToString() +
                    "', '" + nv[6].ToString() + "', '" + nv[7].ToString() + "', '" + nv[8].ToString() + 
                    "', N'" + nv[9].ToString() + "', '" + nv[10].ToString() + "', '" + nv[11].ToString() + "' ";
                connector.openConnection();
                connector.InsertsData("NhanVien", str);
                connector.closeConnection();
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }

        public bool XoaNv (string codeId)
        {
            try
            {
                connector.openConnection();
                connector.DeleteData("NhanVien", "manhanvien = '"+ codeId + "'");
                connector.closeConnection();
            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }

        public bool SuaNv (List<string> nv , string codeId)
        {
            try
            {
                string query = "hoten = N'" + nv[1].ToString() + "' , quequan = N'" + nv[2].ToString() + "' , diachi = N'" + nv[3].ToString() +
                    "' , gioitinh = N'" + nv[4].ToString() + "' , tongiao = N'" + nv[5].ToString() + "' , cmtnd = '" + nv[6].ToString() + 
                    "' , ngaysinh = '" + nv[7].ToString() + "' , luong = '" + nv[8].ToString() + "' , chucvu = N'" + nv[9].ToString() +
                    "' , sdt = '" + nv[11].ToString() + "' , gianhangma = '" + nv[10].ToString() + "'";
                connector.openConnection();
                connector.ModifyData("NhanVien", query, "manhanvien = '" + codeId + "'");
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
