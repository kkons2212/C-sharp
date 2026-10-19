using System;
using System.Data;
using System.Data.SqlClient; // Bước 1: Khai báo thư viện SQL
using System.Windows.Forms;

namespace Bai2
{
    public partial class QuanLySInhVien : Form
    {
        SqlConnection connsql;

        public QuanLySInhVien()
        {
            InitializeComponent();
            string strCon = @"Data Source=127.0.0.1,1433;Initial Catalog=QLSinhVien;User ID=sa;Password=SqlServer@2026;TrustServerCertificate=True;Encrypt=False;";
            connsql = new SqlConnection(strCon);
            buttonThem.Click += buttonThem_Click;
            buttonSua.Click += buttonSua_Click;
            buttonXoa.Click += buttonXoa_Click;
        }

        private void buttonThem_Click (object sender, EventArgs e)
        {
            if(textHoTen.Text== "" ||textMaSV.Text==""|| textMaLop.Text==""|| textNgaySinh.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin sinh vien");
                return;
            }

            try
            {
                if(connsql.State ==ConnectionState.Closed)
                {
                    connsql.Open();
                }

                string insertstring = "INSERT into SinhVien Values('"+ textMaSV.Text+"',N'"+textHoTen.Text+"','"+ textNgaySinh.Text +"','"+textMaLop.Text +"' )" ;
                SqlCommand cmd = new SqlCommand(insertstring,connsql);
                cmd.ExecuteNonQuery();

                connsql.Close();
                MessageBox.Show("them sinh vien thanh cong");



            }
            catch (Exception ex) 
            {

                if (connsql.State == ConnectionState.Open) 
                    connsql.Close();
                MessageBox.Show("loi khi them co the do trung ma"+ex.Message);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (textMaSV.Text == ""||textHoTen.Text=="")
            {
                MessageBox.Show("Mã SV va ten sv không được để trống!");
                return;
            }
            if (textMaLop.Text != ""|| textNgaySinh.Text != "")
            {
                MessageBox.Show("Khi xóa, vui lòng để trống ô Ma lop va ngay sinh!");
                return;
            }

            try
            {
                
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }
                string maSV = textMaSV.Text.Trim();
                string hoTen = textHoTen.Text.Trim();

                string deleteString = "DELETE FROM SinhVien WHERE MaSinhVien = '" + maSV + "'  and HoTen=N'"+ hoTen + "'" ;

               
                SqlCommand cmd = new SqlCommand(deleteString, connsql);

                
                int kq = cmd.ExecuteNonQuery();

               
                connsql.Close();

                if (kq > 0)
                {
                    MessageBox.Show("Xóa sinh vien thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã sinh vien này để xóa!");
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
            if (textMaSV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ ma sinh vien!");
                return;
            }
            bool coSuaLop = (textMaLop.Text.Trim() != "");
            bool coSuaTen = (textHoTen.Text.Trim() != "");
            bool coSuaNgay = (textNgaySinh.Text.Trim() != "" && textNgaySinh.Text != "  /  /");
            if (!coSuaLop && !coSuaTen && !coSuaNgay)
            {
                MessageBox.Show("Phải nhập ít nhất 1 thông tin (Mã lớp, Họ tên hoặc Ngày sinh) để sửa!");
                return;
            }
            try
            {
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }
                string danhSachCot = "";

                if (coSuaLop)
                {
                    danhSachCot += "MaLop = '" + textMaLop.Text.Trim() + "'";
                }

                if (coSuaTen)
                {
                    if (danhSachCot != "") danhSachCot += ", ";
                    danhSachCot += "HoTen = N'" + textHoTen.Text.Trim() + "'";
                }

                if (coSuaNgay)
                {
                    if (danhSachCot != "") danhSachCot += ", ";
                    danhSachCot += "NgaySinh = '" + textNgaySinh.Text.Trim() + "'";
                }
                string updateString = "UPDATE SinhVien SET " + danhSachCot + " WHERE MaSinhVien = '" + textMaSV.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(updateString, connsql);
                int kq = cmd.ExecuteNonQuery();
                connsql.Close();

                if (kq > 0)
                {
                    MessageBox.Show("Sửa thong tin sinh vien thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã sinh vien này để sửa!");
                }
            }
            catch (Exception ex)
            {
                if (connsql.State == ConnectionState.Open) connsql.Close();
                MessageBox.Show("Lỗi khi sửa thong tin sinh vien: " + ex.Message);
            }
        }
    }
}
