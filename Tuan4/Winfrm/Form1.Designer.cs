namespace Winfrm;

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
        textBox1 = new TextBox();
        label2 = new Label();
        textBox2 = new TextBox();
        label3 = new Label();
        textBox3 = new TextBox();
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(44, 58);
        label1.Name = "label1";
        label1.Size = new Size(27, 20);
        label1.TabIndex = 1;
        label1.Text = "a=";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(95, 51);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(125, 27);
        textBox1.TabIndex = 2;
       
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(308, 54);
        label2.Name = "label2";
        label2.Size = new Size(28, 20);
        label2.TabIndex = 3;
        label2.Text = "b=";
        // 
        // textBox2
        // 
        textBox2.Location = new Point(354, 51);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(125, 27);
        textBox2.TabIndex = 4;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(44, 146);
        label3.Name = "label3";
        label3.Size = new Size(65, 20);
        label3.TabIndex = 5;
        label3.Text = "Kết Quả:";
        // 
        // textBox3
        // 
        textBox3.Location = new Point(127, 143);
        textBox3.Name = "textBox3";
        textBox3.ReadOnly = true;
        textBox3.Size = new Size(352, 27);
        textBox3.TabIndex = 6;
        // 
        // button1
        // 
        button1.Location = new Point(61, 227);
        button1.Name = "button1";
        button1.Size = new Size(81, 53);
        button1.TabIndex = 7;
        button1.Text = "+";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new Point(174, 227);
        button2.Name = "button2";
        button2.Size = new Size(85, 55);
        button2.TabIndex = 8;
        button2.Text = "-";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new Point(308, 227);
        button3.Name = "button3";
        button3.Size = new Size(82, 53);
        button3.TabIndex = 9;
        button3.Text = "*";
        button3.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.Location = new Point(417, 225);
        button4.Name = "button4";
        button4.Size = new Size(84, 55);
        button4.TabIndex = 10;
        button4.Text = "/";
        button4.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(575, 380);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(textBox3);
        Controls.Add(label3);
        Controls.Add(textBox2);
        Controls.Add(label2);
        Controls.Add(textBox1);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox textBox1;
    private Label label2;
    private TextBox textBox2;
    private Label label3;
    private TextBox textBox3;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
}
