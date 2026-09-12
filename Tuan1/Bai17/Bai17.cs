using System;
using System.Security.Cryptography.X509Certificates;


namespace Tuan1
{
    public class Bai17
    {   private int n,m;
        private int[,] mang;
        public void sinhngaunhien()
        {
            Console.WriteLine("nhap so hang n");
            n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("nhap so cot m");
            m = int.Parse(Console.ReadLine());
            mang = new int[n,m];
            Random rand = new Random();// Khởi tạo đối tượng sinh số ngẫu nhiên
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<m;j++)
                {
                    mang[i,j]=rand.Next(10,101);// Next(10, 101) sinh số ngẫu nhiên trong khoảng [10, 100]
                }
            }
        }
        public void xuatmang()
        {
            Console.WriteLine("mang ngau nhien vua tao la:");
             for(int i=0;i<n;i++)
            {
                for(int j=0;j<m;j++)
                {  
                   Console.Write(mang[i,j]+"\t");// \t giúp in ký tự Tab để các cột trong ma trận thẳng hàng
                }
                Console.WriteLine();
            }
        }
        public (int[] mangchan, int[] mangle) tachchangle() // Phương thức trả về một Tuple chứa 2 mảng: (mangchan, mangle)
        {   
            // Dùng List để gom các phần tử khi chưa biết trước số lượng
            List<int> dschan = new List<int>();
            List<int> dsle = new List<int>();
            for(int i=0 ;i<n;i++)
            {
                for(int j=0;j<m;j++)
                {
                    if(mang[i,j]%2==0)
                    {
                        dschan.Add(mang[i,j]);
                    }
                    else
                    {
                        dsle.Add(mang[i,j]);
                    }
                }
            }
            // Chuyển List thành mảng int[] rồi đóng gói vào Tuple để return
            return (dschan.ToArray(),dsle.ToArray());
        }
          public static void Run()
        {   
             Bai17 b17 = new Bai17();
             b17.sinhngaunhien();
             b17.xuatmang();
             (int[] chan , int[] le)=b17.tachchangle();
              Console.Write("mang cac so chan la:");
             foreach(int x in chan)
             Console.Write(x+" ");
             Console.WriteLine();
             Console.Write("mang cac so le la:");
             foreach(int x in le)
             Console.Write(x+" ");
        }
    }
}