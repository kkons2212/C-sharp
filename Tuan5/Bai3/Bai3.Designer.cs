namespace Bai3
{
    partial class Bai3
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
            btnNgauNhien = new Button();
            button2 = new Button();
            btnXoaDangChon = new Button();
            button4 = new Button();
            btnXoaTenSon = new Button();
            btnXoaHoLe = new Button();
            btnThanhChuHoa = new Button();
            btnThanhChuThuong = new Button();
            btnVietHoaDauMoiTu = new Button();
            lstDanhSach = new ListBox();
            btnXoaTatCa = new Button();
            SuspendLayout();
            // 
            // btnNgauNhien
            // 
            btnNgauNhien.Location = new Point(24, 33);
            btnNgauNhien.Name = "btnNgauNhien";
            btnNgauNhien.Size = new Size(216, 50);
            btnNgauNhien.TabIndex = 0;
            btnNgauNhien.Text = "Nhập tên ngẫu nhiên";
            btnNgauNhien.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(349, 108);
            button2.Name = "button2";
            button2.Size = new Size(8, 8);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnXoaDangChon
            // 
            btnXoaDangChon.Location = new Point(389, 98);
            btnXoaDangChon.Name = "btnXoaDangChon";
            btnXoaDangChon.Size = new Size(356, 47);
            btnXoaDangChon.TabIndex = 2;
            btnXoaDangChon.Text = "Xóa Phần tử đang chọn";
            btnXoaDangChon.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(358, 151);
            button4.Name = "button4";
            button4.Size = new Size(8, 8);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnXoaTenSon
            // 
            btnXoaTenSon.Location = new Point(389, 151);
            btnXoaTenSon.Name = "btnXoaTenSon";
            btnXoaTenSon.Size = new Size(356, 46);
            btnXoaTenSon.TabIndex = 4;
            btnXoaTenSon.Text = "Xóa Phần tử có tên là Sơn\r\n";
            btnXoaTenSon.UseVisualStyleBackColor = true;
            // 
            // btnXoaHoLe
            // 
            btnXoaHoLe.Location = new Point(389, 203);
            btnXoaHoLe.Name = "btnXoaHoLe";
            btnXoaHoLe.Size = new Size(356, 44);
            btnXoaHoLe.TabIndex = 5;
            btnXoaHoLe.Text = "Xóa phần tử có họ là Lê ";
            btnXoaHoLe.UseVisualStyleBackColor = true;
            // 
            // btnThanhChuHoa
            // 
            btnThanhChuHoa.Location = new Point(389, 253);
            btnThanhChuHoa.Name = "btnThanhChuHoa";
            btnThanhChuHoa.Size = new Size(356, 44);
            btnThanhChuHoa.TabIndex = 6;
            btnThanhChuHoa.Text = "Chuyển PT đang chọn thành HOA\r\n";
            btnThanhChuHoa.UseVisualStyleBackColor = true;
            // 
            // btnThanhChuThuong
            // 
            btnThanhChuThuong.Location = new Point(389, 303);
            btnThanhChuThuong.Name = "btnThanhChuThuong";
            btnThanhChuThuong.Size = new Size(356, 45);
            btnThanhChuThuong.TabIndex = 7;
            btnThanhChuThuong.Text = "Chuyển PT đang chọn thành chữ thường";
            btnThanhChuThuong.UseVisualStyleBackColor = true;
            // 
            // btnVietHoaDauMoiTu
            // 
            btnVietHoaDauMoiTu.Location = new Point(389, 354);
            btnVietHoaDauMoiTu.Name = "btnVietHoaDauMoiTu";
            btnVietHoaDauMoiTu.Size = new Size(356, 43);
            btnVietHoaDauMoiTu.TabIndex = 8;
            btnVietHoaDauMoiTu.Text = "Chuyển PT đang chọn thành viết Hoa đầu mỗi chữ\r\n";
            btnVietHoaDauMoiTu.UseVisualStyleBackColor = true;
            // 
            // lstDanhSach
            // 
            lstDanhSach.FormattingEnabled = true;
            lstDanhSach.Location = new Point(7, 104);
            lstDanhSach.Name = "lstDanhSach";
            lstDanhSach.Size = new Size(348, 344);
            lstDanhSach.TabIndex = 9;
            // 
            // btnXoaTatCa
            // 
            btnXoaTatCa.Location = new Point(389, 403);
            btnXoaTatCa.Name = "btnXoaTatCa";
            btnXoaTatCa.Size = new Size(356, 39);
            btnXoaTatCa.TabIndex = 10;
            btnXoaTatCa.Text = "Xóa tất cả các phần tử";
            btnXoaTatCa.UseVisualStyleBackColor = true;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnXoaTatCa);
            Controls.Add(lstDanhSach);
            Controls.Add(btnVietHoaDauMoiTu);
            Controls.Add(btnThanhChuThuong);
            Controls.Add(btnThanhChuHoa);
            Controls.Add(btnXoaHoLe);
            Controls.Add(btnXoaTenSon);
            Controls.Add(button4);
            Controls.Add(btnXoaDangChon);
            Controls.Add(button2);
            Controls.Add(btnNgauNhien);
            Name = "Bai3";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnNgauNhien;
        private Button button2;
        private Button btnXoaDangChon;
        private Button button4;
        private Button btnXoaTenSon;
        private Button btnXoaHoLe;
        private Button btnThanhChuHoa;
        private Button btnThanhChuThuong;
        private Button btnVietHoaDauMoiTu;
        private ListBox lstDanhSach;
        private Button btnXoaTatCa;
    }
}
