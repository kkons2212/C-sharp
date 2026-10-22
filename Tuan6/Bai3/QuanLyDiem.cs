using System;
using System.Data;
using System.Data.SqlClient; 
using System.Windows.Forms;
namespace Bai3
{
    public partial class QuanLyDiem : Form
    {
        SqlConnection connsql;
        public QuanLyDiem()
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
            if ( textMaSV.Text == "" ||textMamh.Text == "" || textDiem.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin sinh vien");
                return;
            }
            try
            {
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }

                string insertstring = "INSERT into Diem Values('" + textMaSV.Text + "','" + textMamh.Text + "','" + textDiem.Text + "' )";
                SqlCommand cmd = new SqlCommand(insertstring, connsql);
                cmd.ExecuteNonQuery();

                connsql.Close();
                MessageBox.Show("them diem cho sinh vien thanh cong");



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
            if (textMaSV.Text == "" || textMamh.Text == "")
            {
                MessageBox.Show("Mã SV va Ma mh không được để trống!");
                return;
            }
            if (textDiem.Text != "")
            {
                MessageBox.Show("Khi xóa, vui lòng để trống ô Diem!");
                return;
            }
            try
            {

                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }
                string maSV = textMaSV.Text.Trim();
                string MaMH = textMamh.Text.Trim();

                string deleteString = "DELETE FROM Diem WHERE MaSinhVien = '" + maSV + "'  and MaMonHoc='" + MaMH + "'";


                SqlCommand cmd = new SqlCommand(deleteString, connsql);


                int kq = cmd.ExecuteNonQuery();


                connsql.Close();

                if (kq > 0)
                {
                    MessageBox.Show("Xóa diem cua sinh vien thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã sinh vien hoac  ma mon hoc này để xóa!");
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
            
            if (textMaSV.Text == "" || textMamh.Text == "" || textDiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thong tin de sua diem cho sinh vien");
                return;
            }

            try
            {
                
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }

                
                string updateString = "UPDATE Diem SET Diem = '" + textDiem.Text + "' WHERE MaSinhVien = '" + textMaSV.Text + "'and MaMonHoc = '" + textMamh.Text +"' ";

                
                SqlCommand cmd = new SqlCommand(updateString, connsql);

             
                int kq = cmd.ExecuteNonQuery();

            
                connsql.Close();

                if (kq > 0)
                {
                    MessageBox.Show("Sửa diem thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy ma sinh vien hoac ma mh de sua!");
                }
            }
            catch (Exception ex)
            {
                if (connsql.State == ConnectionState.Open) connsql.Close();
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
            }
        }
    }
}
