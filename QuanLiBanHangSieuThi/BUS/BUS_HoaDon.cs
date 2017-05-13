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
    public class BUS_HoaDon
    {
        Connector connector = null; 
        public BUS_HoaDon()
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

        public bool ThemHd(List<string> hd)
        {
            try
            {
                
                string str = " '" + hd[0].ToString() + "' , '" + hd[1].ToString() + "', '" + hd[2].ToString() +
                    "', '" + hd[3].ToString() + "', '" + hd[4].ToString() + "', '" + hd[5].ToString() + "' ";
                connector.openConnection();               
                connector.InsertsData("HoaDon", str);
                connector.closeConnection();
            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }
        public bool ChiTietHoaDon (List<string> ct)
        {
            try
            {
                string str = " '" + ct[0].ToString() + "' , '" + ct[1].ToString() + "', '" + ct[2].ToString() + "' , '" + ct[3].ToString() + "'";
                //string str1 = " '23','22','22','22'";
                connector.openConnection();
                connector.InsertsBill(str);
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
