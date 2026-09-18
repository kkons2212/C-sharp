using System;
using System.Globalization;


namespace Tuan1
{
    public class Bai11
    {
        // Hàm đảo ngược chuỗi, trả về chuỗi mới đã được đảo
       public static string daochuoi (string chuoi)
        {
            string tam= "";
           // Duyệt ngược từ ký tự cuối cùng (Length - 1) về ký tự đầu tiên (0)
           for(int i=chuoi.Length-1;i>=0;i--)
            {  
               // Nối từng ký tự từ cuối chuỗi vào biến tam
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