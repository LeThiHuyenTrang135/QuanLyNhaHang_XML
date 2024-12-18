using System;
using System.IO;
using System.Xml;
using Web_QuanLyNhaHang.Model;

namespace QLNhaHang.Model
{
    class ChiTietHoaDon
    {
        XMLFile XmlFile = new XMLFile();

        String taoMa(XmlDocument XDoc)
        {
            XmlNodeList temp = XDoc.SelectNodes("/ChiTietHoaDons/ChiTietHoaDon[last()]");
            if (temp == null || temp.Count == 0)
            {
                return "CT00001"; // Mã đầu tiên
            }

            string maNV = temp[0].ChildNodes[0]?.InnerText;
            if (string.IsNullOrEmpty(maNV) || maNV.Length < 2)
            {
                throw new FormatException("Dữ liệu trong XML không hợp lệ.");
            }

            int lastId = 0;
            if (!int.TryParse(maNV.Substring(2), out lastId))
            {
                throw new FormatException("Mã không đúng định dạng.");
            }

            lastId++;
            return $"CT{lastId:D5}";
        }

        public Boolean them(String ma, int solg, string hd)
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ChiTietHoaDon.xml");
                XmlDocument XDoc = new XmlDocument();

                if (!File.Exists(filePath))
                {
                    XDoc.LoadXml("<ChiTietHoaDons></ChiTietHoaDons>"); // Tạo file mới
                }
                else
                {
                    XDoc = XmlFile.getXmlDocument("ChiTietHoaDon.xml");
                }

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
                XDoc.Save(filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error in them: {e.Message}\n{e.StackTrace}");
                return false;
            }
            return true;
        }

        public int tongtien(int gia, int sl)
        {
            if (gia < 0 || sl < 0)
            {
                throw new ArgumentException("Giá và số lượng phải lớn hơn hoặc bằng 0.");
            }
            return gia * sl;
        }
    }
}
