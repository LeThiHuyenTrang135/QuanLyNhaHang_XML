namespace Web_QuanLyNhaHang
{
    partial class Login
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxTenDN = new TextBox();
            textBoxMatKhau = new TextBox();
            btDangNhap = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1027, 558);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(329, 121);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(179, 23);
            label1.TabIndex = 1;
            label1.Text = "XIN CHÀO ADMIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(200, 183);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 2;
            label2.Text = "Nhập tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(200, 267);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 3;
            label3.Text = "Nhập mật khẩu";
            // 
            // textBoxTenDN
            // 
            textBoxTenDN.Location = new Point(253, 224);
            textBoxTenDN.Name = "textBoxTenDN";
            textBoxTenDN.Size = new Size(255, 28);
            textBoxTenDN.TabIndex = 4;
            // 
            // textBoxMatKhau
            // 
            textBoxMatKhau.Location = new Point(253, 307);
            textBoxMatKhau.Name = "textBoxMatKhau";
            textBoxMatKhau.Size = new Size(255, 28);
            textBoxMatKhau.TabIndex = 5;
            // 
            // btDangNhap
            // 
            btDangNhap.BackColor = Color.Navy;
            btDangNhap.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDangNhap.ForeColor = SystemColors.ControlLightLight;
            btDangNhap.Location = new Point(305, 409);
            btDangNhap.Name = "btDangNhap";
            btDangNhap.Size = new Size(174, 45);
            btDangNhap.TabIndex = 6;
            btDangNhap.Text = "ĐĂNG NHẬP";
            btDangNhap.UseVisualStyleBackColor = false;
            btDangNhap.Click += btDangNhap_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 555);
            Controls.Add(btDangNhap);
            Controls.Add(textBoxMatKhau);
            Controls.Add(textBoxTenDN);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxTenDN;
        private TextBox textBoxMatKhau;
        private Button btDangNhap;
    }
}