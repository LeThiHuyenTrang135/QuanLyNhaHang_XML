namespace Web_QuanLyNhaHang
{
    partial class QuanLyDanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyDanhMuc));
            label1 = new Label();
            label2 = new Label();
            name = new TextBox();
            label3 = new Label();
            mota = new RichTextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumSpringGreen;
            label1.Location = new Point(283, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(520, 32);
            label1.TabIndex = 0;
            label1.Text = "------------QUẢN LÝ DANH MỤC------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(50, 106);
            label2.Name = "label2";
            label2.Size = new Size(146, 26);
            label2.TabIndex = 1;
            label2.Text = "Tên danh mục";
            // 
            // name
            // 
            name.Location = new Point(214, 103);
            name.Name = "name";
            name.Size = new Size(703, 30);
            name.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(50, 174);
            label3.Name = "label3";
            label3.Size = new Size(65, 26);
            label3.TabIndex = 3;
            label3.Text = "Mô tả";
            // 
            // mota
            // 
            mota.Location = new Point(214, 174);
            mota.Name = "mota";
            mota.Size = new Size(703, 116);
            mota.TabIndex = 4;
            mota.Text = "";
            // 
            // button4
            // 
            button4.BackColor = Color.Coral;
            button4.Location = new Point(781, 331);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 21;
            button4.Text = "Làm mới";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Location = new Point(583, 331);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 20;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Coral;
            button2.Location = new Point(380, 331);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 19;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Coral;
            button1.Location = new Point(195, 331);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 18;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(50, 375);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1020, 197);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            Column2.HeaderText = "MÃ DANH MỤC";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "TÊN DANH MỤC";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "MÔ TẢ";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 600;
            // 
            // QuanLyDanhMuc
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1143, 686);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(mota);
            Controls.Add(label3);
            Controls.Add(name);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "QuanLyDanhMuc";
            Load += QuanLyDanhMuc_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox name;
        private Label label3;
        private RichTextBox mota;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
