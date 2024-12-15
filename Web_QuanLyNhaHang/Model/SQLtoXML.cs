using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_QuanLyNhaHang.Model
{
    class SQLtoXML
    {
        Microsoft.Data.SqlClient.SqlConnection conn = new Microsoft.Data.SqlClient.SqlConnection(@"Data Source=LAPTOP-0DQUS0GF\SQLEXPRESS;Initial Catalog=QuanLyNhaHangTrangVyMinh;Integrated Security=True;Encrypt=False");

        public void RestoreData()
        {
            RestoreData("select * from QuanTriVien", "QuanTriVien");
            RestoreData("select * from NhanVienNhaHang", "NhanVienNhaHang");
            RestoreData("select * from DanhMucMonAn", "DanhMucMonAn");
            RestoreData("select * from MonAn", "MonAn");
            RestoreData("select * from HoaDon", "HoaDon");
            RestoreData("select * from ChiTietHoaDon", "ChiTietHoaDon");
        }

        public void RestoreData(string query, string XMLName)
        {
            try
            {
                Microsoft.Data.SqlClient.SqlDataAdapter da = new Microsoft.Data.SqlClient.SqlDataAdapter();
                da.SelectCommand = new Microsoft.Data.SqlClient.SqlCommand(query, conn);
                Microsoft.Data.SqlClient.SqlCommandBuilder cb = new Microsoft.Data.SqlClient.SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, XMLName);
                ds.DataSetName = XMLName + "s";
                ds.WriteXml(XMLName + ".xml");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}

