namespace Bai9;

public partial class Form1 : Form
{
    // Các biến lưu trữ thống kê cuối ngày
    private int tongSoLuotKhach = 0;
    private double tongSoTien = 0;

    public Form1()
    {
        InitializeComponent();
        this.Text = "FrmDangKyKS";

       
        this.Load += Form1_Load;
        this.FormClosing += Form1_FormClosing;

        txtTenKhach.TextChanged += KiemTraDieuKienThanhToan;
        txtSoNgayO.TextChanged += KiemTraDieuKienThanhToan;

        btnThanhToan.Click += btnThanhToan_Click;
        btnNhapMoi.Click += btnNhapMoi_Click;
        btnTongKet.Click += btnTongKet_Click;
        btnThoat.Click += btnThoat_Click;
    }

   
    private void Form1_Load(object sender, EventArgs e)
    {
        KhoiTaoBanDau();
    }

    private void KhoiTaoBanDau()
    {
        txtTenKhach.Clear();
        txtDiaChi.Clear();
        txtSoNgayO.Clear();

        rdoPhongDon.Checked = true;

        chkTivi.Checked = false;
        chkInternet.Checked = false;
        chkMayNuocNong.Checked = false;

        chkKaraoke.Checked = false;
        chkAnSang.Checked = false;

        lblThanhTien.Text = "0 VNĐ";

        // Các button bị mờ ban đầu 
        btnThanhToan.Enabled = false;
        btnNhapMoi.Enabled = false;
        btnTongKet.Enabled = false;

        txtTenKhach.Focus(); // Con trỏ văn bản đặt vào ô tên khách hàng
    }

    // Kiểm tra điều kiện để bật nút Thanh Toán
    private void KiemTraDieuKienThanhToan(object sender, EventArgs e)
    {
        bool coTen = !string.IsNullOrWhiteSpace(txtTenKhach.Text);
        bool coSoNgay = int.TryParse(txtSoNgayO.Text, out int ngay) && ngay > 0;

        btnThanhToan.Enabled = coTen && coSoNgay;
    }

    // btnThanhToan
    private void btnThanhToan_Click(object sender, EventArgs e)
    {
        int soNgayO = int.Parse(txtSoNgayO.Text);

        // Tiền phòng / ngày
        double tienPhongPerDay = 0;
        if (rdoPhongDon.Checked) tienPhongPerDay = 300000;
        else if (rdoPhongDoi.Checked) tienPhongPerDay = 350000;
        else if (rdoPhongBa.Checked) tienPhongPerDay = 400000;

        double tienPhong = tienPhongPerDay * soNgayO;

        //Tiền tiện nghi: mỗi loại cộng 10.000đ
        int soTienNghi = 0;
        if (chkTivi.Checked) soTienNghi++;
        if (chkInternet.Checked) soTienNghi++;
        if (chkMayNuocNong.Checked) soTienNghi++;

        double tienTienNghi = soTienNghi * 10000;

        //Tiền dịch vụ
        double tienDichVu = 0;
        if (chkKaraoke.Checked) tienDichVu += 50000;
        if (chkAnSang.Checked) tienDichVu += 15000 * soNgayO;

        // Tổng thành tiền khách này
        double thanhTien = tienPhong + tienTienNghi + tienDichVu;

        lblThanhTien.Text = $"{thanhTien:N0} VNĐ";

        // Lưu thông tin tích lũy
        tongSoLuotKhach++;
        tongSoTien += thanhTien;

      
        btnNhapMoi.Enabled = true;
        btnTongKet.Enabled = true;
        btnThanhToan.Enabled = false;
    }

    // btnNhapMoi
    private void btnNhapMoi_Click(object sender, EventArgs e)
    {
        KhoiTaoBanDau();
    }

    // btnTongKet
    private void btnTongKet_Click(object sender, EventArgs e)
    {
        txtTongSoLuot.Text = tongSoLuotKhach.ToString();
        txtTongSoTien.Text = $"{tongSoTien:N0} VNĐ";

        // Khởi tạo lại giá trị 
        tongSoLuotKhach = 0;
        tongSoTien = 0;

        btnTongKet.Enabled = false;
    }

    //btnThoat
    private void btnThoat_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.No)
        {
            e.Cancel = true;
        }
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {

    }
}