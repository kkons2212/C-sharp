namespace Bai5;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        this.Text = "Tâm Gà - Đọc Chữ Số";
        this.AcceptButton = buttonThucHien;

        buttonThucHien.Click += btnThucHien_Click;
        buttonXoa.Click += btnXoa_Click;
        buttonThoat.Click += btnThoat_Click;
        this.FindForm().FormClosing += Form1_FormClosing;
    }
    private string DocSoThanhChu(int n)
    {
        string[] chuSo = { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };

        int tram = n / 100;
        int chuc = (n % 100) / 10;
        int donVi = n % 10;

        string ketQua = "";

        // 1. Đọc hàng trăm
        if (tram > 0)
        {
            ketQua += chuSo[tram] + " Trăm ";
        }

        // 2. Đọc hàng chục
        if (chuc > 1)
        {
            ketQua += chuSo[chuc] + " Mươi ";
        }
        else if (chuc == 1)
        {
            ketQua += "Mười ";
        }
        else if (tram > 0 && donVi > 0) // Ví dụ 105 -> Một Trăm Lẻ Năm
        {
            ketQua += "Lẻ ";
        }

        // 3. Đọc hàng đơn vị
        if (donVi > 0)
        {
            if (donVi == 1 && chuc > 1)
            {
                ketQua += "Mốt";
            }
            else if (donVi == 5 && chuc > 0)
            {
                ketQua += "Lăm";
            }
            else
            {
                ketQua += chuSo[donVi];
            }
        }

        return ketQua.Trim();
    }
    private void btnThucHien_Click(object sender, EventArgs e)
    {
        // Kiểm tra đầu vào từ 1 đến 999
        if (!int.TryParse(textDaySo.Text, out int n) || n < 1 || n > 999)
        {
            MessageBox.Show("Vui lòng nhập số nguyên trong khoảng từ 1 đến 999!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textDaySo.SelectAll();
            textDaySo.Focus();
            return;
        }

        // Hiển thị kết quả đọc số
        textKetQua.Text = DocSoThanhChu(n);
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        textDaySo.Clear();
        textKetQua.Text = "";
        textDaySo.Focus();
    }

    private void btnThoat_Click(object sender, EventArgs e)
    {
        this.Close();
    }
    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        // Bật hộp thoại hỏi 
        DialogResult result = MessageBox.Show(
            "Bạn có chắc chắn muốn đóng ứng dụng không?",
            "Xác nhận thoát",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        // Nếu người dùng bấm NO
        if (result == DialogResult.No)
        {
            e.Cancel = true;
        }
    }
}
