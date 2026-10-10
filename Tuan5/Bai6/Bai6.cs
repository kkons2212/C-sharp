using System;
using System.Windows.Forms;

namespace Bai6
{
    public partial class Bai6 : Form
    {
        private ContactService contactService = new ContactService();

        public Bai6()
        {
            InitializeComponent();

            
            this.Text = "frmBTVN2";
            this.Load += new EventHandler(this.Bai6_Load);
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
            this.btnExit.Click += new EventHandler(this.btnExit_Click);
        }

        // Các hàm xử lý nghiệp vụ

        private void Bai6_Load(object sender, EventArgs e)
        {
            // Nạp sẵn các chữ cái từ A -> Z lên TreeView khi khởi động[cite: 3]
            contactService.KhoiTaoCayAlphabet(trvDanhBa);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            bool thanhCong = contactService.ThemDanhBa(trvDanhBa, firstName, lastName);

            if (thanhCong)
            {
                // Xóa trắng ô nhập liệu để nhập tiếp
                txtFirstName.Clear();
                txtLastName.Clear();
                txtFirstName.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ First Name và Last Name!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}