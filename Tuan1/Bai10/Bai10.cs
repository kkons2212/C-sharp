using System;
using System.Security.Cryptography.X509Certificates;

namespace Tuan1
{
    public class Bai10
    {
        public static bool kiemtradoixung(string chuoi)
        {
            int trai =0;
            int phai = chuoi.Length -1;
            while(trai<phai)
            {
                if(chuoi[trai]!= chuoi[phai])
                {
                    return false;
                }
                trai ++;
                phai --;
            }
            return true;
        }
        
        public static void Run()
        {
         Console.WriteLine("nhap chuoi muon kiem tra:");
         string chuoi = Console.ReadLine();
         if(kiemtradoixung(chuoi))
            {
                Console.WriteLine("chuoi doi xung");

            }
            else
            {
                Console.WriteLine("chuoi khong doi xung");
            }
        }
    }
}