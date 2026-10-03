namespace Bai3;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        this.Text = "Ước Số- Bội Số";
        buttonThucHien.Click += buttonThucHien_Click;
        buttonTiepTuc.Click += buttonTiepTuc_Click; 
        buttonThoat.Click += buttonThoat_Click; 
        this.FindForm().FormClosing += Form1_FormClosing;
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {

    }
    // Hàm tìm Ước Số Chung Lớn Nhất
    private int TimUCLN(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Hàm tìm Bội Số Chung Nhỏ Nhất
    private int TimBCNN(int a, int b)
    {
        if (a == 0 || b == 0) return 0; // Tránh chia cho 0
        return Math.Abs(a * b) / TimUCLN(a, b);
    }

    private void buttonThucHien_Click(object sender, EventArgs e)
    {
        // 1. Kiểm tra dữ liệu nhập vào số a
        if (!int.TryParse(texta.Text, out int a))
        {
            MessageBox.Show("Vui lòng nhập số a hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            texta.Focus();
            return;
        }

        // 2. Kiểm tra dữ liệu nhập vào số b
        if (!int.TryParse(textb.Text, out int b))
        {
            MessageBox.Show("Vui lòng nhập số b hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textb.Focus();
            return;
        }

        int ucln = TimUCLN(a, b);
        int bcnn = TimBCNN(a, b);

        textUSCLN.Text = ucln.ToString();
        textUSCNN.Text = bcnn.ToString();
    }
    private void buttonTiepTuc_Click(object sender, EventArgs e)
    {
        // 1. Xóa trắng nội dung ở 4 ô TextBox
        texta.Clear();
        textb.Clear();
        textUSCLN.Clear();
        textUSCNN.Clear();

        // 2. Đưa con trỏ chuột về lại ô nhập số a
        texta.Focus();
    }
    private void buttonThoat_Click(object sender, EventArgs e)
    {
        this.Close(); // Đóng ứng dụng Form
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
