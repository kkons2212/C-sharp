using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace Bai5
{
    public partial class frmSinhVien_Combo : Form
    {
        SqlConnection connsql;
        public frmSinhVien_Combo()
        {
            InitializeComponent();
            string strCon = @"Data Source=127.0.0.1,1433;Initial Catalog=QLSinhVien;User ID=sa;Password=SqlServer@2026;TrustServerCertificate=True;Encrypt=False;";
            connsql = new SqlConnection(strCon);
            LoadLop_ComboBox();
            buttonThem.Click += buttonThem_Click;
            buttonXoa.Click += buttonXoa_Click;
            buttonSua.Click += buttonSua_Click;
        }
        private void LoadLop_ComboBox()
        {
            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();

                string selectString = "SELECT * FROM Lop";
                SqlCommand cmd = new SqlCommand(selectString, connsql);
                SqlDataReader rd = cmd.ExecuteReader();

                comboBoxLop.Items.Clear(); // Xóa sạch danh sách cũ trước khi nạp
                while (rd.Read())
                {
                    comboBoxLop.Items.Add(rd["MaLop"].ToString());
                }

                rd.Close();
                connsql.Close();

                // Tự động chọn sẵn dòng đầu tiên trên ComboBox
                if (comboBoxLop.Items.Count > 0)
                    comboBoxLop.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                if (connsql.State == ConnectionState.Open) connsql.Close();
                MessageBox.Show("Lỗi tải danh sách lớp: " + ex.Message);
            }
        }

        // Sự kiện khi Form vừa mở lên thì gọi hàm nạp ComboBox
        private void frmSinhvien_Combo_Load(object sender, EventArgs e)
        {
            LoadLop_ComboBox();
        }

        
        //  HÀM KIỂM TRA KHÓA CHÍNH (Mã SV có trong bảng SinhVien chưa?)
        // - Trả về true: Chưa tồn tại 
        // - Trả về false: Đã tồn tại 
        public bool KT_KhoaChinh(string pMaSV)
        {
            if (connsql.State == ConnectionState.Closed)
                connsql.Open();

            string selectString = "SELECT * FROM SinhVien WHERE MaSinhVien = '" + pMaSV + "'";
            SqlCommand cmd = new SqlCommand(selectString, connsql);
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows) // HasRows = true nghĩa là tìm thấy dòng dữ liệu
            {
                rd.Close();
                connsql.Close();
                return false;
            }
            else
            {
                rd.Close();
                connsql.Close();
                return true;
            }
        }

       
        // HÀM KIỂM TRA KHÓA NGOẠI (Sinh viên đã có điểm bên bảng Diem chưa?)
        // - Trả về true: Đã có điểm liên kết 
        // - Trả về false: Chưa có điểm 
      
        public bool KT_KhoaNgoai_Diem(string pMaSV)
        {
            if (connsql.State == ConnectionState.Closed)
                connsql.Open();

            string selectString = "SELECT * FROM Diem WHERE MaSinhVien = '" + pMaSV + "'";
            SqlCommand cmd = new SqlCommand(selectString, connsql);
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows) // Có dữ liệu bên bảng Điểm
            {
                rd.Close();
                connsql.Close();
                return true;
            }
            else
            {
                rd.Close();
                connsql.Close();
                return false;
            }
        }

      
        private void buttonThem_Click(object sender, EventArgs e)
        {
           
            if (comboBoxLop.SelectedItem == null || textMaSinhVien.Text.Trim() == "" || textHoTen.Text.Trim() == "" || textNgaySinh.Text.Trim() == "" || textNgaySinh.Text == "  /  /")
            {
                MessageBox.Show("Tất cả thông tin phải được nhập dữ liệu!");
                return;
            }

            // Kiểm tra tuổi từ 17 trở lên (chỉ tính theo năm sinh)
            DateTime ngaySinh;
            if (!DateTime.TryParse(textNgaySinh.Text, out ngaySinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ! Vui lòng nhập đúng định dạng (ví dụ: 2004-05-12).");
                return;
            }

            int tuoi = DateTime.Now.Year - ngaySinh.Year;
            if (tuoi < 17)
            {
                MessageBox.Show("Sinh viên phải có tuổi từ 17 trở lên! (Tuổi hiện tại: " + tuoi + ")");
                return;
            }

            //Kiểm tra trùng khóa chính (Mã SV) trước khi thêm
            try
            {
                if (KT_KhoaChinh(textMaSinhVien.Text.Trim()) == true)
                {
                    connsql.Open();
                    string maLop = comboBoxLop.SelectedItem.ToString();
                    string insertString = "INSERT INTO SinhVien VALUES ('" + textMaSinhVien.Text.Trim() + "', N'" + textHoTen.Text.Trim() + "', '" + textNgaySinh.Text.Trim() + "', '" + maLop + "')";

                    SqlCommand cmd = new SqlCommand(insertString, connsql);
                    cmd.ExecuteNonQuery();
                    connsql.Close();

                    MessageBox.Show("Thêm sinh viên thành công!");
                }
                else
                {
                    MessageBox.Show("Trùng mã sinh viên! Mã này đã có trong bảng SinhVien.");
                }
            }
            catch (Exception ex)
            {
                if (connsql.State == ConnectionState.Open) connsql.Close();
                MessageBox.Show("Thêm thất bại: " + ex.Message);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (textMaSinhVien.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập Mã sinh viên cần xóa!");
                textMaSinhVien.Focus();
                return;
            }

            try
            {
                //  Kiểm tra Mã SV có tồn tại trong bảng SinhVien không?
               
                if (KT_KhoaChinh(textMaSinhVien.Text.Trim()) == true)
                {
                    MessageBox.Show("Mã sinh viên này không tồn tại để xóa!");
                    return;
                }

                // Kiểm tra khóa ngoại: Sinh viên này có đang vướng điểm bên bảng Diem không?
                if (KT_KhoaNgoai_Diem(textMaSinhVien.Text.Trim()) == true)
                {
                    MessageBox.Show("Không thể xóa! Sinh viên này đang có dữ liệu điểm bên bảng Điểm (vướng khóa ngoại).");
                    return;
                }

                // Nếu vượt qua hết thì tiến hành xóa
                connsql.Open();
                string deleteString = "DELETE FROM SinhVien WHERE MaSinhVien = '" + textMaSinhVien.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(deleteString, connsql);
                cmd.ExecuteNonQuery();
                connsql.Close();

                MessageBox.Show("Xóa sinh viên thành công!");
            }
            catch (Exception ex)
            {
                if (connsql.State == ConnectionState.Open) connsql.Close();
                MessageBox.Show("Xóa thất bại: " + ex.Message);
            }
        }

        
        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (comboBoxLop.SelectedItem == null || textMaSinhVien.Text.Trim() == "" || textHoTen.Text.Trim() == "" || textNgaySinh.Text.Trim() == "" || textNgaySinh.Text == "  /  /")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để sửa!");
                return;
            }

            // Kiểm tra tuổi >= 17 khi sửa ngày sinh
            DateTime ngaySinh;
            if (!DateTime.TryParse(textNgaySinh.Text, out ngaySinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ!");
                return;
            }
            if (DateTime.Now.Year - ngaySinh.Year < 17)
            {
                MessageBox.Show("Sinh viên phải có tuổi từ 17 trở lên!");
                return;
            }

            try
            {
                //Kiểm tra khóa chính xem sinh viên này có tồn tại để sửa hay không
                if (KT_KhoaChinh(textMaSinhVien.Text.Trim()) == true)
                {
                    MessageBox.Show("Không tìm thấy Mã sinh viên này trong cơ sở dữ liệu để sửa!");
                    return;
                }

                //Thực hiện cập nhật Họ tên, Ngày sinh, Mã lớp theo Mã SV
                connsql.Open();
                string maLop = comboBoxLop.SelectedItem.ToString();
                string updateString = "UPDATE SinhVien SET HoTen = N'" + textHoTen.Text.Trim() + "', NgaySinh = '" + textNgaySinh.Text.Trim() + "', MaLop = '" + maLop + "' WHERE MaSinhVien = '" + textMaSinhVien.Text.Trim() + "'";

                SqlCommand cmd = new SqlCommand(updateString, connsql);
                cmd.ExecuteNonQuery();
                connsql.Close();

                MessageBox.Show("Sửa thông tin sinh viên thành công!");
            }
            catch (Exception ex)
            {
                if (connsql.State == ConnectionState.Open) connsql.Close();
                MessageBox.Show("Sửa thất bại: " + ex.Message);
            }
        }
    }
}
