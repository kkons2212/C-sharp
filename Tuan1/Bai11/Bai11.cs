using System;
using System.Globalization;


namespace Tuan1
{
    public class Bai11
    {
       public static string daochuoi (string chuoi)
        {
            string tam= "";
           
           for(int i=chuoi.Length-1;i>=0;i--)
            {
               tam=tam+chuoi[i];

            }
            return tam;
        }
        public static void Run()
        {
           Console.WriteLine("nhap chuoi can dao:");
           string chuoi = Console.ReadLine();
           string ketqua= daochuoi(chuoi);
           Console.WriteLine("chuoi sau khi dao la:"+ketqua);
        }
    }
}