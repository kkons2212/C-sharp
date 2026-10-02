using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace Bai2;

public partial class Form1 : Form
{
    ErrorProvider errorProvider1 = new ErrorProvider();
    public Form1()
    {   
        InitializeComponent();
        this.Text = "Đăng ký tài khoản";
        txtEmail.Leave += txtEmail_leave ;
        this.AcceptButton = buttondangky; 
        buttondangky.Click += buttondangky_Click;
        this.FindForm().FormClosing += Form1_FormClosing;   
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }
    private bool IsValidEmail(string email)
    {
        // Nếu chưa nhập gì thì không báo lỗi định dạng ở đây
        if (string.IsNullOrWhiteSpace(email)) return true;

        // Kiểm tra email có chứa @ và dấu chấm (.) hay không
        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(email, pattern);
    }
    private void txtEmail_leave(object sender, EventArgs e)
    {
        string email = txtEmail.Text;

        // 2. Kiểm tra nếu sai định dạng email
        if (!IsValidEmail(email))
        {
            // Hiện chấm đỏ lỗi bên cạnh ô txtEmail
            errorProvider1.SetError(txtEmail, "Email không hợp lệ!");
        }
        else
        {
            // Đúng định dạng thì tắt chấm đỏ ở ô txtEmail
            errorProvider1.SetError(txtEmail, "");
        }
    }
    private void buttondangky_Click(object sender, EventArgs e)
    {
        bool isHopLe = true; // Biến đánh dấu xem dữ liệu có hợp lệ không

        // 2. Kiểm tra các ô bắt buộc (*)
        if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
        {
            errorProvider1.SetError(txtTenDangNhap, "Tên đăng nhập không được để trống!");
            isHopLe = false;
        }

        if (string.IsNullOrWhiteSpace(txtEmail.Text))
        {
            errorProvider1.SetError(txtEmail, "Email không được để trống!");
            isHopLe = false;
        }
        else if (!IsValidEmail(txtEmail.Text))
        {
            errorProvider1.SetError(txtEmail, "Email không đúng định dạng!");
            isHopLe = false;
        }

        if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
        {
            errorProvider1.SetError(txtMatKhau, "Mật khẩu không được để trống!");
            isHopLe = false;
        }

        // 3. Kiểm tra Mật khẩu và Xác nhận mật khẩu có trùng khớp không
        if (txtMatKhau.Text != txtxacnhanmatkhau.Text)
        {
            errorProvider1.SetError(txtxacnhanmatkhau, "Mật khẩu xác nhận không trùng khớp!");
            isHopLe = false;
        }

        // Nếu có ít nhất 1 ô bị lỗi -> Dừng lại
        if (!isHopLe) return;

        // 4. Nếu tất cả đều đúng -> Hiển thị MessageBox thông tin
        string thongTin = "ĐĂNG KÝ THÀNH CÔNG!\n\n" +
                          "Tên đăng nhập: " + txtTenDangNhap.Text + "\n" +
                          "Email: " + txtEmail.Text + "\n" +
                          "Mật khẩu: " + txtMatKhau.Text;

        MessageBox.Show(thongTin, "Thông tin tài khoản");
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
            e.Cancel = true; // Hủy thao tác đóng Form
        }
    }
}
