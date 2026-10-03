namespace Bai6;

public partial class Form1 : Form
{
    double soThuNhat = 0;
    string phepTinh = "";
    bool isDangNhapSoMoi = true; // Đánh dấu khi vừa bấm nút phép tính xong
    public Form1()
    {
        InitializeComponent();
        this.Text = "Máy Tính Bỏ Túi";

       
        textNhap.TextAlign = HorizontalAlignment.Right;

       
        button0.Click += btnSo_Click;
        button1.Click += btnSo_Click;
        button2.Click += btnSo_Click;
        button3.Click += btnSo_Click;
        button4.Click += btnSo_Click;
        button5.Click += btnSo_Click;
        button6.Click += btnSo_Click;
        button7.Click += btnSo_Click;
        button8.Click += btnSo_Click;
        button9.Click += btnSo_Click;

        buttonCong.Click += btnPhepTinh_Click;
        buttonTru.Click += btnPhepTinh_Click;
        buttonNhan.Click += btnPhepTinh_Click;
        buttonChia.Click += btnPhepTinh_Click;

        buttonEqual.Click += btnBang_Click;
        buttondelete.Click += btnXoa_Click;
        this.FindForm().FormClosing += Form1_FormClosing;
    }

    private void button16_Click(object sender, EventArgs e)
    {

    }
    private void btnSo_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;

        // Nếu vừa bấm phép tính xong, xóa màn hình để nhập số thứ 2
        if (isDangNhapSoMoi)
        {
            textNhap.Text = "";
            isDangNhapSoMoi = false;
        }

        // Không cho nhập số 0 thừa ở đầu
        if (textNhap.Text == "0")
        {
            textNhap.Text = btn.Text;
        }
        else
        {
            textNhap.Text += btn.Text;
        }
    }
    private void btnPhepTinh_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;

        if (double.TryParse(textNhap.Text, out double value))
        {
            soThuNhat = value;
            phepTinh = btn.Text; // Lưu phép tính ('+', '-', '*', '/')
            isDangNhapSoMoi = true;
        }
    }
    private void btnBang_Click(object sender, EventArgs e)
    {
        if (!double.TryParse(textNhap.Text, out double soThuHai)) return;

        double ketQua = 0;

        switch (phepTinh)
        {
            case "+":
                ketQua = soThuNhat + soThuHai;
                break;
            case "-":
                ketQua = soThuNhat - soThuHai;
                break;
            case "*":
                ketQua = soThuNhat * soThuHai;
                break;
            case "/":
                if (soThuHai == 0)
                {
                    MessageBox.Show("Không thể chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ketQua = soThuNhat / soThuHai;
                break;
        }

        textNhap.Text = ketQua.ToString();
        isDangNhapSoMoi = true;
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        textNhap.Text = "0";
        soThuNhat = 0;
        phepTinh = "";
        isDangNhapSoMoi = true;
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
