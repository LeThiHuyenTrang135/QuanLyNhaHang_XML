namespace Web_QuanLyNhaHang
{
    partial class QuanLyMonAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyMonAn));
            label1 = new Label();
            label2 = new Label();
            comboBoxdanhmuc = new ComboBox();
            label3 = new Label();
            tenmonan = new TextBox();
            giamonan = new TextBox();
            label4 = new Label();
            btrefresh = new Button();
            btdelete = new Button();
            btupdate = new Button();
            btadd = new Button();
            dataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LimeGreen;
            label1.Location = new Point(270, 27);
            label1.Name = "label1";
            label1.Size = new Size(516, 32);
            label1.TabIndex = 0;
            label1.Text = "--------------QUẢN LÝ MÓN ĂN--------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(74, 112);
            label2.Name = "label2";
            label2.Size = new Size(108, 26);
            label2.TabIndex = 1;
            label2.Text = "Danh mục";
            // 
            // comboBoxdanhmuc
            // 
            comboBoxdanhmuc.FormattingEnabled = true;
            comboBoxdanhmuc.Location = new Point(216, 111);
            comboBoxdanhmuc.Name = "comboBoxdanhmuc";
            comboBoxdanhmuc.Size = new Size(702, 27);
            comboBoxdanhmuc.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(74, 193);
            label3.Name = "label3";
            label3.Size = new Size(124, 26);
            label3.TabIndex = 3;
            label3.Text = "Tên món ăn";
            // 
            // tenmonan
            // 
            tenmonan.Location = new Point(216, 192);
            tenmonan.Name = "tenmonan";
            tenmonan.Size = new Size(283, 27);
            tenmonan.TabIndex = 4;
            // 
            // giamonan
            // 
            giamonan.Location = new Point(635, 192);
            giamonan.Name = "giamonan";
            giamonan.Size = new Size(283, 27);
            giamonan.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(576, 193);
            label4.Name = "label4";
            label4.Size = new Size(44, 26);
            label4.TabIndex = 5;
            label4.Text = "Giá";
            label4.Click += label4_Click;
            // 
            // btrefresh
            // 
            btrefresh.BackColor = Color.Coral;
            btrefresh.Location = new Point(770, 275);
            btrefresh.Name = "btrefresh";
            btrefresh.Size = new Size(94, 29);
            btrefresh.TabIndex = 21;
            btrefresh.Text = "Làm mới";
            btrefresh.UseVisualStyleBackColor = false;
            btrefresh.Click += btrefresh_Click_1;
            // 
            // btdelete
            // 
            btdelete.BackColor = Color.Red;
            btdelete.Location = new Point(572, 275);
            btdelete.Name = "btdelete";
            btdelete.Size = new Size(94, 29);
            btdelete.TabIndex = 20;
            btdelete.Text = "Xóa";
            btdelete.UseVisualStyleBackColor = false;
            btdelete.Click += btdelete_Click_1;
            // 
            // btupdate
            // 
            btupdate.BackColor = Color.Coral;
            btupdate.Location = new Point(369, 275);
            btupdate.Name = "btupdate";
            btupdate.Size = new Size(94, 29);
            btupdate.TabIndex = 19;
            btupdate.Text = "Sửa";
            btupdate.UseVisualStyleBackColor = false;
            btupdate.Click += btupdate_Click_1;
            // 
            // btadd
            // 
            btadd.BackColor = Color.Coral;
            btadd.Location = new Point(184, 275);
            btadd.Name = "btadd";
            btadd.Size = new Size(94, 29);
            btadd.TabIndex = 18;
            btadd.Text = "Thêm";
            btadd.UseVisualStyleBackColor = false;
            btadd.Click += btadd_Click_1;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView.Location = new Point(55, 331);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(956, 218);
            dataGridView.TabIndex = 22;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "STT";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "MÃ MÓN ĂN";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "TÊN MÓN ĂN";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 300;
            // 
            // Column4
            // 
            Column4.HeaderText = "GIÁ";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "DANH MỤC";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 250;
            // 
            // QuanLyMonAn
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1034, 612);
            Controls.Add(dataGridView);
            Controls.Add(btrefresh);
            Controls.Add(btdelete);
            Controls.Add(btupdate);
            Controls.Add(btadd);
            Controls.Add(giamonan);
            Controls.Add(label4);
            Controls.Add(tenmonan);
            Controls.Add(label3);
            Controls.Add(comboBoxdanhmuc);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "QuanLyMonAn";
            Load += QuanLyMonAn_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBoxdanhmuc;
        private Label label3;
        private TextBox tenmonan;
        private TextBox giamonan;
        private Label label4;
        private Button btrefresh;
        private Button btdelete;
        private Button btupdate;
        private Button btadd;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
