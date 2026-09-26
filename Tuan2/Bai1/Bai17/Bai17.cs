using System;
using System.Collections.Generic;

namespace BaiTap3_5
{
    
    // 1. LỚP TRỪU TƯỢNG NHÂN VIÊN (LỚP CHA)
   
    public abstract class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }

        public NhanVien()
        {
            MaNV = string.Empty;
            HoTen = string.Empty;
        }

        public NhanVien(string maNV, string hoTen)
        {
            MaNV = maNV;
            HoTen = hoTen;
        }

        // Phương thức trừu tượng tính lương (Đa hình)
        public abstract double TinhLuong();

        // Nhập thông tin chung
        public virtual void Nhap()
        {
            Console.Write("  + Nhap ma nhan vien: ");
            MaNV = Console.ReadLine();
            Console.Write("  + Nhap ho ten nhan vien: ");
            HoTen = Console.ReadLine();
        }

        // Xuất thông tin chung
        public virtual void Xuat()
        {
            Console.Write($"{MaNV} | {HoTen} | ");
        }
    }

   
    // 2. LỚP NHÂN VIÊN KINH DOANH (LỚP CON)
   
    public class NhanVienKinhDoanh : NhanVien
    {
        public double LuongCoBan { get; set; }
        public int SoHopDong { get; set; }

        public NhanVienKinhDoanh() : base() { }

        public NhanVienKinhDoanh(string maNV, string hoTen, double luongCoBan, int soHopDong) 
            : base(maNV, hoTen)
        {
            LuongCoBan = luongCoBan;
            SoHopDong = soHopDong;
        }

        // Công thức: Lương cơ bản + (Số hợp đồng * 500.000)
        public override double TinhLuong()
        {
            return LuongCoBan + (SoHopDong * 500000);
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("  + Nhap luong co ban: ");
            LuongCoBan = double.Parse(Console.ReadLine());
            Console.Write("  + Nhap so hop dong da ky: ");
            SoHopDong = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Kinh Doanh | HD: {SoHopDong,3} | Luong: {TinhLuong(),15:N0} VNĐ");
        }
    }

   
    // 3. LỚP NHÂN VIÊN SẢN XUẤT (LỚP CON)
   
    public class NhanVienSanXuat : NhanVien
    {
        public int SoSanPham { get; set; }

        public NhanVienSanXuat() : base() { }

        public NhanVienSanXuat(string maNV, string hoTen, int soSanPham) 
            : base(maNV, hoTen)
        {
            SoSanPham = soSanPham;
        }

        // Công thức: Số SP * 1.000. Nếu SP > 3000 thì thưởng thêm 5% lương (x 1.05)
        public override double TinhLuong()
        {
            double luong = SoSanPham * 1000;
            if (SoSanPham > 3000)
            {
                luong *= 1.05; // Thưởng thêm 5%
            }
            return luong;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("  + Nhap so luong san pham: ");
            SoSanPham = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"San Xuat   | SP: {SoSanPham} | Luong: {TinhLuong()} VNĐ");
        }
    }

   
   
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Danh sách đa hình chứa cả 2 loại nhân viên
            List<NhanVien> dsNhanVien = new List<NhanVien>();

            // Dữ liệu mẫu khởi tạo sẵn
            dsNhanVien.Add(new NhanVienKinhDoanh("KD01", "Nguyen Van A", 7000000, 5));
            dsNhanVien.Add(new NhanVienKinhDoanh("KD02", "Tran Thi B", 8000000, 2));
            dsNhanVien.Add(new NhanVienSanXuat("SX01", "Le Van C", 2500));
            dsNhanVien.Add(new NhanVienSanXuat("SX02", "Pham Van D", 3500)); // Thỏa điều kiện thưởng 5%

            bool tiepTuc = true;
            while (tiepTuc)
            {
                Console.WriteLine("\n================ QUẢN LÝ LƯƠNG NHÂN VIÊN ================");
                Console.WriteLine("1. Nhập thêm Nhân viên Kinh doanh");
                Console.WriteLine("2. Nhập thêm Nhân viên Sản xuất");
                Console.WriteLine("3. Xuất danh sách và bảng lương nhân viên");
                Console.WriteLine("4. Tính tổng lương công ty phải trả");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("=========================================================");

                Console.Write("Nhập lựa chọn của bạn: ");
                string chon = Console.ReadLine();

                switch (chon)
                {
                    case "1":
                        Console.WriteLine("\n--- NHẬP NHÂN VIÊN KINH DOANH ---");
                        NhanVien nvKD = new NhanVienKinhDoanh();
                        nvKD.Nhap();
                        dsNhanVien.Add(nvKD);
                        Console.WriteLine("Thêm thành công!");
                        break;

                    case "2":
                        Console.WriteLine("\n--- NHẬP NHÂN VIÊN SẢN XUẤT ---");
                        NhanVien nvSX = new NhanVienSanXuat();
                        nvSX.Nhap();
                        dsNhanVien.Add(nvSX);
                        Console.WriteLine("Thêm thành công!");
                        break;

                    case "3":
                        Console.WriteLine("\n--- DANH SÁCH BẢNG LƯƠNG NHÂN VIÊN ---");
                        Console.WriteLine(new string("-"));
                        foreach (var nv in dsNhanVien)
                        {
                            nv.Xuat();
                        }
                        Console.WriteLine(new string("-"));
                        break;

                    case "4":
                        double tongLuong = 0;
                        foreach (var nv in dsNhanVien)
                        {
                            tongLuong += nv.TinhLuong(); // Đa hình tự gọi hàm TinhLuong() tương ứng
                        }
                        Console.WriteLine($"\n==> TỔNG LƯƠNG CÔNG TY PHẢI TRẢ: {tongLuong:N0} VNĐ");
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