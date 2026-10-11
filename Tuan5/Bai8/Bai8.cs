using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai8
{
    public partial class Bai8 : Form
    {
        private AccountService accountService = new AccountService();
        private bool đangThem = cờTrạngThaiThem(); // Theo dõi trạng thái nút Thêm/Hủy

        private static bool cờTrạngThaiThem() => false;

        public Bai8()
        {
            InitializeComponent();

            this.Text = "frmBaiTap2"; 
            this.Load += new EventHandler(this.Bai8_Load);
            this.FormClosing += new FormClosingEventHandler(this.Bai8_FormClosing);

            this.btnThem.Click += new EventHandler(this.btnThem_Click);
            this.btnLuu.Click += new EventHandler(this.btnLuu_Click);
            this.btnXoa.Click += new EventHandler(this.btnXoa_Click);
            this.btnThoat.Click += new EventHandler(this.btnThoat_Click);

            this.lsvTaiKhoan.SelectedIndexChanged += new EventHandler(this.lsvTaiKhoan_SelectedIndexChanged);
        }

        private void Bai8_Load(object sender, EventArgs e)
        {
            // Trạng thái ban đầu khi Form load lên
            lsvTaiKhoan.FullRowSelect = true;
            lsvTaiKhoan.GridLines = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            txtTongTien.ReadOnly = true;
            txtTongTien.TextAlign = HorizontalAlignment.Right;
            CapNhatGiaoDienTongTien();
        }

        // Nút Thêm / Hủy
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "Hủy";
                btnLuu.Enabled = true;
                btnXoa.Enabled = false;

              
                XoaTrangTextBox();
                txtSoTaiKhoan.Focus();
            }
            else
            {
               
                btnThem.Text = "Thêm";
                btnLuu.Enabled = false;
                XoaTrangTextBox();
            }
        }

        // Nút Lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string soTK = txtSoTaiKhoan.Text.Trim();
            string tenKH = txtTenKhachHang.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string strTien = txtSoTien.Text.Trim();

            if (string.IsNullOrEmpty(soTK) || string.IsNullOrEmpty(tenKH) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(strTien))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(strTien, out decimal soTien) || soTien < 0)
            {
                MessageBox.Show("Số tiền phải là định dạng số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoTien.Focus();
                return;
            }

            // Tạo dòng mới trên ListView
            ListViewItem item = new ListViewItem("");
            item.SubItems.Add(soTK);
            item.SubItems.Add(tenKH);
            item.SubItems.Add(diaChi);
            item.SubItems.Add(accountService.DinhDangTien(soTien));

            lsvTaiKhoan.Items.Add(item);

            // Tự động đánh lại STT và tính Tổng tiền
            accountService.CapNhatSTT(lsvTaiKhoan);
            CapNhatGiaoDienTongTien();

            // Đưa nút Thêm về trạng thái ban đầu sau khi lưu thành công
            btnThem.Text = "Thêm";
            btnLuu.Enabled = false;
            XoaTrangForm();
        }

        // Click chọn một khách hàng trên ListView hiển thị lên TextBox
        private void lsvTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvTaiKhoan.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvTaiKhoan.SelectedItems[0];
                txtSoTaiKhoan.Text = item.SubItems[1].Text;
                txtTenKhachHang.Text = item.SubItems[2].Text;
                txtDiaChi.Text = item.SubItems[3].Text;
                txtSoTien.Text = item.SubItems[4].Text.Replace(",", "");

                btnXoa.Enabled = true; // Bật nút Xóa khi có mẫu tin được chọn
            }
            else
            {
                btnXoa.Enabled = false;
            }
        }

        // Nút Xóa: 
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvTaiKhoan.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa trên bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (ListViewItem item in lsvTaiKhoan.SelectedItems)
                {
                    lsvTaiKhoan.Items.Remove(item);
                }

                // Cập nhật lại STT và Tổng tiền sau khi xóa
                accountService.CapNhatSTT(lsvTaiKhoan);
                CapNhatGiaoDienTongTien();
                XoaTrangForm();
            }
        }

        //Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bai8_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void XoaTrangTextBox()
        {
            txtSoTaiKhoan.Clear();
            txtTenKhachHang.Clear();
            txtDiaChi.Clear();
            txtSoTien.Clear();
        }

        private void XoaTrangForm()
        {
            XoaTrangTextBox();
            btnXoa.Enabled = false;
        }

        private void CapNhatGiaoDienTongTien()
        {
            decimal tong = accountService.TinhTongTien(lsvTaiKhoan);
            txtTongTien.Text = accountService.DinhDangTien(tong);
        }
        
        private void label2_Click(object sender, EventArgs e)
        {
    
        }
    }
}