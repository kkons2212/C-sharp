using System;

namespace Bai14
{
        public interface ISoSanh
    {
        // Trả về: > 0 nếu lớn hơn, < 0 nếu nhỏ hơn, 0 nếu bằng nhau
        int SoSanhVoi(object obj);
    }

    
    // 2. LỚP THUẬT TOÁN MÔ PHỎNG Array.Sort(...)
        public static class MangTongQuat
    {
        // Phương thức sắp xếp tổng quát nhận mảng các đối tượng thực thi ISoSanh
        public static void Sort(ISoSanh[] arr)
        {
            if (arr == null || arr.Length <= 1) return;

            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Nếu phần tử đứng trước lớn hơn phần tử đứng sau -> Đổi chỗ
                    if (arr[j] != null && arr[j].SoSanhVoi(arr[j + 1]) > 0)
                    {
                        ISoSanh temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }

    
    // 3. LỚP SANPHAM CÀI ĐẶT INTERFACE ISoSanh
   
    public class SanPham : ISoSanh
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

        // Cài đặt phương thức SoSanhVoi của ISoSanh
        public int SoSanhVoi(object obj)
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

            throw new ArgumentException("Doi tuong so sanh khong phai la SanPham!");
        }

        public override string ToString()
        {
            return $"{MaSP,-6} | {TenSP,-20} | {GiaBan,12:N0} VNĐ";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khai báo mảng kiểu ISoSanh[] (Thừa kế & Đa hình)
            ISoSanh[] dsSanPham = new SanPham[]
            {
                new SanPham("SP01", "Laptop Dell", 15000000),
                new SanPham("SP02", "Chuột Logitech", 450000),
                new SanPham("SP03", "Bàn phím Cơ", 1200000),
                new SanPham("SP04", "Màn hình LG", 4500000),
                new SanPham("SP05", "Tai nghe Sony", 1200000)
            };

            Console.WriteLine("=== DANH SÁCH BAN ĐẦU ===");
            InDanhSach(dsSanPham);

            // Sắp xếp mảng tổng quát bằng thuật toán mô phỏng Array.Sort
            MangTongQuat.Sort(dsSanPham);

            Console.WriteLine("\n=== SAU KHI SẮP XẾP BẰNG MangTongQuat.Sort(...) ===");
            InDanhSach(dsSanPham);

            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }

        static void InDanhSach(ISoSanh[] ds)
        {
            foreach (var item in ds)
            {
                Console.WriteLine(item);
            }
        }
    }
}