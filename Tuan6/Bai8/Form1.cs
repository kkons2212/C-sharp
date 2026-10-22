using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Bai8
{
    public partial class Form1 : Form
    {
        SqlConnection connsql;
        public Form1()
        {
            InitializeComponent();
            string strCon = @"Data Source=127.0.0.1,1433;Initial Catalog=QLSinhVien;User ID=sa;Password=SqlServer@2026;TrustServerCertificate=True;Encrypt=False;";
            connsql = new SqlConnection(strCon);
            buttonLoc.Click += buttonLoc_Click;
            LoadMonHoc_ComboBox();
            HienThiDuLieu("");
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

                // Thêm một item là khoảng trắng ở vị trí đầu tiên (hiểu là tất cả môn học)
                comboBoxMH.Items.Add("");

                while (rd.Read())
                {
                    comboBoxMH.Items.Add(rd["MaMonHoc"].ToString());
                }

                rd.Close();
                connsql.Close();

                // Mặc định chọn dòng khoảng trắng đầu tiên
                comboBoxMH.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                if (connsql.State == ConnectionState.Open) connsql.Close();
                MessageBox.Show("Lỗi tải danh sách môn học: " + ex.Message);
            }
        }

        
        // HÀM HIỂN THỊ DỮ LIỆU LÊN LISTVIEW VÀ TÍNH TỔNG ĐIỂM
        // - Nếu maMH == "": Hiển thị tất cả môn học
        // - Nếu maMH != "": Chỉ lọc theo mã môn học được chọn
      
        private void HienThiDuLieu(string maMH)
        {
            try
            {
                if (connsql.State == ConnectionState.Closed)
                    connsql.Open();

               
                string selectString = "SELECT SinhVien.HoTen, SinhVien.NgaySinh, MonHoc.TenMonHoc, Diem.Diem " +
                                      "FROM Diem, SinhVien, MonHoc " +
                                      "WHERE Diem.MaSinhVien = SinhVien.MaSinhVien " +
                                      "AND Diem.MaMonHoc = MonHoc.MaMonHoc";

                // Nếu người dùng chọn 1 mã môn học cụ thể (khác khoảng trắng) thì nối thêm điều kiện lọc
                if (maMH.Trim() != "")
                {
                    selectString += " AND Diem.MaMonHoc = '" + maMH.Trim() + "'";
                }

                SqlCommand cmd = new SqlCommand(selectString, connsql);
                SqlDataReader rd = cmd.ExecuteReader();

                listView1.Items.Clear();

                int stt = 1;
                double tongDiem = 0; 

                while (rd.Read())
                {
                    string hoTen = rd["HoTen"].ToString();
                    string ngaySinh = rd["NgaySinh"].ToString();
                    string tenMH = rd["TenMonHoc"].ToString();
                    string diemStr = rd["Diem"].ToString();

                    // Đưa dòng dữ liệu lên ListView
                    ListViewItem item = new ListViewItem(stt.ToString());
                    item.SubItems.Add(hoTen);
                    item.SubItems.Add(ngaySinh);
                    item.SubItems.Add(tenMH);
                    item.SubItems.Add(diemStr);
                    listView1.Items.Add(item);

                    // Cộng dồn điểm vào tổng điểm
                    tongDiem += Convert.ToDouble(rd["Diem"]);

                    stt++;
                }

                rd.Close();
                connsql.Close();

              
                textTongDiem.Text = tongDiem.ToString();
            }
            catch (Exception ex)
            {
                if (connsql.State == ConnectionState.Open) connsql.Close();
                MessageBox.Show("Lỗi hiển thị dữ liệu: " + ex.Message);
            }
        }

      
        // NÚT LỌC DỮ LIỆU
    
        private void buttonLoc_Click(object sender, EventArgs e)
        {
            // Lấy mã môn học đang chọn trên ComboBox (nếu chọn khoảng trắng thì nó là "")
            string maMHChon = comboBoxMH.Text.Trim();

         
            HienThiDuLieu(maMHChon);
        }
    }
}
