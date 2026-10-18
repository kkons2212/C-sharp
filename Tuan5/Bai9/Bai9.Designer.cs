namespace Bai9
{
    partial class Bai9
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
            menuStrip1 = new MenuStrip();
            menuCapNhat = new ToolStripMenuItem();
            menuNhapHocVienMoi = new ToolStripMenuItem();
            menuChuyenSangLopB = new ToolStripMenuItem();
            menuChuyenSangLopA = new ToolStripMenuItem();
            menuKetThuc = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            lstLopA = new ListBox();
            groupBox2 = new GroupBox();
            lstLopB = new ListBox();
            mnuXoaHocVien = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuCapNhat, menuKetThuc });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuCapNhat
            // 
            menuCapNhat.DropDownItems.AddRange(new ToolStripItem[] { menuNhapHocVienMoi, menuChuyenSangLopB, menuChuyenSangLopA, mnuXoaHocVien });
            menuCapNhat.Name = "menuCapNhat";
            menuCapNhat.Size = new Size(85, 24);
            menuCapNhat.Text = "Cập Nhật";
            // 
            // menuNhapHocVienMoi
            // 
            menuNhapHocVienMoi.Name = "menuNhapHocVienMoi";
            menuNhapHocVienMoi.Size = new Size(224, 26);
            menuNhapHocVienMoi.Text = "Nhập học viên mới";
            // 
            // menuChuyenSangLopB
            // 
            menuChuyenSangLopB.Name = "menuChuyenSangLopB";
            menuChuyenSangLopB.Size = new Size(224, 26);
            menuChuyenSangLopB.Text = "Chuyển sang lớp B";
            // 
            // menuChuyenSangLopA
            // 
            menuChuyenSangLopA.Name = "menuChuyenSangLopA";
            menuChuyenSangLopA.Size = new Size(224, 26);
            menuChuyenSangLopA.Text = "Chuyển sang lớp A";
            // 
            // menuKetThuc
            // 
            menuKetThuc.Name = "menuKetThuc";
            menuKetThuc.Size = new Size(77, 24);
            menuKetThuc.Text = "&Kết thúc";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstLopA);
            groupBox1.Location = new Point(59, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(298, 320);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lớp A";
            // 
            // lstLopA
            // 
            lstLopA.FormattingEnabled = true;
            lstLopA.Items.AddRange(new object[] { "Trần Hùng", "Nguyễn Hưng", "Lâm Tứ" });
            lstLopA.Location = new Point(30, 46);
            lstLopA.Name = "lstLopA";
            lstLopA.SelectionMode = SelectionMode.MultiExtended;
            lstLopA.Size = new Size(223, 244);
            lstLopA.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstLopB);
            groupBox2.Location = new Point(416, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(294, 318);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lớp B";
            // 
            // lstLopB
            // 
            lstLopB.FormattingEnabled = true;
            lstLopB.Items.AddRange(new object[] { "Tuấn Hưng", "Hồng Ngọc", "Anh Minh", "Bảo Lâm" });
            lstLopB.Location = new Point(25, 50);
            lstLopB.Name = "lstLopB";
            lstLopB.SelectionMode = SelectionMode.MultiExtended;
            lstLopB.Size = new Size(235, 244);
            lstLopB.TabIndex = 0;
            // 
            // mnuXoaHocVien
            // 
            mnuXoaHocVien.Name = "mnuXoaHocVien";
            mnuXoaHocVien.Size = new Size(224, 26);
            mnuXoaHocVien.Text = "Xóa Học Viên";
            // 
            // Bai9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Bai9";
            Text = "QuanLyHocVien";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuCapNhat;
        private ToolStripMenuItem menuNhapHocVienMoi;
        private ToolStripMenuItem menuChuyenSangLopB;
        private ToolStripMenuItem menuChuyenSangLopA;
        private ToolStripMenuItem menuKetThuc;
        private GroupBox groupBox1;
        private ListBox lstLopA;
        private GroupBox groupBox2;
        private ListBox lstLopB;
        private ToolStripMenuItem mnuXoaHocVien;
    }
}