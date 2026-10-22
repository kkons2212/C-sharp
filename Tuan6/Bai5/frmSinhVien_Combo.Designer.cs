namespace Bai5
{
    partial class frmSinhVien_Combo
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
            comboBoxLop = new ComboBox();
            textMaSinhVien = new TextBox();
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
            label1.Location = new Point(81, 61);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 0;
            label1.Text = "Lớp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 144);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã Sinh Viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 216);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 2;
            label3.Text = "Họ Tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 289);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 3;
            label4.Text = "Ngày Sinh";
            // 
            // comboBoxLop
            // 
            comboBoxLop.FormattingEnabled = true;
            comboBoxLop.Location = new Point(206, 53);
            comboBoxLop.Name = "comboBoxLop";
            comboBoxLop.Size = new Size(369, 28);
            comboBoxLop.TabIndex = 4;
            // 
            // textMaSinhVien
            // 
            textMaSinhVien.Location = new Point(206, 137);
            textMaSinhVien.Name = "textMaSinhVien";
            textMaSinhVien.Size = new Size(369, 27);
            textMaSinhVien.TabIndex = 5;
            // 
            // textHoTen
            // 
            textHoTen.Location = new Point(206, 216);
            textHoTen.Name = "textHoTen";
            textHoTen.Size = new Size(369, 27);
            textHoTen.TabIndex = 6;
            // 
            // textNgaySinh
            // 
            textNgaySinh.Location = new Point(206, 282);
            textNgaySinh.Name = "textNgaySinh";
            textNgaySinh.Size = new Size(369, 27);
            textNgaySinh.TabIndex = 7;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(206, 350);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(94, 50);
            buttonThem.TabIndex = 8;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(355, 350);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(94, 50);
            buttonXoa.TabIndex = 9;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(504, 350);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(94, 50);
            buttonSua.TabIndex = 10;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            // 
            // frmSinhVien_Combo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSua);
            Controls.Add(buttonXoa);
            Controls.Add(buttonThem);
            Controls.Add(textNgaySinh);
            Controls.Add(textHoTen);
            Controls.Add(textMaSinhVien);
            Controls.Add(comboBoxLop);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmSinhVien_Combo";
            Text = "frmSinhVien_Combo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxLop;
        private TextBox textMaSinhVien;
        private TextBox textHoTen;
        private TextBox textNgaySinh;
        private Button buttonThem;
        private Button buttonXoa;
        private Button buttonSua;
    }
}
