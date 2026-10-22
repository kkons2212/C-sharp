namespace Bai3
{
    partial class QuanLyDiem
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
            textMaSV = new TextBox();
            textMamh = new TextBox();
            textDiem = new TextBox();
            buttonThem = new Button();
            buttonXoa = new Button();
            buttonSua = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 67);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 0;
            label1.Text = "MaSV";
          
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 135);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 1;
            label2.Text = "Ma mh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 198);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 2;
            label3.Text = "Diem";
            // 
            // textMaSV
            // 
            textMaSV.Location = new Point(171, 60);
            textMaSV.Name = "textMaSV";
            textMaSV.Size = new Size(369, 27);
            textMaSV.TabIndex = 3;
            // 
            // textMamh
            // 
            textMamh.Location = new Point(171, 128);
            textMamh.Name = "textMamh";
            textMamh.Size = new Size(369, 27);
            textMamh.TabIndex = 4;
            // 
            // textDiem
            // 
            textDiem.Location = new Point(171, 195);
            textDiem.Name = "textDiem";
            textDiem.Size = new Size(369, 27);
            textDiem.TabIndex = 5;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(143, 295);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(94, 44);
            buttonThem.TabIndex = 6;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += this.buttonThem_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(296, 295);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(94, 44);
            buttonXoa.TabIndex = 7;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(446, 295);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(94, 44);
            buttonSua.TabIndex = 8;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            // 
            // QuanLyDiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSua);
            Controls.Add(buttonXoa);
            Controls.Add(buttonThem);
            Controls.Add(textDiem);
            Controls.Add(textMamh);
            Controls.Add(textMaSV);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "QuanLyDiem";
            Text = "Quản Lý Điểm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textMaSV;
        private TextBox textMamh;
        private TextBox textDiem;
        private Button buttonThem;
        private Button buttonXoa;
        private Button buttonSua;
    }
}
