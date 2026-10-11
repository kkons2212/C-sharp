using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    internal class StudentService
    {
        // Cung cấp danh sách các dân tộc mặc định khi Load Form
        public string[] LayDanhSachDanToc()
        {
            return new string[] { "Kinh", "Tày", "Thái", "Mường", "H'Mông", "Hoa", "Khmer", "Nùng" };
        }

        // Kiểm tra xem mã sinh viên đã tồn tại trên ListView chưa (tránh trùng mã khi thêm)
        public bool KiemTraTrungMa(ListView lsv, string maSV)
        {
            foreach (ListViewItem item in lsv.Items)
            {
                // Cột thứ 1 (Index = 1) trong ListView chính là Mã sinh viên
                if (item.SubItems[1].Text.Trim().ToLower() == maSV.Trim().ToLower())
                {
                    return true; // Đã tồn tại mã này
                }
            }
            return false;
        }
    }
}