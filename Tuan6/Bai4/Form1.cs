using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Bai4
{
    public partial class Form1 : Form
    {
        SqlConnection connsql;
        public Form1()
        {
            InitializeComponent();
            string strCon = @"Data Source=127.0.0.1,1433;Initial Catalog=QLSinhVien;User ID=sa;Password=SqlServer@2026;TrustServerCertificate=True;Encrypt=False;";
            connsql = new SqlConnection(strCon);
            buttonThem.Click += buttonThem_Click;
            buttonSua.Click += buttonSua_Click;
            buttonXoa.Click += buttonXoa_Click;
        }

        private void buttonThem_Click(object sender, EventArgs e)

        {
            if (textMaLop.Text == "" || textTenLop.Text == "" || textMaKhoa.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin");
                return;
            }
            try
            {
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }

                string insertstring = "INSERT into Lop Values('" + textMaLop.Text + "',N'" + textTenLop.Text + "','" + textMaKhoa.Text + "' )";
                SqlCommand cmd = new SqlCommand(insertstring, connsql);
                cmd.ExecuteNonQuery();

                connsql.Close();
                MessageBox.Show("them Lop thanh cong");



            }
            catch (Exception ex)
            {

                if (connsql.State == ConnectionState.Open)
                    connsql.Close();
                MessageBox.Show("loi khi them " + ex.Message);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (textMaLop.Text == "")
            {
                MessageBox.Show("Mã Lop không được để trống!");
                return;
            }
            if (textMaKhoa.Text != "" || textTenLop.Text != "")
            {
                MessageBox.Show("Khi xóa, vui lòng để trống ô Ma khoa va ten lop!");
                return;
            }
            try
            {

                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }
                string maLop = textMaLop.Text.Trim();
                

                string deleteString = "DELETE FROM Lop WHERE MaLop = '" + maLop + "' ";


                SqlCommand cmd = new SqlCommand(deleteString, connsql);


                int kq = cmd.ExecuteNonQuery();


                connsql.Close();

                if (kq > 0)
                {
                    MessageBox.Show("Xóa Lop thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy ma lop này để xóa!");
                }
            }
            catch (Exception ex)
            {
                if (connsql.State == ConnectionState.Open) connsql.Close();
                MessageBox.Show("Không thể xóa: " + ex.Message);
            }
        }
        private void buttonSua_Click(object sender, EventArgs e)
        {

            if (textMaLop.Text == "")
            {
                MessageBox.Show("Vui long nhap ma lop");
                return;
            }

            bool coMaKhoa = (textMaKhoa.Text.Trim() != "");
            bool coTenLop = (textTenLop.Text.Trim() != "");
          
            if (!coMaKhoa && !coTenLop)
            {
                MessageBox.Show("Phải nhập ít nhất 1 thông tin de tien hanh sua!");
                return;
            }
            try
            {
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }
                string danhSachCot = "";

                if (coMaKhoa)
                {
                    danhSachCot += "MaKhoa = '" + textMaKhoa.Text.Trim() + "'";
                }

                if (coTenLop)
                {
                    if (danhSachCot != "") danhSachCot += ", ";
                    danhSachCot += "TenLop = N'" + textTenLop.Text.Trim() + "'";
                }

                string updateString = "UPDATE Lop SET " + danhSachCot + " WHERE MaLop = '" + textMaLop.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(updateString, connsql);
                int kq = cmd.ExecuteNonQuery();
                connsql.Close();

                if (kq > 0)
                {
                    MessageBox.Show("Sửa thong tin Lop thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã Lop này để sửa!");
                }
            }
            catch (Exception ex)
            {
                if (connsql.State == ConnectionState.Open) connsql.Close();
                MessageBox.Show("Lỗi khi sửa thong tin Lop: " + ex.Message);
            }
        }
    }
}
