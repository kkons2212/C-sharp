namespace Bai7;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        this.Text = "Giải phương trình bậc 1-2";

        //  Khi Form load, nút Giải mờ đi[cite: 7]
        btnGiai.Enabled = false;
        rdoBacNhat.Checked = true;
        lblC.Enabled = false;
        txtC.Enabled = false;

        //Đăng ký sự kiện chuyển RadioButton
        rdoBacNhat.CheckedChanged += rdo_CheckedChanged;
        rdoBacHai.CheckedChanged += rdo_CheckedChanged;

        // Đăng ký sự kiện nhập chữ để kiểm tra bật/tắt nút Giải
        txtA.TextChanged += txt_TextChanged;
        txtB.TextChanged += txt_TextChanged;
        txtC.TextChanged += txt_TextChanged;


        btnGiai.Click += btnGiai_Click;
        btnThoat.Click += btnThoat_Click;
        this.FormClosing += Form1_FormClosing;
    }

    // Ẩn / hiện ô nhập C khi chọn loại phương trình
    private void rdo_CheckedChanged(object sender, EventArgs e)
    {
        bool isBacHai = rdoBacHai.Checked;

        lblC.Enabled = isBacHai;
        txtC.Enabled = isBacHai;

        txtKetQua.Clear();
        KiemTraDieuKienGiai();
    }

    // Tự động kiểm tra đủ dữ liệu chưa để bật nút Giải
    private void KiemTraDieuKienGiai()
    {
        bool coA = double.TryParse(txtA.Text, out _);
        bool coB = double.TryParse(txtB.Text, out _);
        bool coC = double.TryParse(txtC.Text, out _);

        if (rdoBacNhat.Checked)
        {
            btnGiai.Enabled = coA && coB;
        }
        else
        {
            btnGiai.Enabled = coA && coB && coC;
        }
    }

    private void txt_TextChanged(object sender, EventArgs e)
    {
        KiemTraDieuKienGiai();
    }

    // Xử lý nút Giải
    private void btnGiai_Click(object sender, EventArgs e)
    {
        double a = double.Parse(txtA.Text);
        double b = double.Parse(txtB.Text);
        double c = rdoBacHai.Checked ? double.Parse(txtC.Text) : 0;

        PhuongTrinhBacHai pt = new PhuongTrinhBacHai(a, b, c);

        if (rdoBacNhat.Checked)
        {
            txtKetQua.Text = pt.GiaiBacNhat();
        }
        else
        {
            txtKetQua.Text = pt.GiaiBacHai();
        }

        // Sau khi giải xong button Giải mờ đi
        btnGiai.Enabled = false;
    }

    private void btnThoat_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    // Xác nhận khi đóng Form[cite: 8]
    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.No)
        {
            e.Cancel = true;
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {

    }
}

// Class PhuongTrinhBacHai theo đúng yêu cầu đề bài[cite: 7, 8]
public class PhuongTrinhBacHai
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public PhuongTrinhBacHai(double a, double b, double c = 0)
    {
        A = a;
        B = b;
        C = c;
    }

    public string GiaiBacNhat()
    {
        if (A == 0)
        {
            if (B == 0) return "Phương trình có vô số nghiệm";
            return "Phương trình vô nghiệm";
        }
        double x = -B / A;
        return $"Phương trình có nghiệm x = {x:F2}";
    }

    public string GiaiBacHai()
    {
        if (A == 0) return GiaiBacNhat();

        double delta = B * B - 4 * A * C;
        if (delta < 0)
        {
            return "Phương trình vô nghiệm";
        }
        else if (delta == 0)
        {
            double x = -B / (2 * A);
            return $"Phương trình có nghiệm kép x1 = x2 = {x:F2}";
        }
        else
        {
            double x1 = (-B + Math.Sqrt(delta)) / (2 * A);
            double x2 = (-B - Math.Sqrt(delta)) / (2 * A);
            return $"Phương trình có 2 nghiệm phân biệt:\r\nx1 = {x1:F2}\r\nx2 = {x2:F2}";
        }
    }
}