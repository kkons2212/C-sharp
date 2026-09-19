using System;
using Mylib;
namespace Bai2
{
    public class Point
    {
        //Field
        private double x;
        private double y;

        //Property
        public double X
        {
            get => x;
            set => x = value;
        }

        public double Y
        {
            get => y;
            set => y = value;
        }
        //Default Constructor
        public Point()
        {
            x = 0;
            y = 0;
        }

        // Constructor có tham số
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        //  Method Input & Output 
        public void Input()
        {
            x = Mylib.Input.ReadDouble("  Nhap toa do  x: ");
            y = Mylib.Input.ReadDouble("  Nhap toa do y: ");
        }

        public void Output()
        {
            Console.WriteLine($"({x}, {y})");
        }

        // Override ToString()
        public override string ToString()
        {
            return $"({x}, {y})";
        }

        //Phép toán: +, -, lấy âm (-)
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }

        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.x - p2.x, p1.y - p2.y);
        }

        public static Point operator -(Point p)
        {
            return new Point(-p.x, -p.y);
        }
        // (a) KHOẢNG CÁCH GIỮA 2 ĐIỂM
        // Phương thức thành viên 
        public double DistanceTo(Point other)
        {
            return Math.Sqrt(Math.Pow(this.x - other.x, 2) + Math.Pow(this.y - other.y, 2));
        }

        // Phương thức tĩnh 
        public static double Distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
        }

        // (b) TRUNG ĐIỂM CỦA 2 ĐIỂM
        //  Phương thức thành viên 
        public Point MidpointTo(Point other)
        {
            return new Point((this.x + other.x) / 2.0, (this.y + other.y) / 2.0);
        }

        // Phương thức tĩnh 
        public static Point Midpoint(Point p1, Point p2)
        {
            return new Point((p1.x + p2.x) / 2.0, (p1.y + p2.y) / 2.0);
        }
        static void Main(string[] args)
    {   

        if (args.Length > 0 && (args[0] == "--test" || args[0] == "test"))
            {
              
                Bai2_test.Run();
                return; 
            }

        Console.WriteLine("NHAP TOA DO 2 DIEM A VA B");

        Console.WriteLine("\n[Nhap diem A]");
        Point A = new Point();
        A.Input();

        Console.WriteLine("\n[Nhap diem B]");
        Point B = new Point();
        B.Input();

        Console.WriteLine("\n---------------------------------");
        Console.WriteLine($"Diem A: {A}");
        Console.WriteLine($"Diem B: {B}");
        Console.WriteLine("---------------------------------");

        // --- Kiểm tra phép toán ---
        Console.WriteLine($"A + B = {A + B}");
        Console.WriteLine($"A - B = {A - B}");
        Console.WriteLine($"Lay am A (-A) = {-A}");

        Console.WriteLine("\n---------------------------------");

        // --- (a) Khoảng cách ---
        Console.WriteLine("(a) KHOANG CACH GIUA A VA B");
        Console.WriteLine($"C1 (Phương thức thành viên): {A.DistanceTo(B)}");
        Console.WriteLine($"C2 (Phương thức tĩnh): {Point.Distance(A, B)}");


        // --- (b) Trung điểm ---
        Console.WriteLine("(b) TRUNG DIEM I CUA A VA B");
        Console.WriteLine($"C1 (Phương thức thành viên): {A.MidpointTo(B)}");
        Console.WriteLine($"C2 (Phương thức tĩnh): {Point.Midpoint(A, B)}");
  
    }
    }
    
}