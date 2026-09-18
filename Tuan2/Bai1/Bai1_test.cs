using System;

namespace Bai1
{
    public class Bai1_test
    {
        public static void RunTests()
        {
            Console.WriteLine("=== CHẠY DÒNG TEST NỘI BỘ ===");

            // Test case 1: Sinh viên sinh năm 2000
            Sinhvien sv1 = new Sinhvien("Nguyen Van A", 2000);
            int expectedAge1 = DateTime.Now.Year - 2000;
            int actualAge1 = sv1.GetTuoi();

            if (actualAge1 == expectedAge1)
            {
                Console.WriteLine("[PASS] Test case 1 thành công!");
            }
            else
            {
                Console.WriteLine($"[FAIL] Test case 1 thất bại! Kỳ vọng: {expectedAge1}, Thực tế: {actualAge1}");
            }

            // Test case 2: Sinh viên sinh năm 2005
            Sinhvien sv2 = new Sinhvien("Tran Thi B", 2005);
            int expectedAge2 = DateTime.Now.Year - 2005;
            int actualAge2 = sv2.GetTuoi();

            if (actualAge2 == expectedAge2)
            {
                Console.WriteLine("[PASS] Test case 2 thành công!");
            }
            else
            {
                Console.WriteLine($"[FAIL] Test case 2 thất bại! Kỳ vọng: {expectedAge2}, Thực tế: {actualAge2}");
            }

            Console.WriteLine("=== HOÀN THÀNH KIỂM THỬ ===");
        }
    }
}