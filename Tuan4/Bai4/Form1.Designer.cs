namespace Bai4;

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
        label6 = new Label();
        buttonTiepTuc = new Button();
        buttonThoat = new Button();
        button3 = new Button();
        buttonNhap = new Button();
        textSo = new TextBox();
        textDaySo = new TextBox();
        textCacPhanTu = new TextBox();
        textChan = new TextBox();
        textLe = new TextBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 163);
        label1.ForeColor = Color.Red;
        label1.Location = new Point(74, 58);
        label1.Name = "label1";
        label1.Size = new Size(453, 46);
        label1.TabIndex = 0;
        label1.Text = "Nhập Dãy Số Và Tính Tổng ";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(74, 161);
        label2.Name = "label2";
        label2.Size = new Size(73, 20);
        label2.TabIndex = 1;
        label2.Text = "Nhập Số :";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(74, 218);
        label3.Name = "label3";
        label3.Size = new Size(108, 20);
        label3.TabIndex = 2;
        label3.Text = "Dãy Vừa Nhập:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(74, 277);
        label4.Name = "label4";
        label4.Size = new Size(203, 20);
        label4.TabIndex = 3;
        label4.Text = "Tổng Các Phần Tử Trong Dãy:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(74, 333);
        label5.Name = "label5";
        label5.Size = new Size(83, 20);
        label5.TabIndex = 4;
        label5.Text = "Tổng Chẵn:";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(328, 336);
        label6.Name = "label6";
        label6.Size = new Size(65, 20);
        label6.TabIndex = 5;
        label6.Text = "Tổng Lẻ:";
        // 
        // buttonTiepTuc
        // 
        buttonTiepTuc.Location = new Point(183, 391);
        buttonTiepTuc.Name = "buttonTiepTuc";
        buttonTiepTuc.Size = new Size(94, 47);
        buttonTiepTuc.TabIndex = 6;
        buttonTiepTuc.Text = "Tiếp Tục";
        buttonTiepTuc.UseVisualStyleBackColor = true;
        // 
        // buttonThoat
        // 
        buttonThoat.Location = new Point(340, 391);
        buttonThoat.Name = "buttonThoat";
        buttonThoat.Size = new Size(94, 47);
        buttonThoat.TabIndex = 7;
        buttonThoat.Text = "Thoát";
        buttonThoat.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Location = new Point(385, 163);
        button3.Name = "button3";
        button3.Size = new Size(8, 8);
        button3.TabIndex = 8;
        button3.Text = "button3";
        button3.UseVisualStyleBackColor = true;
        // 
        // buttonNhap
        // 
        buttonNhap.Location = new Point(399, 149);
        buttonNhap.Name = "buttonNhap";
        buttonNhap.Size = new Size(94, 35);
        buttonNhap.TabIndex = 9;
        buttonNhap.Text = "Nhập";
        buttonNhap.UseVisualStyleBackColor = true;
        // 
        // textSo
        // 
        textSo.Location = new Point(200, 157);
        textSo.Name = "textSo";
        textSo.Size = new Size(125, 27);
        textSo.TabIndex = 10;
        // 
        // textDaySo
        // 
        textDaySo.Location = new Point(200, 215);
        textDaySo.Name = "textDaySo";
        textDaySo.ReadOnly = true;
        textDaySo.Size = new Size(125, 27);
        textDaySo.TabIndex = 11;
        // 
        // textCacPhanTu
        // 
        textCacPhanTu.Location = new Point(297, 274);
        textCacPhanTu.Name = "textCacPhanTu";
        textCacPhanTu.ReadOnly = true;
        textCacPhanTu.Size = new Size(109, 27);
        textCacPhanTu.TabIndex = 12;
        // 
        // textChan
        // 
        textChan.Location = new Point(183, 329);
        textChan.Name = "textChan";
        textChan.ReadOnly = true;
        textChan.Size = new Size(76, 27);
        textChan.TabIndex = 13;
        // 
        // textLe
        // 
        textLe.Location = new Point(419, 330);
        textLe.Name = "textLe";
        textLe.ReadOnly = true;
        textLe.Size = new Size(84, 27);
        textLe.TabIndex = 14;
        textLe.TextChanged += textBox5_TextChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(573, 450);
        Controls.Add(textLe);
        Controls.Add(textChan);
        Controls.Add(textCacPhanTu);
        Controls.Add(textDaySo);
        Controls.Add(textSo);
        Controls.Add(buttonNhap);
        Controls.Add(button3);
        Controls.Add(buttonThoat);
        Controls.Add(buttonTiepTuc);
        Controls.Add(label6);
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
    private Label label6;
    private Button buttonTiepTuc;
    private Button buttonThoat;
    private Button button3;
    private Button buttonNhap;
    private TextBox textSo;
    private TextBox textDaySo;
    private TextBox textCacPhanTu;
    private TextBox textChan;
    private TextBox textLe;
}
