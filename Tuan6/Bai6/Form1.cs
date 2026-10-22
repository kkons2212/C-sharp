using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai6
{
    
    public partial class Form1 : Form
    {
        SqlConnection connsql;
        public Form1()
        {
            InitializeComponent();
            string strCon = @"Data Source=127.0.0.1,1433;Initial Catalog=QLSinhVien;User ID=sa;Password=SqlServer@2026;TrustServerCertificate=True;Encrypt=False;";
            connsql = new SqlConnection(strCon);
            LoadSinhVien_ComboBox();
            LoadMonHoc_ComboBox();
            buttonThem.Click += buttonThem_Click;
            buttonXoa.Click += buttonXoa_Click;
            buttonSua.Click += buttonSua_Click;
        }

        private void LoadSinhVien_ComboBox()
        {
            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();

                string selectString = "SELECT * FROM SinhVien";
                SqlCommand cmd = new SqlCommand(selectString, connsql);
                SqlDataReader rd = cmd.ExecuteReader();

                comboBoxSV.Items.Clear();
                while (rd.Read())
                {
                    comboBoxSV.Items.Add(rd["MaSinhVien"].ToString());
                }

                rd.Close();
                connsql.Close();

                if (comboBoxSV.Items.Count > 0)
                    comboBoxSV.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                if (connsql.State == ConnectionState.Open) connsql.Close();
                MessageBox.Show("Lỗi tải danh sách sinh viên: " + ex.Message);
            }
        }

        private void LoadMonHoc_ComboBox()
        {
            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();

                string selectString = "SELECT * FROM MonHoc";
                SqlCommand cmd = new SqlCommand(selectString, connsql);
                SqlDataReader rd = cmd.ExecuteReader();

                comboBoxMH.Items.Clear();
                while (rd.Read())
                {
                    comboBoxMH.Items.Add(rd["MaMonHoc"].ToString());
                }

                rd.Close();
                connsql.Close();

                if (comboBoxMH.Items.Count > 0)
                    comboBoxMH.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                if (connsql.State == ConnectionState.Open) connsql.Close();
                MessageBox.Show("Lỗi tải danh sách môn học: " + ex.Message);
            }
        }
      

        // Kiểm tra Khóa Chính của bảng Diem (Cặp MaSinhVien + MaMonHoc đã có điểm chưa?)
        // - Trả về true: Chưa có điểm (Được phép Thêm)
        // - Trả về false: Đã có điểm rồi (Bị trùng khóa chính, hoặc Tìm thấy để Xóa/Sửa)
        public bool KT_KhoaChinh_Diem(string pMaSV, string pMaMH)
        {
            if (connsql.State == ConnectionState.Closed)
                connsql.Open();

            string selectString = "SELECT * FROM Diem WHERE MaSinhVien = '" + pMaSV + "' AND MaMonHoc = '" + pMaMH + "'";
            SqlCommand cmd = new SqlCommand(selectString, connsql);
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
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

        // Kiểm tra Mã SV có tồn tại trong bảng SinhVien không
        public bool KT_TonTai_SinhVien(string pMaSV)
        {
            if (connsql.State == ConnectionState.Closed)
                connsql.Open();

            string selectString = "SELECT * FROM SinhVien WHERE MaSinhVien = '" + pMaSV + "'";
            SqlCommand cmd = new SqlCommand(selectString, connsql);
            SqlDataReader rd = cmd.ExecuteReader();

            bool tonTai = rd.HasRows;
            rd.Close();
            connsql.Close();
            return tonTai;
        }

        // Kiểm tra Mã MH có tồn tại trong bảng MonHoc không
        public bool KT_TonTai_MonHoc(string pMaMH)
        {
            if (connsql.State == ConnectionState.Closed)
                connsql.Open();

            string selectString = "SELECT * FROM MonHoc WHERE MaMonHoc = '" + pMaMH + "'";
            SqlCommand cmd = new SqlCommand(selectString, connsql);
            SqlDataReader rd = cmd.ExecuteReader();

            bool tonTai = rd.HasRows;
            rd.Close();
            connsql.Close();
            return tonTai;
        }

      
        private void buttonThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra nhập đầy đủ thông tin
            if (comboBoxSV.Text.Trim() == "" || comboBoxMH.Text.Trim() == "" || textDiem.Text.Trim() == "")
            {
                MessageBox.Show("Tất cả thông tin phải được nhập dữ liệu!");
                return;
            }

            // Kiểm tra Điểm phải là số và nằm trong khoảng (0 - 10)
      
            string chuoiDiem = textDiem.Text.Trim().Replace(',', '.');
            double diemSo;
            if (!double.TryParse(chuoiDiem, NumberStyles.Any, CultureInfo.InvariantCulture, out diemSo) || diemSo < 0 || diemSo > 10)
            {
                MessageBox.Show("Điểm phải là số và nằm trong khoảng từ 0 đến 10!");
                return;
            }

            string maSV = comboBoxSV.Text.Trim();
            string maMH = comboBoxMH.Text.Trim();

            try
            {
                // Kiểm tra Mã SV và Mã MH phải tồn tại trong CSDL 
                if (KT_TonTai_SinhVien(maSV) == false)
                {
                    MessageBox.Show("Mã sinh viên không tồn tại trong cơ sở dữ liệu!");
                    return;
                }
                if (KT_TonTai_MonHoc(maMH) == false)
                {
                    MessageBox.Show("Mã môn học không tồn tại trong cơ sở dữ liệu!");
                    return;
                }

                // Kiểm tra trùng khóa chính bảng Điểm
                if (KT_KhoaChinh_Diem(maSV, maMH) == true)
                {
                    connsql.Open();
                    string insertString = "INSERT INTO Diem VALUES ('" + maSV + "', '" + maMH + "', " + chuoiDiem + ")";
                    SqlCommand cmd = new SqlCommand(insertString, connsql);
                    cmd.ExecuteNonQuery();
                    connsql.Close();

                    MessageBox.Show("Thêm điểm thành công!");
                }
                else
                {
                    MessageBox.Show("Trùng khóa chính! Sinh viên " + maSV + " đã có điểm môn " + maMH + " rồi.");
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
            if (comboBoxSV.Text.Trim() == "" || comboBoxMH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn Mã sinh viên và Mã môn học cần xóa điểm!");
                return;
            }

            string maSV = comboBoxSV.Text.Trim();
            string maMH = comboBoxMH.Text.Trim();

            try
            {
                // Kiểm tra xem cặp (Mã SV + Mã MH) này có trong bảng Điểm để xóa hay không
                if (KT_KhoaChinh_Diem(maSV, maMH) == true)
                {
                    MessageBox.Show("Sinh viên " + maSV + " chưa có điểm môn " + maMH + " để xóa!");
                    return;
                }

                connsql.Open();
                string deleteString = "DELETE FROM Diem WHERE MaSinhVien = '" + maSV + "' AND MaMonHoc = '" + maMH + "'";
                SqlCommand cmd = new SqlCommand(deleteString, connsql);
                cmd.ExecuteNonQuery();
                connsql.Close();

                MessageBox.Show("Xóa điểm thành công!");
                textDiem.Clear();
            }
            catch (Exception ex)
            {
                if (connsql.State == ConnectionState.Open) connsql.Close();
                MessageBox.Show("Xóa thất bại: " + ex.Message);
            }
        }

        
        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (comboBoxSV.Text.Trim() == "" || comboBoxMH.Text.Trim() == "" || textDiem.Text.Trim() == "")
            {
                MessageBox.Show("Tất cả thông tin phải được nhập dữ liệu để sửa!");
                return;
            }

            // Kiểm tra Điểm nằm trong khoảng (0 - 10)
            string chuoiDiem = textDiem.Text.Trim().Replace(',', '.');
            double diemSo;
            if (!double.TryParse(chuoiDiem, NumberStyles.Any, CultureInfo.InvariantCulture, out diemSo) || diemSo < 0 || diemSo > 10)
            {
                MessageBox.Show("Điểm phải là số và nằm trong khoảng từ 0 đến 10!");
                return;
            }

            string maSV = comboBoxSV.Text.Trim();
            string maMH = comboBoxMH.Text.Trim();

            try
            {
                // Kiểm tra khóa chính xem cặp (Mã SV + Mã MH) đã có điểm trong bảng Diem chưa
                if (KT_KhoaChinh_Diem(maSV, maMH) == true)
                {
                    MessageBox.Show("Không tìm thấy điểm của sinh viên " + maSV + " ở môn " + maMH + " để sửa!");
                    return;
                }

                connsql.Open();
                string updateString = "UPDATE Diem SET Diem = " + chuoiDiem + " WHERE MaSinhVien = '" + maSV + "' AND MaMonHoc = '" + maMH + "'";
                SqlCommand cmd = new SqlCommand(updateString, connsql);
                cmd.ExecuteNonQuery();
                connsql.Close();

                MessageBox.Show("Sửa điểm thành công!");
            }
            catch (Exception ex)
            {
                if (connsql.State == ConnectionState.Open) connsql.Close();
                MessageBox.Show("Sửa thất bại: " + ex.Message);
            }
        }
    }
}
