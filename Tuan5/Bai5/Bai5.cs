using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        // Khởi tạo đối tượng Service quản lý dữ liệu
        private ListService listService = new ListService();

        public Form1()
        {
            InitializeComponent();

            // Cấu hình tiêu đề Form và gắn sự kiện tường minh bằng code
            this.Text = "frmListbox";
            this.btnNhap.Click += new EventHandler(this.btnNhap_Click);
            this.btnTinhTong.Click += new EventHandler(this.btnTinhTong_Click);
            this.btnXoaDauCuoi.Click += new EventHandler(this.btnXoaDauCuoi_Click);
            this.btnXoaDangChon.Click += new EventHandler(this.btnXoaDangChon_Click);
            this.btnTang2.Click += new EventHandler(this.btnTang2_Click);
            this.btnBinhPhuong.Click += new EventHandler(this.btnBinhPhuong_Click);
            this.btnChonChan.Click += new EventHandler(this.btnChonChan_Click);
            this.btnChonLe.Click += new EventHandler(this.btnChonLe_Click);
            this.btnKetThuc.Click += new EventHandler(this.btnKetThuc_Click);
        }

        // Hàm tiện ích: Đồng bộ dữ liệu từ Service hiển thị lên ListBox
        private void LamMoiGiaoDien()
        {
            lstDanhSach.Items.Clear();
            foreach (var item in listService.LayDanhSach())
            {
                lstDanhSach.Items.Add(item);
            }
        }

        // 1. Nút Nhập
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSoN.Text.Trim(), out int n))
            {
                listService.ThemPhanTu(n);
                LamMoiGiaoDien();
                txtSoN.Clear();
                txtSoN.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập vào một số nguyên hợp lệ!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoN.Focus();
            }
        }

        // 2. Tính tổng
        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.Items.Count == 0)
            {
                MessageBox.Show("Danh sách đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int tong = listService.TinhTong();
            MessageBox.Show($"Tổng các phần tử trong ListBox là: {tong}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 3. Xóa đầu và cuối
        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.Items.Count == 0)
            {
                MessageBox.Show("Danh sách đang trống, không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            listService.XoaDauVaCuoi();
            LamMoiGiaoDien();
            MessageBox.Show("Đã xóa phần tử đầu và cuối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 4. Xóa phần tử đang chọn
        private void btnXoaDangChon_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dòng cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = lstDanhSach.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int index = lstDanhSach.SelectedIndices[i];
                listService.XoaTaiViTri(index);
            }
            LamMoiGiaoDien();
        }

        // 5. Tăng giá trị lên 2
        private void btnTang2_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.Items.Count == 0) return;

            listService.TangLen2();
            LamMoiGiaoDien();
            MessageBox.Show("Đã tăng giá trị mỗi phần tử lên 2!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 6. Bình phương phần tử
        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.Items.Count == 0) return;

            listService.BinhPhuong();
            LamMoiGiaoDien();
            MessageBox.Show("Đã thay thế bằng bình phương của mỗi phần tử!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 7. Chọn số chẵn
        private void btnChonChan_Click(object sender, EventArgs e)
        {
            lstDanhSach.ClearSelected();
            List<int> viTriChan = listService.LayViTriSoChan();
            foreach (var idx in viTriChan)
            {
                lstDanhSach.SetSelected(idx, true);
            }
        }

        // 8. Chọn số lẻ
        private void btnChonLe_Click(object sender, EventArgs e)
        {
            lstDanhSach.ClearSelected();
            List<int> viTriLe = listService.LayViTriSoLe();
            foreach (var idx in viTriLe)
            {
                lstDanhSach.SetSelected(idx, true);
            }
        }

        // 9. Nút Kết thúc
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}