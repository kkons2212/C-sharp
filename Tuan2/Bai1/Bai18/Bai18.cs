using System;
using System.Collections.Generic;

namespace BaiTap3_6
{
   
    // 1. LỚP TRỪU TƯỢNG THÍ SINH (LỚP CHA)
   
    public abstract class ThiSinh
    {
        public string SBD { get; set; }
        public string HoTen { get; set; }
        public double Bai1 { get; set; }
        public double Bai2 { get; set; }
        public double Bai3 { get; set; }

        public ThiSinh()
        {
            SBD = string.Empty;
            HoTen = string.Empty;
            Bai1 = Bai2 = Bai3 = 0;
        }

        public ThiSinh(string sbd, string hoTen, double b1, double b2, double b3)
        {
            SBD = sbd;
            HoTen = hoTen;
            Bai1 = b1;
            Bai2 = b2;
            Bai3 = b3;
        }

        // Phương thức trừu tượng tính tổng điểm (Đa hình)
        public abstract double TinhTongDiem();

        // Nhập thông tin chung
        public virtual void Nhap()
        {
            Console.Write("  + Nhap So bao danh: ");
            SBD = Console.ReadLine();
            Console.Write("  + Nhap Ho va ten: ");
            HoTen = Console.ReadLine();
            Console.Write("  + Nhap diem Bai 1: ");
            Bai1 = double.Parse(Console.ReadLine());
            Console.Write("  + Nhap diem Bai 2: ");
            Bai2 = double.Parse(Console.ReadLine());
            Console.Write("  + Nhap diem Bai 3: ");
            Bai3 = double.Parse(Console.ReadLine());
        }

        // Xuất thông tin chung
        public virtual void Xuat()
        {
            Console.Write($"{SBD,-8} | {HoTen,-20} | {Bai1,5:F1} | {Bai2,5:F1} | {Bai3,5:F1} | ");
        }
    }

   
    // 2. LỚP THÍ SINH CHUYÊN (LỚP CON)
   
    public class ThiSinhChuyen : ThiSinh
    {
        public double TiengAnh { get; set; }

        public ThiSinhChuyen() : base() { }

        public ThiSinhChuyen(string sbd, string hoTen, double b1, double b2, double b3, double tiengAnh)
            : base(sbd, hoTen, b1, b2, b3)
        {
            TiengAnh = tiengAnh;
        }

        // Tính tổng điểm + Điểm thưởng Tiếng Anh
        public override double TinhTongDiem()
        {
            double diemBonus = 0;
            if (TiengAnh >= 7 && TiengAnh <= 8)
            {
                diemBonus = 1;
            }
            else if (TiengAnh >= 9 && TiengAnh <= 10)
            {
                diemBonus = 2;
            }

            return Bai1 + Bai2 + Bai3 + diemBonus;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("  + Nhap diem Tieng Anh (0 - 10): ");
            TiengAnh = double.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Khối Chuyên   | Anh: {TiengAnh} | Tong diem: {TinhTongDiem()}");
        }
    }

   
    // 3. LỚP THÍ SINH SIÊU CÚP (LỚP CON)
   
    public class ThiSinhSieuCup : ThiSinh
    {
        public double CSDL { get; set; }

        public ThiSinhSieuCup() : base() { }

        public ThiSinhSieuCup(string sbd, string hoTen, double b1, double b2, double b3, double csdl)
            : base(sbd, hoTen, b1, b2, b3)
        {
            CSDL = csdl;
        }

        // Tính tổng điểm của cả 4 bài thi
        public override double TinhTongDiem()
        {
            return Bai1 + Bai2 + Bai3 + CSDL;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("  + Nhap diem CSDL: ");
            CSDL = double.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Khối Siêu Cúp | CSDL: {CSDL} | Tong diem: {TinhTongDiem()}");
        }
    }

   
    // 4. LỚP QUẢN LÝ CUỘC THI VÀ CHẠY THỬ (MAIN)
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Danh sách đa hình chứa toàn bộ thí sinh cuộc thi
            List<ThiSinh> dsThiSinh = new List<ThiSinh>();

            // Dữ liệu thử nghiệm khởi tạo sẵn
            dsThiSinh.Add(new ThiSinhChuyen("C01", "Nguyen Van An", 8.5, 9.0, 7.5, 8.5)); // Anh 8.5 -> +1d
            dsThiSinh.Add(new ThiSinhChuyen("C02", "Tran Thi Binh", 7.0, 8.0, 6.5, 9.5)); // Anh 9.5 -> +2d
            dsThiSinh.Add(new ThiSinhSieuCup("SC01", "Le Hoang Cuong", 10.0, 9.5, 9.0, 8.5));

            bool tiepTuc = true;
            while (tiepTuc)
            {
                Console.WriteLine("\n================ QUẢN LÝ CUỘC THI TIN HỌC ================");
                Console.WriteLine("1. Nhập thí sinh khối Chuyên");
                Console.WriteLine("2. Nhập thí sinh khối Siêu Cúp");
                Console.WriteLine("3. Xuất danh sách kết quả tổng điểm các thí sinh");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("==========================================================");

                Console.Write("Nhập lựa chọn của bạn: ");
                string chon = Console.ReadLine();

                switch (chon)
                {
                    case "1":
                        Console.WriteLine("\n--- NHẬP THÍ SINH KHỐI CHUYÊN ---");
                        ThiSinh tsChuyen = new ThiSinhChuyen();
                        tsChuyen.Nhap();
                        dsThiSinh.Add(tsChuyen);
                        Console.WriteLine("Thêm thành công!");
                        break;

                    case "2":
                        Console.WriteLine("\n--- NHẬP THÍ SINH KHỐI SIÊU CÚP ---");
                        ThiSinh tsSieuCup = new ThiSinhSieuCup();
                        tsSieuCup.Nhap();
                        dsThiSinh.Add(tsSieuCup);
                        Console.WriteLine("Thêm thành công!");
                        break;

                    case "3":
                        Console.WriteLine("\n--- BẢNG KẾT QUẢ TỔNG ĐIỂM THI SĨ ---");
                        Console.WriteLine(new string("-"));
                        Console.WriteLine($"{"SBD"} | {"HỌ TÊN"} | {"BÀI 1"} | {"BÀI 2"} | {"BÀI 3"} | {"ĐỐI TƯỢNG"} | {"ĐIỂM RIÊNG"} | {"TỔNG ĐIỂM"}");
                        Console.WriteLine(new string("-"));

                        foreach (var ts in dsThiSinh)
                        {
                            ts.Xuat(); // Thể hiện tính Đa hình
                        }
                        Console.WriteLine(new string("-"));
                        break;

                    case "0":
                        tiepTuc = false;
                        Console.WriteLine("Đã thoát chương trình!");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }
        }
    }
}