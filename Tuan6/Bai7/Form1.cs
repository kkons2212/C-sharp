using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Bai7
{
    public partial class Form1 : Form
    {
        SqlConnection connsql;
        public Form1()
        {
            InitializeComponent();
            string strCon = @"Data Source=127.0.0.1,1433;Initial Catalog=QLSinhVien;User ID=sa;Password=SqlServer@2026;TrustServerCertificate=True;Encrypt=False;";
            connsql = new SqlConnection(strCon);
            buttonHienThi.Click += buttonHienThi_Click;
            buttonThoat.Click += buttonThoat_Click;
        }
        private void buttonHienThi_Click(object sender, EventArgs e)
        {
            try
            {
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }

                string selectString = "SELECT * FROM Lop";
                SqlCommand cmd = new SqlCommand(selectString, connsql);
                SqlDataReader rd = cmd.ExecuteReader();

                // Xóa dữ liệu cũ trên ListView trước khi nạp mới
                listView1.Items.Clear();

                int stt = 1; 
                while (rd.Read())
                {
                    // Lấy dữ liệu từ các cột trong cơ sở dữ liệu
                    string maLop = rd["MaLop"].ToString();
                    string tenLop = rd["TenLop"].ToString();
                    string maKhoa = rd["MaKhoa"].ToString();

                    // Tạo một dòng (ListViewItem) 
                    ListViewItem item = new ListViewItem(stt.ToString());

                    // Thêm tiếp các cột còn lại (Mã lớp, Tên lớp, Mã khoa) vào dòng đó
                    item.SubItems.Add(maLop);
                    item.SubItems.Add(tenLop);
                    item.SubItems.Add(maKhoa);

                    // Đưa dòng hoàn chỉnh lên ListView
                    listView1.Items.Add(item);

                    stt++; 
                }

                rd.Close();
                connsql.Close();

                if (listView1.Items.Count == 0)
                {
                    MessageBox.Show("Bảng Lớp hiện chưa có dữ liệu nào!");
                }
            }
            catch (Exception ex)
            {
                if (connsql.State == ConnectionState.Open)
                    connsql.Close();
                MessageBox.Show("Lỗi hiển thị dữ liệu: " + ex.Message);
            }
        }

       
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
