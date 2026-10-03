namespace Bai9;

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
        panel1 = new Panel();
        panel2 = new Panel();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        groupBox1 = new GroupBox();
        groupBox2 = new GroupBox();
        groupBox3 = new GroupBox();
        rdoPhongDon = new RadioButton();
        rdoPhongDoi = new RadioButton();
        rdoPhongBa = new RadioButton();
        chkTivi = new CheckBox();
        chkInternet = new CheckBox();
        chkMayNuocNong = new CheckBox();
        chkKaraoke = new CheckBox();
        chkAnSang = new CheckBox();
        txtTenKhach = new TextBox();
        txtDiaChi = new TextBox();
        txtSoNgayO = new TextBox();
        btnThanhToan = new Button();
        btnNhapMoi = new Button();
        label5 = new Label();
        lblThanhTien = new TextBox();
        btnTongKet = new Button();
        label6 = new Label();
        label7 = new Label();
        label8 = new Label();
        txtTongSoLuot = new TextBox();
        txtTongSoTien = new TextBox();
        btnThoat = new Button();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox3.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(txtSoNgayO);
        panel1.Controls.Add(txtDiaChi);
        panel1.Controls.Add(txtTenKhach);
        panel1.Controls.Add(groupBox3);
        panel1.Controls.Add(groupBox2);
        panel1.Controls.Add(groupBox1);
        panel1.Controls.Add(label4);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(label2);
        panel1.Location = new Point(2, 112);
        panel1.Name = "panel1";
        panel1.Size = new Size(604, 378);
        panel1.TabIndex = 0;
        // 
        // panel2
        // 
        panel2.Controls.Add(btnThoat);
        panel2.Controls.Add(txtTongSoTien);
        panel2.Controls.Add(txtTongSoLuot);
        panel2.Controls.Add(label8);
        panel2.Controls.Add(label7);
        panel2.Controls.Add(label6);
        panel2.Controls.Add(btnTongKet);
        panel2.Controls.Add(lblThanhTien);
        panel2.Controls.Add(label5);
        panel2.Controls.Add(btnNhapMoi);
        panel2.Controls.Add(btnThanhToan);
        panel2.Location = new Point(603, 112);
        panel2.Name = "panel2";
        panel2.Size = new Size(371, 378);
        panel2.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 163);
        label1.ForeColor = Color.Orange;
        label1.Location = new Point(112, 35);
        label1.Name = "label1";
        label1.Size = new Size(713, 46);
        label1.TabIndex = 2;
        label1.Text = "KHÁCH SẠN THANH THANH - TRẢ PHÒNG\r\n";
        label1.Click += label1_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(57, 25);
        label2.Name = "label2";
        label2.Size = new Size(79, 20);
        label2.TabIndex = 0;
        label2.Text = "Họ Và Tên:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(57, 73);
        label3.Name = "label3";
        label3.Size = new Size(60, 20);
        label3.TabIndex = 1;
        label3.Text = "Địa Chỉ:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(57, 125);
        label4.Name = "label4";
        label4.Size = new Size(83, 20);
        label4.TabIndex = 2;
        label4.Text = "Số Ngày Ở:";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(rdoPhongBa);
        groupBox1.Controls.Add(rdoPhongDoi);
        groupBox1.Controls.Add(rdoPhongDon);
        groupBox1.Location = new Point(37, 189);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(159, 180);
        groupBox1.TabIndex = 3;
        groupBox1.TabStop = false;
        groupBox1.Text = "Loại Phòng";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(chkMayNuocNong);
        groupBox2.Controls.Add(chkInternet);
        groupBox2.Controls.Add(chkTivi);
        groupBox2.Location = new Point(218, 196);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(155, 173);
        groupBox2.TabIndex = 4;
        groupBox2.TabStop = false;
        groupBox2.Text = "Tiện Nghi";
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(chkAnSang);
        groupBox3.Controls.Add(chkKaraoke);
        groupBox3.Location = new Point(392, 201);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(141, 168);
        groupBox3.TabIndex = 5;
        groupBox3.TabStop = false;
        groupBox3.Text = "Dịch Vụ";
        // 
        // rdoPhongDon
        // 
        rdoPhongDon.AutoSize = true;
        rdoPhongDon.Location = new Point(6, 35);
        rdoPhongDon.Name = "rdoPhongDon";
        rdoPhongDon.Size = new Size(102, 24);
        rdoPhongDon.TabIndex = 0;
        rdoPhongDon.TabStop = true;
        rdoPhongDon.Text = "Phòng đơn";
        rdoPhongDon.UseVisualStyleBackColor = true;
        // 
        // rdoPhongDoi
        // 
        rdoPhongDoi.AutoSize = true;
        rdoPhongDoi.Location = new Point(6, 80);
        rdoPhongDoi.Name = "rdoPhongDoi";
        rdoPhongDoi.Size = new Size(98, 24);
        rdoPhongDoi.TabIndex = 1;
        rdoPhongDoi.TabStop = true;
        rdoPhongDoi.Text = "Phòng đôi";
        rdoPhongDoi.UseVisualStyleBackColor = true;
        // 
        // rdoPhongBa
        // 
        rdoPhongBa.AutoSize = true;
        rdoPhongBa.Location = new Point(6, 127);
        rdoPhongBa.Name = "rdoPhongBa";
        rdoPhongBa.Size = new Size(93, 24);
        rdoPhongBa.TabIndex = 2;
        rdoPhongBa.TabStop = true;
        rdoPhongBa.Text = "Phòng ba";
        rdoPhongBa.UseVisualStyleBackColor = true;
        // 
        // chkTivi
        // 
        chkTivi.AutoSize = true;
        chkTivi.Location = new Point(15, 29);
        chkTivi.Name = "chkTivi";
        chkTivi.Size = new Size(54, 24);
        chkTivi.TabIndex = 0;
        chkTivi.Text = "Tivi";
        chkTivi.UseVisualStyleBackColor = true;
        chkTivi.CheckedChanged += checkBox1_CheckedChanged;
        // 
        // chkInternet
        // 
        chkInternet.AutoSize = true;
        chkInternet.Location = new Point(15, 74);
        chkInternet.Name = "chkInternet";
        chkInternet.Size = new Size(82, 24);
        chkInternet.TabIndex = 1;
        chkInternet.Text = "Internet";
        chkInternet.UseVisualStyleBackColor = true;
        // 
        // chkMayNuocNong
        // 
        chkMayNuocNong.AutoSize = true;
        chkMayNuocNong.Location = new Point(15, 121);
        chkMayNuocNong.Name = "chkMayNuocNong";
        chkMayNuocNong.Size = new Size(140, 24);
        chkMayNuocNong.TabIndex = 2;
        chkMayNuocNong.Text = "Máy Nước Nóng";
        chkMayNuocNong.UseVisualStyleBackColor = true;
        // 
        // chkKaraoke
        // 
        chkKaraoke.AutoSize = true;
        chkKaraoke.Location = new Point(20, 46);
        chkKaraoke.Name = "chkKaraoke";
        chkKaraoke.Size = new Size(85, 24);
        chkKaraoke.TabIndex = 0;
        chkKaraoke.Text = "Karaoke";
        chkKaraoke.UseVisualStyleBackColor = true;
        // 
        // chkAnSang
        // 
        chkAnSang.AutoSize = true;
        chkAnSang.Location = new Point(20, 95);
        chkAnSang.Name = "chkAnSang";
        chkAnSang.Size = new Size(84, 24);
        chkAnSang.TabIndex = 1;
        chkAnSang.Text = "Ăn sáng";
        chkAnSang.UseVisualStyleBackColor = true;
        // 
        // txtTenKhach
        // 
        txtTenKhach.Location = new Point(183, 22);
        txtTenKhach.Name = "txtTenKhach";
        txtTenKhach.Size = new Size(221, 27);
        txtTenKhach.TabIndex = 6;
        // 
        // txtDiaChi
        // 
        txtDiaChi.Location = new Point(183, 70);
        txtDiaChi.Name = "txtDiaChi";
        txtDiaChi.Size = new Size(330, 27);
        txtDiaChi.TabIndex = 7;
        // 
        // txtSoNgayO
        // 
        txtSoNgayO.Location = new Point(183, 118);
        txtSoNgayO.Name = "txtSoNgayO";
        txtSoNgayO.Size = new Size(125, 27);
        txtSoNgayO.TabIndex = 8;
        // 
        // btnThanhToan
        // 
        btnThanhToan.Location = new Point(28, 20);
        btnThanhToan.Name = "btnThanhToan";
        btnThanhToan.Size = new Size(94, 29);
        btnThanhToan.TabIndex = 0;
        btnThanhToan.Text = "Thanh Toán";
        btnThanhToan.UseVisualStyleBackColor = true;
        // 
        // btnNhapMoi
        // 
        btnNhapMoi.Location = new Point(165, 21);
        btnNhapMoi.Name = "btnNhapMoi";
        btnNhapMoi.Size = new Size(94, 29);
        btnNhapMoi.TabIndex = 1;
        btnNhapMoi.Text = "Nhập Mới";
        btnNhapMoi.UseVisualStyleBackColor = true;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(28, 73);
        label5.Name = "label5";
        label5.Size = new Size(81, 20);
        label5.TabIndex = 2;
        label5.Text = "Thành tiền:";
        // 
        // lblThanhTien
        // 
        lblThanhTien.Location = new Point(114, 66);
        lblThanhTien.Name = "lblThanhTien";
        lblThanhTien.Size = new Size(213, 27);
        lblThanhTien.TabIndex = 3;
        // 
        // btnTongKet
        // 
        btnTongKet.Location = new Point(28, 121);
        btnTongKet.Name = "btnTongKet";
        btnTongKet.Size = new Size(94, 29);
        btnTongKet.TabIndex = 4;
        btnTongKet.Text = "Tổng Kết";
        btnTongKet.UseVisualStyleBackColor = true;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(28, 174);
        label6.Name = "label6";
        label6.Size = new Size(131, 20);
        label6.TabIndex = 5;
        label6.Text = "Thông tin tổng kết";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(28, 215);
        label7.Name = "label7";
        label7.Size = new Size(109, 20);
        label7.TabIndex = 6;
        label7.Text = "Số Lượt Người:";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(28, 258);
        label8.Name = "label8";
        label8.Size = new Size(99, 20);
        label8.TabIndex = 7;
        label8.Text = "Tổng Số Tiền:";
        // 
        // txtTongSoLuot
        // 
        txtTongSoLuot.Location = new Point(143, 212);
        txtTongSoLuot.Name = "txtTongSoLuot";
        txtTongSoLuot.Size = new Size(125, 27);
        txtTongSoLuot.TabIndex = 8;
        // 
        // txtTongSoTien
        // 
        txtTongSoTien.Location = new Point(143, 255);
        txtTongSoTien.Name = "txtTongSoTien";
        txtTongSoTien.Size = new Size(125, 27);
        txtTongSoTien.TabIndex = 9;
        // 
        // btnThoat
        // 
        btnThoat.Location = new Point(28, 317);
        btnThoat.Name = "btnThoat";
        btnThoat.Size = new Size(94, 29);
        btnThoat.TabIndex = 10;
        btnThoat.Text = "Thoát";
        btnThoat.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(970, 493);
        Controls.Add(label1);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Name = "Form1";
        Text = "Form1";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel panel1;
    private Panel panel2;
    private Label label1;
    private GroupBox groupBox3;
    private GroupBox groupBox2;
    private GroupBox groupBox1;
    private RadioButton rdoPhongDoi;
    private RadioButton rdoPhongDon;
    private Label label4;
    private Label label3;
    private Label label2;
    private CheckBox chkTivi;
    private RadioButton rdoPhongBa;
    private TextBox txtSoNgayO;
    private TextBox txtDiaChi;
    private TextBox txtTenKhach;
    private CheckBox chkAnSang;
    private CheckBox chkKaraoke;
    private CheckBox chkMayNuocNong;
    private CheckBox chkInternet;
    private TextBox txtTongSoTien;
    private TextBox txtTongSoLuot;
    private Label label8;
    private Label label7;
    private Label label6;
    private Button btnTongKet;
    private TextBox lblThanhTien;
    private Label label5;
    private Button btnNhapMoi;
    private Button btnThanhToan;
    private Button btnThoat;
}
