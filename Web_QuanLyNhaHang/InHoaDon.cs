using System;
using System.Windows.Forms;

namespace Web_QuanLyNhaHang
{
    public partial class InHoaDon : Form
    {
        private WebBrowser webBrowser1; // Khai báo thành viên của lớp

        public InHoaDon()
        {
            InitializeComponent();
            richTextBoxContent.Font = new System.Drawing.Font("Courier New", 10);

        }

        private void InHoaDon_Load(object sender, EventArgs e)
        {
            // Có thể sử dụng sự kiện này nếu cần
        }


        public void ShowTextContent(string content)
        {
            // Assuming you have a TextBox or RichTextBox to display the content
            richTextBoxContent.Text = content;
        }

        private void richTextBoxContent_TextChanged(object sender, EventArgs e)
        {
            FormatRichTextBoxContent();
        }
        private void FormatRichTextBoxContent()
        {
            string[] lines = richTextBoxContent.Lines;
            richTextBoxContent.Clear();

            // Thêm tiêu đề cột
            string header = "STT".PadRight(5) +
                            "Mã HĐ".PadRight(10) +
                            "Mã Món".PadRight(10) +
                            "Tên Món Ăn".PadRight(40) +
                            "Số Lượng".PadRight(10) +
                            "Đơn Giá".PadRight(10) +
                            "Thành Tiền".PadRight(12);

            richTextBoxContent.AppendText(header + Environment.NewLine);

            for (int i = 0; i < lines.Length; i++)
            {
                string[] columns = lines[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (columns.Length < 7) continue; // Bỏ qua dòng không đủ dữ liệu

                // Gộp các từ thành tên món ăn
                string tenMonAn = string.Join(" ", columns, 3, columns.Length - 6);

                string formattedLine = columns[0].PadRight(5) +
                                       columns[1].PadRight(10) +
                                       columns[2].PadRight(10) +
                                       tenMonAn.PadRight(40) +
                                       columns[4].PadRight(10) +
                                       columns[5].PadRight(10) +
                                       columns[6].PadRight(12);

                // Xen kẽ màu nền cho từng hàng
                richTextBoxContent.SelectionStart = richTextBoxContent.TextLength;
                richTextBoxContent.SelectionLength = 0;
                richTextBoxContent.SelectionBackColor = (i % 2 == 0) ? System.Drawing.Color.LightGray : System.Drawing.Color.White;

                // Thêm dòng đã định dạng
                richTextBoxContent.AppendText(formattedLine + Environment.NewLine);
            }
        }



    }
}
