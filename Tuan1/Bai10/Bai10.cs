using System;
using System.Security.Cryptography.X509Certificates;

namespace Tuan1
{
    public class Bai10
    {
        // Hàm kiểm tra chuỗi đối xứng trả về true nếu đối xứng, ngược lại false
        public static bool kiemtradoixung(string chuoi)
        {   // Khởi tạo hai con trỏ: trai ở đầu chuỗi, phai ở cuối chuỗi
            int trai =0;
            int phai = chuoi.Length -1;
            // Vòng lặp so sánh từng cặp ký tự đối xứng từ 2 đầu tiến vào giữa
            while(trai<phai)
            {  
                 // Nếu phát hiện cặp ký tự khác nhau thì kết luận ngay chuỗi không đối xứng
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