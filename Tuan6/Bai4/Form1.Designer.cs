namespace Bai4
{
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
            textMaKhoa = new TextBox();
            textMaLop = new TextBox();
            textTenLop = new TextBox();
            buttonThem = new Button();
            buttonXoa = new Button();
            buttonSua = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 86);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Khoa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 160);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã Lớp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 229);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên Lớp";
            // 
            // textMaKhoa
            // 
            textMaKhoa.Location = new Point(175, 79);
            textMaKhoa.Name = "textMaKhoa";
            textMaKhoa.Size = new Size(395, 27);
            textMaKhoa.TabIndex = 3;
            // 
            // textMaLop
            // 
            textMaLop.Location = new Point(175, 153);
            textMaLop.Name = "textMaLop";
            textMaLop.Size = new Size(395, 27);
            textMaLop.TabIndex = 4;
            // 
            // textTenLop
            // 
            textTenLop.Location = new Point(175, 222);
            textTenLop.Name = "textTenLop";
            textTenLop.Size = new Size(395, 27);
            textTenLop.TabIndex = 5;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(175, 324);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(94, 42);
            buttonThem.TabIndex = 6;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(323, 324);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(94, 42);
            buttonXoa.TabIndex = 7;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(476, 324);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(94, 42);
            buttonSua.TabIndex = 8;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSua);
            Controls.Add(buttonXoa);
            Controls.Add(buttonThem);
            Controls.Add(textTenLop);
            Controls.Add(textMaLop);
            Controls.Add(textMaKhoa);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "FrmLop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textMaKhoa;
        private TextBox textMaLop;
        private TextBox textTenLop;
        private Button buttonThem;
        private Button buttonXoa;
        private Button buttonSua;
    }
}
