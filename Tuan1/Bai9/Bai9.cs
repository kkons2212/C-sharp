using System;
using System.Security.Cryptography.X509Certificates;

namespace Tuan1
{
    public class Bai9
    {
        public static double Max(double a ,double b, double c)
        {
           
           return Math.Max(a,Math.Max(b,c));
        }
        public static double Min(double a ,double b, double c)
        {
           
           return Math.Min(a,Math.Min(b,c));
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
          max = Max(a,b,c);
          min = Min(a,b,c);
          Console.WriteLine("so lon nhat trong 3 so la:"+max);
          Console.WriteLine("so nho nhat trong 3 so la:"+min);
        }
    }
}