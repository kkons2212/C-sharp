using System;
using Mylib;
using Bai8;
namespace Bai9
{
    public class Manghaichieu
    {
        private int[,] a;
        private int soDong;
        private int soCot;

        // ==========================================
        // a. CÁC LOẠI CONSTRUCTOR
        // ==========================================

        // 1. Constructor mặc định
        public Manghaichieu()
        {
            this.soDong = 0;
            this.soCot = 0;
            this.a = new int[0, 0];
        }

        // 2. Constructor khởi tạo với số dòng n và số cột m
        public Manghaichieu(int n, int m)
        {
            this.soDong = n > 0 ? n : 0;
            this.soCot = m > 0 ? m : 0;
            this.a = new int[this.soDong, this.soCot];
        }

        // 3. Constructor khởi tạo từ một mảng 2 chiều có sẵn
        public Manghaichieu(int[,] maTran, int n, int m)
        {
            this.soDong = n;
            this.soCot = m;
            this.a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    this.a[i, j] = maTran[i, j];
                }
            }
        }

        // 4. Copy Constructor (Sao chép sâu)
        public Manghaichieu(Manghaichieu other)
        {
            if (other != null)
            {
                this.soDong = other.soDong;
                this.soCot = other.soCot;
                this.a = new int[this.soDong, this.soCot];
                for (int i = 0; i < this.soDong; i++)
                {
                    for (int j = 0; j < this.soCot; j++)
                    {
                        this.a[i, j] = other.a[i, j];
                    }
                }
            }
        }

        // ==========================================
        // b. INDEXER TRUY CẬP PHẦN TỬ TẠI (i, j)
        // ==========================================
        public int this[int i, int j]
        {
            get
            {
                if (i < 0 || i >= soDong || j < 0 || j >= soCot)
                {
                    throw new IndexOutOfRangeException("Chi so (i, j) vuot qua pham vi cua mang 2 chieu!");
                }
                return a[i, j];
            }
            set
            {
                if (i < 0 || i >= soDong || j < 0 || j >= soCot)
                {
                    throw new IndexOutOfRangeException("Chi so (i, j) vuot qua pham vi cua mang 2 chieu!");
                }
                a[i, j] = value;
            }
        }

        // ==========================================
        // c. PHƯƠNG THỨC NHẬP / XUẤT
        // ==========================================
        public void nhap()
        {
            do
            {
                soDong = Input.ReadInt("Nhap so dong (n > 0): ");
                if (soDong <= 0) Console.WriteLine("Loi: So dong phai lon hon 0!");
            } while (soDong <= 0);

            do
            {
                soCot = Input.ReadInt("Nhap so cot (m > 0): ");
                if (soCot <= 0) Console.WriteLine("Loi: So cot phai lon hon 0!");
            } while (soCot <= 0);

            a = new int[soDong, soCot];

            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    a[i, j] = Input.ReadInt($"Nhap a[{i},{j}]: ");
                }
            }
        }

        public void xuat()
        {
            if (a == null || soDong == 0 || soCot == 0)
            {
                Console.WriteLine("Mang 2 chieu dang rong!");
                return;
            }

            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    Console.Write($"{a[i, j],6}"); // Can le 6 khoang trang cho dep
                }
                Console.WriteLine(); // Xuong dong khi het 1 hang
            }
        }

        // ==========================================
        // d. TÌM CÁC SỐ NGUYÊN TỐ TRONG MẢNG 2 CHIỀU
        // ==========================================

        // Hàm phụ kiểm tra số nguyên tố
        private bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        // Trả về một đối tượng Mangmotchieu (hoặc in trực tiếp) chứa các SNT tìm được
        public Mangmotchieu timSoNguyenTo()
        {
            // Bước 1: Đếm số lượng SNT
            int dem = 0;
            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    if (IsPrime(a[i, j]))
                    {
                        dem++;
                    }
                }
            }

            // Bước 2: Trích xuất các SNT vào mảng 1 chiều tạm
            int[] temp = new int[dem];
            int k = 0;
            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    if (IsPrime(a[i, j]))
                    {
                        temp[k] = a[i, j];
                        k++;
                    }
                }
            }

            // Bước 3: Trả về đối tượng Mangmotchieu từ bài trước
            return new Mangmotchieu(temp, dem);
        }
        static void Main(string[] args)
        {
            Manghaichieu matrix = new Manghaichieu();
            bool tiepTuc = true;

            while (tiepTuc)
            {
                Console.WriteLine("\n================ MENU MANG 2 CHIEU ================");
                Console.WriteLine("1. Nhap mang 2 chieu (n x m)");
                Console.WriteLine("2. Xuat mang 2 chieu");
                Console.WriteLine("3. Truy cap / Thay doi phan tu tai (i, j) qua Indexer");
                Console.WriteLine("4. Tim va xuat cac so nguyen to (tra ve Mangmotchieu)");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("==================================================");

                int chon = Input.ReadInt("Nhap lua chon cua ban: ");

                switch (chon)
                {
                    case 1:
                        Console.WriteLine("\n--- NHAP MANG 2 CHIEU ---");
                        matrix.nhap();
                        break;

                    case 2:
                        Console.WriteLine("\n--- MANG 2 CHIEU HIEN TAI ---");
                        matrix.xuat();
                        break;

                    case 3:
                        Console.WriteLine("\n--- TRUY CAP INDEXER (i, j) ---");
                        int i = Input.ReadInt("Nhap chi so dong i: ");
                        int j = Input.ReadInt("Nhap chi so cot j: ");
                        try
                        {
                            Console.WriteLine($"Gia tri hien tai matrix[{i},{j}] = {matrix[i, j]}");
                            string ans = Input.ReadString("Ban co muon sua gia tri nay? (y/n): ");
                            if (ans.ToLower() == "y")
                            {
                                int val = Input.ReadInt("Nhap gia tri moi: ");
                                matrix[i, j] = val;
                                Console.WriteLine("Cap nhat thanh cong!");
                            }
                        }
                        catch (IndexOutOfRangeException ex)
                        {
                            Console.WriteLine($"Loi: {ex.Message}");
                        }
                        break;

                    case 4:
                        Console.WriteLine("\n--- TRICH XUAT SO NGUYEN TO (MANG 1 CHIEU) ---");
                        // Gọi phương thức timSoNguyenTo() trả về đối tượng Mangmotchieu
                        Mangmotchieu dsSNT = matrix.timSoNguyenTo();
                        
                        Console.Write("Ket qua: ");
                        dsSNT.xuat(); // Gọi phương thức xuat() của lớp Mangmotchieu thuộc Bai8
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