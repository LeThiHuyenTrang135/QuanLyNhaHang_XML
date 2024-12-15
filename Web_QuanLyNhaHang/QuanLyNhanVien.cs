using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Web_QuanLyNhaHang.Model;

namespace Web_QuanLyNhaHang
{
    public partial class QuanLyNhanVien : Form
    {
        XMLFile XmlFile = new XMLFile();
        int stt = 0;
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }
        void capNhapBang()
        {
            stt = 0;
            dataGridView1.Rows.Clear();
            XmlDocument XDoc = XmlFile.getXmlDocument("NhanVienNhaHang.xml");
            XmlNodeList nodeList = XDoc.SelectNodes("/NhanVienNhaHangs/NhanVienNhaHang");
            foreach (XmlNode x in nodeList)
            {
                dataGridView1.Rows.Add(++stt,
                    x.ChildNodes[0].InnerText,
                    x.ChildNodes[1].InnerText,
                    x.ChildNodes[2].InnerText,
                    x.ChildNodes[3].InnerText,
                    x.ChildNodes[4].InnerText,
                    x.ChildNodes[5].InnerText,
                    x.ChildNodes[6].InnerText);
            }
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }
        void clear()
        {
            hoten.Clear();
            dc.Clear();
            email.Clear();
            sdt.Clear();
            dateTimePicker1.ResetText();
            gt.ResetText();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Cells[2].Value != null)
                {
                    DateTime dt = DateTime.ParseExact(dataGridView1.CurrentRow.Cells[3].Value.ToString(), "dd/mm/yyyy", CultureInfo.InvariantCulture);
                    hoten.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    dateTimePicker1.Value = dt;
                    gt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    dc.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    email.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    sdt.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                }
            }
            catch { }
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            capNhapBang();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (hoten.Text.Equals("") || dateTimePicker1.Text.Equals("") || dc.Text.Equals("") || email.Text.Equals("") || sdt.Text.Equals("") || gt.Text.Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    hoten.Focus();
                }
                else
                {
                    NhanVien kh = new NhanVien();

                    if (kh.themKhachHang(hoten.Text, dateTimePicker1.Text, gt.Text, dc.Text, email.Text, sdt.Text))
                        MessageBox.Show("Thêm Thành Công", "Thông Báo");
                    capNhapBang();
                    clear();
                }

            }
            catch
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();

            if (nv.suaThongTin(dataGridView1.CurrentRow.Cells[1].Value.ToString(),
               hoten.Text, dateTimePicker1.Text, gt.Text, dc.Text, email.Text, sdt.Text))
            {
                MessageBox.Show("Đã Sửa Thông Tin Thành Công", "Thông Báo");
                clear();
            }
            else
                MessageBox.Show("Sửa Thông Tin Đã Thất Bại", "Thông Báo");
            capNhapBang();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Chắc Chắn Muốn Xóa Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    NhanVien nv = new NhanVien();
                    if (nv.xoaThongTin(dataGridView1.CurrentRow.Cells[1].Value.ToString()))
                        capNhapBang();
                    clear();

                }
                catch { }

            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
