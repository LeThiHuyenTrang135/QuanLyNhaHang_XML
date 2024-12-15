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
    public partial class QuanLyMonAn : Form
    {
        XMLFile XmlFile = new XMLFile();
        XmlNodeList nodeListDM;
        XmlNodeList nodeListCTNS;
        String ma;
        int stt = 0;
        public QuanLyMonAn()
        {
            InitializeComponent();
        }
        void LoadBang()
        {
            DanhMucMonAn DMMA = new DanhMucMonAn();
            nodeListDM = DMMA.getListDM();
            stt = 0;
            dataGridView.Rows.Clear();
            XmlDocument XDoc = XmlFile.getXmlDocument("MonAn.xml");
            XmlNodeList nodeList = XDoc.SelectNodes("/MonAns/MonAn");
            foreach (XmlNode x in nodeList)
            {
                foreach (XmlNode y in nodeListDM)
                {
                    if (y.ChildNodes[0].InnerText.Equals(x.ChildNodes[3].InnerText.ToString()))
                    {
                        ma = y.ChildNodes[0].InnerText.ToString();
                        dataGridView.Rows.Add(++stt,
                        x.ChildNodes[0].InnerText,
                        x.ChildNodes[1].InnerText,
                        x.ChildNodes[2].InnerText,
                        y.ChildNodes[1].InnerText);
                    }
                }
            }
        }

        public void clear()
        {
            tenmonan.Clear();
            giamonan.Clear();
            comboBoxdanhmuc.Text = "";
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyMonAn_Load(object sender, EventArgs e)
        {
            DanhMucMonAn DMMA = new DanhMucMonAn();
            nodeListDM = DMMA.getListDM();
            foreach (XmlNode x in nodeListDM)
            {
                comboBoxdanhmuc.Items.Add(x.ChildNodes[1].InnerText);
                comboBoxdanhmuc.ValueMember = x.ChildNodes[0].InnerText;
            }
            LoadBang();
        }








        

        private void btadd_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (tenmonan.Text.Equals("") || giamonan.Text.Equals("") || comboBoxdanhmuc.SelectedItem.ToString() == "")
                {
                    MessageBox.Show("Nhập Thiếu thông tin - Vui Lòng Nhập đầy đủ");
                }
                else
                {
                    DanhMucMonAn DMMA = new DanhMucMonAn();
                    nodeListDM = DMMA.getListDM();
                    foreach (XmlNode x in nodeListDM)
                    {
                        if (x.ChildNodes[1].InnerText.Equals(comboBoxdanhmuc.SelectedItem.ToString()))
                        {
                            ma = x.ChildNodes[0].InnerText.ToString();
                        }
                    }
                    MonAn dm = new MonAn();
                    if (dm.them(tenmonan.Text, Int32.Parse(giamonan.Text), ma.ToString()))
                        MessageBox.Show("Thanh cong", "Thông Báo");
                    LoadBang();
                    clear();
                }

            }
            catch
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btupdate_Click_1(object sender, EventArgs e)
        {
            MonAn dm = new MonAn();
            DanhMucMonAn DMMA = new DanhMucMonAn();
            nodeListDM = DMMA.getListDM();
            foreach (XmlNode x in nodeListDM)
            {
                if (x.ChildNodes[1].InnerText.Equals(comboBoxdanhmuc.SelectedItem.ToString()))
                {
                    ma = x.ChildNodes[0].InnerText.ToString();
                }
            }
            if (dm.suaThongTin(dataGridView.CurrentRow.Cells[1].Value.ToString(),
               tenmonan.Text, Int32.Parse(giamonan.Text), ma))

            {
                MessageBox.Show("Đã Sửa Thông Tin Thành Công", "Thông Báo");
                clear();
            }
            else
                MessageBox.Show("Sửa Thông Tin Thất Bại", "Thông Báo");
            LoadBang();
        }

        private void btdelete_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Chắc Chắn Muốn Xóa Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    MonAn dm = new MonAn();
                    if (dm.xoaThongTin(dataGridView.CurrentRow.Cells[1].Value.ToString()))
                        LoadBang();
                    clear();

                }
                catch { }

            }
        }

        private void btrefresh_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView.CurrentRow.Cells[2].Value != null)
                {
                    tenmonan.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
                    giamonan.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
                    comboBoxdanhmuc.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
                }
            }
            catch { }
        }
    }
}
