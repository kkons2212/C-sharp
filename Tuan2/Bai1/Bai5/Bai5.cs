using System;
using Mylib;

namespace Bai5
{
    public class DonThuc
    {
        private double a; // Hệ số
        private int n;    // Số mũ (n >= 0)

        // --- PROPERTIES ---
        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public int N
        {
            get { return n; }
            set
            {
                if (value < 0)
                    throw new Exception("So mu n phai la so nguyen khong am (n >= 0)!");
                n = value;
            }
        }

        // --- CONSTRUCTORS ---
        public DonThuc()
        {
            this.a = 0.0;
            this.n = 0;
        }

        public DonThuc(double a, int n)
        {
            if (n < 0)
                throw new Exception("So mu n phai la so nguyen khong am (n >= 0)!");
            this.a = a;
            this.n = n;
        }

        public DonThuc(DonThuc dt)
        {
            if (dt != null)
            {
                this.a = dt.a;
                this.n = dt.n;
            }
        }

        // --- HÀM TÍNH GIÁ TRỊ P(x) ---
        public double TinhGiaTri(double x)
        {
            return this.a * Math.Pow(x, this.n);
        }

        // --- HÀM TÍNH ĐẠO HÀM P'(x) ---
        public DonThuc DaoHam()
        {
            if (this.n == 0)
            {
                return new DonThuc(0, 0); // Đạo hàm của hằng số bằng 0
            }
            double heSoMoi = this.a * this.n;
            int soMuMoi = this.n - 1;
            return new DonThuc(heSoMoi, soMuMoi);
        }

        // --- NHẬP / XUẤT ---
        public void Input()
        {
            this.a = Mylib.Input.ReadDouble("Nhap he so a: ");
            do
            {
                this.n = Mylib.Input.ReadInt("Nhap so mu n (n >= 0): ");
                if (this.n < 0)
                    Console.WriteLine("So mu phai >= 0! Vui long nhap lai.");
            } while (this.n < 0);
        }

        public override string ToString()
        {
            if (this.a == 0) return "0";
            if (this.n == 0) return $"{this.a}";
            if (this.n == 1) return $"{this.a}x";
            return $"{this.a}x^{this.n}";
        }

        // --- MAIN METHOD ---
        public static void Main(string[] args)
        {
            if (args.Length > 0 && (args[0] == "--test" || args[0] == "test"))
            {
                Bai5_test.Run();
                return;
            }

            Console.WriteLine("=== CHUONG TRINH TINH TOAN DON THUC P(x) = a*x^n ");
            
            // 1. Nhập đơn thức
            DonThuc p = new DonThuc();
            p.Input();


            Console.WriteLine($"Don thuc vua nhap: P(x) = {p}");

            // 2. Câu (a): Tính giá trị P(x) với x cho trước
            double x = Mylib.Input.ReadDouble("\nNhap gia tri x de tinh P(x): ");
            double giaTri = p.TinhGiaTri(x);
            Console.WriteLine($"-> Gia tri P({x}) = {giaTri}");

            // 3. Câu (b): Tính đạo hàm
            DonThuc pDaoHam = p.DaoHam();
            Console.WriteLine($"-> Dao ham P'(x) = {pDaoHam}");

            Console.WriteLine("\nNhan phim bat ky de thoat...");
            Console.ReadKey();
        }
    }
}