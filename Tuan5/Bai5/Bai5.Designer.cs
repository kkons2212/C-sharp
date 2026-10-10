namespace Bai5
{
    partial class Form1
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
            listView1 = new ListView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            lstDanhSach = new ListBox();
            btnNhap = new Button();
            txtSoN = new TextBox();
            groupBox2 = new GroupBox();
            btnChonLe = new Button();
            btnChonChan = new Button();
            btnBinhPhuong = new Button();
            btnTang2 = new Button();
            btnXoaDangChon = new Button();
            btnXoaDauCuoi = new Button();
            btnTinhTong = new Button();
            btnKetThuc = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(71, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(731, 110);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(335, 24);
            label1.Name = "label1";
            label1.Size = new Size(201, 62);
            label1.TabIndex = 1;
            label1.Text = "LISTBOX";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstDanhSach);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(txtSoN);
            groupBox1.Location = new Point(185, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(253, 357);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "ListBox";
            // 
            // lstDanhSach
            // 
            lstDanhSach.FormattingEnabled = true;
            lstDanhSach.Location = new Point(10, 130);
            lstDanhSach.Name = "lstDanhSach";
            lstDanhSach.SelectionMode = SelectionMode.MultiExtended;
            lstDanhSach.Size = new Size(164, 224);
            lstDanhSach.TabIndex = 2;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(6, 86);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(125, 29);
            btnNhap.TabIndex = 1;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // txtSoN
            // 
            txtSoN.Location = new Point(6, 42);
            txtSoN.Name = "txtSoN";
            txtSoN.Size = new Size(125, 27);
            txtSoN.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnChonLe);
            groupBox2.Controls.Add(btnChonChan);
            groupBox2.Controls.Add(btnBinhPhuong);
            groupBox2.Controls.Add(btnTang2);
            groupBox2.Controls.Add(btnXoaDangChon);
            groupBox2.Controls.Add(btnXoaDauCuoi);
            groupBox2.Controls.Add(btnTinhTong);
            groupBox2.Location = new Point(499, 128);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(270, 354);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Xử Lý ListBox";
            // 
            // btnChonLe
            // 
            btnChonLe.Location = new Point(37, 311);
            btnChonLe.Name = "btnChonLe";
            btnChonLe.Size = new Size(227, 37);
            btnChonLe.TabIndex = 6;
            btnChonLe.Text = "Chọn số lẻ";
            btnChonLe.UseVisualStyleBackColor = true;
            // 
            // btnChonChan
            // 
            btnChonChan.Location = new Point(37, 263);
            btnChonChan.Name = "btnChonChan";
            btnChonChan.Size = new Size(227, 42);
            btnChonChan.TabIndex = 5;
            btnChonChan.Text = "Chọn số chẵn";
            btnChonChan.UseVisualStyleBackColor = true;
            // 
            // btnBinhPhuong
            // 
            btnBinhPhuong.Location = new Point(37, 218);
            btnBinhPhuong.Name = "btnBinhPhuong";
            btnBinhPhuong.Size = new Size(227, 39);
            btnBinhPhuong.TabIndex = 4;
            btnBinhPhuong.Text = "Thay Bằng bình phương";
            btnBinhPhuong.UseVisualStyleBackColor = true;
            // 
            // btnTang2
            // 
            btnTang2.Location = new Point(37, 177);
            btnTang2.Name = "btnTang2";
            btnTang2.Size = new Size(227, 35);
            btnTang2.TabIndex = 3;
            btnTang2.Text = "Tăng mỗi phần tử lên 2";
            btnTang2.UseVisualStyleBackColor = true;
            // 
            // btnXoaDangChon
            // 
            btnXoaDangChon.Location = new Point(37, 130);
            btnXoaDangChon.Name = "btnXoaDangChon";
            btnXoaDangChon.Size = new Size(227, 42);
            btnXoaDangChon.TabIndex = 2;
            btnXoaDangChon.Text = "Xóa Phần tử đang chọn";
            btnXoaDangChon.UseVisualStyleBackColor = true;
            // 
            // btnXoaDauCuoi
            // 
            btnXoaDauCuoi.Location = new Point(37, 79);
            btnXoaDauCuoi.Name = "btnXoaDauCuoi";
            btnXoaDauCuoi.Size = new Size(227, 45);
            btnXoaDauCuoi.TabIndex = 1;
            btnXoaDauCuoi.Text = "Xóa Phần tử đầu và cuối";
            btnXoaDauCuoi.UseVisualStyleBackColor = true;
            // 
            // btnTinhTong
            // 
            btnTinhTong.Location = new Point(37, 32);
            btnTinhTong.Name = "btnTinhTong";
            btnTinhTong.Size = new Size(227, 41);
            btnTinhTong.TabIndex = 0;
            btnTinhTong.Text = "Tổng các phần tử trong List";
            btnTinhTong.UseVisualStyleBackColor = true;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(219, 491);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(509, 41);
            btnKetThuc.TabIndex = 4;
            btnKetThuc.Text = "Kết Thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 556);
            Controls.Add(btnKetThuc);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnNhap;
        private TextBox txtSoN;
        private GroupBox groupBox2;
        private ListBox lstDanhSach;
        private Button btnChonLe;
        private Button btnChonChan;
        private Button btnBinhPhuong;
        private Button btnTang2;
        private Button btnXoaDangChon;
        private Button btnXoaDauCuoi;
        private Button btnTinhTong;
        private Button btnKetThuc;
    }
}