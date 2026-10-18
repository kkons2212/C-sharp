using System.Drawing.Text;

namespace Bai9
{
    public partial class Bai9 : Form
    {
        public Bai9()
        {
            InitializeComponent();
            menuChuyenSangLopB.Click += menuChuyenSangLopB_click;
            menuChuyenSangLopA.Click += menuChuyenSangLopA_click;
            mnuXoaHocVien.Click += mnuXoaHocVien_click;
            menuNhapHocVienMoi.Click += menuNhapHocVienMoi_Click;
            menuKetThuc.Click += menuKetThuc_Click;
        }

        private void menuChuyenSangLopB_click(object sender, EventArgs e)
        {
            if(lstLopA.SelectedItems.Count==0)
            {
                MessageBox.Show("vui lòng chọn học viên trước" +" ");
            }

            foreach (var hocvien in lstLopA .SelectedItems)
            {
                lstLopB.Items.Add(hocvien);
            }
            for (int i = lstLopA.SelectedItems.Count - 1;i>=0;i--)
            { 
             lstLopA.Items.RemoveAt(lstLopA.SelectedIndices[i]);
            }
            
        }
        private void menuChuyenSangLopA_click(object sender, EventArgs e)
        {
            if (lstLopB.SelectedItems.Count == 0)
            {
                MessageBox.Show("vui lòng chọn học viên trước" + " ");
            }

            foreach (var hocvien in lstLopB.SelectedItems)
            {
                lstLopA.Items.Add(hocvien);
            }
            for (int i = lstLopB.SelectedItems.Count - 1; i >= 0; i--)
            {
                lstLopB.Items.RemoveAt(lstLopB.SelectedIndices[i]);
            }
        }


        private void mnuXoaHocVien_click(object sender, EventArgs e)
        {
            if (lstLopA.SelectedItems.Count == 0 && lstLopB.SelectedItems.Count == 0)
            {
                MessageBox.Show(" vui lòng chọn học viên cần xóa");

            }

            for (int i = lstLopA.SelectedIndices.Count - 1; i >= 0; i--)

            {
                lstLopA.Items.RemoveAt(lstLopA.SelectedIndices[i]);
            }

            for (int i = lstLopB.SelectedIndices.Count - 1; i >= 0; i--)

            {
                lstLopB.Items.RemoveAt(lstLopB.SelectedIndices[i]);
            }
        }

            private void menuNhapHocVienMoi_Click (object sender, EventArgs e)
            {
            frmNhapHocVien f = new frmNhapHocVien(this);
            f.ShowDialog();
            }
        private void menuKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void themhocvien (string hoTen ,string lop)
        {
            if (lop == "Lớp A")
            {
                lstLopA.Items.Add(hoTen);
            }
            else if (lop == "Lớp B")
            {
                lstLopB.Items.Add(hoTen);
            }
        }

        }
    }

