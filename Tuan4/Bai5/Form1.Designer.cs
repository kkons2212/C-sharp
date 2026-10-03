namespace Bai5;

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
        textDaySo = new TextBox();
        textKetQua = new TextBox();
        buttonThucHien = new Button();
        buttonXoa = new Button();
        buttonThoat = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 163);
        label1.ForeColor = Color.Red;
        label1.Location = new Point(123, 45);
        label1.Name = "label1";
        label1.Size = new Size(312, 46);
        label1.TabIndex = 0;
        label1.Text = "Đọc Số Thành Chữ";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(103, 175);
        label2.Name = "label2";
        label2.Size = new Size(201, 20);
        label2.TabIndex = 1;
        label2.Text = "Nhập Dãy Số: (Từ 1 Đến 999)\r\n";
        // 
        // textDaySo
        // 
        textDaySo.Location = new Point(334, 172);
        textDaySo.Name = "textDaySo";
        textDaySo.Size = new Size(125, 27);
        textDaySo.TabIndex = 2;
        // 
        // textKetQua
        // 
        textKetQua.BackColor = Color.PeachPuff;
        textKetQua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
        textKetQua.ForeColor = Color.MediumSlateBlue;
        textKetQua.Location = new Point(103, 355);
        textKetQua.Name = "textKetQua";
        textKetQua.ReadOnly = true;
        textKetQua.Size = new Size(405, 34);
        textKetQua.TabIndex = 3;
        // 
        // buttonThucHien
        // 
        buttonThucHien.Location = new Point(103, 272);
        buttonThucHien.Name = "buttonThucHien";
        buttonThucHien.Size = new Size(94, 41);
        buttonThucHien.TabIndex = 4;
        buttonThucHien.Text = "Thực Hiện";
        buttonThucHien.UseVisualStyleBackColor = true;
        // 
        // buttonXoa
        // 
        buttonXoa.Location = new Point(265, 272);
        buttonXoa.Name = "buttonXoa";
        buttonXoa.Size = new Size(94, 41);
        buttonXoa.TabIndex = 5;
        buttonXoa.Text = "Xóa";
        buttonXoa.UseVisualStyleBackColor = true;
        // 
        // buttonThoat
        // 
        buttonThoat.Location = new Point(414, 272);
        buttonThoat.Name = "buttonThoat";
        buttonThoat.Size = new Size(94, 41);
        buttonThoat.TabIndex = 6;
        buttonThoat.Text = "Thoát";
        buttonThoat.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(570, 450);
        Controls.Add(buttonThoat);
        Controls.Add(buttonXoa);
        Controls.Add(buttonThucHien);
        Controls.Add(textKetQua);
        Controls.Add(textDaySo);
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
    private TextBox textDaySo;
    private TextBox textKetQua;
    private Button buttonThucHien;
    private Button buttonXoa;
    private Button buttonThoat;
}
