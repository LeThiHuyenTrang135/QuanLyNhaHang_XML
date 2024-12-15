namespace Web_QuanLyNhaHang
{
    partial class LichSuBanHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            button3 = new Button();
            button1 = new Button();
            grvHoaDon = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grvHoaDon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.GreenYellow;
            label1.Location = new Point(391, 26);
            label1.Name = "label1";
            label1.Size = new Size(238, 35);
            label1.TabIndex = 0;
            label1.Text = "Lịch sử đơn hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 106);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 1;
            label2.Text = "Tìm kiếm đơn hàng";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(419, 103);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(459, 27);
            txtTimKiem.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.DarkSeaGreen;
            btnTimKiem.ForeColor = Color.Black;
            btnTimKiem.Location = new Point(222, 205);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(99, 35);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(705, 205);
            button3.Name = "button3";
            button3.Size = new Size(99, 35);
            button3.TabIndex = 4;
            button3.Text = "In";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(451, 205);
            button1.Name = "button1";
            button1.Size = new Size(99, 35);
            button1.TabIndex = 5;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // grvHoaDon
            // 
            grvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvHoaDon.Location = new Point(63, 273);
            grvHoaDon.Name = "grvHoaDon";
            grvHoaDon.RowHeadersWidth = 51;
            grvHoaDon.Size = new Size(923, 348);
            grvHoaDon.TabIndex = 6;
            // 
            // LichSuBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backQLsanPham;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1033, 633);
            Controls.Add(grvHoaDon);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LichSuBanHang";
            Load += LichSuBanHang_Load;
            ((System.ComponentModel.ISupportInitialize)grvHoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Button button3;
        private Button button1;
        private DataGridView grvHoaDon;
    }
}
