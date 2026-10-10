namespace Bai4
{
    partial class Bai4
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtNghiaViet = new TextBox(); // Đã đổi tên từ textBox2 thành txtNghiaViet
            label4 = new Label();
            lstTuAnh = new ListBox();
            cboTuAnh = new ComboBox();
            label3 = new Label();
            tabPage2 = new TabPage();
            txtNghiaAnh = new TextBox();
            label2 = new Label();
            lstTuViet = new ListBox();
            cboTuViet = new ComboBox();
            label1 = new Label();
            btnThoat = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(61, 35);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(584, 439);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtNghiaViet);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(lstTuAnh);
            tabPage1.Controls.Add(cboTuAnh);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(576, 406);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Anh-Việt ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtNghiaViet
            // 
            txtNghiaViet.Location = new Point(328, 56);
            txtNghiaViet.Multiline = true;
            txtNghiaViet.Name = "txtNghiaViet";
            txtNghiaViet.Size = new Size(212, 344);
            txtNghiaViet.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(340, 22);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 4;
            label4.Text = "Tiếng Việt";
            // 
            // lstTuAnh
            // 
            lstTuAnh.FormattingEnabled = true;
            lstTuAnh.Location = new Point(30, 96);
            lstTuAnh.Name = "lstTuAnh";
            lstTuAnh.Size = new Size(218, 304);
            lstTuAnh.TabIndex = 3;
            // 
            // cboTuAnh
            // 
            cboTuAnh.FormattingEnabled = true;
            cboTuAnh.Location = new Point(30, 56);
            cboTuAnh.Name = "cboTuAnh";
            cboTuAnh.Size = new Size(151, 28);
            cboTuAnh.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 22);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 1;
            label3.Text = "Tiếng Anh";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtNghiaAnh);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(lstTuViet);
            tabPage2.Controls.Add(cboTuViet);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(576, 406);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Việt-Anh";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtNghiaAnh
            // 
            txtNghiaAnh.Location = new Point(334, 59);
            txtNghiaAnh.Multiline = true;
            txtNghiaAnh.Name = "txtNghiaAnh";
            txtNghiaAnh.Size = new Size(212, 344);
            txtNghiaAnh.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(358, 36);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 3;
            label2.Text = "Tiếng Anh";
            // 
            // lstTuViet
            // 
            lstTuViet.FormattingEnabled = true;
            lstTuViet.Location = new Point(38, 93);
            lstTuViet.Name = "lstTuViet";
            lstTuViet.Size = new Size(218, 304);
            lstTuViet.TabIndex = 2;
            // 
            // cboTuViet
            // 
            cboTuViet.FormattingEnabled = true;
            cboTuViet.Location = new Point(38, 59);
            cboTuViet.Name = "cboTuViet";
            cboTuViet.Size = new Size(151, 28);
            cboTuViet.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 36);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Tiếng Việt";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(672, 482);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 523);
            Controls.Add(btnThoat);
            Controls.Add(tabControl1);
            Name = "Bai4";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListBox lstTuViet;
        private ComboBox cboTuViet;
        private Label label1;
        private TextBox txtNghiaAnh;
        private Label label2;
        private TextBox txtNghiaViet; // Khai báo đúng tên txtNghiaViet
        private Label label4;
        private ListBox lstTuAnh;
        private ComboBox cboTuAnh;
        private Label label3;
        private Button btnThoat;
    }
}