using System;
using System.Formats.Tar;
using Mylib;

namespace Bai1
{
    public class Sinhvien
    {
        public string Hoten { get; set; }
        public int namsinh { get; set; }

        public Sinhvien()
        {
        }

        public Sinhvien(string Hoten, int namsinh)
        {
            this.Hoten = Hoten;
            this.namsinh = namsinh;
        }

        // Trả về số tuổi để dễ dàng kiểm thử logic
        public int GetTuoi()
        {
            return DateTime.Now.Year - namsinh;
        }

        public void tinhtuoi()
        {
            Console.WriteLine("tuoi cua sinh vien la:" + GetTuoi());
        }

        public static void Main(string[] args)
        {
            // Kiểm tra xem có truyền tham số 'test' hoặc '--test' khi chạy không
            if (args.Length > 0 && (args[0] == "test" || args[0] == "--test"))
            {
                Bai1_test.RunTests();
                return;
            }

            // Luồng chạy ứng dụng bình thường
            string hoten = Input.ReadString("nhap ten sinh vien: ");
            int namsinh = Input.ReadInt("nhap nam sinh: ");
            Sinhvien sv = new Sinhvien(hoten, namsinh);
            sv.tinhtuoi();
        }
    }
}