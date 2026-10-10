namespace Bai1;

partial class Bai1
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
        textNhapSo = new GroupBox();
        cboDanhSach = new ComboBox();
        btnCapNhat = new Button();
        txtNhapSo = new TextBox();
        btnThoat = new Button();
        btnTongUoc = new Button();
        button4 = new Button();
        btnSoLuongChan = new Button();
        btnSoLuongNT = new Button();
        groupBox1 = new GroupBox();
        lstUocSo = new ListBox();
        textNhapSo.SuspendLayout();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // textNhapSo
        // 
        textNhapSo.Controls.Add(cboDanhSach);
        textNhapSo.Controls.Add(btnCapNhat);
        textNhapSo.Controls.Add(txtNhapSo);
        textNhapSo.Location = new Point(90, 55);
        textNhapSo.Name = "textNhapSo";
        textNhapSo.Size = new Size(281, 136);
        textNhapSo.TabIndex = 0;
        textNhapSo.TabStop = false;
        textNhapSo.Text = "Nhập Số";
        // 
        // cboDanhSach
        // 
        cboDanhSach.FormattingEnabled = true;
        cboDanhSach.Location = new Point(17, 92);
        cboDanhSach.Name = "cboDanhSach";
        cboDanhSach.Size = new Size(245, 28);
        cboDanhSach.TabIndex = 2;
        // 
        // btnCapNhat
        // 
        btnCapNhat.Location = new Point(168, 46);
        btnCapNhat.Name = "btnCapNhat";
        btnCapNhat.Size = new Size(94, 29);
        btnCapNhat.TabIndex = 1;
        btnCapNhat.Text = "Cập Nhật";
        btnCapNhat.UseVisualStyleBackColor = true;
        // 
        // txtNhapSo
        // 
        txtNhapSo.Location = new Point(17, 46);
        txtNhapSo.Name = "txtNhapSo";
        txtNhapSo.Size = new Size(125, 27);
        txtNhapSo.TabIndex = 0;
        // 
        // btnThoat
        // 
        btnThoat.Location = new Point(277, 366);
        btnThoat.Name = "btnThoat";
        btnThoat.Size = new Size(94, 35);
        btnThoat.TabIndex = 1;
        btnThoat.Text = "Thoát";
        btnThoat.UseVisualStyleBackColor = true;
        // 
        // btnTongUoc
        // 
        btnTongUoc.Location = new Point(467, 269);
        btnTongUoc.Name = "btnTongUoc";
        btnTongUoc.Size = new Size(216, 29);
        btnTongUoc.TabIndex = 2;
        btnTongUoc.Text = "Tổng Các Ước Số";
        btnTongUoc.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.Location = new Point(467, 352);
        button4.Name = "button4";
        button4.Size = new Size(8, 8);
        button4.TabIndex = 3;
        button4.Text = "button4";
        button4.UseVisualStyleBackColor = true;
        // 
        // btnSoLuongChan
        // 
        btnSoLuongChan.Location = new Point(467, 317);
        btnSoLuongChan.Name = "btnSoLuongChan";
        btnSoLuongChan.Size = new Size(216, 29);
        btnSoLuongChan.TabIndex = 4;
        btnSoLuongChan.Text = "Số Lượng Các Ước Số Chãn";
        btnSoLuongChan.UseVisualStyleBackColor = true;
        // 
        // btnSoLuongNT
        // 
        btnSoLuongNT.Location = new Point(467, 366);
        btnSoLuongNT.Name = "btnSoLuongNT";
        btnSoLuongNT.Size = new Size(216, 29);
        btnSoLuongNT.TabIndex = 5;
        btnSoLuongNT.Text = "Số Lượng Các Số Nguyên Tố";
        btnSoLuongNT.UseVisualStyleBackColor = true;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(lstUocSo);
        groupBox1.Location = new Point(460, 65);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(291, 169);
        groupBox1.TabIndex = 6;
        groupBox1.TabStop = false;
        groupBox1.Text = "Danh Sách Các Ước Số";
        groupBox1.Enter += groupBox1_Enter;
        // 
        // lstUocSo
        // 
        lstUocSo.FormattingEnabled = true;
        lstUocSo.Location = new Point(16, 36);
        lstUocSo.Name = "lstUocSo";
        lstUocSo.Size = new Size(150, 104);
        lstUocSo.TabIndex = 0;
        // 
        // Bai1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(groupBox1);
        Controls.Add(btnSoLuongNT);
        Controls.Add(btnSoLuongChan);
        Controls.Add(button4);
        Controls.Add(btnTongUoc);
        Controls.Add(btnThoat);
        Controls.Add(textNhapSo);
        Name = "Bai1";
        Text = "Form1";
        textNhapSo.ResumeLayout(false);
        textNhapSo.PerformLayout();
        groupBox1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private GroupBox textNhapSo;
    private ComboBox cboDanhSach;
    private Button btnCapNhat;
    private TextBox txtNhapSo;
    private Button btnThoat;
    private Button btnTongUoc;
    private Button button4;
    private Button btnSoLuongChan;
    private Button btnSoLuongNT;
    private GroupBox groupBox1;
    private ListBox lstUocSo;
}
