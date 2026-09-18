using System;


namespace Tuan1
{
    public class SinhVien
    {
        // Khai báo các thuộc tính để lưu thông tin sinh viên
        public  string masv {get;set;}
        public string hotensv {get;set;}
        public string diachi {get;set;}
        public int nam {get;set;}
        // Hàm khởi tạo (Constructor) có tham số để gán giá trị ban đầu cho các thuộc tính của đối tượng
        public SinhVien(string masv,string hotensv,string diachi,int nam)
        {
            this.masv = masv;
            this.hotensv=hotensv;
            this.diachi=diachi;
            this.nam=nam;
        }
        // Phương thức xuất thông tin sinh viên ra màn hình
        public void xuat()
        {   Console.WriteLine("Thong tin sinh vien:");
            Console.WriteLine("ma so sinh vien:"+masv);
            Console.WriteLine("ho ten sinh vien:"+hotensv);
            Console.WriteLine("dia chi sinh vien:"+diachi);
            Console.WriteLine("sinh vien nam thu:"+nam);
        }
               public static void Run()
        {
            Console.WriteLine("nhap thong tin sinh vien:");
            Console.WriteLine("Nhap ma sinh vien:");
            string masv = Console.ReadLine();
            Console.WriteLine("Nhap ho ten sinh vien:");
            string hotensv = Console.ReadLine();
            Console.WriteLine("Nhap dia chi sinh vien:");
            string diachi = Console.ReadLine();
            Console.WriteLine("Nhap nam hoc cua sinh vien:");
            int nam = int.Parse(Console.ReadLine());
            // Khởi tạo đối tượng SinhVien mới thông qua constructor có tham số
            SinhVien sv=new SinhVien(masv,hotensv,diachi,nam);
            sv.xuat();
        }
    }
}