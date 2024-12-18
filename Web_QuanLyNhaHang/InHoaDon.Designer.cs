namespace Web_QuanLyNhaHang
{
    partial class InHoaDon
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
            richTextBoxContent = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBoxContent
            // 
            richTextBoxContent.Location = new Point(3, 12);
            richTextBoxContent.Name = "richTextBoxContent";
            richTextBoxContent.Size = new Size(933, 392);
            richTextBoxContent.TabIndex = 0;
            richTextBoxContent.Text = "";
            richTextBoxContent.TextChanged += richTextBoxContent_TextChanged;
            // 
            // InHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 406);
            Controls.Add(richTextBoxContent);
            Name = "InHoaDon";
            Load += InHoaDon_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBoxContent;
    }
}
