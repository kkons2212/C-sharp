using System;
using System.Collections; 
using Bai2;
using Mylib;

namespace Bai6
{
    public class ArrayPoint
    {
        // Field: Sử dụng ArrayList để lưu danh sách các Point
        private ArrayList points;

        // Constructor mặc định
        public ArrayPoint()
        {
            points = new ArrayList();
        }

        // Constructor khởi tạo trước sức chứa (capacity)
        public ArrayPoint(int capacity)
        {
            points = new ArrayList(capacity);
        }

        // Property trả về số lượng điểm hiện có trong danh sách
        public int Count
        {
            get => points.Count;
        }

       
        // INDEXER: Cho phép truy cập phần tử thứ i dạng arr[i]
       
        public Point this[int index]
        {
            get
            {
                if (index < 0 || index >= points.Count)
                {
                    throw new IndexOutOfRangeException("Chỉ số phần tử nằm ngoài phạm vi danh sách!");
                }
                // Vì ArrayList lưu kiểu object nên phải ép kiểu về (Point)
                return (Point)points[index];
            }
            set
            {
                if (index < 0 || index >= points.Count)
                {
                    throw new IndexOutOfRangeException("Chỉ số phần tử nằm ngoài phạm vi danh sách!");
                }
                points[index] = value;
            }
        }

       
        // CÁC PHƯƠNG THỨC THAO TÁC BỔ SUNG
        
        // Thêm 1 Point vào danh sách
        public void Add(Point p)
        {
            points.Add(p);
        }

        // Nhập danh sách các Point từ bàn phím
        public void Input()
        {
            int n = Mylib.Input.ReadInt("Nhap so luong diem: ");
            points.Clear();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n[Nhap diem thu {i + 1}]");
                Point p = new Point();
                p.Input(); // Dùng phương thức Input() của Bai2.Point
                points.Add(p);
            }
        }

        // In danh sách các Point ra màn hình
        public void Output()
        {
            for (int i = 0; i < points.Count; i++)
            {
                // Tự động gọi phương thức ToString() của Bai2.Point
                Console.WriteLine($"Diem [{i}]: {points[i]}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("=== THIẾT KẾ & KIỂM THỬ LỚP ARRAYPOINT (BÀI 6) ===");

            ArrayPoint list = new ArrayPoint();

            // 1. Nhập danh sách các điểm
            list.Input();

            // 2. Xuất danh sách các điểm vừa nhập
            Console.WriteLine("\n---------------------------------");
            Console.WriteLine("Danh sách các điểm:");
            list.Output();

            // 3. Minh họa tính năng của Indexer
            if (list.Count > 0)
            {
                Console.WriteLine("\n---------------------------------");
                // Lấy phần tử qua Indexer (Getter)
                Point p0 = list[0]; 
                Console.WriteLine($"Lấy điểm đầu tiên thông qua Indexer list[0]: {p0}");

                // Đổi giá trị phần tử qua Indexer (Setter)
                list[0] = new Point(100, 200);
                Console.WriteLine($"Đã đổi list[0] thành (100, 200). Giá trị mới: {list[0]}");
            }
        }
    }
}