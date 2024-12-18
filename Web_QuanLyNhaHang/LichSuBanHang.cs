using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Drawing.Printing;
using Excel = Microsoft.Office.Interop.Excel;

using Web_QuanLyNhaHang.Model;

namespace Web_QuanLyNhaHang
{
    public partial class LichSuBanHang : Form
    {
        XMLFile XmlFile = new XMLFile();
        int stt = 0;
        private Dictionary<string, string> tenMonAn = new Dictionary<string, string>();
        private PrintDocument printDocument = new PrintDocument();
        private string printContent = string.Empty;

        public LichSuBanHang()
        {
            InitializeComponent();
            InitializeDataGridView();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
        }

        private void InitializeDataGridView()
        {
            grvHoaDon.Columns.Add("STT", "STT");
            grvHoaDon.Columns.Add("MaHD", "Mã Hóa Đơn");
            grvHoaDon.Columns.Add("MaMonAn", "Mã Món Ăn");
            grvHoaDon.Columns.Add("TenMonAn", "Tên Món Ăn");
            grvHoaDon.Columns.Add("SoLuong", "Số Lượng");
            grvHoaDon.Columns.Add("DonGia", "Đơn Giá");
            grvHoaDon.Columns.Add("ThanhTien", "Thành Tiền");
            grvHoaDon.Columns.Add("NgayTao", "Ngày tạo");
        }

        private void LichSuBanHang_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
        }
        public void LoadHoaDon(string searchText = "")
        {
            XmlDocument XDoc1 = XmlFile.getXmlDocument("MonAn.xml");
            XmlNodeList? nodeList1 = XDoc1.SelectNodes("/MonAns/MonAn");

            stt = 0;
            grvHoaDon.Rows.Clear();
            XmlDocument XDoc = XmlFile.getXmlDocument("ChiTietHoaDon.xml");
            XmlNodeList? nodeList = XDoc.SelectNodes("/ChiTietHoaDons/ChiTietHoaDon");

            // Load HoaDon.xml and store ngaytao values in a dictionary
            XmlDocument XDocHoaDon = XmlFile.getXmlDocument("HoaDon.xml");
            XmlNodeList? nodeListHoaDon = XDocHoaDon.SelectNodes("/HoaDons/HoaDon");
            Dictionary<string, string> ngayTaoDict = new Dictionary<string, string>();

            if (nodeListHoaDon != null)
            {
                foreach (XmlNode node in nodeListHoaDon)
                {
                    string maHD = node["maHD"]?.InnerText ?? string.Empty;
                    string ngayTao = node["ngaytao"]?.InnerText ?? string.Empty;
                    if (!string.IsNullOrEmpty(maHD) && !string.IsNullOrEmpty(ngayTao))
                    {
                        ngayTaoDict[maHD] = ngayTao;
                    }
                }
            }

            if (nodeList == null || nodeList1 == null)
            {
                return;
            }

            foreach (XmlNode x in nodeList)
            {
                foreach (XmlNode y in nodeList1)
                {
                    if (y.ChildNodes[0]?.InnerText.Equals(x.ChildNodes[1]?.InnerText) == true)
                    {
                        string maHD = x["maHD"]?.InnerText ?? string.Empty;
                        string tenMonAn = y.ChildNodes[1]?.InnerText ?? string.Empty;
                        string ngayTao = ngayTaoDict.ContainsKey(maHD) ? ngayTaoDict[maHD] : string.Empty;

                        if (string.IsNullOrEmpty(searchText) || maHD.ToLower().Contains(searchText) || tenMonAn.ToLower().Contains(searchText))
                        {
                            grvHoaDon.Rows.Add(++stt,
                                maHD,
                                x.ChildNodes[1]?.InnerText,
                                tenMonAn,
                                x.ChildNodes[2]?.InnerText,
                                y.ChildNodes[2]?.InnerText,
                                int.Parse(x.ChildNodes[2]?.InnerText ?? "0") * int.Parse(y.ChildNodes[2]?.InnerText ?? "0"),
                                ngayTao);
                        }
                    }
                }
            }
        }


        private string LoadMHD()
        {
            XDocument doc = XDocument.Load("HoaDon.xml");
            string? id = doc.Descendants("maHD").LastOrDefault()?.Value;
            return id ?? string.Empty;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string textTimKiem = txtTimKiem.Text.ToLower();
            LoadHoaDon(textTimKiem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GatherPrintContent();
            InHoaDon formin = new InHoaDon();
            formin.ShowTextContent(printContent);
            formin.Show();
        }

        private void GatherPrintContent()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("STT\tMã Hóa Đơn\tMã Món Ăn\tTên Món Ăn\tSố Lượng\tĐơn Giá\tThành Tiền\tNgày tạo");

            foreach (DataGridViewRow row in grvHoaDon.Rows)
            {
                if (row.IsNewRow) continue;
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    sb.Append(row.Cells[i].Value?.ToString() + "\t");
                }
                sb.AppendLine();
            }

            printContent = sb.ToString();
        }

        private void PrintInvoice()
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(printContent, new Font("Arial", 12), Brushes.Black, new PointF(100, 100));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Tạo ứng dụng Excel
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = false; // Ẩn ứng dụng Excel khi tạo file

            // Tạo workbook và worksheet
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

            // Đặt tiêu đề cho file Excel
            worksheet.Cells[1, 1] = "STT";
            worksheet.Cells[1, 2] = "Mã Hóa Đơn";
            worksheet.Cells[1, 3] = "Mã Món Ăn";
            worksheet.Cells[1, 4] = "Tên Món Ăn";
            worksheet.Cells[1, 5] = "Số Lượng";
            worksheet.Cells[1, 6] = "Đơn Giá";
            worksheet.Cells[1, 7] = "Thành Tiền";
            worksheet.Cells[1, 8] = "Ngày Tạo";

            // Ghi dữ liệu từ DataGridView vào Excel
            int rowExcel = 2; // Bắt đầu từ hàng thứ 2 trong Excel
            foreach (DataGridViewRow row in grvHoaDon.Rows)
            {
                if (row.IsNewRow) continue;

                for (int i = 0; i < grvHoaDon.Columns.Count; i++)
                {
                    worksheet.Cells[rowExcel, i + 1] = row.Cells[i].Value?.ToString();
                }
                rowExcel++;
            }

            // Lưu file Excel
            string savePath = "LichSuBanHang.xlsx";
            workbook.SaveAs(savePath);
            workbook.Close();
            excelApp.Quit();

            MessageBox.Show($"Dữ liệu đã được xuất ra file {savePath}", "Xuất Excel Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
