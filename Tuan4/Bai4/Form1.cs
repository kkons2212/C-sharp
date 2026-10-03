namespace Bai4;

public partial class Form1 : Form
{
    int tongDay = 0;
    int tongChan = 0;
    int tongLe = 0;
    public Form1()
    {
        InitializeComponent();
        this.Text = "Dãy Số Và Tính Tổng ";
        this.AcceptButton = buttonNhap;
        buttonNhap.Click += btnNhap_Click;  
        buttonThoat.Click += buttonThoat_Click;
        buttonTiepTuc.Click += buttonTiepTuc_Click;
        this.FindForm().FormClosing += Form1_FormClosing;
    }

    private void textBox5_TextChanged(object sender, EventArgs e)
    {

    }
    private void btnNhap_Click(object sender, EventArgs e)
    {
        //  Kiểm tra dữ liệu nhập vào có phải số nguyên không
        if (!int.TryParse(textSo.Text, out int so))
        {
            MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textSo.SelectAll();
            textSo.Focus();
            return;
        }

        //  Nối số vừa nhập vào ô Dãy vừa nhập
        textDaySo.Text += so.ToString() + " ";

        tongDay += so;

        //  Kiểm tra chẵn / lẻ 
        if (so % 2 == 0)
        {
            tongChan += so; 
        }
        else
        {
            tongLe += so;   
        }

        // 5. Hiển thị kết quả ra các ô TextBox tương ứng[cite: 3]
        textCacPhanTu.Text = tongDay.ToString();
        textChan.Text = tongChan.ToString();
        textLe.Text = tongLe.ToString();

        // 6. Xóa ô Nhập số và chuẩn bị cho lần nhập tiếp theo
        textSo.Clear();
        textSo.Focus();
    }
    private void buttonTiepTuc_Click(object sender, EventArgs e)
    {
        // Reset biến tổng
        tongDay = 0;
        tongChan = 0;
        tongLe = 0;

        // Xóa trắng các ô
        textSo.Clear();
        textDaySo.Clear();
        textCacPhanTu.Clear();
        textChan.Clear();
        textLe.Clear();

        textSo.Focus();
    }

    private void buttonThoat_Click(object sender, EventArgs e)
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
