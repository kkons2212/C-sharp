using System;

namespace Bai16
{
    // Lớp áp dụng Kế Thừa từ ConsoleMenu
    public class PTBac2Console : ConsoleMenu
    {
        public PTBac2Console()
        {
            Title = "GIAI PHUONG TRINH BAC 2";
            AddMenuItem("Giai phuong trinh ax^2 + bx + c = 0");
            AddMenuItem("Huong dan su dung");
        }

        // Ghi đè phương thức xử lý
        protected override void OnExecuteOption(int option)
        {
            base.OnExecuteOption(option); // Giữ event nếu có đăng ký thêm

            switch (option)
            {
                case 1:
                    GiaiPT();
                    break;
                case 2:
                    Console.WriteLine("Nhap 3 he so a, b, c tu ban phim. He so a phai khac 0.");
                    break;
            }
        }

        private void GiaiPT()
        {
            Console.Write("Nhap a: "); double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b: "); double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap c: "); double c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("He so a = 0 -> Day la phuong trinh bac 1!");
                return;
            }

            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem!");
            }
            else if (delta == 0)
            {
                Console.WriteLine($"Phuong trinh co nghiem kep: x1 = x2 = {-b / (2 * a)}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet:");
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Chạy ứng dụng áp dụng Thừa kế
            PTBac2Console app = new PTBac2Console();

            // Đăng ký thêm sự kiện bằng toán tử += (Chuẩn yêu cầu bài toán)
            app.Choose += (option) =>
            {
                // Có thể log lại hoặc xử lý thêm sự kiện ở đây nếu thích
            };

            app.Run();
        }
    }
}