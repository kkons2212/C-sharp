using System;
using System.Windows.Forms;

namespace Bai1;

public partial class Bai1 : Form
{
    public Bai1()
    {
        InitializeComponent();

        this.Text = "Combobox";
        this.btnCapNhat.Click += new EventHandler(this.btnCapNhat_Click);
        this.cboDanhSach.SelectedIndexChanged += new EventHandler(this.cboDanhSach_SelectedIndexChanged);
        this.btnTongUoc.Click += new EventHandler(this.btnTongUoc_Click);
        this.btnSoLuongChan.Click += new EventHandler(this.btnSoLuongChan_Click);
        this.btnSoLuongNT.Click += new EventHandler(this.btnSoLuongNT_Click);
        this.btnThoat.Click += new EventHandler(this.btnThoat_Click);
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {
    }

   
    private void btnCapNhat_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtNhapSo.Text))
        {
            MessageBox.Show("Vui lòng nhập một số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNhapSo.Focus();
            return;
        }

        if (!int.TryParse(txtNhapSo.Text.Trim(), out int soMoi))
        {
            MessageBox.Show("Dữ liệu nhập không phải là số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtNhapSo.Clear();
            txtNhapSo.Focus();
            return;
        }

        if (cboDanhSach.Items.Contains(soMoi))
        {
            MessageBox.Show("Số này đã có trong danh sách Combobox!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Vẫn cho phép chọn lại số đã có để xem ước số luôn nếu muốn
            cboDanhSach.SelectedItem = soMoi;
            txtNhapSo.Clear();
            txtNhapSo.Focus();
            return;
        }

        // Thêm vào ComboBox và tự động chọn dòng vừa thêm để kích hoạt hiển thị ước số
        int indexMoi = cboDanhSach.Items.Add(soMoi);
        cboDanhSach.SelectedIndex = indexMoi;

        txtNhapSo.Clear();
        txtNhapSo.Focus();
    }

    // 2. Sự kiện chọn item trong ComboBox để hiện ước lên ListBox
    private void cboDanhSach_SelectedIndexChanged(object sender, EventArgs e)
    {  
        if (cboDanhSach.SelectedItem != null)
        {
            if (int.TryParse(cboDanhSach.SelectedItem.ToString(), out int giaTriChon))
            {
                SoHoc soHoc = new SoHoc(giaTriChon);

                lstUocSo.Items.Clear();
                var danhSachUoc = soHoc.TimCacUocSo();
                foreach (var uoc in danhSachUoc)
                {
                    lstUocSo.Items.Add(uoc);
                }
            }
        }
    }

    // Hàm phụ trợ kiểm tra chọn số cho các nút tính toán
    private SoHoc LaySoHocHienTai()
    {
        if (cboDanhSach.Text == null || string.IsNullOrWhiteSpace(cboDanhSach.Text))
        {
            MessageBox.Show("Vui lòng chọn một số trong ComboBox trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return null;
        }

        if (int.TryParse(cboDanhSach.Text.Trim(), out int giaTri))
        {
            return new SoHoc(giaTri);
        }
        else
        {
            MessageBox.Show("Giá trị trong ComboBox không phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
    }

    // 3. Nút Tổng các ước số
    private void btnTongUoc_Click(object sender, EventArgs e)
    {
        SoHoc soHoc = LaySoHocHienTai();
        if (soHoc != null)
        {
            int tong = soHoc.TinhTongUoc();
            MessageBox.Show($"Tổng các ước số của {soHoc.GiaTri} là: {tong}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    // 4. Nút Số lượng các ước số chẵn
    private void btnSoLuongChan_Click(object sender, EventArgs e)
    {
        SoHoc soHoc = LaySoHocHienTai();
        if (soHoc != null)
        {
            int slChan = soHoc.DemUocChan();
            MessageBox.Show($"Số lượng các ước số chẵn của {soHoc.GiaTri} là: {slChan}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    // 5. Nút Số lượng các ước số nguyên tố
    private void btnSoLuongNT_Click(object sender, EventArgs e)
    {
        SoHoc soHoc = LaySoHocHienTai();
        if (soHoc != null)
        {
            int slNT = soHoc.DemUocNguyenTo();
            MessageBox.Show($"Số lượng các ước số nguyên tố của {soHoc.GiaTri} là: {slNT}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    // 6. Nút Thoát
    private void btnThoat_Click(object sender, EventArgs e)
    {
        DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dr == DialogResult.Yes)
        {
            Application.Exit();
        }
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
    private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e) { }
}