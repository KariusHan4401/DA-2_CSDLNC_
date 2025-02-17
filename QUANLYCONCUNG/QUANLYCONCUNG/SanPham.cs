﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;

namespace QUANLYCONCUNG
{
    public class SanPham
    {
        public int MaSP { get; set; }
        public int MaLH { get; set; }
        public int MaTH { get; set; }
        public string TenSP { get; set; }
        public string HinhAnh { get; set; }
        public string MoTa { get; set; }
        public int LuotYeuThich { get; set; }
        public int LuotBinhLuan { get; set; }
        public decimal GiaBan { get; set; }

        //public static DataSet ds = new DataSet();
        public static DataTable dt = new DataTable();
        void LoadData(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connection))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    data.Fill(dt);
                   // data.Fill(ds);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public static List<SanPham> GetProducts()
        {
            //var products = new List<SanPham>();
            //LoadData("SELECT MASP, TEN_SP, HINH_ANH, LUOT_YEU_THICH, LUOT_BINH_LUAN, GIA_BAN FROM SAN_PHAM");
            var query = "SELECT TOP 52 MASP, MALH, MATH, TEN_SP, HINH_ANH, LUOT_YEU_THICH, MO_TA, LUOT_BINH_LUAN, GIA_BAN FROM SAN_PHAM";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connection))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    data.Fill(dt);
                    // data.Fill(ds);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            List<SanPham> products = new List<SanPham>();

            products = (from DataRow dr in dt.Rows
                        select new SanPham()
                        {
                            MaSP = Convert.ToInt32(dr["MASP"]),
                            MaTH = Convert.ToInt32(dr["MATH"]),
                            MaLH = dr["MALH"]== DBNull.Value ? 0 : Convert.ToInt32(dr["MALH"]),
                            TenSP = dr["TEN_SP"].ToString(),
                            HinhAnh = dr["HINH_ANH"].ToString(),
                            //HinhAnh = @"D:\DOWNLOADS\dep.jpg",
                            GiaBan = Convert.ToDecimal(dr["GIA_BAN"]),
                            LuotYeuThich = Convert.ToInt32(dr["LUOT_YEU_THICH"]),
                            LuotBinhLuan = Convert.ToInt32(dr["LUOT_BINH_LUAN"]),
                            MoTa = dr["MO_TA"].ToString()
                        }).ToList();
            
            return products;
        }

    }
}
