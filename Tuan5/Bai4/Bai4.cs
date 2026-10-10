using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Bai4 : Form
    {
        private Dictionary<string, string> tuDienAV;
        private Dictionary<string, string> tuDienVA;

        public Bai4()
        {
            InitializeComponent();

           
            this.Text = "TỪ ĐIỂN ANH VIỆT - VIỆT ANH";

            // Tab 1 (Anh - Việt)
            this.cboTuAnh.TextChanged += new EventHandler(this.cboTuAnh_TextChanged);
            this.cboTuAnh.KeyDown += new KeyEventHandler(this.cboTuAnh_KeyDown);
            this.lstTuAnh.DoubleClick += new EventHandler(this.lstTuAnh_DoubleClick);
            this.lstTuAnh.SelectedIndexChanged += new EventHandler(this.lstTuAnh_SelectedIndexChanged);

            // Tab 2 (Việt - Anh)
            this.cboTuViet.TextChanged += new EventHandler(this.cboTuViet_TextChanged);
            this.cboTuViet.KeyDown += new KeyEventHandler(this.cboTuViet_KeyDown);
            this.lstTuViet.DoubleClick += new EventHandler(this.lstTuViet_DoubleClick);
            this.lstTuViet.SelectedIndexChanged += new EventHandler(this.lstTuViet_SelectedIndexChanged);

            // Nút Thoát
            this.btnThoat.Click += new EventHandler(this.btnThoat_Click);

            // Nạp dữ liệu ban đầu
            KhoiTaoDuLieu();
        }

        private void KhoiTaoDuLieu()
        {
            tuDienAV = TuDienService.LayTuDienAnhViet();
            tuDienVA = TuDienService.LayTuDienVietAnh();

            // Đổ dữ liệu Tab Anh - Việt
            cboTuAnh.Items.Clear();
            lstTuAnh.Items.Clear();
            foreach (var key in tuDienAV.Keys)
            {
                cboTuAnh.Items.Add(key);
                lstTuAnh.Items.Add(key);
            }

            // Đổ dữ liệu Tab Việt - Anh
            cboTuViet.Items.Clear();
            lstTuViet.Items.Clear();
            foreach (var key in tuDienVA.Keys)
            {
                cboTuViet.Items.Add(key);
                lstTuViet.Items.Add(key);
            }
        }

        // --- TAB ANH - VIỆT ---

        private void cboTuAnh_TextChanged(object sender, EventArgs e)
        {
            string keyword = cboTuAnh.Text.Trim();
            int index = cboTuAnh.FindString(keyword);
            if (index != -1)
            {
                cboTuAnh.SelectedIndex = index;
                cboTuAnh.SelectionStart = keyword.Length;
                cboTuAnh.SelectionLength = cboTuAnh.Text.Length - keyword.Length;
            }
        }

        private void cboTuAnh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TraTuAnh();
            }
        }

        private void lstTuAnh_DoubleClick(object sender, EventArgs e)
        {
            TraTuAnh();
        }

        private void lstTuAnh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTuAnh.SelectedItem != null)
            {
                string tuChon = lstTuAnh.SelectedItem.ToString();
                if (tuDienAV.ContainsKey(tuChon))
                {
                    txtNghiaViet.Text = tuDienAV[tuChon];
                }
            }
        }

        private void TraTuAnh()
        {
            string tuCanTra = cboTuAnh.Text.Trim();
            if (tuDienAV.ContainsKey(tuCanTra))
            {
                txtNghiaViet.Text = tuDienAV[tuCanTra];
                lstTuAnh.SelectedItem = tuCanTra;
            }
            else
            {
                MessageBox.Show("Không tìm thấy từ này trong từ điển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        // --- TAB VIỆT - ANH ---

        private void cboTuViet_TextChanged(object sender, EventArgs e)
        {
            string keyword = cboTuViet.Text.Trim();
            int index = cboTuViet.FindString(keyword);
            if (index != -1)
            {
                cboTuViet.SelectedIndex = index;
                cboTuViet.SelectionStart = keyword.Length;
                cboTuViet.SelectionLength = cboTuViet.Text.Length - keyword.Length;
            }
        }

        private void cboTuViet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TraTuViet();
            }
        }

        private void lstTuViet_DoubleClick(object sender, EventArgs e)
        {
            TraTuViet();
        }

        private void lstTuViet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTuViet.SelectedItem != null)
            {
                string tuChon = lstTuViet.SelectedItem.ToString();
                if (tuDienVA.ContainsKey(tuChon))
                {
                    txtNghiaAnh.Text = tuDienVA[tuChon];
                }
            }
        }

        private void TraTuViet()
        {
            string tuCanTra = cboTuViet.Text.Trim();
            if (tuDienVA.ContainsKey(tuCanTra))
            {
                txtNghiaAnh.Text = tuDienVA[tuCanTra];
                lstTuViet.SelectedItem = tuCanTra;
            }
            else
            {
                MessageBox.Show("Không tìm thấy từ này trong từ điển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


 
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}