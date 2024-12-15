using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Web_QuanLyNhaHang.Model
{
    class NhanVien
    {
        XMLFile XmlFile = new XMLFile();

        String taoMaNhanVien(XmlDocument XDoc)
        {
            XmlNodeList temp = XDoc.SelectNodes("/NhanVienNhaHangs/NhanVienNhaHang[last()]");

            String maNV = temp[0].ChildNodes[0].InnerText;
            maNV = ("000000" + (int.Parse(maNV.Substring(2)) + 1).ToString());
            maNV = "NV" + maNV.Substring(maNV.Length - 5);
            return maNV;
        }

        public Boolean themKhachHang(String ten, String ns, String gt, String dc, String mail, String dt)
        {
            try
            {
                XmlDocument XDoc = XmlFile.getXmlDocument("NhanVienNhaHang.xml");
                XmlElement node = XDoc.CreateElement("NhanVienNhaHang");
                XmlElement maNV = XDoc.CreateElement("maNV");
                XmlElement tenNV = XDoc.CreateElement("tenNV");
                XmlElement ngaysinh = XDoc.CreateElement("ngaysinh");
                XmlElement gioitinh = XDoc.CreateElement("gioitinh");
                XmlElement diachi = XDoc.CreateElement("diachi");
                XmlElement email = XDoc.CreateElement("email");
                XmlElement sdt = XDoc.CreateElement("sdt");
                maNV.InnerText = taoMaNhanVien(XDoc);
                tenNV.InnerText = ten;
                ngaysinh.InnerText = ns;
                gioitinh.InnerText = gt;
                diachi.InnerText = dc;
                email.InnerText = mail;
                sdt.InnerText = dt;

                node.AppendChild(maNV);
                node.AppendChild(tenNV);
                node.AppendChild(ngaysinh);
                node.AppendChild(gioitinh);
                node.AppendChild(diachi);
                node.AppendChild(email);
                node.AppendChild(sdt);

                XDoc.DocumentElement.AppendChild(node);


                XDoc.Save("NhanVienNhaHang.xml");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }
        public Boolean xoaThongTin(String maNV)
        {
            try
            {
                XmlDocument Xdoc = XmlFile.getXmlDocument("NhanVienNhaHang.xml");
                XmlNodeList nodeList = Xdoc.SelectNodes("/NhanVienNhaHangs/NhanVienNhaHang[maNV = '" + maNV + "']");



                Xdoc.DocumentElement.RemoveChild(nodeList[0]);
                Xdoc.Save("NhanVienNhaHang.xml");

            }
            catch { }
            return true;
        }
        public Boolean suaThongTin(String maNV, String ten, String ns, String gt, String dc, String mail, String dt)
        {
            try
            {
                XmlDocument XDoc = XmlFile.getXmlDocument("NhanVienNhaHang.xml");
                XmlNodeList nodeList = XDoc.SelectNodes("/NhanVienNhaHangs/NhanVienNhaHang[maNV = '" + maNV + "']");
                XmlNode node = nodeList[0];
                node.ChildNodes[1].InnerText = ten;
                node.ChildNodes[2].InnerText = ns;
                node.ChildNodes[3].InnerText = gt;
                node.ChildNodes[4].InnerText = dc;
                node.ChildNodes[5].InnerText = mail;
                node.ChildNodes[6].InnerText = dt;
                XDoc.Save("NhanVienNhaHang.xml");
            }
            catch
            {
                return false;
            }



            return true;
        }
    }
}
