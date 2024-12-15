using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Web_QuanLyNhaHang.Model;

namespace QLNhaHang.Model
{
    class ChiTietHoaDon
    {
        XMLFile XmlFile = new XMLFile();
        int stt = 0;
        DateTime today = DateTime.Today;
        String taoMa(XmlDocument XDoc)
        {

            XmlNodeList temp = XDoc.SelectNodes("/ChiTietHoaDons/ChiTietHoaDon[last()]");
            String maNV = temp[0].ChildNodes[0].InnerText;
            maNV = ("000000" + (int.Parse(maNV.Substring(2)) + 1).ToString());
            maNV = "CT" + maNV.Substring(maNV.Length - 5);
            return maNV;
        }
        public Boolean them(String ma, int solg, string hd)
        {
            try
            {
                XmlDocument XDoc = XmlFile.getXmlDocument("ChiTietHoaDon.xml");
                XmlElement node = XDoc.CreateElement("ChiTietHoaDon");
                XmlElement maCT = XDoc.CreateElement("maCT");
                XmlElement maSP = XDoc.CreateElement("maSP");
                XmlElement soluong = XDoc.CreateElement("soluong");
                XmlElement maHD = XDoc.CreateElement("maHD");
                maCT.InnerText = taoMa(XDoc);
                maSP.InnerText = ma;
                soluong.InnerText = solg.ToString();
                maHD.InnerText = hd;
                node.AppendChild(maCT);
                node.AppendChild(maSP);
                node.AppendChild(soluong);
                node.AppendChild(maHD);
                XDoc.DocumentElement.AppendChild(node);
                XDoc.Save("ChiTietHoaDon.xml");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }
        public int tongtien( int gia, int sl)
        {
            return gia * sl;
        }
    }
}
