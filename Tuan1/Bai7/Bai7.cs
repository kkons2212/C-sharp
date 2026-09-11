using System;
using System.Security.Cryptography.X509Certificates;
namespace Tuan1
{
    public class Isprime
    {
        public static Boolean ktrasonguyento (int n)
        {
            if(n<2)
            {
                return false;
            }
            else
            {
                for(int i=2;i<=Math.Sqrt(n);i++)
                {
                    if(n%i==0)
                    {
                        return false;
                    }
                }
                return true;
            }
            
        }
        public static void Run()
        {
            Console.WriteLine("nhap so nguyen duong N:");
            int N = Convert.ToInt32(Console.ReadLine());
            if(Isprime.ktrasonguyento(N))
            {
                Console.WriteLine("N la so nguyen to:");
            }
            else
            {
                Console.WriteLine("N k la so nguyen to");
            }
        }
    }
}