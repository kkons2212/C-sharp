using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class LopHoc
    {
        public string TenLop { get; set; }
        public List<SinhVien> DanhSachSinhVien { get; set; }

        public LopHoc(string tenLop)
        {
            TenLop = tenLop;
            DanhSachSinhVien = new List<SinhVien>();
        }

        // Kiểm tra và thêm sinh viên vào lớp (Chống trùng mã SV)
        public bool ThemSinhVien(SinhVien sv)
        {
            foreach (var s in DanhSachSinhVien)
            {
                if (s.MaSV.Equals(sv.MaSV, System.StringComparison.OrdinalIgnoreCase))
                {
                    return false; // Trùng mã SV
                }
            }
            DanhSachSinhVien.Add(sv);
            return true;
        }
    }
}
