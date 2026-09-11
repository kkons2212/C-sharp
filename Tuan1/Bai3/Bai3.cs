using System;

namespace Tuan1
{
    public class Bai3
    {
        public static void Run()
        {
            Console.Write("nhap so nguyen x: ");
            int x= Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            Console.Write("nhap so nguyen y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write($"ket qua {x} mu {y} la:"+Math.Pow(x,y));
        }

    }
}