namespace Bai6
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
            comboBoxSV = new ComboBox();
            comboBoxMH = new ComboBox();
            textDiem = new TextBox();
            buttonThem = new Button();
            buttonXoa = new Button();
            buttonSua = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 78);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Sinh Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 164);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Môn Học";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 237);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 2;
            label3.Text = "Điểm";
            // 
            // comboBoxSV
            // 
            comboBoxSV.FormattingEnabled = true;
            comboBoxSV.Location = new Point(200, 70);
            comboBoxSV.Name = "comboBoxSV";
            comboBoxSV.Size = new Size(348, 28);
            comboBoxSV.TabIndex = 3;
            // 
            // comboBoxMH
            // 
            comboBoxMH.FormattingEnabled = true;
            comboBoxMH.Location = new Point(200, 156);
            comboBoxMH.Name = "comboBoxMH";
            comboBoxMH.Size = new Size(348, 28);
            comboBoxMH.TabIndex = 4;
            // 
            // textDiem
            // 
            textDiem.Location = new Point(200, 237);
            textDiem.Name = "textDiem";
            textDiem.Size = new Size(348, 27);
            textDiem.TabIndex = 5;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(160, 332);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(94, 49);
            buttonThem.TabIndex = 6;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(311, 332);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(94, 49);
            buttonXoa.TabIndex = 7;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(474, 332);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(94, 49);
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
            Controls.Add(textDiem);
            Controls.Add(comboBoxMH);
            Controls.Add(comboBoxSV);
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
        private ComboBox comboBoxSV;
        private ComboBox comboBoxMH;
        private TextBox textDiem;
        private Button buttonThem;
        private Button buttonXoa;
        private Button buttonSua;
    }
}
