using System;
using System.Linq.Expressions;

namespace Tuan1
{
    public class Bai4
    {
        public static void Run()
        {   
            int x=0;
            int y=0;
            
            try
            { 
                  Console.Write("nhap so nguyen x: ");
                x=int.Parse(Console.ReadLine());
            }
            catch(FormatException )
            {   
                Console.WriteLine("x khong thuoc kieu so nguyen");// Thông báo và dừng chương trình nếu x không phải số nguyên
                return;
            }
          
            try
            {    Console.Write("nhap so nguyen y: ");
                  y=int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("y khong thuoc kieu so nguyen");// Thông báo và dừng chương trình nếu y không phải số nguyên
                return;
            }
            Console.Write($"ket qua {x} mu {y} la:"+Math.Pow(x,y));
        }

    }
}