using System;


namespace Tuan1
{
    public class Bai16
    {
          public static void Run()
        {   
            Console.WriteLine("nhap so luong ten can nhap vao mang:");
            int n= int.Parse(Console.ReadLine());
            string [] mang = new string[n];
            for(int i=0;i<n;i++)
            {  
                Console.WriteLine("ten nguoi thu:"+(i+1));
                mang[i]= Console.ReadLine();
            }
            Array.Sort(mang);// Sử dụng phương thức tĩnh Array.Sort để sắp xếp mảng chuỗi theo thứ tự tăng dần
            Console.WriteLine("mang sau khi sap xep theo thu tu tang dan la:");
             for(int i=0;i<n;i++)
            {  
                Console.WriteLine(mang[i]);
            }
           
        }
    }
}