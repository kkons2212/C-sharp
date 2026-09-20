using System;

namespace Bai5
{
    public class Bai5_test
    {
        public static void Run()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("          KIEM THU TU DONG CLASS DON THUC         ");
            Console.WriteLine("==================================================");

            // 1. Test Constructor & ToString
            Console.WriteLine("\n[1] Test Constructor & ToString():");
            DonThuc dt1 = new DonThuc();             // 0
            DonThuc dt2 = new DonThuc(5, 0);          // 5
            DonThuc dt3 = new DonThuc(3, 1);          // 3x
            DonThuc dt4 = new DonThuc(2.5, 3);        // 2.5x^3

            Console.WriteLine($"- dt1 (Mac dinh) : P(x) = {dt1}");
            Console.WriteLine($"- dt2 (Hang so)  : P(x) = {dt2}");
            Console.WriteLine($"- dt3 (Bac 1)    : P(x) = {dt3}");
            Console.WriteLine($"- dt4 (Bac 3)    : P(x) = {dt4}");

            // 2. Test Câu (a): Tính giá trị với x
            Console.WriteLine("\n[2] Test Cau (a) - Tinh gia tri P(x):");
            double x = 2.0;
            Console.WriteLine($"- Voi P(x) = {dt4} va x = {x}:");
            Console.WriteLine($"  P({x}) = 2.5 * ({x}^3) = {dt4.TinhGiaTri(x)}"); // Kết quả kỳ vọng: 20

            // 3. Test Câu (b): Đạo hàm
            Console.WriteLine("\n[3] Test Cau (b) - Tinh dao ham P'(x):");
            DonThuc dh2 = dt2.DaoHam(); // (5)' -> 0
            DonThuc dh3 = dt3.DaoHam(); // (3x)' -> 3
            DonThuc dh4 = dt4.DaoHam(); // (2.5x^3)' -> 7.5x^2

            Console.WriteLine($"- Dao ham cua [{dt2}] la: {dh2}");
            Console.WriteLine($"- Dao ham cua [{dt3}] la: {dh3}");
            Console.WriteLine($"- Dao ham cua [{dt4}] la: {dh4}");

            // 4. Test Bắt ngoại lệ số mũ âm
            Console.WriteLine("\n[4] Test Bắt ngoại lệ (So mu n < 0):");
            try
            {
                Console.Write("- Thu tao don thuc voi n = -2: ");
                DonThuc dtLoi = new DonThuc(3, -2);
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