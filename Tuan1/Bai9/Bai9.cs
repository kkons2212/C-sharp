using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Tuan1
{
    public class Bai9
    {
        // Phương thức tìm Max và Min sử dụng tham chiếu out để trả về 2 kết quả cùng lúc
        public static void TimMaxMin(double a ,double b, double c,out double max , out double min)
        {
           
            max= Math.Max(a,Math.Max(b,c));
            min = Math.Min(a,Math.Min(b,c));
        }
       
        public static void Run()
        {
          double a,b,c;
          double max,min;
          Console.WriteLine("nhap so thuc a:");
          a=Double.Parse(Console.ReadLine());
          Console.WriteLine("nhap so thuc b:");
          b=Double.Parse(Console.ReadLine());
          Console.WriteLine("nhap so thuc c:");
          c=Double.Parse(Console.ReadLine());
          // Truyền biến max, min kèm từ khóa out để nhận kết quả từ phương thức
          TimMaxMin(a,b,c,out max,out min);
          Console.WriteLine("so lon nhat trong 3 so la:"+max);
          Console.WriteLine("so nho nhat trong 3 so la:"+min);
        }
    }
}