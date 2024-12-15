using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Web_QuanLyNhaHang.Model
{
    class LoginXuLy
    {
        XMLFile XmlFile = new XMLFile();

        public String DangNhap(String userName, string password)
        {
            XmlDocument XDoc = XmlFile.getXmlDocument("QuanTriVien.xml");
            XmlNodeList nodeList = XDoc.SelectNodes("/QuanTriViens/QuanTriVien[tenDN = '" + userName + "']");

            if (nodeList.Count != 0)
                if (nodeList[0].ChildNodes[3].InnerText.Equals(password))
                {
                    return nodeList[0].ChildNodes[0].InnerText;
                }

                else
                {
                    return "";
                }
            return "";
        }
    }
}
