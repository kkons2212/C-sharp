namespace Bai2
{
    partial class Bai2
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
            panel1 = new Panel();
            tvDanhSachLop = new TreeView();
            groupBox1 = new GroupBox();
            txtDiaChi = new TextBox();
            txtHoTen = new TextBox();
            txtMaSV = new TextBox();
            btnXoa = new Button();
            btnCapNhat = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cboChonLop = new ComboBox();
            chkThemLop = new CheckBox();
            grpThemLop = new GroupBox();
            label5 = new Label();
            txtTenLop = new TextBox();
            btnThemLop = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            grpThemLop.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tvDanhSachLop);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 566);
            panel1.TabIndex = 0;
            // 
            // tvDanhSachLop
            // 
            tvDanhSachLop.Location = new Point(3, 0);
            tvDanhSachLop.Name = "tvDanhSachLop";
            tvDanhSachLop.Size = new Size(265, 551);
            tvDanhSachLop.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(txtMaSV);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnCapNhat);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(295, 147);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 258);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(194, 152);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(249, 27);
            txtDiaChi.TabIndex = 7;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(194, 106);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(249, 27);
            txtHoTen.TabIndex = 6;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(194, 50);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(249, 27);
            txtMaSV.TabIndex = 5;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(349, 205);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(194, 205);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 29);
            btnCapNhat.TabIndex = 3;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 152);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 2;
            label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 106);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 1;
            label3.Text = "Họ tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 50);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã Sinh viên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(308, 51);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "Chọn Lớp:";
            label1.Click += label1_Click;
            // 
            // cboChonLop
            // 
            cboChonLop.FormattingEnabled = true;
            cboChonLop.Location = new Point(414, 48);
            cboChonLop.Name = "cboChonLop";
            cboChonLop.Size = new Size(324, 28);
            cboChonLop.TabIndex = 4;
            cboChonLop.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // chkThemLop
            // 
            chkThemLop.AutoSize = true;
            chkThemLop.Location = new Point(295, 425);
            chkThemLop.Name = "chkThemLop";
            chkThemLop.Size = new Size(97, 24);
            chkThemLop.TabIndex = 5;
            chkThemLop.Text = "Thêm Lớp";
            chkThemLop.UseVisualStyleBackColor = true;
            // 
            // grpThemLop
            // 
            grpThemLop.Controls.Add(btnThemLop);
            grpThemLop.Controls.Add(txtTenLop);
            grpThemLop.Controls.Add(label5);
            grpThemLop.Location = new Point(287, 468);
            grpThemLop.Name = "grpThemLop";
            grpThemLop.Size = new Size(516, 93);
            grpThemLop.TabIndex = 6;
            grpThemLop.TabStop = false;
            grpThemLop.Text = "Thêm Lớp";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 50);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 0;
            label5.Text = "Tên Lớp:";
            // 
            // txtTenLop
            // 
            txtTenLop.Location = new Point(127, 47);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(169, 27);
            txtTenLop.TabIndex = 1;
            // 
            // btnThemLop
            // 
            btnThemLop.Location = new Point(357, 38);
            btnThemLop.Name = "btnThemLop";
            btnThemLop.Size = new Size(94, 44);
            btnThemLop.TabIndex = 2;
            btnThemLop.Text = "Thêm Lớp";
            btnThemLop.UseVisualStyleBackColor = true;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 567);
            Controls.Add(grpThemLop);
            Controls.Add(chkThemLop);
            Controls.Add(cboChonLop);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Bai2";
            Text = "Form1";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpThemLop.ResumeLayout(false);
            grpThemLop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TreeView tvDanhSachLop;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cboChonLop;
        private TextBox txtDiaChi;
        private TextBox txtHoTen;
        private TextBox txtMaSV;
        private Button btnXoa;
        private Button btnCapNhat;
        private Label label4;
        private Label label3;
        private Label label2;
        private CheckBox chkThemLop;
        private GroupBox grpThemLop;
        private Button btnThemLop;
        private TextBox txtTenLop;
        private Label label5;
    }
}
