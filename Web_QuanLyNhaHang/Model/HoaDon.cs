using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Web_QuanLyNhaHang.Model
{
    class HoaDon
    {
        XMLFile XmlFile = new XMLFile();
        int stt = 0;
        DateTime today = DateTime.Today;
        String taoMa(XmlDocument XDoc)
        {

            XmlNodeList temp = XDoc.SelectNodes("/HoaDons/HoaDon[last()]");
            String maNV = temp[0].ChildNodes[0].InnerText;
            maNV = ("000000" + (int.Parse(maNV.Substring(2)) + 1).ToString());
            maNV = "HD" + maNV.Substring(maNV.Length - 5);
            return maNV;
        }
        public Boolean them()
        {
            try
            {
                XmlDocument XDoc = XmlFile.getXmlDocument("HoaDon.xml");
                XmlElement node = XDoc.CreateElement("HoaDon");
                XmlElement maHD = XDoc.CreateElement("maHD");
                XmlElement ngaytao = XDoc.CreateElement("ngaytao");
                maHD.InnerText = taoMa(XDoc);
                ngaytao.InnerText = today.ToString("d");
                node.AppendChild(maHD);
                node.AppendChild(ngaytao);
                XDoc.DocumentElement.AppendChild(node);
                XDoc.Save("HoaDon.xml");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }
    }
}
