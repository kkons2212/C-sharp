using System;
using System.Globalization;
using System.Windows.Forms;

namespace Winfrm
{
    public partial class Form1 : Form
    {
        
        private ErrorProvider errorProvider1 = new ErrorProvider();

        public Form1()
        {
            InitializeComponent();

            
            textBox1.KeyPress += TextBox_KeyPress;
            textBox2.KeyPress += TextBox_KeyPress;

            button3.Click += button3_Click;
            button4.Click += button4_Click;

            this.FormClosing += Form1_FormClosing;
        }

        #region Mức 2: Chặn nhập ký tự khác số vào textBox1, textBox2
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Cho phép phím điều khiển (Backspace, Delete,...)
            if (char.IsControl(e.KeyChar)) return;

            // Cho phép chữ số (0-9)
            if (char.IsDigit(e.KeyChar)) return;

            // Cho phép 1 dấu chấm hoặc dấu phẩy thập phân
            if ((e.KeyChar == '.' || e.KeyChar == ',') && !textBox.Text.Contains(".") && !textBox.Text.Contains(",")) return;

            // Cho phép dấu trừ (-) ở vị trí đầu tiên
            if (e.KeyChar == '-' && textBox.SelectionStart == 0 && !textBox.Text.Contains("-")) return;

            // Hủy ký tự không hợp lệ
            e.Handled = true;
        }
        #endregion

        #region Mức 1: Kiểm tra hợp lệ dữ liệu & Thông báo lỗi
        private bool ValidateInputs(out double a, out double b)
        {
            a = 0;
            b = 0;
            bool isValid = true;

            // Xóa thông báo lỗi cũ
            errorProvider1.SetError(textBox1, "");
            errorProvider1.SetError(textBox2, "");

            // Kiểm tra số a (textBox1)
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                !double.TryParse(textBox1.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out a))
            {
                errorProvider1.SetError(textBox1, "Vui lòng nhập số a hợp lệ!");
                isValid = false;
            }

            // Kiểm tra số b (textBox2)
            if (string.IsNullOrWhiteSpace(textBox2.Text) ||
                !double.TryParse(textBox2.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out b))
            {
                errorProvider1.SetError(textBox2, "Vui lòng nhập số b hợp lệ!");
                isValid = false;
            }

            // Nếu dữ liệu không hợp lệ -> Hiện MessageBox
            if (!isValid)
            {
                MessageBox.Show("Dữ liệu nhập vào không phù hợp! Vui lòng kiểm tra lại.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return isValid;
        }
        #endregion

        #region Xử lý nút bấm các phép toán
        // Phép cộng (+) - button1
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInputs(out double a, out double b))
            {
                textBox3.Text = (a + b).ToString();
            }
        }

        // Phép trừ (-) - button2
        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateInputs(out double a, out double b))
            {
                textBox3.Text = (a - b).ToString();
            }
        }

        // Phép nhân (*) - button3
        private void button3_Click(object sender, EventArgs e)
        {
            if (ValidateInputs(out double a, out double b))
            {
                textBox3.Text = (a * b).ToString();
            }
        }

        // Phép chia (/) - button4
        private void button4_Click(object sender, EventArgs e)
        {
            if (ValidateInputs(out double a, out double b))
            {
                if (b == 0)
                {
                    errorProvider1.SetError(textBox2, "Không thể chia cho 0!");
                    MessageBox.Show("Không thể chia cho 0!", "Lỗi toán học", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox3.Text = "";
                    return;
                }
                textBox3.Text = (a / b).ToString();
            }
        }
        #endregion

        #region Hỏi xác nhận trước khi đóng Form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Hủy thao tác đóng
            }
        }
        #endregion
    }
}