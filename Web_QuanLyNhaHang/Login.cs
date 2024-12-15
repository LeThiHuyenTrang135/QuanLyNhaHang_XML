using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Web_QuanLyNhaHang.Model;

namespace Web_QuanLyNhaHang
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            LoginXuLy DN = new LoginXuLy();
            String maNV = DN.DangNhap(textBoxTenDN.Text, textBoxMatKhau.Text);
            if (!maNV.Equals(""))
            {
                Home2 home = new Home2();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất Bại", "Thông Báo");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
