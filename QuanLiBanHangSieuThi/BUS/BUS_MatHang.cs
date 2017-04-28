using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO_Model;
using DAO;
namespace BUS
{
    public class BUS_MatHang
    {
        Connector connector;
        public BUS_MatHang()
        {
            connector = new Connector();
        }
        public DataTable DSMatHang()
        {
            connector.openConnection();
            DataTable tbl = new DataTable();
            try
            {
                tbl = connector.getDataTable("MatHang");
                connector.closeConnection();
            }
            catch (Exception)
            {

                throw;
            }
            return tbl;
        }
        public bool ThemMh(List<string> mh)
        {
            try
            {
                string str = " '" + mh[0].ToString() + "' , '" + mh[1].ToString() + "', '" + mh[2].ToString() +
                    "', '" + mh[3].ToString() + "', '" + mh[4].ToString() + "', '" + mh[5].ToString() + "' ";
                connector.openConnection();
                connector.InsertsData("MatHang", str);
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
