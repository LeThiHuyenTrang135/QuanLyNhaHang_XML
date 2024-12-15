using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Web_QuanLyNhaHang.Model
{

    class ConvertData
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-GR95O5RQ\HUYENTRANG;Initial Catalog=QuanLyNhaHangTrangVyMinh;Integrated Security=True;Encrypt=False");
        public void RestoreData()
        {
            RestoreData("select * from QuanTriVien", "QuanTriVien");
            RestoreData("select * from NhanVienNhaHang", "NhanVienNhaHang");
            RestoreData("select * from DanhMucMonAn", "DanhMucMonAn");
            RestoreData("select * from MonAn", "MonAn");
            RestoreData("select * from HoaDon", "HoaDon");
            RestoreData("select * from ChiTietHoaDon", "ChiTietHoaDon");
        }
        public void RestoreData(String query, String XMLName)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(query, conn);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
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

        public void BackUpData()
        {
            BackUpData("QuanTriVien");
            BackUpData("NhanVienNhaHang");
            BackUpData("DanhMucMonAn");
            BackUpData("MonAn");
            BackUpData("HoaDon");
            BackUpData("ChiTietHoaDon");
        }
        String toString(XElement elm)
        {
            String result = "";
            foreach (XElement x in elm.Elements())
            {
                if (x == elm.LastNode)
                    result += "N'" + x.Value + "'";
                else
                {
                    result += "N'" + x.Value + "',";
                }
            }
            return "(" + result + "),\n";
        }

        private void BackUpData(String XMLFileName)
        {
            XDocument XDoc = XDocument.Load(XMLFileName + ".xml");
            Console.WriteLine();
            conn.Open();
            SqlCommand command;
            String query = "DELETE FROM " + XMLFileName + "\n insert into " + XMLFileName + " values\n";
            try
            {
                foreach (XElement x in XDoc.Descendants(XMLFileName))
                {
                    toString(x);
                    query += toString(x);
                }
                Console.WriteLine(query.Substring(0, query.Length - 2));
                command = new SqlCommand(query.Substring(0, query.Length - 2), conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                conn.Close();
            }
            Console.Read();
        }
    }
}
