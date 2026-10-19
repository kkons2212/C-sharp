namespace Bai2
{
    partial class QuanLySInhVien
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
            textMaLop = new TextBox();
            textMaSV = new TextBox();
            textHoTen = new TextBox();
            textNgaySinh = new TextBox();
            buttonThem = new Button();
            buttonXoa = new Button();
            buttonSua = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 65);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Lớp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 129);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã SV";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 192);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 2;
            label3.Text = "Họ Tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 271);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 3;
            label4.Text = "Ngày sinh";
            // 
            // textMaLop
            // 
            textMaLop.Location = new Point(236, 58);
            textMaLop.Name = "textMaLop";
            textMaLop.Size = new Size(246, 27);
            textMaLop.TabIndex = 4;
            // 
            // textMaSV
            // 
            textMaSV.Location = new Point(236, 126);
            textMaSV.Name = "textMaSV";
            textMaSV.Size = new Size(246, 27);
            textMaSV.TabIndex = 5;
            // 
            // textHoTen
            // 
            textHoTen.Location = new Point(236, 185);
            textHoTen.Name = "textHoTen";
            textHoTen.Size = new Size(246, 27);
            textHoTen.TabIndex = 6;
            // 
            // textNgaySinh
            // 
            textNgaySinh.Location = new Point(236, 264);
            textNgaySinh.Name = "textNgaySinh";
            textNgaySinh.Size = new Size(246, 27);
            textNgaySinh.TabIndex = 7;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(101, 347);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(94, 45);
            buttonThem.TabIndex = 8;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += this.buttonThem_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(246, 347);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(115, 45);
            buttonXoa.TabIndex = 9;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(433, 347);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(94, 45);
            buttonSua.TabIndex = 10;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            // 
            // QuanLySInhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSua);
            Controls.Add(buttonXoa);
            Controls.Add(buttonThem);
            Controls.Add(textNgaySinh);
            Controls.Add(textHoTen);
            Controls.Add(textMaSV);
            Controls.Add(textMaLop);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "QuanLySInhVien";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textMaLop;
        private TextBox textMaSV;
        private TextBox textHoTen;
        private TextBox textNgaySinh;
        private Button buttonThem;
        private Button buttonXoa;
        private Button buttonSua;
    }
}
