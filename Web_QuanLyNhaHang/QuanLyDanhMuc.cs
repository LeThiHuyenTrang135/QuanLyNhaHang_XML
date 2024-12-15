using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Web_QuanLyNhaHang.Model;

namespace Web_QuanLyNhaHang
{
    public partial class QuanLyDanhMuc : Form
    {
        XMLFile XmlFile = new XMLFile();
        int stt = 0;
        void LoadBang()
        {
            stt = 0;
            dataGridView1.Rows.Clear();
            XmlDocument XDoc = XmlFile.getXmlDocument("DanhMucMonAn.xml");
            XmlNodeList nodeList = XDoc.SelectNodes("/DanhMucMonAns/DanhMucMonAn");
            foreach (XmlNode x in nodeList)
            {
                dataGridView1.Rows.Add(++stt,
                    x.ChildNodes[0].InnerText,
                    x.ChildNodes[1].InnerText,
                    x.ChildNodes[2].InnerText);
            }
        }
        public void clear()
        {
            name.Clear();
            mota.Clear();
        }
        public QuanLyDanhMuc()
        {
            InitializeComponent();
        }

        private void QuanLyDanhMuc_Load(object sender, EventArgs e)
        {
            LoadBang();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (name.Text.Equals("") || mota.Text.Equals(""))
                {
                    MessageBox.Show("Nhập Thiếu thông tin - Vui Lòng Nhập đầy đủ");
                }
                else
                {
                    DanhMucMonAn dm = new DanhMucMonAn();

                    if (dm.themDanhMuc(name.Text, mota.Text))
                        MessageBox.Show("Thêm Danh Mục Thành Công", "Thông Báo");
                    LoadBang();
                    clear();
                }

            }
            catch
            {
                MessageBox.Show("Thêm thất bại!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DanhMucMonAn dm = new DanhMucMonAn();

            if (dm.suaThongTin(dataGridView1.CurrentRow.Cells[1].Value.ToString(),
               name.Text, mota.Text))
            {
                MessageBox.Show("Đã Sửa Thông Tin Thành Công", "Thông Báo");
                clear();
            }
            else
                MessageBox.Show("Sửa Thông Tin ĐÃ Thất Bại", "Thông Báo");
            LoadBang();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Chắc Chắn Muốn Xóa Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    DanhMucMonAn dm = new DanhMucMonAn();
                    if (dm.xoaThongTin(dataGridView1.CurrentRow.Cells[1].Value.ToString()))
                        LoadBang();
                    clear();

                }
                catch { }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tự động điều chỉnh kích thước các cột dựa trên nội dung
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Thiết lập chiều rộng cho cột cụ thể
            dataGridView1.Columns[0].Width = 100; // Cột đầu tiên rộng 150 pixels
            dataGridView1.Columns[1].Width = 200; // Cột thứ hai rộng 200 pixels

            try
            {
                if (dataGridView1.CurrentRow.Cells[2].Value != null)
                {
                    name.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    mota.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                }
            }
            catch { }
        }
    }
}
