namespace Bai9
{
    partial class frmNhapHocVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtHoTen = new TextBox();
            cboLop = new ComboBox();
            btnCapNhat = new Button();
            btnTroVe = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 91);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ Tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 174);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 1;
            label2.Text = "Lớp";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(240, 84);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(297, 27);
            txtHoTen.TabIndex = 2;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            // 
            // cboLop
            // 
            cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLop.FormattingEnabled = true;
            cboLop.Items.AddRange(new object[] { "Lớp A", "Lớp B" });
            cboLop.Location = new Point(240, 166);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(297, 28);
            cboLop.TabIndex = 3;
            cboLop.SelectedIndexChanged += cboLop_SelectedIndexChanged;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(397, 289);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 50);
            btnCapNhat.TabIndex = 4;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnTroVe
            // 
            btnTroVe.Location = new Point(555, 289);
            btnTroVe.Name = "btnTroVe";
            btnTroVe.Size = new Size(94, 50);
            btnTroVe.TabIndex = 5;
            btnTroVe.Text = "Trở Về";
            btnTroVe.UseVisualStyleBackColor = true;
            btnTroVe.Click += btnTroVe_Click;
            // 
            // frmNhapHocVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 394);
            Controls.Add(btnTroVe);
            Controls.Add(btnCapNhat);
            Controls.Add(cboLop);
            Controls.Add(txtHoTen);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNhapHocVien";
            Text = "frmNhapHocVien";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtHoTen;
        private ComboBox cboLop;
        private Button btnCapNhat;
        private Button btnTroVe;
    }
}