using System;

namespace Bai3
{
    public class Bai3_test
    {
        public static void Run()
        {
        
            Console.WriteLine("  KET QUA CHAY TEST CASE");
            

            // Test 1: Khởi tạo mặc định
            Console.WriteLine("\n[Test 1] Khoi tao mac dinh (Default Constructor):");
            Person p1 = new Person();
            p1.Output();
            Console.WriteLine(); // Xuống dòng cho đẹp

            // Test 2: Khởi tạo có tham số (Trường hợp còn sống)
            Console.WriteLine("\n[Test 2] Khoi tao co tham so (Nguoi con song - yod = 0):");
            Person p2 = new Person("P002", "Tran Thi B", 1998, 0);
            p2.Output();
            Console.WriteLine();

            // Test 3: Khởi tạo có tham số (Trường hợp đã mất)
            Console.WriteLine("\n[Test 3] Khoi tao co tham so (Nguoi da mat - yod = 2021):");
            Person p3 = new Person("P003", "Le Van C", 1945, 2021);
            p3.Output();
            Console.WriteLine();

            // Test 4: Copy Constructor
            Console.WriteLine("\n[Test 4] Khoi tao sao chep (Copy p3 sang p4):");
            Person p4 = new Person(p3);
            p4.Output();
            Console.WriteLine();

            // Test 5: Kiểm tra giá trị IsLiving()
            Console.WriteLine("\n[Test 5] Kiem tra ket qua tra ve cua hàm IsLiving():");
            Console.WriteLine($"- p2 (Tran Thi B): IsLiving() = {p2.IsLiving()} (Mong doi: True)");
            Console.WriteLine($"- p3 (Le Van C)  : IsLiving() = {p3.IsLiving()} (Mong doi: False)");

           
            Console.WriteLine("          HOAN THANH TEST CASE AUTO          ");
            
        }
    }
}