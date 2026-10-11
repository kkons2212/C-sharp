namespace Bai8
{
    partial class Bai8
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
            label5 = new Label();
            label6 = new Label();
            txtSoTaiKhoan = new TextBox();
            txtTenKhachHang = new TextBox();
            txtDiaChi = new TextBox();
            txtSoTien = new TextBox();
            lsvTaiKhoan = new ListView();
            label7 = new Label();
            txtTongTien = new TextBox();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            btnThem = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(81, 28);
            label1.Name = "label1";
            label1.Size = new Size(650, 62);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Thông tin tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 110);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 1;
            label2.Text = "Số tài khoản";
            label2.Click += this.label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 165);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên khách hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 210);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ khách hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 4;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(103, 257);
            label6.Name = "label6";
            label6.Size = new Size(160, 20);
            label6.TabIndex = 5;
            label6.Text = "Số tiền trong tài khoản";
            // 
            // txtSoTaiKhoan
            // 
            txtSoTaiKhoan.Location = new Point(285, 110);
            txtSoTaiKhoan.Name = "txtSoTaiKhoan";
            txtSoTaiKhoan.Size = new Size(432, 27);
            txtSoTaiKhoan.TabIndex = 6;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(285, 158);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(432, 27);
            txtTenKhachHang.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(285, 207);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(432, 27);
            txtDiaChi.TabIndex = 8;
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(285, 254);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(432, 27);
            txtSoTien.TabIndex = 9;
            // 
            // lsvTaiKhoan
            // 
            lsvTaiKhoan.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lsvTaiKhoan.FullRowSelect = true;
            lsvTaiKhoan.GridLines = true;
            lsvTaiKhoan.Location = new Point(63, 371);
            lsvTaiKhoan.Name = "lsvTaiKhoan";
            lsvTaiKhoan.Size = new Size(701, 220);
            lsvTaiKhoan.TabIndex = 10;
            lsvTaiKhoan.UseCompatibleStateImageBehavior = false;
            lsvTaiKhoan.View = View.Details;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(482, 618);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 11;
            label7.Text = "Tổng Tiền";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(606, 611);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(125, 27);
            txtTongTien.TabIndex = 12;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Số Thứ Tự ";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số Tài Khoản";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tên Khách Hàng";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Địa Chỉ";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Số Tiền";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 150;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(285, 320);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 13;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Enabled = false;
            btnLuu.Location = new Point(395, 320);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 14;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Location = new Point(510, 320);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(623, 320);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 16;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // Bai8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 668);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(btnThem);
            Controls.Add(txtTongTien);
            Controls.Add(label7);
            Controls.Add(lsvTaiKhoan);
            Controls.Add(txtSoTien);
            Controls.Add(txtDiaChi);
            Controls.Add(txtTenKhachHang);
            Controls.Add(txtSoTaiKhoan);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai8";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtSoTaiKhoan;
        private TextBox txtTenKhachHang;
        private TextBox txtDiaChi;
        private TextBox txtSoTien;
        private ListView lsvTaiKhoan;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label7;
        private TextBox txtTongTien;
        private Button btnThem;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnThoat;
    }
}
