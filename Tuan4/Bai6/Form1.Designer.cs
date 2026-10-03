namespace Bai6;

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
        textNhap = new TextBox();
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        button5 = new Button();
        button6 = new Button();
        button7 = new Button();
        button8 = new Button();
        button9 = new Button();
        buttonCong = new Button();
        button0 = new Button();
        buttonTru = new Button();
        buttonEqual = new Button();
        buttondelete = new Button();
        buttonNhan = new Button();
        buttonChia = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 163);
        label1.ForeColor = Color.Red;
        label1.Location = new Point(144, 37);
        label1.Name = "label1";
        label1.Size = new Size(279, 46);
        label1.TabIndex = 0;
        label1.Text = "Máy Tính Bỏ Túi";
        // 
        // textNhap
        // 
        textNhap.Anchor = AnchorStyles.Right;
        textNhap.ForeColor = Color.MediumSlateBlue;
        textNhap.Location = new Point(98, 114);
        textNhap.Name = "textNhap";
        textNhap.Size = new Size(389, 27);
        textNhap.TabIndex = 1;
        textNhap.TextAlign = HorizontalAlignment.Right;
        // 
        // button1
        // 
        button1.Location = new Point(81, 187);
        button1.Name = "button1";
        button1.Size = new Size(94, 38);
        button1.TabIndex = 2;
        button1.Text = "1";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Location = new Point(181, 187);
        button2.Name = "button2";
        button2.Size = new Size(94, 38);
        button2.TabIndex = 3;
        button2.Text = "2";
        button2.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Location = new Point(294, 187);
        button3.Name = "button3";
        button3.Size = new Size(94, 38);
        button3.TabIndex = 4;
        button3.Text = "3";
        button3.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.Location = new Point(405, 187);
        button4.Name = "button4";
        button4.Size = new Size(94, 38);
        button4.TabIndex = 5;
        button4.Text = "4";
        button4.UseVisualStyleBackColor = true;
        // 
        // button5
        // 
        button5.Location = new Point(81, 249);
        button5.Name = "button5";
        button5.Size = new Size(94, 39);
        button5.TabIndex = 6;
        button5.Text = "5";
        button5.UseVisualStyleBackColor = true;
        // 
        // button6
        // 
        button6.Location = new Point(181, 249);
        button6.Name = "button6";
        button6.Size = new Size(94, 39);
        button6.TabIndex = 7;
        button6.Text = "6";
        button6.UseVisualStyleBackColor = true;
        // 
        // button7
        // 
        button7.Location = new Point(294, 249);
        button7.Name = "button7";
        button7.Size = new Size(94, 39);
        button7.TabIndex = 8;
        button7.Text = "7";
        button7.UseVisualStyleBackColor = true;
        // 
        // button8
        // 
        button8.Location = new Point(405, 249);
        button8.Name = "button8";
        button8.Size = new Size(94, 39);
        button8.TabIndex = 9;
        button8.Text = "8";
        button8.UseVisualStyleBackColor = true;
        // 
        // button9
        // 
        button9.Location = new Point(81, 314);
        button9.Name = "button9";
        button9.Size = new Size(94, 38);
        button9.TabIndex = 10;
        button9.Text = "9";
        button9.UseVisualStyleBackColor = true;
        // 
        // buttonCong
        // 
        buttonCong.Location = new Point(81, 370);
        buttonCong.Name = "buttonCong";
        buttonCong.Size = new Size(94, 38);
        buttonCong.TabIndex = 11;
        buttonCong.Text = "+";
        buttonCong.UseVisualStyleBackColor = true;
        // 
        // button0
        // 
        button0.Location = new Point(181, 314);
        button0.Name = "button0";
        button0.Size = new Size(94, 38);
        button0.TabIndex = 12;
        button0.Text = "0";
        button0.UseVisualStyleBackColor = true;
        // 
        // buttonTru
        // 
        buttonTru.Location = new Point(181, 370);
        buttonTru.Name = "buttonTru";
        buttonTru.Size = new Size(94, 38);
        buttonTru.TabIndex = 13;
        buttonTru.Text = "-";
        buttonTru.UseVisualStyleBackColor = true;
        // 
        // buttonEqual
        // 
        buttonEqual.Location = new Point(294, 314);
        buttonEqual.Name = "buttonEqual";
        buttonEqual.Size = new Size(94, 38);
        buttonEqual.TabIndex = 14;
        buttonEqual.Text = "=";
        buttonEqual.UseVisualStyleBackColor = true;
        // 
        // buttondelete
        // 
        buttondelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
        buttondelete.Location = new Point(405, 314);
        buttondelete.Name = "buttondelete";
        buttondelete.Size = new Size(94, 38);
        buttondelete.TabIndex = 15;
        buttondelete.Text = "C";
        buttondelete.UseVisualStyleBackColor = true;
        // 
        // buttonNhan
        // 
        buttonNhan.Location = new Point(294, 370);
        buttonNhan.Name = "buttonNhan";
        buttonNhan.Size = new Size(94, 38);
        buttonNhan.TabIndex = 16;
        buttonNhan.Text = "*";
        buttonNhan.UseVisualStyleBackColor = true;
        // 
        // buttonChia
        // 
        buttonChia.Location = new Point(405, 370);
        buttonChia.Name = "buttonChia";
        buttonChia.Size = new Size(94, 38);
        buttonChia.TabIndex = 17;
        buttonChia.Text = "/";
        buttonChia.UseVisualStyleBackColor = true;
        buttonChia.Click += button16_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(558, 450);
        Controls.Add(buttonChia);
        Controls.Add(buttonNhan);
        Controls.Add(buttondelete);
        Controls.Add(buttonEqual);
        Controls.Add(buttonTru);
        Controls.Add(button0);
        Controls.Add(buttonCong);
        Controls.Add(button9);
        Controls.Add(button8);
        Controls.Add(button7);
        Controls.Add(button6);
        Controls.Add(button5);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(textNhap);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox textNhap;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private Button button5;
    private Button button6;
    private Button button7;
    private Button button8;
    private Button button9;
    private Button buttonCong;
    private Button button0;
    private Button buttonTru;
    private Button buttonEqual;
    private Button buttondelete;
    private Button buttonNhan;
    private Button buttonChia;
}
