using System;
using System.Data;
using System.Data.SqlClient; // Bước 1: Khai báo thư viện SQL
using System.Windows.Forms;

namespace Bai1
{
    public partial class QuanLyMonHoc : Form
    {
        // Bước 2: Khai báo đối tượng SqlConnection dùng chung cho cả Form
        SqlConnection connsql;

        public QuanLyMonHoc()
        {
            InitializeComponent();

            // Bước 3: Khởi tạo chuỗi kết nối (Giữ nguyên thông số đăng nhập của bạn)
            string strCon = @"Data Source=127.0.0.1,1433;Initial Catalog=QLSinhVien;User ID=sa;Password=SqlServer@2026;TrustServerCertificate=True;Encrypt=False;";
            connsql = new SqlConnection(strCon);
        }

        private void txtMaMH_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTenMH_TextChanged(object sender, EventArgs e)
        {
        }

        //NÚT THÊM 
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra không cho để trống
            if (txtMaMH.Text == "" || txtTenMH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã môn học và Tên môn học!");
                return; // Dừng lại ngay, không chạy code bên dưới nữa
            }

            try
            {
                // 1. Mở kết nối
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }

                // 2. Viết câu lệnh SQL Thêm (nối chuỗi giống hệt đề cương)
                string insertString = "INSERT INTO MonHoc VALUES ('" + txtMaMH.Text + "', N'" + txtTenMH.Text + "')";

                // 3. Khai báo SqlCommand
                SqlCommand cmd = new SqlCommand(insertString, connsql);

                // 4. Thực thi câu lệnh
                cmd.ExecuteNonQuery();

                // 5. Đóng kết nối
                connsql.Close();

                MessageBox.Show("Thêm môn học thành công!");
            }
            catch (Exception ex)
            {
                // Nếu lỗi thì cũng nhớ đóng kết nối lại cho an toàn
                if (connsql.State == ConnectionState.Open) connsql.Close();
                MessageBox.Show("Lỗi khi thêm (có thể trùng mã): " + ex.Message);
            }
        }

        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra: Mã môn học không được để trống
            if (txtMaMH.Text == "")
            {
                MessageBox.Show("Mã môn học không được để trống!");
                return;
            }

            // Kiểm tra: Khi xóa thì ô Tên môn học phải để trống
            if (txtTenMH.Text != "")
            {
                MessageBox.Show("Khi xóa, vui lòng để trống ô Tên môn học!");
                return;
            }

            try
            {
                // 1. Mở kết nối
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }

                // 2. Viết câu lệnh SQL Xóa 
                string deleteString = "DELETE FROM MonHoc WHERE MaMonHoc = '" + txtMaMH.Text + "'";

                // 3. Khai báo SqlCommand
                SqlCommand cmd = new SqlCommand(deleteString, connsql);

                // 4. Thực thi câu lệnh 
                int kq = cmd.ExecuteNonQuery();

                // 5. Đóng kết nối
                connsql.Close();

                if (kq > 0)
                {
                    MessageBox.Show("Xóa môn học thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã môn học này để xóa!");
                }
            }
            catch (Exception ex)
            {
                if (connsql.State == ConnectionState.Open) connsql.Close();
                MessageBox.Show("Không thể xóa (do môn này đang có điểm bên bảng Điểm): " + ex.Message);
            }
        }

        //  NÚT SỬA 
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra không cho để trống
            if (txtMaMH.Text == "" || txtTenMH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã môn học và Tên môn học mới!");
                return;
            }

            try
            {
                // 1. Mở kết nối
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }

                // 2. Viết câu lệnh SQL Sửa
                string updateString = "UPDATE MonHoc SET TenMonHoc = N'" + txtTenMH.Text + "' WHERE MaMonHoc = '" + txtMaMH.Text + "'";

                // 3. Khai báo SqlCommand
                SqlCommand cmd = new SqlCommand(updateString, connsql);

                // 4. Thực thi câu lệnh
                int kq = cmd.ExecuteNonQuery();

                // 5. Đóng kết nối
                connsql.Close();

                if (kq > 0)
                {
                    MessageBox.Show("Sửa tên môn học thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã môn học này để sửa!");
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