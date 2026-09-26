using System;
using Mylib;
using Bai4; 

namespace Bai11
{
    public class DayPhanSo
    {
        private PhanSo[] ds;
        private int n;

        // Constructor mặc định
        public DayPhanSo()
        {
            this.n = 0;
            this.ds = new PhanSo[0];
        }

        // Constructor khởi tạo kích thước n
        public DayPhanSo(int n)
        {
            this.n = n > 0 ? n : 0;
            this.ds = new PhanSo[this.n];
        }

        // Indexer để truy cập/thay đổi phân số thứ i
        public PhanSo this[int index]
        {
            get
            {
                if (index < 0 || index >= n)
                    throw new IndexOutOfRangeException("Chi so phan so vuot qua pham vi!");
                return ds[index];
            }
            set
            {
                if (index < 0 || index >= n)
                    throw new IndexOutOfRangeException("Chi so phan so vuot qua pham vi!");
                ds[index] = value;
            }
        }

        // Nhập dãy n phân số sử dụng Mylib.Input
        public void Nhap()
        {
            do
            {
                n = Input.ReadInt("Nhap so luong phan so n (n > 0): ");
                if (n <= 0) Console.WriteLine("Loi: So luong phai lon hon 0!");
            } while (n <= 0);

            ds = new PhanSo[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n-- Nhap phan so thu {i + 1} --");
                int tu = Input.ReadInt("  + Nhap tu so: ");
                int mau;
                do
                {
                    mau = Input.ReadInt("  + Nhap mau so (khac 0): ");
                    if (mau == 0) Console.WriteLine("Loi: Mau so phai khac 0!");
                } while (mau == 0);

                // Khởi tạo phân số sử dụng Constructor của Bai4.PhanSo
                ds[i] = new PhanSo(tu, mau);
            }
        }

        // Xuất dãy phân số ra màn hình (Sử dụng hàm ToString() của Bai4.PhanSo)
        public void Xuat()
        {
            if (ds == null || n == 0)
            {
                Console.WriteLine("Day phan so dang rong!");
                return;
            }

            Console.Write("Day phan so: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{ds[i]} "); // ds[i] sẽ tự động gọi ToString()
            }
            Console.WriteLine();
        }

        // TÍNH TỔNG CỦA N PHÂN SỐ
        public PhanSo TinhTong()
        {
            PhanSo tong = new PhanSo(0, 1); // Tổng khởi tạo = 0
            for (int i = 0; i < n; i++)
            {
                tong = tong + ds[i]; // Tận dụng toán tử '+' bạn đã nạp chồng ở Bai4
            }
            return tong;
        }
        static void Main(string[] args)
        {
            DayPhanSo dayPS = new DayPhanSo();

            Console.WriteLine("=== CHUONG TRINH TINH TONG DAY PHAN SO ===");
            
            // 1. Nhập dãy phân số
            dayPS.Nhap();

            // 2. In dãy phân số vừa nhập
            Console.WriteLine("\n--- DAY PHAN SO VUA NHAP ---");
            dayPS.Xuat();

            // 3. Tính và xuất tổng
            Console.WriteLine("\n--- KET QUA TONG ---");
            PhanSo tong = dayPS.TinhTong();
            Console.WriteLine($"Tong cua {dayPS} phan so la: {tong}");

            Console.WriteLine("\nNhan phim bat ky de ket thuc...");
            Console.ReadKey();
        }
    
    }
}