using System;
using System.Security.Cryptography.X509Certificates;
namespace Tuan1
{
    public class Isprime
    {
        public static Boolean ktrasonguyento (int n)// Hàm kiểm tra số nguyên tố, trả về true nếu là số nguyên tố, ngược lại false
        {
            if(n<2)
            {
                return false;
            }
            else
            {
                for(int i=2;i<=Math.Sqrt(n);i++)// Kiểm tra các ước số từ 2 đến căn bậc 2 của n
                {
                    if(n%i==0)// Nếu chia hết cho i thì n không phải là số nguyên tố
                    {
                        return false;
                    }
                }
                return true;// Không chia hết cho số nào trong khoảng trên thì là số nguyên tố
            }
            
        }
        public static void Run()
        {
            Console.WriteLine("nhap so nguyen duong N:");
            int N = Convert.ToInt32(Console.ReadLine());
            if(Isprime.ktrasonguyento(N))
            {
                Console.WriteLine("N la so nguyen to");
            }
            else
            {
                Console.WriteLine("N k la so nguyen to");
            }
        }
    }
}