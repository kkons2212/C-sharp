using System;
using System.Collections.Generic;

namespace Bai3
{
    public class XuLyChuoi
    {
        private static string[] HO = { "Lê", "Nguyễn", "Lý", "Trần", "Lâm", "Hồ", "Lai", "Huỳnh", "La" };
        private static string[] TENLOT = { "Quang", "Thành", "Ngọc", "Anh", "Xuân", "Bảo", "Cẩm", "Thị", "Kim", "Thái", "Hồng" };
        private static string[] TEN = { "Hà", "Danh", "Sơn", "Mai", "Thắng", "Kỳ", "Thành", "Lâm", "Tâm", "Phụng", "Thắm" };

        // Hàm tạo danh sách 50 tên ngẫu nhiên
        public static List<string> Tao50TenNgauNhien()
        {
            List<string> danhSach = new List<string>();
            Random rand = new Random();

            for (int i = 0; i < 50; i++)
            {
                string ho = HO[rand.Next(HO.Length)];
                string tenLot = TENLOT[rand.Next(TENLOT.Length)];
                string ten = TEN[rand.Next(TEN.Length)];

                string hoVaTen = $"{ho} {tenLot} {ten}";
                danhSach.Add(hoVaTen);
            }

            return danhSach;
        }
    }
}