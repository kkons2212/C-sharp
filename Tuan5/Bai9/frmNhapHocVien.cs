using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai9
{
    public partial class frmNhapHocVien : Form
    {
        private Bai9 frmchinh;
        public frmNhapHocVien(Bai9 frm)
        {
            InitializeComponent();
            this.frmchinh = frm;

            if (cboLop.Items.Count > 0)
            {
                cboLop.SelectedIndex = 0;
            }
          

        }



        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ và Tên!", "Thông báo",
                                MessageBoxButtons.OK);
              
                return;
            }

            string ten = txtHoTen.Text.Trim();
            string lop = cboLop.SelectedItem.ToString();

            frmchinh.themhocvien(ten, lop);


            txtHoTen.Clear();
            txtHoTen.Focus();
        }
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
