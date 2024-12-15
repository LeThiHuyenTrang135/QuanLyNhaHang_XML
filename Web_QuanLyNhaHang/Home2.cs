using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_QuanLyNhaHang
{
    public partial class Home2 : Form
    {
        private Form formHienTai;
        private void moFormMenu(Form form)
        {
            if (formHienTai != null)
            {
                formHienTai.Close();
            }
            formHienTai = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            containerpanel.Controls.Add(form);
            containerpanel.Tag = form;
            form.BringToFront();
            form.Show();
        }
        public Home2()
        {
            InitializeComponent();
            moFormMenu(new QuanLyNhanVien());
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

            moFormMenu(new QuanLyNhanVien());
        }

        private void quảnLýDanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moFormMenu(new QuanLyDanhMuc());

        }

        private void quảnLýMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moFormMenu(new QuanLyMonAn());
        }

        private void containerpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // moFormMenu(new BanHang());
            //LichSuBanHang lichSuBanHang = new LichSuBanHang();
            //moFormMenu(new BanHang(lichSuBanHang));
        }

        private void saoLưuDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moFormMenu(new SaoLuu());
        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // LichSuBanHang lichSuBanHang = new LichSuBanHang();
            moFormMenu(new BanHang());
        }

        private void lịchSửĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moFormMenu(new LichSuBanHang());
        }
    }
}
