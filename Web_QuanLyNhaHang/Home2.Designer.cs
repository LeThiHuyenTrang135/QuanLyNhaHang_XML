namespace Web_QuanLyNhaHang
{
    partial class Home2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home2));
            panel1 = new Panel();
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            quảnLýNhânViênToolStripMenuItem = new ToolStripMenuItem();
            quảnLýDanhMụcToolStripMenuItem = new ToolStripMenuItem();
            quảnLýMónĂnToolStripMenuItem = new ToolStripMenuItem();
            bánHàngToolStripMenuItem = new ToolStripMenuItem();
            saoLưuDữLiệuToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            containerpanel = new Panel();
            dateTimePicker1 = new DateTimePicker();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, -2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 147);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(menuStrip1);
            panel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(110, 120);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(758, 27);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.PeachPuff;
            menuStrip1.BackgroundImageLayout = ImageLayout.None;
            menuStrip1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLýNhânViênToolStripMenuItem, quảnLýDanhMụcToolStripMenuItem, quảnLýMónĂnToolStripMenuItem, bánHàngToolStripMenuItem, saoLưuDữLiệuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.RightToLeft = RightToLeft.No;
            menuStrip1.Size = new Size(758, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            quảnLýNhânViênToolStripMenuItem.Size = new Size(155, 25);
            quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            quảnLýNhânViênToolStripMenuItem.Click += quảnLýNhânViênToolStripMenuItem_Click;
            // 
            // quảnLýDanhMụcToolStripMenuItem
            // 
            quảnLýDanhMụcToolStripMenuItem.Name = "quảnLýDanhMụcToolStripMenuItem";
            quảnLýDanhMụcToolStripMenuItem.Size = new Size(158, 25);
            quảnLýDanhMụcToolStripMenuItem.Text = "Quản lý danh mục";
            quảnLýDanhMụcToolStripMenuItem.Click += quảnLýDanhMụcToolStripMenuItem_Click;
            // 
            // quảnLýMónĂnToolStripMenuItem
            // 
            quảnLýMónĂnToolStripMenuItem.Name = "quảnLýMónĂnToolStripMenuItem";
            quảnLýMónĂnToolStripMenuItem.Size = new Size(140, 25);
            quảnLýMónĂnToolStripMenuItem.Text = "Quản lý món ăn";
            quảnLýMónĂnToolStripMenuItem.Click += quảnLýMónĂnToolStripMenuItem_Click;
            // 
            // bánHàngToolStripMenuItem
            // 
            bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
            bánHàngToolStripMenuItem.Size = new Size(91, 25);
            bánHàngToolStripMenuItem.Text = "Bán hàng";
            bánHàngToolStripMenuItem.Click += bánHàngToolStripMenuItem_Click;
            // 
            // saoLưuDữLiệuToolStripMenuItem
            // 
            saoLưuDữLiệuToolStripMenuItem.Name = "saoLưuDữLiệuToolStripMenuItem";
            saoLưuDữLiệuToolStripMenuItem.Size = new Size(134, 25);
            saoLưuDữLiệuToolStripMenuItem.Text = "Sao lưu dữ liệu";
            saoLưuDữLiệuToolStripMenuItem.Click += saoLưuDữLiệuToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 192);
            label1.Font = new Font("Colonna MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 27);
            label1.Name = "label1";
            label1.Size = new Size(286, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhà hàng TrangVyMinh ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-34, -34);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // containerpanel
            // 
            containerpanel.Location = new Point(1, 146);
            containerpanel.Margin = new Padding(3, 2, 3, 2);
            containerpanel.Name = "containerpanel";
            containerpanel.Size = new Size(958, 644);
            containerpanel.TabIndex = 1;
            containerpanel.Paint += containerpanel_Paint;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(418, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // Home2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 789);
            Controls.Add(dateTimePicker1);
            Controls.Add(containerpanel);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Home2";
            Text = "Home";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private ToolStripMenuItem quảnLýDanhMụcToolStripMenuItem;
        private ToolStripMenuItem quảnLýMónĂnToolStripMenuItem;
        private ToolStripMenuItem bánHàngToolStripMenuItem;
        private ToolStripMenuItem saoLưuDữLiệuToolStripMenuItem;
        private Panel containerpanel;
        private DateTimePicker dateTimePicker1;
    }
}