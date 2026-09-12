using System;
using System.Security.Cryptography.X509Certificates;

namespace Tuan1
{
    public class Bai8
    {
        public static void hoanvi (ref double a ,ref double b )
        {
            double temp = a ;
            a = b;
            b = temp;
        }
        public static void Run()
        {
            double x1=0,x2=0;
            Console.WriteLine("nhap gia tri x1: ");
            x1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("nhap gia tri x2: ");
            x2 = Double.Parse(Console.ReadLine());
            hoanvi(ref x1,ref x2);
            Console.WriteLine("gia tri x1 sau khi hoan vi la:"+x1);
            Console.WriteLine("gia tri x1 sau khi hoan vi la:"+x2);
            
        }
    }
}