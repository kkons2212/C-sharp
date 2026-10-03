namespace Bai7;

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
        groupBox1 = new GroupBox();
        rdoBacHai = new RadioButton();
        rdoBacNhat = new RadioButton();
        label2 = new Label();
        label3 = new Label();
        lblC = new Label();
        label5 = new Label();
        txtA = new TextBox();
        txtB = new TextBox();
        txtC = new TextBox();
        txtKetQua = new TextBox();
        btnGiai = new Button();
        btnThoat = new Button();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 163);
        label1.ForeColor = Color.Red;
        label1.Location = new Point(88, 56);
        label1.Name = "label1";
        label1.Size = new Size(362, 54);
        label1.TabIndex = 0;
        label1.Text = "Giải Phương Trình";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(rdoBacHai);
        groupBox1.Controls.Add(rdoBacNhat);
        groupBox1.Location = new Point(88, 154);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(421, 124);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        groupBox1.Text = "Mời Bạn Chọn";
        // 
        // rdoBacHai
        // 
        rdoBacHai.AutoSize = true;
        rdoBacHai.Location = new Point(51, 81);
        rdoBacHai.Name = "rdoBacHai";
        rdoBacHai.Size = new Size(172, 24);
        rdoBacHai.TabIndex = 1;
        rdoBacHai.TabStop = true;
        rdoBacHai.Text = "Phương Trình Bậc Hai";
        rdoBacHai.UseVisualStyleBackColor = true;
        // 
        // rdoBacNhat
        // 
        rdoBacNhat.AutoSize = true;
        rdoBacNhat.Location = new Point(51, 42);
        rdoBacNhat.Name = "rdoBacNhat";
        rdoBacNhat.Size = new Size(185, 24);
        rdoBacNhat.TabIndex = 0;
        rdoBacNhat.TabStop = true;
        rdoBacNhat.Text = "Phương Trình Bậc Nhất ";
        rdoBacNhat.UseVisualStyleBackColor = true;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(88, 315);
        label2.Name = "label2";
        label2.Size = new Size(57, 20);
        label2.TabIndex = 2;
        label2.Text = "Nhập a";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(88, 360);
        label3.Name = "label3";
        label3.Size = new Size(58, 20);
        label3.TabIndex = 3;
        label3.Text = "Nhập b";
        // 
        // lblC
        // 
        lblC.AutoSize = true;
        lblC.Location = new Point(84, 411);
        lblC.Name = "lblC";
        lblC.Size = new Size(56, 20);
        lblC.TabIndex = 4;
        lblC.Text = "Nhập c";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(84, 462);
        label5.Name = "label5";
        label5.Size = new Size(62, 20);
        label5.TabIndex = 5;
        label5.Text = "Kết Quả";
        // 
        // txtA
        // 
        txtA.Location = new Point(186, 312);
        txtA.Name = "txtA";
        txtA.Size = new Size(125, 27);
        txtA.TabIndex = 6;
        txtA.TextAlign = HorizontalAlignment.Right;
        // 
        // txtB
        // 
        txtB.Location = new Point(186, 360);
        txtB.Name = "txtB";
        txtB.Size = new Size(125, 27);
        txtB.TabIndex = 7;
        txtB.TextAlign = HorizontalAlignment.Right;
        // 
        // txtC
        // 
        txtC.Location = new Point(186, 404);
        txtC.Name = "txtC";
        txtC.Size = new Size(125, 27);
        txtC.TabIndex = 8;
        txtC.TextAlign = HorizontalAlignment.Right;
        // 
        // txtKetQua
        // 
        txtKetQua.Location = new Point(186, 459);
        txtKetQua.Name = "txtKetQua";
        txtKetQua.ReadOnly = true;
        txtKetQua.Size = new Size(204, 27);
        txtKetQua.TabIndex = 9;
        // 
        // btnGiai
        // 
        btnGiai.Location = new Point(433, 312);
        btnGiai.Name = "btnGiai";
        btnGiai.Size = new Size(94, 68);
        btnGiai.TabIndex = 10;
        btnGiai.Text = "Giải";
        btnGiai.UseVisualStyleBackColor = true;
        // 
        // btnThoat
        // 
        btnThoat.Location = new Point(433, 396);
        btnThoat.Name = "btnThoat";
        btnThoat.Size = new Size(94, 60);
        btnThoat.TabIndex = 11;
        btnThoat.Text = "Thoát";
        btnThoat.UseVisualStyleBackColor = true;
        btnThoat.Click += button2_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(587, 541);
        Controls.Add(btnThoat);
        Controls.Add(btnGiai);
        Controls.Add(txtKetQua);
        Controls.Add(txtC);
        Controls.Add(txtB);
        Controls.Add(txtA);
        Controls.Add(label5);
        Controls.Add(lblC);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(groupBox1);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Form1";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private GroupBox groupBox1;
    private RadioButton rdoBacHai;
    private RadioButton rdoBacNhat;
    private Label label2;
    private Label label3;
    private Label lblC;
    private Label label5;
    private TextBox txtA;
    private TextBox txtB;
    private TextBox txtC;
    private TextBox txtKetQua;
    private Button btnGiai;
    private Button btnThoat;
}
