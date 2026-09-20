using System;

namespace Bai4
{
    public class PhanSo
    {
        private int tuSo; 
        private int mauSo;

        public int TuSo
        {
            get { return tuSo; }
            set { tuSo = value; }
        }

        public int MauSo
        {
            get { return mauSo; }
            set
            {
                if (value == 0)
                    throw new Exception("Mau so bang 0!");
                mauSo = value;
            }
        }

        // --- CONSTRUCTORS ---
        public PhanSo() // Mac dinh 0/1
        {
            this.tuSo = 0;
            this.mauSo = 1;
        }

        public PhanSo(int n) // Tu so nguyen n
        {
            this.tuSo = n;
            this.mauSo = 1;
        }

        public PhanSo(int tu, int mau) // Tu tu va mau
        {
            if (mau == 0)
                throw new Exception("Mau so bang 0!");
            this.tuSo = tu;
            this.mauSo = mau;
            this.rutGon();
        }

        public PhanSo(PhanSo p) // Sao chep
        {
            if (p != null)
            {
                this.tuSo = p.tuSo;
                this.mauSo = p.mauSo;
            }
        }

        // --- TOSTRING ---
        public override string ToString()
        {
            if (this.mauSo == 1)
                return string.Format("[{0}]", this.tuSo);
            if (this.tuSo == 0)
                return "[0]";
            return string.Format("[{0}/{1}]", this.tuSo, this.mauSo);
        }

        // --- HAM RUT GON & UCLN ---
        public void rutGon()
        {
            int uc = PhanSo.uocSoChungLonNhat(this.tuSo, this.mauSo);
            this.tuSo = this.tuSo / uc;
            this.mauSo = this.mauSo / uc;

            if (this.mauSo < 0)
            {
                this.tuSo = -this.tuSo;
                this.mauSo = -this.mauSo;
            }
        }

        private static int uocSoChungLonNhat(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int tmp = a;
                a = b;
                b = tmp % a;
            }
            return a;
        }

        // --- TOAN TU 1 NGOI (+, -) ---
        public static PhanSo operator +(PhanSo a) => new PhanSo(a);
        public static PhanSo operator -(PhanSo a) => new PhanSo(-a.tuSo, a.mauSo);

        // --- TOAN TU 2 NGOI (+, -, *, /) ---
        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.tuSo * b.mauSo + a.mauSo * b.tuSo, a.mauSo * b.mauSo);
        }

        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.tuSo * b.mauSo - a.mauSo * b.tuSo, a.mauSo * b.mauSo);
        }

        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.tuSo * b.tuSo, a.mauSo * b.mauSo);
        }

        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            if (b.tuSo == 0) throw new Exception("Khong the chia cho 0!");
            return new PhanSo(a.tuSo * b.mauSo, a.mauSo * b.tuSo);
        }

        // --- TOAN TU SO SANH (>, <, >=, <=, ==, !=) ---
        public static bool operator >(PhanSo a, PhanSo b) => (a.tuSo * b.mauSo) > (b.tuSo * a.mauSo);
        public static bool operator <(PhanSo a, PhanSo b) => (a.tuSo * b.mauSo) < (b.tuSo * a.mauSo);
        public static bool operator >=(PhanSo a, PhanSo b) => (a.tuSo * b.mauSo) >= (b.tuSo * a.mauSo);
        public static bool operator <=(PhanSo a, PhanSo b) => (a.tuSo * b.mauSo) <= (b.tuSo * a.mauSo);

        public static bool operator ==(PhanSo a, PhanSo b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;
            return (a.tuSo * b.mauSo) == (b.tuSo * a.mauSo);
        }

        public static bool operator !=(PhanSo a, PhanSo b) => !(a == b);

        public override bool Equals(object obj)
        {
            if (obj is PhanSo p) return this == p;
            return false;
        }

        public override int GetHashCode() => HashCode.Combine(tuSo, mauSo);
        public static void Main(string[] args)
        {
            if (args.Length > 0 && (args[0] == "--test" || args[0] == "test"))
            {
                Bai4_test.Run();
                return;
            }

            // 1. Nhap Phan So A
            Console.WriteLine("\n-- Nhap Phan So A --");
            Console.Write("Nhap tu so A: ");
            int tuA = int.Parse(Console.ReadLine());
            
            int mauA;
            do
            {
                Console.Write("Nhap mau so A (khac 0): ");
                mauA = int.Parse(Console.ReadLine());
                if (mauA == 0) Console.WriteLine("Mau so phai khac 0! Vui long nhap lai.");
            } while (mauA == 0);

            PhanSo a = new PhanSo(tuA, mauA);

            // 2. Nhap Phan So B
            Console.WriteLine("\n-- Nhap Phan So B --");
            Console.Write("Nhap tu so B: ");
            int tuB = int.Parse(Console.ReadLine());

            int mauB;
            do
            {
                Console.Write("Nhap mau so B (khac 0): ");
                mauB = int.Parse(Console.ReadLine());
                if (mauB == 0) Console.WriteLine("Mau so phai khac 0! Vui long nhap lai.");
            } while (mauB == 0);

            PhanSo b = new PhanSo(tuB, mauB);

            // 3. Xuat hai phan so da duoc toi gian
            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine($"Phan so A vua nhap (da toi gian): {a}");
            Console.WriteLine($"Phan so B vua nhap (da toi gian): {b}");

            // 4. Thuc hien cac phep tinh 2 ngoi
            Console.WriteLine("\n-- KET QUA PHEP TINH --");
            Console.WriteLine($"A + B = {a + b}");
            Console.WriteLine($"A - B = {a - b}");
            Console.WriteLine($"A * B = {a * b}");

            if (b.TuSo != 0)
            {
                Console.WriteLine($"A / B = {a / b}");
            }
            else
            {
                Console.WriteLine("A / B = Khong the chia vi tu so cua B bang 0!");
            }

            // 5. Thuc hien so sanh
            Console.WriteLine("\n-- KET QUA SO SANH --");
            if (a == b)
                Console.WriteLine("Phan so A BANG Phan so B (A == B)");
            else if (a > b)
                Console.WriteLine("Phan so A LON HON Phan so B (A > B)");
            else
                Console.WriteLine("Phan so A NHO HON Phan so B (A < B)");

            Console.WriteLine("\nNhan phim bat ky de thoat...");
            Console.ReadKey();
        }

    }
}