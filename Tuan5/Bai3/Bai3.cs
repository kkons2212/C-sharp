using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();

            // Cấu hình Tiêu đề Form và gắn sự kiện tường minh chuẩn chỉnh bằng code
            this.Text = "frmChuoi";
            this.btnNgauNhien.Click += new EventHandler(this.btnNgauNhien_Click);
            this.btnXoaDangChon.Click += new EventHandler(this.btnXoaDangChon_Click);
            this.btnXoaTenSon.Click += new EventHandler(this.btnXoaTenSon_Click);
            this.btnXoaHoLe.Click += new EventHandler(this.btnXoaHoLe_Click);
            this.btnThanhChuHoa.Click += new EventHandler(this.btnThanhChuHoa_Click);
            this.btnThanhChuThuong.Click += new EventHandler(this.btnThanhChuThuong_Click);
            this.btnVietHoaDauMoiTu.Click += new EventHandler(this.btnVietHoaDauMoiTu_Click);
            this.btnXoaTatCa.Click += new EventHandler(this.btnXoaTatCa_Click);

            // Gắn sự kiện DoubleClick cho ListBox để mở hộp thoại đổi tên
            this.lstDanhSach.DoubleClick += new EventHandler(this.lstDanhSach_DoubleClick);
        }

        //  Thêm 50 tên ngẫu nhiên vào ListBox
        private void btnNgauNhien_Click(object sender, EventArgs e)
        {
            lstDanhSach.Items.Clear();
            List<string> danhSach = XuLyChuoi.Tao50TenNgauNhien();

            foreach (var item in danhSach)
            {
                lstDanhSach.Items.Add(item);
            }
            MessageBox.Show("Đã thêm 50 tên ngẫu nhiên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Xóa phần tử đang được chọn
        private void btnXoaDangChon_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedItem != null)
            {
                lstDanhSach.Items.Remove(lstDanhSach.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa trong danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Xóa phần tử có tên là "Sơn" (Từ cuối cùng)
        private void btnXoaTenSon_Click(object sender, EventArgs e)
        {
            for (int i = lstDanhSach.Items.Count - 1; i >= 0; i--)
            {
                string text = lstDanhSach.Items[i].ToString();
                string[] parts = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length > 0 && parts[parts.Length - 1].Equals("Sơn", StringComparison.OrdinalIgnoreCase))
                {
                    lstDanhSach.Items.RemoveAt(i);
                }
            }
            MessageBox.Show("Đã xóa các phần tử có tên là Sơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Xóa phần tử có họ là "Lê" (Từ đầu tiên)
        private void btnXoaHoLe_Click(object sender, EventArgs e)
        {
            for (int i = lstDanhSach.Items.Count - 1; i >= 0; i--)
            {
                string text = lstDanhSach.Items[i].ToString();
                string[] parts = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length > 0 && parts[0].Equals("Lê", StringComparison.OrdinalIgnoreCase))
                {
                    lstDanhSach.Items.RemoveAt(i);
                }
            }
            MessageBox.Show("Đã xóa các phần tử có họ là Lê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Chuyển phần tử đang chọn thành chữ HOA
        private void btnThanhChuHoa_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedIndex != -1)
            {
                int idx = lstDanhSach.SelectedIndex;
                lstDanhSach.Items[idx] = lstDanhSach.SelectedItem.ToString().ToUpper();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để chuyển đổi!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Chuyển phần tử đang chọn thành chữ thường
        private void btnThanhChuThuong_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedIndex != -1)
            {
                int idx = lstDanhSach.SelectedIndex;
                lstDanhSach.Items[idx] = lstDanhSach.SelectedItem.ToString().ToLower();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để chuyển đổi!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Viết hoa chữ cái đầu mỗi từ
        private void btnVietHoaDauMoiTu_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedIndex != -1)
            {
                int idx = lstDanhSach.SelectedIndex;
                string text = lstDanhSach.SelectedItem.ToString().ToLower();
                string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Length > 0)
                    {
                        words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
                    }
                }
                lstDanhSach.Items[idx] = string.Join(" ", words);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để chuyển đổi!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Xóa sạch danh sách trong ListBox
        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            lstDanhSach.Items.Clear();
        }

        // Mở InputBox cho phép thay đổi tên mới vào vị trí đang chọn
        private void lstDanhSach_DoubleClick(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedIndex != -1)
            {
                int idx = lstDanhSach.SelectedIndex;
                string tenCu = lstDanhSach.SelectedItem.ToString();

                string tenMoi = Microsoft.VisualBasic.Interaction.InputBox(
                    "Nhập tên mới thay thế:",
                    "Cập nhật tên",
                    tenCu,
                    -1, -1
                );

                if (!string.IsNullOrWhiteSpace(tenMoi))
                {
                    lstDanhSach.Items[idx] = tenMoi.Trim();
                }
            }
        }
    }
}