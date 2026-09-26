using System;

namespace Bai13
{
    // interface IComparable 
    public class SanPham : IComparable
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public double GiaBan { get; set; }

        public SanPham(string maSP, string tenSP, double giaBan)
        {
            MaSP = maSP;
            TenSP = tenSP;
            GiaBan = giaBan;
        }

        // Cài đặt phương thức CompareTo của interface IComparable
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            if (obj is SanPham spKhac)
            {
                // Tiêu chí 1: Sắp xếp theo Giá Bán tăng dần
                if (this.GiaBan > spKhac.GiaBan) return 1;
                if (this.GiaBan < spKhac.GiaBan) return -1;

                // Tiêu chí 2: Nếu giá bằng nhau thì xếp theo Tên (A-Z)
                return string.Compare(this.TenSP, spKhac.TenSP, StringComparison.OrdinalIgnoreCase);
            }

            throw new ArgumentException("Đối tượng so sánh không phải là SanPham!");
        }

        public override string ToString()
        {
            return $"{MaSP,-6} | {TenSP,-20} | {GiaBan,12:N0} VNĐ";
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khai báo mảng các đối tượng SanPham
            SanPham[] dsSanPham = new SanPham[]
            {
                new SanPham("SP01", "Laptop Dell", 15000000),
                new SanPham("SP02", "Chuột Logitech", 450000),
                new SanPham("SP03", "Bàn phím Cơ", 1200000),
                new SanPham("SP04", "Màn hình LG", 4500000),
                new SanPham("SP05", "Tai nghe Sony", 1200000)
            };

            Console.WriteLine("=== DANH SÁCH BAN ĐẦU ===");
            InDanhSach(dsSanPham);

            // SỬ DỤNG PHƯƠNG THỨC TĨNH Array.Sort(...)
            Array.Sort(dsSanPham);

            Console.WriteLine("\n=== SAU KHI SẮP XẾP BẰNG Array.Sort(...) ===");
            InDanhSach(dsSanPham);

            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }

        static void InDanhSach(SanPham[] ds)
        {
            foreach (var item in ds)
            {
                Console.WriteLine(item);
            }
        }
    }
}