namespace Bai8;

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
        txtNhapMang = new TextBox();
        txtKetQuaMang = new TextBox();
        btnReset = new Button();
        btnThoat = new Button();
        btnThucHien = new Button();
        groupBox1 = new GroupBox();
        rdoGiam = new RadioButton();
        rdoTang = new RadioButton();
        groupBox2 = new GroupBox();
        txtTimOutput = new TextBox();
        txtTimViTri = new TextBox();
        txtTimGiaTri = new TextBox();
        label12 = new Label();
        rdoTimViTri = new RadioButton();
        rdoTimGiaTri = new RadioButton();
        groupBox3 = new GroupBox();
        textBox7 = new TextBox();
        txtXoaInput = new TextBox();
        label13 = new Label();
        rdoXoaViTri = new RadioButton();
        rdoXoaGiaTri = new RadioButton();
        groupBox4 = new GroupBox();
        label5 = new Label();
        txtThemIdx = new TextBox();
        txtThemVal = new TextBox();
        label4 = new Label();
        radioButton7 = new RadioButton();
        groupBox5 = new GroupBox();
        txtTongLe = new TextBox();
        txtTongChan = new TextBox();
        txtTongMang = new TextBox();
        btnTong = new Button();
        label8 = new Label();
        TongChan = new Label();
        label6 = new Label();
        groupBox6 = new GroupBox();
        txtMin = new TextBox();
        txtMax = new TextBox();
        btnMaxMin = new Button();
        label10 = new Label();
        label9 = new Label();
        groupBox7 = new GroupBox();
        txtThayMoi = new TextBox();
        textBox17 = new TextBox();
        txtThayCu = new TextBox();
        label11 = new Label();
        rdoThayViTri = new RadioButton();
        rdoThayGiaTri = new RadioButton();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox4.SuspendLayout();
        groupBox5.SuspendLayout();
        groupBox6.SuspendLayout();
        groupBox7.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
        label1.ForeColor = Color.Red;
        label1.Location = new Point(147, 32);
        label1.Name = "label1";
        label1.Size = new Size(322, 50);
        label1.TabIndex = 0;
        label1.Text = "Mảng Số Nguyên";
        label1.Click += label1_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(74, 118);
        label2.Name = "label2";
        label2.Size = new Size(90, 20);
        label2.TabIndex = 1;
        label2.Text = "Nhập Mảng:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(58, 166);
        label3.Name = "label3";
        label3.Size = new Size(107, 20);
        label3.TabIndex = 2;
        label3.Text = "Kết Quả Mảng:";
        // 
        // txtNhapMang
        // 
        txtNhapMang.Location = new Point(179, 115);
        txtNhapMang.Name = "txtNhapMang";
        txtNhapMang.Size = new Size(263, 27);
        txtNhapMang.TabIndex = 3;
        // 
        // txtKetQuaMang
        // 
        txtKetQuaMang.Location = new Point(179, 163);
        txtKetQuaMang.Name = "txtKetQuaMang";
        txtKetQuaMang.Size = new Size(263, 27);
        txtKetQuaMang.TabIndex = 4;
        // 
        // btnReset
        // 
        btnReset.Location = new Point(472, 109);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(94, 29);
        btnReset.TabIndex = 5;
        btnReset.Text = "Reset";
        btnReset.UseVisualStyleBackColor = true;
        // 
        // btnThoat
        // 
        btnThoat.Location = new Point(472, 166);
        btnThoat.Name = "btnThoat";
        btnThoat.Size = new Size(94, 29);
        btnThoat.TabIndex = 6;
        btnThoat.Text = "Thoát";
        btnThoat.UseVisualStyleBackColor = true;
        // 
        // btnThucHien
        // 
        btnThucHien.Location = new Point(74, 227);
        btnThucHien.Name = "btnThucHien";
        btnThucHien.Size = new Size(99, 62);
        btnThucHien.TabIndex = 7;
        btnThucHien.Text = "Thực Hiện";
        btnThucHien.UseVisualStyleBackColor = true;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(rdoGiam);
        groupBox1.Controls.Add(rdoTang);
        groupBox1.Location = new Point(280, 227);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(308, 70);
        groupBox1.TabIndex = 8;
        groupBox1.TabStop = false;
        groupBox1.Text = "Sắp Xếp";
        groupBox1.Enter += groupBox1_Enter;
        // 
        // rdoGiam
        // 
        rdoGiam.AutoSize = true;
        rdoGiam.Location = new Point(169, 26);
        rdoGiam.Name = "rdoGiam";
        rdoGiam.Size = new Size(124, 24);
        rdoGiam.TabIndex = 1;
        rdoGiam.TabStop = true;
        rdoGiam.Text = "Sắp Xếp Giảm";
        rdoGiam.UseVisualStyleBackColor = true;
        // 
        // rdoTang
        // 
        rdoTang.AutoSize = true;
        rdoTang.Location = new Point(20, 26);
        rdoTang.Name = "rdoTang";
        rdoTang.Size = new Size(121, 24);
        rdoTang.TabIndex = 0;
        rdoTang.TabStop = true;
        rdoTang.Text = "Sắp Xếp Tăng";
        rdoTang.UseVisualStyleBackColor = true;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(txtTimOutput);
        groupBox2.Controls.Add(txtTimViTri);
        groupBox2.Controls.Add(txtTimGiaTri);
        groupBox2.Controls.Add(label12);
        groupBox2.Controls.Add(rdoTimViTri);
        groupBox2.Controls.Add(rdoTimGiaTri);
        groupBox2.Location = new Point(74, 339);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(261, 149);
        groupBox2.TabIndex = 9;
        groupBox2.TabStop = false;
        groupBox2.Text = "Tìm Kiếm";
        // 
        // txtTimOutput
        // 
        txtTimOutput.Location = new Point(163, 113);
        txtTimOutput.Name = "txtTimOutput";
        txtTimOutput.ReadOnly = true;
        txtTimOutput.Size = new Size(56, 27);
        txtTimOutput.TabIndex = 5;
        txtTimOutput.TextChanged += textBox5_TextChanged;
        // 
        // txtTimViTri
        // 
        txtTimViTri.Location = new Point(163, 70);
        txtTimViTri.Name = "txtTimViTri";
        txtTimViTri.Size = new Size(81, 27);
        txtTimViTri.TabIndex = 4;
        // 
        // txtTimGiaTri
        // 
        txtTimGiaTri.Location = new Point(163, 34);
        txtTimGiaTri.Name = "txtTimGiaTri";
        txtTimGiaTri.Size = new Size(81, 27);
        txtTimGiaTri.TabIndex = 3;
        txtTimGiaTri.TextChanged += textBox3_TextChanged;
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new Point(26, 116);
        label12.Name = "label12";
        label12.Size = new Size(117, 20);
        label12.TabIndex = 2;
        label12.Text = "Số Tìm Được Là:";
        // 
        // rdoTimViTri
        // 
        rdoTimViTri.AutoSize = true;
        rdoTimViTri.Location = new Point(6, 71);
        rdoTimViTri.Name = "rdoTimViTri";
        rdoTimViTri.Size = new Size(150, 24);
        rdoTimViTri.TabIndex = 1;
        rdoTimViTri.TabStop = true;
        rdoTimViTri.Text = "Tìm Vị Trí Cần Tìm";
        rdoTimViTri.UseVisualStyleBackColor = true;
        // 
        // rdoTimGiaTri
        // 
        rdoTimGiaTri.AutoSize = true;
        rdoTimGiaTri.Location = new Point(6, 35);
        rdoTimGiaTri.Name = "rdoTimGiaTri";
        rdoTimGiaTri.Size = new Size(159, 24);
        rdoTimGiaTri.TabIndex = 0;
        rdoTimGiaTri.TabStop = true;
        rdoTimGiaTri.Text = "Tìm Giá Trị Cần Tìm";
        rdoTimGiaTri.UseVisualStyleBackColor = true;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(textBox7);
        groupBox3.Controls.Add(txtXoaInput);
        groupBox3.Controls.Add(label13);
        groupBox3.Controls.Add(rdoXoaViTri);
        groupBox3.Controls.Add(rdoXoaGiaTri);
        groupBox3.Location = new Point(386, 339);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(250, 149);
        groupBox3.TabIndex = 10;
        groupBox3.TabStop = false;
        groupBox3.Text = "Xóa";
        // 
        // textBox7
        // 
        textBox7.Location = new Point(180, 71);
        textBox7.Name = "textBox7";
        textBox7.Size = new Size(64, 27);
        textBox7.TabIndex = 4;
        // 
        // txtXoaInput
        // 
        txtXoaInput.Location = new Point(180, 34);
        txtXoaInput.Name = "txtXoaInput";
        txtXoaInput.Size = new Size(64, 27);
        txtXoaInput.TabIndex = 3;
        txtXoaInput.TextChanged += textBox6_TextChanged;
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
        label13.ForeColor = Color.Red;
        label13.Location = new Point(26, 108);
        label13.Name = "label13";
        label13.Size = new Size(180, 28);
        label13.TabIndex = 2;
        label13.Text = "Cần Sắp Xếp Tăng";
        // 
        // rdoXoaViTri
        // 
        rdoXoaViTri.AutoSize = true;
        rdoXoaViTri.Location = new Point(6, 71);
        rdoXoaViTri.Name = "rdoXoaViTri";
        rdoXoaViTri.Size = new Size(151, 24);
        rdoXoaViTri.TabIndex = 1;
        rdoXoaViTri.TabStop = true;
        rdoXoaViTri.Text = "Tìm Vị Trí Cần Xóa";
        rdoXoaViTri.UseVisualStyleBackColor = true;
        // 
        // rdoXoaGiaTri
        // 
        rdoXoaGiaTri.AutoSize = true;
        rdoXoaGiaTri.Location = new Point(6, 35);
        rdoXoaGiaTri.Name = "rdoXoaGiaTri";
        rdoXoaGiaTri.Size = new Size(160, 24);
        rdoXoaGiaTri.TabIndex = 0;
        rdoXoaGiaTri.TabStop = true;
        rdoXoaGiaTri.Text = "Tìm Giá Trị Cần Xóa";
        rdoXoaGiaTri.UseVisualStyleBackColor = true;
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(label5);
        groupBox4.Controls.Add(txtThemIdx);
        groupBox4.Controls.Add(txtThemVal);
        groupBox4.Controls.Add(label4);
        groupBox4.Controls.Add(radioButton7);
        groupBox4.Location = new Point(74, 508);
        groupBox4.Name = "groupBox4";
        groupBox4.Size = new Size(261, 147);
        groupBox4.TabIndex = 11;
        groupBox4.TabStop = false;
        groupBox4.Text = "Thêm";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
        label5.ForeColor = Color.Red;
        label5.Location = new Point(39, 109);
        label5.Name = "label5";
        label5.Size = new Size(180, 28);
        label5.TabIndex = 5;
        label5.Text = "Cần Sắp Xếp Tăng";
        // 
        // txtThemIdx
        // 
        txtThemIdx.Location = new Point(180, 76);
        txtThemIdx.Name = "txtThemIdx";
        txtThemIdx.Size = new Size(81, 27);
        txtThemIdx.TabIndex = 4;
        // 
        // txtThemVal
        // 
        txtThemVal.Location = new Point(180, 39);
        txtThemVal.Name = "txtThemVal";
        txtThemVal.Size = new Size(81, 27);
        txtThemVal.TabIndex = 3;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(29, 80);
        label4.Name = "label4";
        label4.Size = new Size(136, 20);
        label4.TabIndex = 1;
        label4.Text = "Tại Vị Trí Cần Thêm";
        // 
        // radioButton7
        // 
        radioButton7.AutoSize = true;
        radioButton7.Location = new Point(6, 39);
        radioButton7.Name = "radioButton7";
        radioButton7.Size = new Size(171, 24);
        radioButton7.TabIndex = 0;
        radioButton7.TabStop = true;
        radioButton7.Text = "Tìm Giá Trị Cần Thêm";
        radioButton7.UseVisualStyleBackColor = true;
        // 
        // groupBox5
        // 
        groupBox5.Controls.Add(txtTongLe);
        groupBox5.Controls.Add(txtTongChan);
        groupBox5.Controls.Add(txtTongMang);
        groupBox5.Controls.Add(btnTong);
        groupBox5.Controls.Add(label8);
        groupBox5.Controls.Add(TongChan);
        groupBox5.Controls.Add(label6);
        groupBox5.Location = new Point(386, 508);
        groupBox5.Name = "groupBox5";
        groupBox5.Size = new Size(250, 147);
        groupBox5.TabIndex = 12;
        groupBox5.TabStop = false;
        groupBox5.Text = "Tổng";
        // 
        // txtTongLe
        // 
        txtTongLe.Location = new Point(83, 109);
        txtTongLe.Name = "txtTongLe";
        txtTongLe.ReadOnly = true;
        txtTongLe.Size = new Size(72, 27);
        txtTongLe.TabIndex = 6;
        // 
        // txtTongChan
        // 
        txtTongChan.Location = new Point(86, 73);
        txtTongChan.Name = "txtTongChan";
        txtTongChan.ReadOnly = true;
        txtTongChan.Size = new Size(69, 27);
        txtTongChan.TabIndex = 5;
        // 
        // txtTongMang
        // 
        txtTongMang.Location = new Point(88, 32);
        txtTongMang.Name = "txtTongMang";
        txtTongMang.ReadOnly = true;
        txtTongMang.Size = new Size(69, 27);
        txtTongMang.TabIndex = 4;
        // 
        // btnTong
        // 
        btnTong.Location = new Point(171, 39);
        btnTong.Name = "btnTong";
        btnTong.Size = new Size(73, 85);
        btnTong.TabIndex = 3;
        btnTong.Text = "Tổng";
        btnTong.UseVisualStyleBackColor = true;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(6, 112);
        label8.Name = "label8";
        label8.Size = new Size(62, 20);
        label8.TabIndex = 2;
        label8.Text = "Tổng Lẻ";
        label8.Click += label8_Click;
        // 
        // TongChan
        // 
        TongChan.AutoSize = true;
        TongChan.Location = new Point(3, 79);
        TongChan.Name = "TongChan";
        TongChan.Size = new Size(80, 20);
        TongChan.TabIndex = 1;
        TongChan.Text = "Tổng Chẵn";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(0, 42);
        label6.Name = "label6";
        label6.Size = new Size(85, 20);
        label6.TabIndex = 0;
        label6.Text = "Tổng Mảng";
        // 
        // groupBox6
        // 
        groupBox6.Controls.Add(txtMin);
        groupBox6.Controls.Add(txtMax);
        groupBox6.Controls.Add(btnMaxMin);
        groupBox6.Controls.Add(label10);
        groupBox6.Controls.Add(label9);
        groupBox6.Location = new Point(74, 661);
        groupBox6.Name = "groupBox6";
        groupBox6.Size = new Size(261, 148);
        groupBox6.TabIndex = 13;
        groupBox6.TabStop = false;
        groupBox6.Text = "Max-Min";
        // 
        // txtMin
        // 
        txtMin.Location = new Point(127, 82);
        txtMin.Name = "txtMin";
        txtMin.Size = new Size(58, 27);
        txtMin.TabIndex = 4;
        // 
        // txtMax
        // 
        txtMax.Location = new Point(127, 41);
        txtMax.Name = "txtMax";
        txtMax.Size = new Size(58, 27);
        txtMax.TabIndex = 3;
        // 
        // btnMaxMin
        // 
        btnMaxMin.Location = new Point(206, 34);
        btnMaxMin.Name = "btnMaxMin";
        btnMaxMin.Size = new Size(55, 87);
        btnMaxMin.TabIndex = 2;
        btnMaxMin.Text = "Tìm";
        btnMaxMin.UseVisualStyleBackColor = true;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(6, 85);
        label10.Name = "label10";
        label10.Size = new Size(119, 20);
        label10.TabIndex = 1;
        label10.Text = "Giá Trị Nhỏ Nhất";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(6, 45);
        label9.Name = "label9";
        label9.Size = new Size(115, 20);
        label9.TabIndex = 0;
        label9.Text = "Giá Trị Lớn Nhất";
        // 
        // groupBox7
        // 
        groupBox7.Controls.Add(txtThayMoi);
        groupBox7.Controls.Add(textBox17);
        groupBox7.Controls.Add(txtThayCu);
        groupBox7.Controls.Add(label11);
        groupBox7.Controls.Add(rdoThayViTri);
        groupBox7.Controls.Add(rdoThayGiaTri);
        groupBox7.Location = new Point(386, 661);
        groupBox7.Name = "groupBox7";
        groupBox7.Size = new Size(250, 148);
        groupBox7.TabIndex = 14;
        groupBox7.TabStop = false;
        groupBox7.Text = "Thay Thế";
        // 
        // txtThayMoi
        // 
        txtThayMoi.Location = new Point(171, 111);
        txtThayMoi.Name = "txtThayMoi";
        txtThayMoi.Size = new Size(73, 27);
        txtThayMoi.TabIndex = 5;
        // 
        // textBox17
        // 
        textBox17.Location = new Point(171, 78);
        textBox17.Name = "textBox17";
        textBox17.Size = new Size(73, 27);
        textBox17.TabIndex = 4;
        // 
        // txtThayCu
        // 
        txtThayCu.Location = new Point(171, 41);
        txtThayCu.Name = "txtThayCu";
        txtThayCu.Size = new Size(73, 27);
        txtThayCu.TabIndex = 3;
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(47, 114);
        label11.Name = "label11";
        label11.Size = new Size(108, 20);
        label11.TabIndex = 2;
        label11.Text = "Số Thay Thế Là";
        label11.Click += label11_Click;
        // 
        // rdoThayViTri
        // 
        rdoThayViTri.AutoSize = true;
        rdoThayViTri.Location = new Point(6, 79);
        rdoThayViTri.Name = "rdoThayViTri";
        rdoThayViTri.Size = new Size(155, 24);
        rdoThayViTri.TabIndex = 1;
        rdoThayViTri.TabStop = true;
        rdoThayViTri.Text = "Vị Trí Cần Thay Thế";
        rdoThayViTri.UseVisualStyleBackColor = true;
        // 
        // rdoThayGiaTri
        // 
        rdoThayGiaTri.AutoSize = true;
        rdoThayGiaTri.Location = new Point(6, 41);
        rdoThayGiaTri.Name = "rdoThayGiaTri";
        rdoThayGiaTri.Size = new Size(164, 24);
        rdoThayGiaTri.TabIndex = 0;
        rdoThayGiaTri.TabStop = true;
        rdoThayGiaTri.Text = "Giá Trị Cần Thay Thế";
        rdoThayGiaTri.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(671, 823);
        Controls.Add(groupBox7);
        Controls.Add(groupBox6);
        Controls.Add(groupBox5);
        Controls.Add(groupBox4);
        Controls.Add(groupBox3);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Controls.Add(btnThucHien);
        Controls.Add(btnThoat);
        Controls.Add(btnReset);
        Controls.Add(txtKetQuaMang);
        Controls.Add(txtNhapMang);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Nhập Số Nguyên";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        groupBox4.ResumeLayout(false);
        groupBox4.PerformLayout();
        groupBox5.ResumeLayout(false);
        groupBox5.PerformLayout();
        groupBox6.ResumeLayout(false);
        groupBox6.PerformLayout();
        groupBox7.ResumeLayout(false);
        groupBox7.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox txtNhapMang;
    private TextBox txtKetQuaMang;
    private Button btnReset;
    private Button btnThoat;
    private Button btnThucHien;
    private GroupBox groupBox1;
    private RadioButton rdoGiam;
    private RadioButton rdoTang;
    private GroupBox groupBox2;
    private GroupBox groupBox3;
    private GroupBox groupBox4;
    private GroupBox groupBox5;
    private GroupBox groupBox6;
    private GroupBox groupBox7;
    private RadioButton rdoTimViTri;
    private RadioButton rdoTimGiaTri;
    private RadioButton rdoXoaViTri;
    private RadioButton rdoXoaGiaTri;
    private Label label4;
    private RadioButton radioButton7;
    private Button btnTong;
    private Label label8;
    private Label TongChan;
    private Label label6;
    private Button btnMaxMin;
    private Label label10;
    private Label label9;
    private Label label11;
    private RadioButton rdoThayViTri;
    private RadioButton rdoThayGiaTri;
    private TextBox txtTimOutput;
    private TextBox txtTimViTri;
    private TextBox txtTimGiaTri;
    private Label label12;
    private TextBox textBox7;
    private TextBox txtXoaInput;
    private Label label13;
    private TextBox txtThemIdx;
    private TextBox txtThemVal;
    private TextBox txtTongLe;
    private TextBox txtTongChan;
    private TextBox txtTongMang;
    private TextBox txtMin;
    private TextBox txtMax;
    private TextBox txtThayMoi;
    private TextBox textBox17;
    private TextBox txtThayCu;
    private Label label5;
}
