using System;

namespace Bai4
{
    public class Bai4_test
    {
        public static void Run()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("          KIEU THU TU DONG CLASS PHAN SO          ");
            Console.WriteLine("==================================================");

            // 1. Test Khởi tạo & Rút gọn
            Console.WriteLine("\n[1] Test Constructor & Rut gon:");
            PhanSo p1 = new PhanSo();             // [0]
            PhanSo p2 = new PhanSo(5);            // [5]
            PhanSo p3 = new PhanSo(6, 8);         // [3/4]
            PhanSo p4 = new PhanSo(-2, -4);       // [1/2]
            PhanSo p5 = new PhanSo(p3);           // [3/4]

            Console.WriteLine($"- p1 (mac dinh)  : {p1}");
            Console.WriteLine($"- p2 (so nguyen) : {p2}");
            Console.WriteLine($"- p3 (6/8)       : {p3}");
            Console.WriteLine($"- p4 (-2/-4)     : {p4}");
            Console.WriteLine($"- p5 (copy p3)   : {p5}");

            // 2. Test Toán tử 1 ngôi
            Console.WriteLine("\n[2] Test Toan tu 1 ngoi (p3 = [3/4]):");
            Console.WriteLine($"- +p3 = {+p3}");
            Console.WriteLine($"- -p3 = {-p3}");

            // 3. Test Toán tử 2 ngôi
            Console.WriteLine("\n[3] Test Toan tu 2 ngoi (p3 = [3/4], p4 = [1/2]):");
            Console.WriteLine($"- p3 + p4 = {p3 + p4}"); // [5/4]
            Console.WriteLine($"- p3 - p4 = {p3 - p4}"); // [1/4]
            Console.WriteLine($"- p3 * p4 = {p3 * p4}"); // [3/8]
            Console.WriteLine($"- p3 / p4 = {p3 / p4}"); // [3/2]

            // 4. Test So sánh
            Console.WriteLine("\n[4] Test So sanh:");
            Console.WriteLine($"- p3 > p4  ([3/4] > [1/2])  : {p3 > p4}");   // True
            Console.WriteLine($"- p3 < p4  ([3/4] < [1/2])  : {p3 < p4}");   // False
            Console.WriteLine($"- p3 == p5 ([3/4] == [3/4]) : {p3 == p5}");  // True
            Console.WriteLine($"- p3 != p4 ([3/4] != [1/2]) : {p3 != p4}");  // True

            // 5. Test Bắt ngoại lệ
            Console.WriteLine("\n[5] Test Ngoai le (Exception):");
            try
            {
                Console.Write("- Tao phan so mau = 0: ");
                PhanSo pLoi = new PhanSo(1, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Thanh cong] {ex.Message}");
            }

            try
            {
                Console.Write("- Chia cho phan so [0]: ");
                PhanSo pZero = new PhanSo(0, 1);
                PhanSo pChia = p3 / pZero;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Thanh cong] {ex.Message}");
            }

            Console.WriteLine("\n==================================================");
            Console.WriteLine("               HOAN THANH KIEM THU!               ");
            Console.WriteLine("==================================================");
        }
    }
}