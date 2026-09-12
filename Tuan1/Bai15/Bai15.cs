using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Tuan1
{
    public class Bai15
    {   public int n;
        private int [] mang ;
        public void nhapmang()
        {
            
            Console.WriteLine("nhap so luong phan tu cua mang");
            n= int.Parse(Console.ReadLine());
            mang = new int[n];
            for(int i=0 ;i<mang.Length;i++)
            {   Console.WriteLine("nhap phan tu thu:"+(i+1));
                mang[i]=int.Parse(Console.ReadLine()); 
            }
        } 
        public void xuat()
        {   Console.Write("cac phan tu trong mang la:");
            for(int i=0;i<mang.Length;i++)
            {
                Console.Write(mang[i]+" ");
            }
            Console.Write("\n");
        }
        public void Timmaxmin()
        {   
            // Gán max và min ban đầu bằng phần tử đầu tiên của mảng
            int max=mang[0];
            int min=mang[0];
            for(int i=0;i<mang.Length;i++)
            {
                if(mang[i]>max)
                {
                    max=mang[i];
                }
                if(mang[i]<min)
                {
                    min = mang[i];
                }
                
            }
            Console.WriteLine("phan tu lon nhat mang la:"+max);
             Console.WriteLine("phan tu nho nhat mang la:"+min);
        }
        public static Boolean kiemtrasonguyento(int n)
        {
            if(n<2)
            {
                return false;
            }
            for(int i=2;i<=Math.Sqrt(n);i++)
            {
                if(n%i==0)
                {
                    return false;
                }
            }
            return true;
        }
        public int[] mangcacsonguyento()
        {   
           int dem=0;
            // Đếm số lượng So nguyen to để xác định kích thước mảng tam
            for(int i=0;i<mang.Length;i++)
            {
                if(kiemtrasonguyento(mang[i]))
                {
                    dem++;
                }
            }
            // Khởi tạo mảng tam với độ dài đúng bằng biến dem
            int [] tam = new int[dem];
            int k=0; // Biến chỉ số riêng để nạp dữ liệu vào mảng tam
            
            for(int i=0;i<mang.Length;i++)
            {
                if(kiemtrasonguyento(mang[i]))
                {
                    tam[k]=mang[i];
                    k++; //tang moi lan thanh cong
                }
            }
            return tam;
        }
        public static void Run()
        {
           Bai15 b15 = new Bai15();
           b15.nhapmang();
           b15.xuat();
           b15.Timmaxmin();
           int [] ketqua = b15.mangcacsonguyento();
           Console.Write("mang cac so nguyen to la:");
           for(int i=0; i<ketqua.Length;i++)
            {
                Console.Write(ketqua[i]+" ");
            }



        }
    }
}