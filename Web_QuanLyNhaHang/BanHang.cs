using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using Web_QuanLyNhaHang.Model;
using QLNhaHang.Model;
using System.Globalization;

namespace Web_QuanLyNhaHang
{
    public partial class BanHang : Form
    {

        XMLFile XmlFile = new XMLFile();
        int tt = 0;
        int stt = 0;
        String mahoadon, mamonan;

        public BanHang()
        {
            InitializeComponent();
        }

        void LoadBangMA()
        {
            stt = 0;
            datamonan.Rows.Clear();
            XmlDocument XDoc = XmlFile.getXmlDocument("MonAn.xml");
            XmlNodeList nodeList = XDoc.SelectNodes("/MonAns/MonAn");
            foreach (XmlNode x in nodeList)
            {
                datamonan.Rows.Add(++stt,
                    x.ChildNodes[0].InnerText,
                    x.ChildNodes[1].InnerText,
                    x.ChildNodes[2].InnerText);

            }

        }

        void LoadBangCTHD(String mahd)
        {

            XmlDocument XDoc1 = XmlFile.getXmlDocument("MonAn.xml");
            XmlNodeList nodeList1 = XDoc1.SelectNodes("/MonAns/MonAn");

            stt = 0;
            datacthd.Rows.Clear();
            XmlDocument XDoc = XmlFile.getXmlDocument("ChiTietHoaDon.xml");
            XmlNodeList nodeList = XDoc.SelectNodes("/ChiTietHoaDons/ChiTietHoaDon[maHD= '" + mahd + "']");
            foreach (XmlNode x in nodeList)
            {
                foreach (XmlNode y in nodeList1)
                {

                    if (y.ChildNodes[0].InnerText.Equals(x.ChildNodes[1].InnerText.ToString()))
                    {
                        datacthd.Rows.Add(++stt,
                        x.ChildNodes[1].InnerText,
                        y.ChildNodes[1].InnerText,
                        x.ChildNodes[2].InnerText,
                        y.ChildNodes[2].InnerText,
                        Int32.Parse(x.ChildNodes[2].InnerText) * Int32.Parse(y.ChildNodes[2].InnerText)
                        );
                        ;
                    }

                }



            }

        }

        void clear()
        {
            name.Clear();
            soluong.Clear();
            gia.Clear();
        }
        String LoadMHD()
        {
            XDocument doc = XDocument.Load("HoaDon.xml");
            string id = (string)doc.Descendants("maHD").LastOrDefault();
            return id;
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            LoadBangMA();
            mahoadon = LoadMHD();
            LoadBangCTHD(mahoadon);
        }

       





        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (name.Text.Equals("") || gia.Text.Equals("") || soluong.Text.Equals(""))
                {
                    MessageBox.Show("Nhập Thiếu thông tin - Vui Lòng Nhập đầy đủ");
                }
                else
                {
                    ChiTietHoaDon cthd = new ChiTietHoaDon();
                    if (cthd.them(mamonan, Int32.Parse(soluong.Text), mahoadon))
                    {
                        tt = tt + cthd.tongtien(Int32.Parse(soluong.Text), Int32.Parse(gia.Text));
                        tongtien.Text = "Tổng tiền: " + string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", tt) + " VNĐ";
                        MessageBox.Show("Thêm Thành Công", "Thông Báo");
                    }
                    clear();
                    LoadBangCTHD(mahoadon);
                    LoadBangMA();
                }

            }
            catch
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void xongdon_Click_1(object sender, EventArgs e)
        {
            mahoadon = null;
            mamonan = null;
            datacthd.Rows.Clear();
            HoaDon hd = new HoaDon();
            hd.them();
            mahoadon = LoadMHD();
            LoadBangMA();
            tongtien.Text = "Tổng tiền:";
            tt = 0;
        }

        private void datamonan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (datamonan.CurrentRow.Cells[1].Value != null)
                {
                    mamonan = datamonan.CurrentRow.Cells[1].Value.ToString();
                    name.Text = datamonan.CurrentRow.Cells[2].Value.ToString();
                    gia.Text = datamonan.CurrentRow.Cells[3].Value.ToString();
                }
            }
            catch { }
        }
    }
}
