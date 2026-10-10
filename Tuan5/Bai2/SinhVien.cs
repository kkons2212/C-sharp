using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }

        public SinhVien(string maSV, string hoTen, string diaChi)
        {
            MaSV = maSV;
            HoTen = hoTen;
            DiaChi = diaChi;
        }
    }
}