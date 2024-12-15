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
    public partial class SaoLuu : Form
    {
        public SaoLuu()
        {
            InitializeComponent();
        }



        private void SaoLuu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ConvertData convertData = new ConvertData();
            convertData.BackUpData();
            MessageBox.Show("Đã sao lưu lên database", "Thông Báo");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ConvertData convertData = new ConvertData();
            convertData.RestoreData();
            MessageBox.Show("Đã sao lưu từ database", "Thông Báo");
        }
    }
}
