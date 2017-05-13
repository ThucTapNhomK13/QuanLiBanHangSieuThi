﻿using System;
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
    public class BUS_User
    {
        Connector connector = null;
        public BUS_User()
        {
            connector = new Connector();           
        }
        public List<DangNhap> dangNhap()
        {
            List<DangNhap> dn = new List<DangNhap>();
            //SqlCommand cmd = new SqlCommand("select * from DangNhap"); // thuc thi cac cau lenh sql 
            //SqlDataAdapter com = new SqlDataAdapter(cmd); // van chuyen du lieu
            DataTable tbl = new DataTable();    // tao bang ao de luu du lieu
            //com.Fill(tbl); // do du lieu vao bang ao
            tbl = connector.getDataTable("DangNhap");
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                DangNhap ds = new DangNhap(tbl.Rows[i]["tendangnhap"].ToString(), tbl.Rows[i]["matkhau"].ToString());
                dn.Add(ds);
            }
            connector.closeConnection();
            return dn;
        }

        //public List<string> matkhau()
        //{
        //    List<string> mk = new List<string>();
        //    //SqlCommand cmd = new SqlCommand("select matkhau from DangNhap");
        //    //SqlDataAdapter com = new SqlDataAdapter(cmd);
        //    DataTable tbl = new DataTable();
        //    tbl = connector.dangnhap("matkhau");
        //    //com.Fill(tbl);
        //    for (int i = 0; i < tbl.Rows.Count; i++)
        //    {
        //        mk.Add(tbl.Rows[i].ToString());
        //    }
        //    return mk;
        //}

    }
}
