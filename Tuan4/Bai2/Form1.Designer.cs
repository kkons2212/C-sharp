namespace Bai2;

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
        txtTenDangNhap = new TextBox();
        txtEmail = new TextBox();
        label4 = new Label();
        label5 = new Label();
        txtMatKhau = new TextBox();
        txtxacnhanmatkhau = new TextBox();
        buttondangky = new Button();
        label6 = new Label();
        label7 = new Label();
        label8 = new Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.BackColor = SystemColors.InactiveBorder;
        label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 163);
        label1.ForeColor = Color.DodgerBlue;
        label1.Location = new Point(191, 27);
        label1.Name = "label1";
        label1.Size = new Size(318, 46);
        label1.TabIndex = 0;
        label1.Text = "Đăng Ký Tài Khoản";
        label1.TextAlign = ContentAlignment.TopCenter;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.ForeColor = SystemColors.InactiveCaptionText;
        label2.Location = new Point(49, 100);
        label2.Name = "label2";
        label2.Size = new Size(119, 20);
        label2.TabIndex = 2;
        label2.Text = "Tên Đăng Nhập: ";
        label2.Click += label2_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.ForeColor = SystemColors.InactiveCaptionText;
        label3.Location = new Point(49, 160);
        label3.Name = "label3";
        label3.Size = new Size(105, 20);
        label3.TabIndex = 3;
        label3.Text = "Địa Chỉ Email: ";
        // 
        // txtTenDangNhap
        // 
        txtTenDangNhap.Location = new Point(206, 97);
        txtTenDangNhap.Name = "txtTenDangNhap";
        txtTenDangNhap.Size = new Size(310, 27);
        txtTenDangNhap.TabIndex = 4;
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(206, 160);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(310, 27);
        txtEmail.TabIndex = 5;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.ForeColor = SystemColors.InactiveCaptionText;
        label4.Location = new Point(49, 214);
        label4.Name = "label4";
        label4.Size = new Size(75, 20);
        label4.TabIndex = 6;
        label4.Text = "Mật Khẩu:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.ForeColor = SystemColors.InactiveCaptionText;
        label5.Location = new Point(49, 261);
        label5.Name = "label5";
        label5.Size = new Size(146, 20);
        label5.TabIndex = 7;
        label5.Text = "Xác Nhận Mật Khẩu: ";
        // 
        // txtMatKhau
        // 
        txtMatKhau.Location = new Point(206, 214);
        txtMatKhau.Name = "txtMatKhau";
        txtMatKhau.Size = new Size(310, 27);
        txtMatKhau.TabIndex = 8;
        // 
        // txtxacnhanmatkhau
        // 
        txtxacnhanmatkhau.Location = new Point(206, 258);
        txtxacnhanmatkhau.Name = "txtxacnhanmatkhau";
        txtxacnhanmatkhau.Size = new Size(310, 27);
        txtxacnhanmatkhau.TabIndex = 9;
        // 
        // buttondangky
        // 
        buttondangky.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
        buttondangky.Location = new Point(266, 326);
        buttondangky.Name = "buttondangky";
        buttondangky.Size = new Size(170, 58);
        buttondangky.TabIndex = 10;
        buttondangky.Text = "Đăng Ký ";
        buttondangky.UseVisualStyleBackColor = true;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.ForeColor = SystemColors.InactiveCaptionText;
        label6.Location = new Point(549, 104);
        label6.Name = "label6";
        label6.Size = new Size(25, 20);
        label6.TabIndex = 11;
        label6.Text = "(*)";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.ForeColor = SystemColors.InactiveCaptionText;
        label7.Location = new Point(549, 163);
        label7.Name = "label7";
        label7.Size = new Size(25, 20);
        label7.TabIndex = 12;
        label7.Text = "(*)";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.ForeColor = SystemColors.InactiveCaptionText;
        label8.Location = new Point(549, 221);
        label8.Name = "label8";
        label8.Size = new Size(25, 20);
        label8.TabIndex = 13;
        label8.Text = "(*)";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(709, 405);
        Controls.Add(label8);
        Controls.Add(label7);
        Controls.Add(label6);
        Controls.Add(buttondangky);
        Controls.Add(txtxacnhanmatkhau);
        Controls.Add(txtMatKhau);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(txtEmail);
        Controls.Add(txtTenDangNhap);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        ForeColor = SystemColors.Highlight;
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox txtTenDangNhap;
    private TextBox txtEmail;
    private Label label4;
    private Label label5;
    private TextBox txtMatKhau;
    private TextBox txtxacnhanmatkhau;
    private Button buttondangky;
    private Label label6;
    private Label label7;
    private Label label8;
}
