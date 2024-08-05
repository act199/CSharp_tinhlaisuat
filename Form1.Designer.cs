namespace CSharp_tinhlaisuat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnTinh = new Button();
            listBox1 = new ListBox();
            txtSotien = new TextBox();
            cbBLaixuat = new ComboBox();
            lblKetqua = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(285, 33);
            label1.Name = "label1";
            label1.Size = new Size(184, 15);
            label1.TabIndex = 0;
            label1.Text = "Ứng Dụng Tính Lãi Xuất Tiết Kiệm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 88);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Số tiền :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 122);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Lãi suất :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 156);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 3;
            label4.Text = "Số năm gửi :";
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(355, 195);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(75, 23);
            btnTinh.TabIndex = 4;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(126, 224);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(524, 214);
            listBox1.TabIndex = 5;
            // 
            // txtSotien
            // 
            txtSotien.Location = new Point(232, 88);
            txtSotien.Name = "txtSotien";
            txtSotien.Size = new Size(121, 23);
            txtSotien.TabIndex = 6;
            // 
            // cbBLaixuat
            // 
            cbBLaixuat.FormattingEnabled = true;
            cbBLaixuat.Location = new Point(232, 119);
            cbBLaixuat.Name = "cbBLaixuat";
            cbBLaixuat.Size = new Size(121, 23);
            cbBLaixuat.TabIndex = 7;
            // 
            // lblKetqua
            // 
            lblKetqua.AutoSize = true;
            lblKetqua.Location = new Point(126, 199);
            lblKetqua.Name = "lblKetqua";
            lblKetqua.Size = new Size(49, 15);
            lblKetqua.TabIndex = 9;
            lblKetqua.Text = "Kết Quả";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(232, 154);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(lblKetqua);
            Controls.Add(cbBLaixuat);
            Controls.Add(txtSotien);
            Controls.Add(listBox1);
            Controls.Add(btnTinh);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnTinh;
        private ListBox listBox1;
        private TextBox txtSotien;
        private ComboBox cbBLaixuat;
        private Label lblKetqua;
        private NumericUpDown numericUpDown1;
    }
}
