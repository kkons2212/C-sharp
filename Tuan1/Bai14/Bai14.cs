using System;
using System.Net;


namespace Tuan1
{
    public class Nhanvien
    {
        // Thuộc tính thông tin nhân viên
        public  string hoten {get;set;}
        public decimal mucluong {get;set;}
        public int songayvang {get;set;}

        // Hàm khởi tạo (Constructor) có tham số gán dữ liệu ban đầu cho đối tượng
            public Nhanvien(string hoten,decimal mucluong,int songayvang)
        {
            this.hoten = hoten;
            this.mucluong=mucluong;
            this.songayvang=songayvang;
            
        }
        public void xuly()
        {   // Trừ 100k cho mỗi ngày vắng trước khi in ra kết quả
            if(songayvang>0)
            {
                mucluong=mucluong-(songayvang*100000);
                xuat();
            }
            else
            {
                xuat();
            }
        }
        // Phương thức tính toán phạt trừ lương theo số ngày vắng
        public void xuat()
        {   Console.WriteLine("Thong tin nhan vien:");
            Console.WriteLine("ho ten nhan vien:"+hoten);
            Console.WriteLine("muc luong:"+mucluong+"VND");
            Console.WriteLine("so ngay vang :"+songayvang);
         
        }
               public static void Run()
        {
            Console.WriteLine("nhap thong tin nhan vien:");
           
            Console.WriteLine("Nhap ho ten nhan vien:");
            string hoten = Console.ReadLine();
            Console.WriteLine("Nhap muc luong nhan vien:");
            decimal mucluong = decimal.Parse(Console.ReadLine());// Ép kiểu chuỗi nhập từ bàn phím sang kiểu decimal
            Console.WriteLine("so ngay vang:");
            int songayvang = int.Parse(Console.ReadLine());
            Nhanvien nv=new Nhanvien(hoten,mucluong,songayvang);
            nv.xuly();
            
        }
    }
}