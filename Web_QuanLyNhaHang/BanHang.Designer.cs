namespace Web_QuanLyNhaHang
{
    partial class BanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanHang));
            label1 = new Label();
            label2 = new Label();
            datamonan = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            name = new TextBox();
            gia = new TextBox();
            soluong = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            datacthd = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            xongdon = new Button();
            tongtien = new Label();
            ((System.ComponentModel.ISupportInitialize)datamonan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datacthd).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.MediumSpringGreen;
            label1.Location = new Point(364, 30);
            label1.Name = "label1";
            label1.Size = new Size(381, 32);
            label1.TabIndex = 0;
            label1.Text = "------------BÁN HÀNG------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(26, 92);
            label2.Name = "label2";
            label2.Size = new Size(123, 26);
            label2.TabIndex = 1;
            label2.Text = "Các món ăn";
            // 
            // datamonan
            // 
            datamonan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datamonan.BackgroundColor = SystemColors.AppWorkspace;
            datamonan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datamonan.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            datamonan.Location = new Point(26, 132);
            datamonan.Margin = new Padding(3, 4, 3, 4);
            datamonan.Name = "datamonan";
            datamonan.RowHeadersWidth = 51;
            datamonan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datamonan.Size = new Size(571, 200);
            datamonan.TabIndex = 2;
            datamonan.CellContentClick += datamonan_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "STT";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Mã món ăn";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Tên món ăn";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Giá";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(695, 132);
            label3.Name = "label3";
            label3.Size = new Size(130, 26);
            label3.TabIndex = 3;
            label3.Text = "Tên món ăn:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 13.8F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(695, 179);
            label4.Name = "label4";
            label4.Size = new Size(50, 26);
            label4.TabIndex = 4;
            label4.Text = "Giá:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 13.8F);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(695, 229);
            label5.Name = "label5";
            label5.Size = new Size(102, 26);
            label5.TabIndex = 5;
            label5.Text = "Số lượng:";
            // 
            // name
            // 
            name.Location = new Point(855, 132);
            name.Margin = new Padding(3, 4, 3, 4);
            name.Name = "name";
            name.Size = new Size(152, 27);
            name.TabIndex = 6;
            // 
            // gia
            // 
            gia.Location = new Point(855, 180);
            gia.Margin = new Padding(3, 4, 3, 4);
            gia.Name = "gia";
            gia.Size = new Size(152, 27);
            gia.TabIndex = 7;
            // 
            // soluong
            // 
            soluong.Location = new Point(855, 229);
            soluong.Margin = new Padding(3, 4, 3, 4);
            soluong.Name = "soluong";
            soluong.Size = new Size(152, 27);
            soluong.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.Coral;
            button1.Location = new Point(695, 303);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(130, 39);
            button1.TabIndex = 9;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Coral;
            button2.Location = new Point(893, 303);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(130, 39);
            button2.TabIndex = 10;
            button2.Text = "Làm mới";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            label6.ForeColor = Color.MediumSpringGreen;
            label6.Location = new Point(381, 376);
            label6.Name = "label6";
            label6.Size = new Size(303, 32);
            label6.TabIndex = 11;
            label6.Text = "DANH SÁCH MÓN ĂN";
            // 
            // datacthd
            // 
            datacthd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datacthd.BackgroundColor = SystemColors.AppWorkspace;
            datacthd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datacthd.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6, Column7, Column8, Column9, Column10 });
            datacthd.Location = new Point(26, 442);
            datacthd.Margin = new Padding(3, 4, 3, 4);
            datacthd.Name = "datacthd";
            datacthd.RowHeadersWidth = 51;
            datacthd.Size = new Size(997, 163);
            datacthd.TabIndex = 12;
            datacthd.CellContentClick += datacthd_CellContentClick;
            // 
            // Column5
            // 
            Column5.HeaderText = "STT";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Mã món ăn";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Tên món ăn";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Số lượng";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Giá";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.HeaderText = "Thành tiền";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            // 
            // xongdon
            // 
            xongdon.BackColor = Color.Coral;
            xongdon.ForeColor = SystemColors.ControlText;
            xongdon.Location = new Point(45, 638);
            xongdon.Margin = new Padding(3, 4, 3, 4);
            xongdon.Name = "xongdon";
            xongdon.Size = new Size(129, 39);
            xongdon.TabIndex = 13;
            xongdon.Text = "Hoàn thành đơn";
            xongdon.UseVisualStyleBackColor = false;
            xongdon.Click += xongdon_Click_1;
            // 
            // tongtien
            // 
            tongtien.AutoSize = true;
            tongtien.BackColor = Color.Transparent;
            tongtien.Font = new Font("Times New Roman", 13.8F);
            tongtien.ForeColor = SystemColors.ControlLightLight;
            tongtien.Location = new Point(638, 643);
            tongtien.Name = "tongtien";
            tongtien.Size = new Size(107, 26);
            tongtien.TabIndex = 14;
            tongtien.Text = "Tổng tiền:";
            // 
            // BanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1089, 815);
            Controls.Add(tongtien);
            Controls.Add(xongdon);
            Controls.Add(datacthd);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(soluong);
            Controls.Add(gia);
            Controls.Add(name);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(datamonan);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BanHang";
            Text = "BanHang";
            Load += BanHang_Load;
            ((System.ComponentModel.ISupportInitialize)datamonan).EndInit();
            ((System.ComponentModel.ISupportInitialize)datacthd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView datamonan;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox name;
        private TextBox gia;
        private TextBox soluong;
        private Button button1;
        private Button button2;
        private Label label6;
        private DataGridView datacthd;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private Button xongdon;
        private Label tongtien;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}