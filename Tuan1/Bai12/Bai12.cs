using System;
using System.Globalization;

namespace Tuan1
{
    public class Bai12
    {
        public static void Run()
        {
           
            Console.WriteLine("nhap 1 chuoi bat ky:");
            string chuoi = Console.ReadLine();
            Console.WriteLine("chuoi sau khi chuyen sang ky tu thuong: " + chuoi.ToLower());
            Console.WriteLine("chuoi sau khi chuyen sang ky tu hoa: " + chuoi.ToUpper());

            // Tách chuỗi thành mảng các từ phân cách bởi khoảng trắng (" ")
            // StringSplitOptions.RemoveEmptyEntries giúp tự động bỏ qua các khoảng trắng thừa
            string[] Sotu = chuoi.Split(" ", StringSplitOptions.RemoveEmptyEntries);

           
            Console.WriteLine("so tu trong chuoi la: " + Sotu.Length);
        }
    }
}