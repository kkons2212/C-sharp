using System;
using Mylib;

namespace Bai10
{
    public class DaThuc
    {
        private int n;       // Bậc của đa thức
        private double[] a;  // Mảng chứa n + 1 hệ số (a[0], a[1], ..., a[n])

        // ==========================================
        // a. CÁC LOẠI CONSTRUCTOR
        // ==========================================

        // 1. Constructor mặc định (đa thức bậc 0)
        public DaThuc()
        {
            this.n = 0;
            this.a = new double[1];
        }

        // 2. Constructor khởi tạo với bậc n
        public DaThuc(int n)
        {
            this.n = n >= 0 ? n : 0;
            this.a = new double[this.n + 1];
        }

        // 3. Constructor khởi tạo từ mảng hệ số và bậc n
        public DaThuc(double[] heSo, int n)
        {
            this.n = n >= 0 ? n : 0;
            this.a = new double[this.n + 1];
            for (int i = 0; i <= this.n; i++)
            {
                if (i < heSo.Length)
                {
                    this.a[i] = heSo[i];
                }
            }
        }

        // 4. Copy Constructor
        public DaThuc(DaThuc other)
        {
            if (other != null)
            {
                this.n = other.n;
                this.a = new double[this.n + 1];
                Array.Copy(other.a, this.a, this.n + 1);
            }
        }

        // ==========================================
        // b. INDEXER TRUY CẬP ĐƠN THỨC THỨ i (a[i])
        // ==========================================
        public double this[int i]
        {
            get
            {
                if (i < 0 || i > n)
                {
                    throw new IndexOutOfRangeException($"Chi so i = {i} khong hop le! Bac cua da thuc la {n}.");
                }
                return a[i];
            }
            set
            {
                if (i < 0 || i > n)
                {
                    throw new IndexOutOfRangeException($"Chi so i = {i} khong hop le! Bac cua da thuc la {n}.");
                }
                a[i] = value;
            }
        }

        // ==========================================
        // c. PHƯƠNG THỨC NHẬP / XUẤT
        // ==========================================

        // Nhập bậc n và danh sách các hệ số
        public void Nhap()
        {
            do
            {
                n = Input.ReadInt("Nhap bac cua da thuc (n >= 0): ");
                if (n < 0)
                {
                    Console.WriteLine("Loi: Bac da thuc phai lon hon hoac bang 0!");
                }
            } while (n < 0);

            a = new double[n + 1];

            Console.WriteLine($"\nNhap cac he so cho da thuc P(x) = a0 + a1*x + ... + a{n}*x^{n}:");
            for (int i = 0; i <= n; i++)
            {
                a[i] = Input.ReadDouble($"Nhap he so a[{i}]: ");
            }
        }

        // In đa thức ra dạng toán học P(x) = a0 + a1.x^1 + a2.x^2 + ... + an.x^n
        public void Xuat()
        {
            if (a == null || a.Length == 0)
            {
                Console.WriteLine("Da thuc rong!");
                return;
            }

            Console.Write("P(x) = ");
            bool isFirst = true;

            for (int i = 0; i <= n; i++)
            {
                if (a[i] == 0 && n > 0) continue; // Bỏ qua hệ số 0 trừ khi đa thức chỉ là bậc 0

                // Xử lý dấu (+) giữa các đơn thức
                if (!isFirst)
                {
                    if (a[i] > 0) Console.Write(" + ");
                    else Console.Write(" - ");
                }
                else if (a[i] < 0)
                {
                    Console.Write("-");
                }

                double val = Math.Abs(a[i]);

                // In hệ số và biến x^i
                if (i == 0)
                {
                    Console.Write($"{val}");
                }
                else if (i == 1)
                {
                    Console.Write(val == 1 ? "x" : $"{val}.x");
                }
                else
                {
                    Console.Write(val == 1 ? $"x^{i}" : $"{val}.x^{i}");
                }

                isFirst = false;
            }

            if (isFirst) // Nếu tất cả hệ số đều bằng 0
            {
                Console.Write("0");
            }

            Console.WriteLine();
        }

        // ==========================================
        // d. TÍNH GIÁ TRỊ CỦA ĐA THỨC VỚI x
        // ==========================================
        public double TinhGiaTri(double x)
        {
            double result = 0;
            for (int i = 0; i <= n; i++)
            {
                result += a[i] * Math.Pow(x, i);
            }
            return result;
        }
        static void Main(string[] args)
        {
            DaThuc P = new DaThuc();
            bool tiepTuc = true;

            while (tiepTuc)
            {
                Console.WriteLine("\n================ MENU CHUONG TRINH DA THUC ================");
                Console.WriteLine("1. Nhap da thuc P(x)");
                Console.WriteLine("2. Xuat da thuc P(x)");
                Console.WriteLine("3. Truy cap / Thay doi he so a[i] qua Indexer");
                Console.WriteLine("4. Tinh gia tri P(x) voi x nhap tu ban phim");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("==========================================================");

                int chon = Input.ReadInt("Nhap lua chon cua ban: ");

                switch (chon)
                {
                    case 1:
                        Console.WriteLine("\n--- NHAP DA THUC ---");
                        P.Nhap();
                        break;

                    case 2:
                        Console.WriteLine("\n--- XUAT DA THUC ---");
                        P.Xuat();
                        break;

                    case 3:
                        Console.WriteLine("\n--- INDEXER HE SO a[i] ---");
                        int i = Input.ReadInt("Nhap so mu i (0 <= i <= n) can thao tac: ");
                        try
                        {
                            Console.WriteLine($"He so hien tai a[{i}] = {P[i]}");
                            string ans = Input.ReadString("Ban co muon sua he so nay? (y/n): ");
                            if (ans.ToLower() == "y")
                            {
                                double val = Input.ReadDouble("Nhap he so moi: ");
                                P[i] = val;
                                Console.WriteLine("Cap nhat thanh cong!");
                            }
                        }
                        catch (IndexOutOfRangeException ex)
                        {
                            Console.WriteLine($"Loi: {ex.Message}");
                        }
                        break;

                    case 4:
                        Console.WriteLine("\n--- TINH GIA TRI DA THUC ---");
                        double x = Input.ReadDouble("Nhap gia tri x = ");
                        double res = P.TinhGiaTri(x);
                        Console.Write("Kieu bieu thuc: ");
                        P.Xuat();
                        Console.WriteLine($"Gia tri cua P({x}) = {res}");
                        break;

                    case 0:
                        tiepTuc = false;
                        Console.WriteLine("Da thoat chuong trinh.");
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le, vui long nhap lai!");
                        break;
                }
            }
        }
    }
}