using System;
using Mylib;

namespace Bai2
{
    public static class Bai2_test
    {
        public static void Run()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("          BAT DAU CHAY BAI 2 TEST           ");
            Console.WriteLine("============================================");

            // TEST 1: Khoảng cách (0,0) tới (3,4) -> Kết quả phải là 5
            Point p1 = new Point(0, 0);
            Point p2 = new Point(3, 4);
            Console.WriteLine($"• Point 1: {p1}");
            Console.WriteLine($"• Point 2: {p2}");
            Console.WriteLine($"• Khoang cach (Phương thức thành viên): {p1.DistanceTo(p2)}");
            Console.WriteLine($"• Khoang cach (hương thức tĩnh): {Point.Distance(p1, p2)}");

            Console.WriteLine("--------------------------------------------");

            // TEST 2: Trung điểm (2,6) và (4,10) -> Kết quả phải là (3,8)
            Point p3 = new Point(2, 6);
            Point p4 = new Point(4, 10);
            Console.WriteLine($"• Point 3: {p3}");
            Console.WriteLine($"• Point 4: {p4}");
            Console.WriteLine($"• Trung diem (Phương thức thành viên): {p3.MidpointTo(p4)}");
            Console.WriteLine($"• Trung diem (Phương thức tĩnh): Point.Midpoint: {Point.Midpoint(p3, p4)}");

            Console.WriteLine("--------------------------------------------");

            // TEST 3: Phép toán +, -, lấy âm (-)
            Console.WriteLine($"• p1 + p2 = {p1 + p2}");
            Console.WriteLine($"• p3 - p4 = {p3 - p4}");
            Console.WriteLine($"• Lay am -p4 = {-p4}");

            Console.WriteLine("============================================");
            Console.WriteLine("             KET THUC TEST CASE             ");
            Console.WriteLine("============================================");
        }
    }
}