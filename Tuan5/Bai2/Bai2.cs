using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Bai2 : Form
    {
        
        private TreeNode rootNode;
        private List<LopHoc> danhSachLopHoc;

        public Bai2()
        {
            InitializeComponent();

            
            this.Text = "Quản lý sinh viên";
            this.chkThemLop.CheckedChanged += new EventHandler(this.chkThemLop_CheckedChanged);
            this.btnThemLop.Click += new EventHandler(this.btnThemLop_Click);
            this.btnCapNhat.Click += new EventHandler(this.btnCapNhat_Click);
            this.btnXoa.Click += new EventHandler(this.btnXoa_Click);
            this.tvDanhSachLop.AfterSelect += new TreeViewEventHandler(this.tvDanhSachLop_AfterSelect);

            // Khởi tạo dữ liệu mẫu
            KhoiTaoDuLieuMau();
        }

        // Khởi tạo dữ liệu mẫu ban đầu
        private void KhoiTaoDuLieuMau()
        {
            grpThemLop.Visible = false;
            chkThemLop.Checked = false;

            danhSachLopHoc = new List<LopHoc>
            {
                new LopHoc("05DHTH1"),
                new LopHoc("05DHTH2"),
                new LopHoc("05DHTH3"),
                new LopHoc("05DHTH4")
            };

            LoadDuLieuLenGiaoDien();
        }

        // dữ liệu từ danh sách lên TreeView và ComboBox
        private void LoadDuLieuLenGiaoDien()
        {
            tvDanhSachLop.Nodes.Clear();
            cboChonLop.Items.Clear();

            rootNode = new TreeNode("Danh sách lớp");
            tvDanhSachLop.Nodes.Add(rootNode);

            foreach (var lop in danhSachLopHoc)
            {
                cboChonLop.Items.Add(lop.TenLop);

                TreeNode lopNode = new TreeNode(lop.TenLop);
                foreach (var sv in lop.DanhSachSinhVien)
                {
                    TreeNode svNode = new TreeNode($"{sv.MaSV}, {sv.HoTen}");
                    svNode.Nodes.Add(new TreeNode(sv.DiaChi));
                    lopNode.Nodes.Add(svNode);
                }
                rootNode.Nodes.Add(lopNode);
            }

            if (cboChonLop.Items.Count > 0)
                cboChonLop.SelectedIndex = 0;

            rootNode.Expand();
        }

        //CheckBox Thêm lớp (Ẩn/Hiện GroupBox Thêm lớp)
        private void chkThemLop_CheckedChanged(object sender, EventArgs e)
        {
            grpThemLop.Visible = chkThemLop.Checked;
        }

        //Thêm lớp mới vào danh sách và chống trùng
        private void btnThemLop_Click(object sender, EventArgs e)
        {
            string tenLopMoi = txtTenLop.Text.Trim();
            if (string.IsNullOrEmpty(tenLopMoi))
            {
                MessageBox.Show("Tên lớp không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLop.Focus();
                return;
            }

            foreach (var lop in danhSachLopHoc)
            {
                if (lop.TenLop.Equals(tenLopMoi, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Tên lớp này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenLop.Focus();
                    return;
                }
            }

            danhSachLopHoc.Add(new LopHoc(tenLopMoi));
            LoadDuLieuLenGiaoDien();
            txtTenLop.Clear();
            MessageBox.Show("Thêm lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Thêm sinh viên vào lớp đang chọn trên ComboBox
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (cboChonLop.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn lớp cần thêm sinh viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sinh viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenLopDangChon = cboChonLop.SelectedItem.ToString();
            LopHoc lopChon = danhSachLopHoc.Find(l => l.TenLop == tenLopDangChon);

            if (lopChon != null)
            {
                SinhVien svMoi = new SinhVien(maSV, hoTen, diaChi);
                if (lopChon.ThemSinhVien(svMoi))
                {
                    LoadDuLieuLenGiaoDien();
                    ClearTextBoxSV();
                    MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại trong lớp này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaSV.Focus();
                }
            }
        }

        // Chỉ cho phép xóa node là sinh viên đang chọn trên TreeView
        private void btnXoa_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = tvDanhSachLop.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa trên cây TreeView!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedNode.Parent != null && selectedNode.Parent.Parent == rootNode)
            {
                DialogResult dialogResult = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa sinh viên '{selectedNode.Text}' không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (dialogResult == DialogResult.Yes)
                {
                    string tenLop = selectedNode.Parent.Text;
                    string[] info = selectedNode.Text.Split(',');
                    string maSV = info[0].Trim();

                    LopHoc lop = danhSachLopHoc.Find(l => l.TenLop == tenLop);
                    if (lop != null)
                    {
                        lop.DanhSachSinhVien.RemoveAll(s => s.MaSV == maSV);
                    }

                    LoadDuLieuLenGiaoDien();
                    ClearTextBoxSV();
                    MessageBox.Show("Đã xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Chỉ được phép chọn xóa node là sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Khi click chọn node sinh viên trên TreeView, hiển thị thông tin lên TextBox
        private void tvDanhSachLop_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            if (selectedNode.Parent != null && selectedNode.Parent.Parent == rootNode)
            {
                string[] parts = selectedNode.Text.Split(',');
                if (parts.Length >= 2)
                {
                    txtMaSV.Text = parts[0].Trim();
                    txtHoTen.Text = parts[1].Trim();
                }
                if (selectedNode.Nodes.Count > 0)
                {
                    txtDiaChi.Text = selectedNode.Nodes[0].Text.Trim();
                }
            }
            else
            {
                ClearTextBoxSV();
            }
        }

        private void ClearTextBoxSV()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtMaSV.Focus();
        }

       
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}