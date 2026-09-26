using System;
using Mylib;

namespace Bai8
{
    public class Mangmotchieu
    {
        private int[] dayso;
        private int n;
        public Mangmotchieu()
        {   this.n=0;
            this.dayso = new int[0];
        }
        public Mangmotchieu( int n)
        {
            this.n = n;
            this.dayso = new int[this.n];
        }
        public Mangmotchieu(int[] dayso, int n)
        {
            this.n = n;
            this.dayso = new int[n];
            Array.Copy(dayso, this.dayso, n);
        }
        public Mangmotchieu(Mangmotchieu other)
        {
            if(other != null)
            {
                this.n = other.n;
                this.dayso = new int[this.n];
                Array.Copy(other.dayso,this.dayso,this.n);
            }
        }
        public int this[int index]
        {
            get
            {
                if(index <0 || index >= dayso.Count())
                {
                    throw new IndexOutOfRangeException("chi so phan tu nam ngoai pham vi day so");
                }
                return dayso[index];
            }
            set
            {
                 if(index <0 || index >= dayso.Length)
                {
                    throw new IndexOutOfRangeException("chi so phan tu nam ngoai pham vi day so");
                }
                 dayso[index]= value;
            }
        }
        public void nhap()
        {
             n = Input.ReadInt("nhap tong so phan tu trong mang");
            dayso = new int[n];
            for(int i =0;i<dayso.Length;i++)
            {
                
                dayso[i]= Input.ReadInt($"Nhap phan tu thu {i+1}:");
            }
        }
        public void xuat()
        {
            for (int i=0 ;i<dayso.Length;i++)
            {
                Console.Write(dayso[i]+" ");
            }
            Console.WriteLine();
        }
        public Mangmotchieu timsochan ()
        {   int tam=0;
            for(int i=0;i<dayso.Length;i++)
            {
                if(dayso[i]%2==0)
                {
                    tam++;
                }
            }
            int[] mangtam = new int[tam];
            int k =0;
            for(int i=0;i<dayso.Length;i++)
            {
                if(dayso[i]%2==0)
                {
                    mangtam[k]=dayso[i];
                    k++;
                }
            }
            return new Mangmotchieu(mangtam,tam);

        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("=== CHUONG TRINH QUAN LY MANG 1 CHIEU ===");

            // 1. Kiểm tra Constructor không tham số & Phương thức Nhập/Xuất
            Console.WriteLine("\n--- 1. NHAP VA XUAT MANG ---");
            Mangmotchieu ds = new Mangmotchieu();
            ds.nhap();

            Console.WriteLine("\nDay so vua nhap la:");
            ds.xuat();

            // 2. Kiểm tra Indexer (Đọc và Ghi)
            Console.WriteLine("\n--- 2. KIEM TRA INDEXER ---");
            try
            {
                // Đọc phần tử đầu tiên bằng Indexer
                Console.WriteLine($"Phan tu dau tien (ds[0]): {ds[0]}");

                // Sửa phần tử đầu tiên thành 99
                Console.WriteLine("-> Gan ds[0] = 99 qua Indexer...");
                ds[0] = 99;

                Console.WriteLine("Day so sau khi sua phan tu dau tiên:");
                ds.xuat();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Loi: {ex.Message}");
            }

            // 3. Kiểm tra Tìm Số Chẵn
            Console.WriteLine("\n--- 3. TIM CAC SO CHAN ---");
            Mangmotchieu dsChan = ds.timsochan();
            Console.WriteLine("Dach sach cac so chan trong mang:");
            dsChan.xuat();

            // 4. Kiểm tra Copy Constructor
            Console.WriteLine("\n--- 4. KIEM TRA COPY CONSTRUCTOR ---");
            Mangmotchieu dsSaoChep = new Mangmotchieu(ds);
            Console.WriteLine("Day so duoc sao chep bang Copy Constructor:");
            dsSaoChep.xuat();

            Console.WriteLine("\nBam pham bat ky de ket thuc...");
            Console.ReadKey();
        }
    }
}