using System;


namespace Tuan1
{
    public class TimMax
    {
       public static int TimsoLonnhat (int a, int b , int c)
        {
            return Math.Max(a,Math.Max(b,c));
        }
        public static void Run()
        {
            int a,b,c;
            Console.WriteLine("Nhap so nguyen a");
            a = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Nhap so nguyen b");
            b = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Nhap so nguyen c");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("so lon nhat trong 3 so nguyen la:"+TimMax.TimsoLonnhat(a,b,c));
        }
    }
}