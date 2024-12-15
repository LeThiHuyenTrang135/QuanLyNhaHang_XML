using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Web_QuanLyNhaHang.Model
{
    class DanhMucMonAn
    {
        XMLFile XmlFile = new XMLFile();
        int stt = 0;
        public Boolean themDanhMuc(String ten, String mieuta)
        {
            try
            {
                XmlDocument XDoc = XmlFile.getXmlDocument("DanhMucMonAn.xml");
                XmlElement node = XDoc.CreateElement("DanhMucMonAn");
                XmlElement maDM = XDoc.CreateElement("maDM");
                XmlElement tenDM = XDoc.CreateElement("tenDM");
                XmlElement mota = XDoc.CreateElement("mota");
                maDM.InnerText = taoMaDanhMuc(XDoc);
                tenDM.InnerText = ten;
                mota.InnerText = mieuta;

                node.AppendChild(maDM);
                node.AppendChild(tenDM);
                node.AppendChild(mota);

                XDoc.DocumentElement.AppendChild(node);

                XDoc.Save("DanhMucMonAn.xml");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }
        String taoMaDanhMuc(XmlDocument XDoc)
        {

            XmlNodeList temp = XDoc.SelectNodes("/DanhMucMonAns/DanhMucMonAn[last()]");
            String maNV = temp[0].ChildNodes[0].InnerText;
            maNV = ("000000" + (int.Parse(maNV.Substring(2)) + 1).ToString());
            maNV = "DM" + maNV.Substring(maNV.Length - 5);
            return maNV;
        }
        public Boolean xoaThongTin(String maDM)
        {
            try
            {
                XmlDocument Xdoc = XmlFile.getXmlDocument("DanhMucMonAn.xml");
                XmlNodeList nodeList = Xdoc.SelectNodes("/DanhMucMonAns/DanhMucMonAn[maDM = '" + maDM + "']");
                Xdoc.DocumentElement.RemoveChild(nodeList[0]);
                Xdoc.Save("DanhMucMonAn.xml");

            }
            catch { }
            return true;
        }
        public Boolean suaThongTin(String maDM, String ten, String mota)
        {
            try
            {
                XmlDocument XDoc = XmlFile.getXmlDocument("DanhMucMonAn.xml");
                XmlNodeList nodeList = XDoc.SelectNodes("/DanhMucMonAns/DanhMucMonAn[maDM= '" + maDM + "']");
                XmlNode node = nodeList[0];
                node.ChildNodes[1].InnerText = ten;
                node.ChildNodes[2].InnerText = mota;
                XDoc.Save("DanhMucMonAn.xml");
            }
            catch
            {
                return false;
            }
            return true;
        }
        public XmlNodeList getListDM()
        {
            XmlDocument XDoc = XmlFile.getXmlDocument("DanhMucMonAn.xml");
            XmlNodeList nodeList = XDoc.SelectNodes("/DanhMucMonAns/DanhMucMonAn");
            for (int i = 0; i < nodeList.Count; i++)
            {
                XmlNode a = nodeList[i];
            }
            return nodeList;

        }
    }
}
