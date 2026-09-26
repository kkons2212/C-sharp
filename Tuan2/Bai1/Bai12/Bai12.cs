using System;
using Mylib;

namespace Bai12
{
    // ==========================================
    // LỚP NHÂN VIÊN
    // ==========================================
    public class NhanVien
    {
        public string HoTen { get; set; }
        public double MucLuong { get; set; }
        public int SoNgayVang { get; set; }

        // Constructor
        public NhanVien()
        {
            HoTen = string.Empty;
            MucLuong = 0;
            SoNgayVang = 0;
        }

        public NhanVien(string hoTen, double mucLuong, int soNgayVang)
        {
            HoTen = hoTen;
            MucLuong = mucLuong > 0 ? mucLuong : 0;
            SoNgayVang = soNgayVang >= 0 ? soNgayVang : 0;
        }

        // Tính lương thực nhận sau khi trừ phạt ngày vắng
        public double TinhLuongThucNhan()
        {
            double tienPhat = SoNgayVang * 100000;
            double luongThucNhan = MucLuong - tienPhat;
            return luongThucNhan > 0 ? luongThucNhan : 0; // Đảm bảo lương không âm
        }

        // Nhập thông tin nhân viên
        public void Nhap()
        {
            HoTen = Input.ReadString("  + Nhap ho ten nhan vien: ");
            
            do
            {
                MucLuong = Input.ReadDouble("  + Nhap muc luong co ban (VNĐ): ");
                if (MucLuong < 0) Console.WriteLine("Loi: Muc luong khong duoc am!");
            } while (MucLuong < 0);

            do
            {
                SoNgayVang = Input.ReadInt("  + Nhap so ngay vang: ");
                if (SoNgayVang < 0) Console.WriteLine("Loi: So ngay vang khong duoc am!");
            } while (SoNgayVang < 0);
        }

        // Xuất thông tin nhân viên
        public void Xuat()
        {
            Console.WriteLine($"{HoTen,-25} | {MucLuong,15:N0} VNĐ | {SoNgayVang,10} ngay | {TinhLuongThucNhan(),15:N0} VNĐ");
        }
    }

    // ==========================================
    // LỚP PHÒNG BÀN
    // ==========================================
    public class PhongBan
    {
        private NhanVien[] dsNhanVien;
        private int n;

        // Constructor
        public PhongBan()
        {
            n = 0;
            dsNhanVien = new NhanVien[0];
        }

        public PhongBan(int n)
        {
            this.n = n > 0 ? n : 0;
            dsNhanVien = new NhanVien[this.n];
        }

        // Indexer
        public NhanVien this[int index]
        {
            get
            {
                if (index < 0 || index >= n)
                    throw new IndexOutOfRangeException("Chi so nhan vien khong hop le!");
                return dsNhanVien[index];
            }
            set
            {
                if (index < 0 || index >= n)
                    throw new IndexOutOfRangeException("Chi so nhan vien khong hop le!");
                dsNhanVien[index] = value;
            }
        }

        // Nhập danh sách n nhân viên
        public void Nhap()
        {
            do
            {
                n = Input.ReadInt("Nhap so luong nhan vien trong phong ban (n > 0): ");
                if (n <= 0) Console.WriteLine("Loi: So luong phai lon hon 0!");
            } while (n <= 0);

            dsNhanVien = new NhanVien[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n-- Nhap thong tin nhan vien thu {i + 1} --");
                dsNhanVien[i] = new NhanVien();
                dsNhanVien[i].Nhap();
            }
        }

        // Xuất danh sách nhân viên
        public void Xuat()
        {
            if (dsNhanVien == null || n == 0)
            {
                Console.WriteLine("Danh sach nhan vien dang rong!");
                return;
            }

            Console.WriteLine("\n" + new string('-', 75));
            Console.WriteLine($"{"HO TEN",-25} | {"MUC LUONG",15} | {"NGAY VANG",10} | {"LUONG THUC NHAN",15}");
            Console.WriteLine(new string('-', 75));

            for (int i = 0; i < n; i++)
            {
                dsNhanVien[i].Xuat();
            }
            Console.WriteLine(new string('-', 75));
        }

        // TÍNH TỔNG LƯƠNG CỦA PHÒNG BÀN
        public double TinhTongLuong()
        {
            double tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += dsNhanVien[i].TinhLuongThucNhan();
            }
            return tong;
        }
        static void Main(string[] args)
        {
            PhongBan pb = new PhongBan();
            bool tiepTuc = true;

            while (tiepTuc)
            {
                Console.WriteLine("\n================ MENU QUAN LY LUONG PHONG BAN ================");
                Console.WriteLine("1. Nhap danh sach nhan vien phong ban");
                Console.WriteLine("2. Xuat danh sach nhan vien");
                Console.WriteLine("3. Tinh tong luong thuc tra cua phong ban");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("=============================================================");

                int chon = Input.ReadInt("Nhap lua chon cua ban: ");

                switch (chon)
                {
                    case 1:
                        Console.WriteLine("\n--- NHAP DANH SACH NHAN VIEN ---");
                        pb.Nhap();
                        break;

                    case 2:
                        Console.WriteLine("\n--- DANH SACH NHAN VIEN PHONG BAN ---");
                        pb.Xuat();
                        break;

                    case 3:
                        Console.WriteLine("\n--- TONG LUONG PHONG BAN ---");
                        double tongLuong = pb.TinhTongLuong();
                        Console.WriteLine($"Tong luong phong ban phai tra: {tongLuong:N0} VNĐ");
                        break;

                    case 0:
                        tiepTuc = false;
                        Console.WriteLine("Da thoat chuong trinh.");
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
            }
        }
    }
}