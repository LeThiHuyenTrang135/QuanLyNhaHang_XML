using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Web_QuanLyNhaHang.Model
{
    class MonAn
    {
        XMLFile XmlFile = new XMLFile();
        int stt = 0;
        String taoMa(XmlDocument XDoc)
        {

            XmlNodeList temp = XDoc.SelectNodes("/MonAns/MonAn[last()]");
            String maNV = temp[0].ChildNodes[0].InnerText;
            maNV = ("000000" + (int.Parse(maNV.Substring(2)) + 1).ToString());
            maNV = "MA" + maNV.Substring(maNV.Length - 5);
            return maNV;
        }
        public Boolean them(String ten, int giama, String madm)
        {
            try
            {
                XmlDocument XDoc = XmlFile.getXmlDocument("MonAn.xml");
                XmlElement node = XDoc.CreateElement("MonAn");
                XmlElement maMA = XDoc.CreateElement("maMA");
                XmlElement tenMA = XDoc.CreateElement("tenMA");
                XmlElement gia = XDoc.CreateElement("gia");
                XmlElement maDM = XDoc.CreateElement("maDM");
                maMA.InnerText = taoMa(XDoc);
                tenMA.InnerText = ten;
                gia.InnerText = giama.ToString();
                maDM.InnerText = madm;
                node.AppendChild(maMA);
                node.AppendChild(tenMA);
                node.AppendChild(gia);
                node.AppendChild(maDM);
                XDoc.DocumentElement.AppendChild(node);

                XDoc.Save("MonAn.xml");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }
        public Boolean suaThongTin(String maMA, String ten, int giama, String dm)
        {
            try
            {

                XmlDocument XDoc = XmlFile.getXmlDocument("MonAn.xml");
                XmlNodeList nodeList = XDoc.SelectNodes("/MonAns/MonAn[maMA= '" + maMA + "']");
                XmlNode node = nodeList[0];
                node.ChildNodes[1].InnerText = ten;
                node.ChildNodes[2].InnerText = giama.ToString();
                node.ChildNodes[3].InnerText = dm;
                XDoc.Save("MonAn.xml");
            }
            catch
            {
                return false;
            }
            return true;
        }
        public Boolean xoaThongTin(String maMA)
        {
            try
            {
                XmlDocument Xdoc = XmlFile.getXmlDocument("MonAn.xml");
                XmlNodeList nodeList = Xdoc.SelectNodes("/MonAns/MonAn[maMA = '" + maMA + "']");
                Xdoc.DocumentElement.RemoveChild(nodeList[0]);
                Xdoc.Save("MonAn.xml");

            }
            catch { }
            return true;
        }
    }
}
