using System;
using System.Text;
using System.Windows.Forms;

namespace Bai7
{
    public partial class Bai7 : Form
    {
        private StudentService studentService = new StudentService();

        public Bai7()
        {
            InitializeComponent();

           
            this.Text = "frmBaitap1";
            this.Load += new EventHandler(this.Bai7_Load);
            this.FormClosing += new FormClosingEventHandler(this.Bai7_FormClosing);
            this.btnThem.Click += new EventHandler(this.btnThem_Click);
            this.btnXoa.Click += new EventHandler(this.btnXoa_Click);
            this.btnSua.Click += new EventHandler(this.btnSua_Click);

            this.listView1.SelectedIndexChanged += new EventHandler(this.listView1_SelectedIndexChanged);
        }

        private void Bai7_Load(object sender, EventArgs e)
        {
            // Thêm dữ liệu vào ComboBox dân tộc khi load form
            cboDanToc.Items.AddRange(studentService.LayDanhSachDanToc());
            if (cboDanToc.Items.Count > 0) cboDanToc.SelectedIndex = 0;

            listView1.FullRowSelect = true;
            listView1.GridLines = true;
        }

        private string LayNgoaiNgu()
        {
            StringBuilder sb = new StringBuilder();
            if (chkAnh.Checked) sb.Append("Anh ");
            if (chkPhap.Checked) sb.Append("Pháp ");
            if (chkHoa.Checked) sb.Append("Hoa ");
            return sb.ToString().Trim();
        }

        // Nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string maSV = txtMaSV.Text.Trim();

            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên và Mã sinh viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (studentService.KiemTraTrungMa(listView1, maSV))
            {
                MessageBox.Show($"Mã sinh viên '{maSV}' đã tồn tại. Không thể thêm trùng mã!", "Lỗi trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaSV.Focus();
                return;
            }

            string gioiTinh = rdNam.Checked ? "Nam" : "Nữ";
            string ngoaiNgu = LayNgoaiNgu();
            string danToc = cboDanToc.Text;

            ListViewItem item = new ListViewItem(hoTen);
            item.SubItems.Add(maSV);
            item.SubItems.Add(gioiTinh);
            item.SubItems.Add(ngoaiNgu);
            item.SubItems.Add(danToc);

            listView1.Items.Add(item);
            XoaTrangForm();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                txtHoTen.Text = item.SubItems[0].Text;
                txtMaSV.Text = item.SubItems[1].Text;
                txtMaSV.ReadOnly = true; 

                if (item.SubItems[2].Text == "Nam") rdNam.Checked = true;
                else rdNữ.Checked = true;

                string nn = item.SubItems[3].Text;
                chkAnh.Checked = nn.Contains("Anh");
                chkPhap.Checked = nn.Contains("Pháp");
                chkHoa.Checked = nn.Contains("Hoa");

                cboDanToc.Text = item.SubItems[4].Text;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng sinh viên cần sửa trên bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ListViewItem item = listView1.SelectedItems[0];
            item.SubItems[0].Text = txtHoTen.Text.Trim();
            item.SubItems[2].Text = rdNam.Checked ? "Nam" : "Nữ";
            item.SubItems[3].Text = LayNgoaiNgu();
            item.SubItems[4].Text = cboDanToc.Text;

            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            XoaTrangForm();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ThucHienXoa();
        }

        private void ThucHienXoa()
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    listView1.Items.Remove(item);
                }
                XoaTrangForm();
            }
        }

        private void XoaTrangForm()
        {
            txtHoTen.Clear();
            txtMaSV.Clear();
            txtMaSV.ReadOnly = false;
            rdNam.Checked = true;
            chkAnh.Checked = chkPhap.Checked = chkHoa.Checked = false;
            if (cboDanToc.Items.Count > 0) cboDanToc.SelectedIndex = 0;
            txtHoTen.Focus();
        }

        private void Bai7_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            btnThem_Click(sender, e);
        }
    }
}