using System;

namespace Bai15
{
    
    // 1. KHAI BÁO DELEGATE SO SÁNH TỔNG QUÁT (GENERIC DELEGATE)
    
    public delegate int SoSanhDelegate<T>(T x, T y);

    
    // 2. LỚP THUẬT TOÁN SẮP XẾP BẰNG DELEGATE
    
    public static class ThuatToanSapXepDelegate
    {
        // Phương thức sắp xếp nhận mảng kiểu T và một Delegate điều kiện so sánh
        public static void Sort<T>(T[] arr, SoSanhDelegate<T> soSanh)
        {
            if (arr == null || arr.Length <= 1 || soSanh == null) return;

            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Thực thi Delegate để so sánh 2 phần tử kề nhau
                    if (soSanh(arr[j], arr[j + 1]) > 0)
                    {
                        // Đổi chỗ
                        T temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }

    
    // 3. LỚP SANPHAM (Lớp dữ liệu đơn thuần, KHÔNG cần cài Interface)
    public class SanPham
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

        public override string ToString()
        {
            return $"{MaSP,-6} | {TenSP,-20} | {GiaBan,12:N0} VNĐ";
        }
    }

   
    class Program
    {
        // Hàm so sánh 1: Theo Giá Bán tăng dần
        static int SoSanhTheoGia(SanPham a, SanPham b)
        {
            if (a.GiaBan > b.GiaBan) return 1;
            if (a.GiaBan < b.GiaBan) return -1;
            return 0;
        }

        // Hàm so sánh 2: Theo Tên (A-Z)
        static int SoSanhTheoTen(SanPham a, SanPham b)
        {
            return string.Compare(a.TenSP, b.TenSP, StringComparison.OrdinalIgnoreCase);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

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

            // CÁCH 1: Truyền phương thức tĩnh 
           
            ThuatToanSapXepDelegate.Sort(dsSanPham, SoSanhTheoGia);
            Console.WriteLine("\n=== 1. SAU KHI SẮP XẾP THEO GIÁ (DÙNG DELEGATE TÊN HÀM) ===");
            InDanhSach(dsSanPham);

          
            // CÁCH 2: Dùng Biểu thức Lambda (Lambda Expression)
           
            ThuatToanSapXepDelegate.Sort(dsSanPham, (x, y) => string.Compare(x.TenSP, y.TenSP));
            Console.WriteLine("\n=== 2. SAU KHI SẮP XẾP THEO TÊN A-Z (DÙNG LAMBDA EXPRESSION) ===");
            InDanhSach(dsSanPham);

            
            // CÁCH 3: Sắp xếp theo Giá giảm dần
            ThuatToanSapXepDelegate.Sort(dsSanPham, (x, y) => y.GiaBan.CompareTo(x.GiaBan));
            Console.WriteLine("\n=== 3. SAU KHI SẮP XẾP THEO GIÁ GIẢM DẦN (LAMBDA) ===");
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