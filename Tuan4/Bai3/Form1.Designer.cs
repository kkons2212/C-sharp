namespace Bai3;

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
        label5 = new Label();
        buttonThucHien = new Button();
        buttonTiepTuc = new Button();
        buttonThoat = new Button();
        texta = new TextBox();
        textb = new TextBox();
        textUSCLN = new TextBox();
        textUSCNN = new TextBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 163);
        label1.ForeColor = Color.Red;
        label1.Location = new Point(86, 44);
        label1.Name = "label1";
        label1.Size = new Size(493, 46);
        label1.TabIndex = 0;
        label1.Text = "Ước Số Chung - Bội Số Chung";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(108, 136);
        label2.Name = "label2";
        label2.Size = new Size(81, 20);
        label2.TabIndex = 1;
        label2.Text = "Nhập Số a:";
        label2.Click += label2_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(108, 192);
        label3.Name = "label3";
        label3.Size = new Size(82, 20);
        label3.TabIndex = 2;
        label3.Text = "Nhập Số b:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(108, 240);
        label4.Name = "label4";
        label4.Size = new Size(170, 20);
        label4.TabIndex = 3;
        label4.Text = "Ước Số Chung Lớn Nhất:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(108, 293);
        label5.Name = "label5";
        label5.Size = new Size(174, 20);
        label5.TabIndex = 4;
        label5.Text = "Ước Số Chung Nhỏ Nhất:";
        // 
        // buttonThucHien
        // 
        buttonThucHien.Location = new Point(95, 357);
        buttonThucHien.Name = "buttonThucHien";
        buttonThucHien.Size = new Size(94, 42);
        buttonThucHien.TabIndex = 5;
        buttonThucHien.Text = "Thực Hiện";
        buttonThucHien.UseVisualStyleBackColor = true;
        buttonThucHien.Click += button1_Click;
        // 
        // buttonTiepTuc
        // 
        buttonTiepTuc.Location = new Point(267, 357);
        buttonTiepTuc.Name = "buttonTiepTuc";
        buttonTiepTuc.Size = new Size(94, 42);
        buttonTiepTuc.TabIndex = 6;
        buttonTiepTuc.Text = "Tiếp Tục";
        buttonTiepTuc.UseVisualStyleBackColor = true;
        // 
        // buttonThoat
        // 
        buttonThoat.Location = new Point(441, 357);
        buttonThoat.Name = "buttonThoat";
        buttonThoat.Size = new Size(94, 42);
        buttonThoat.TabIndex = 7;
        buttonThoat.Text = "Thoát";
        buttonThoat.UseVisualStyleBackColor = true;
        // 
        // texta
        // 
        texta.Location = new Point(220, 136);
        texta.Name = "texta";
        texta.Size = new Size(125, 27);
        texta.TabIndex = 8;
        // 
        // textb
        // 
        textb.Location = new Point(220, 189);
        textb.Name = "textb";
        textb.Size = new Size(125, 27);
        textb.TabIndex = 9;
        // 
        // textUSCLN
        // 
        textUSCLN.Location = new Point(309, 237);
        textUSCLN.Name = "textUSCLN";
        textUSCLN.ReadOnly = true;
        textUSCLN.Size = new Size(93, 27);
        textUSCLN.TabIndex = 10;
        // 
        // textUSCNN
        // 
        textUSCNN.Location = new Point(309, 293);
        textUSCNN.Name = "textUSCNN";
        textUSCNN.ReadOnly = true;
        textUSCNN.Size = new Size(93, 27);
        textUSCNN.TabIndex = 11;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(607, 414);
        Controls.Add(textUSCNN);
        Controls.Add(textUSCLN);
        Controls.Add(textb);
        Controls.Add(texta);
        Controls.Add(buttonThoat);
        Controls.Add(buttonTiepTuc);
        Controls.Add(buttonThucHien);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "Form1";
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
    private Button buttonThucHien;
    private Button buttonTiepTuc;
    private Button buttonThoat;
    private TextBox texta;
    private TextBox textb;
    private TextBox textUSCLN;
    private TextBox textUSCNN;
}
