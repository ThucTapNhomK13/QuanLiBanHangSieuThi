using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Model;
using DAO;
using System.Data;

namespace BUS
{
    public class BUS_NhaCungCap
    {
        Connector connector;
        public BUS_NhaCungCap()
        {
            connector = new Connector();
        }
        public DataTable DSNcc()
        {
            connector.openConnection();
            DataTable tbl = new DataTable();
            try
            {
                tbl = connector.getDataTable("NhaCungCap");
                connector.closeConnection();
            }
            catch (Exception)
            {

                throw;
            }
            return tbl;
        }
        public bool ThemNcc(List<string> ncc)
        {
            try
            {
                string str = " '" + ncc[0].ToString() + "' , '" + ncc[1].ToString() + "', '" + ncc[2].ToString() +
                    "', '" + ncc[3].ToString() + "', '" + ncc[4].ToString() + "' ";
                connector.openConnection();
                connector.InsertsData("NhaCungCap", str);
                connector.closeConnection();
            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }

        public bool XoaNcc(string codeId)
        {
            try
            {
                connector.openConnection();
                connector.DeleteData("NhaCungCap", "manhacc = '" + codeId + "'");
                connector.closeConnection();
            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }
        public bool SuaNcc(List<string> nv, string codeId)
        {
            try
            {
                string query = "tennhacc = N'" + nv[1].ToString() + "' , mathangma = '" + nv[2].ToString() + "' , giamathang = '" + nv[3].ToString() +
                    "' , soluong = '" + nv[4].ToString() + "'";
                connector.openConnection();
                connector.ModifyData("NhaCungCap", query, "manhacc = '" + codeId + "'");
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
