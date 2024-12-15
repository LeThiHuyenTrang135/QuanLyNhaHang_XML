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
    }
}
