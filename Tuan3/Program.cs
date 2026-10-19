using System;
using System.Collections.Generic;
using System.Linq;
using Dumpify;

namespace BaiThucHanhLINQ
{
    class Program
    {
        static void Main()
        {
            Bai5_2();
        }

        public static void Bai5_2()
        {
            List<MonHoc> dsmonhoc = DuLieu.DS_Mon();
            
            // Câu A
            var tongso = from monhoc in dsmonhoc
                         group monhoc by monhoc.MaMon into g
                         select new 
                         {
                             MaMonhoc = g.Key,
                             tongcacmon = g.Count()
                         };
            tongso.Dump("tổng các môn hiện có:");
            
            int tongSoMon = dsmonhoc.Count();
            tongSoMon.Dump("Tổng các môn hiện có:");

            // Câu B
            var tongmonlaptrinh = dsmonhoc.Where(monhoc => monhoc.TenMon.StartsWith("Lập trình")).Count();
            tongmonlaptrinh.Dump("số môn có tên bắt đầu bằng “Lập trình");

            // Câu C
            var tongsotiet = dsmonhoc.Where(monhoc => monhoc.He == "KTV").Sum(monhoc => monhoc.SoTiet);
            tongsotiet.Dump("tổng số tiết của hệ Kỹ thuật viên (KTV)");                   

            // Câu D
            var tongmonmoihe = from monhoc in dsmonhoc
                               group monhoc by monhoc.He into g
                               select new 
                               {
                                   He = g.Key,
                                   tongsomon = g.Count()
                               };
            tongmonmoihe.Dump("tổng số môn của mỗi hệ: Hệ, Tổng số môn");

            // Câu E
            var truyvane = from monhoc in dsmonhoc
                           group monhoc by monhoc.SoTiet into g
                           orderby g.Key descending 
                           select new 
                           {
                               Sotiet = g.Key,
                               TongSoMon = g.Count()
                           };
            truyvane.Dump("Nhóm theo Số tiết; in Số tiết và Tổng số môn, sắp xếp giảm dần theo Số tiết");

            // Câu F
            var sotietmax = dsmonhoc.Max(monhoc => monhoc.SoTiet);
            var truyvanf = dsmonhoc.Where(monhoc => monhoc.SoTiet == sotietmax).Select(monhoc => monhoc.TenMon);
            truyvanf.Dump("Cho biết thông tin môn học có số tiết cao nhất");

            // Câu G
            var truyvang = from monhoc in dsmonhoc
                           group monhoc by monhoc.He into g
                           select new 
                           {
                               He = g.Key,
                               TongSoMon = g.Count(),
                               TongSoTiet = g.Sum(m => m.SoTiet),
                               SoTietCaoNhat = g.Max(m => m.SoTiet),
                               SoTietThapNhat = g.Min(m => m.SoTiet)
                           };
            truyvang.Dump("Thống kê theo Hệ");

            // Câu H
            var truyvanh = from monhoc in dsmonhoc
                           group monhoc by monhoc.He into g
                           select new 
                           {
                               He = g.Key,
                               DSMon = g
                           };
            truyvanh.Dump("các môn học được phân nhóm theo Hệ");
            
            // Câu I
            var truyvani = from monhoc in dsmonhoc
                           group monhoc by monhoc.SoTiet into g
                           orderby g.Key ascending 
                           select new 
                           {
                               Sotiet = g.Key,
                               DSMon = g
                           };
            truyvani.Dump("các môn học được phân nhóm theo Số tiết và tăng dần theo Số tiết");

            // Câu J
            var truyvanj = from monhoc in dsmonhoc 
                           where monhoc.He == "KTV"
                           group monhoc by monhoc.MaMon.Split('_')[0] into g
                           orderby g.Key
                           select new 
                           {
                               HocPhan = g.Key,
                               danhsach = g.OrderBy(monhoc => monhoc.MaMon)
                           };
            truyvanj.Dump("Với hệ KTV, phân nhóm theo học phần HP2, HP3, HP4, HP5; sắp xếp theo Mã môn");

            // Câu K
            var truyvank = from monhoc in dsmonhoc
                           where monhoc.SoTiet > 40
                           group monhoc by monhoc.He into g
                           select new 
                           {
                               He = g.Key,
                               danhsach = g.OrderBy(monhoc => monhoc.MaMon)
                           };
            truyvank.Dump("Phân nhóm theo Hệ, chỉ lấy các môn có Số tiết > 40; trong mỗi nhóm sắp xếp theo Mã môn");
        }
    }

    public class MonHoc
    {
        public string MaMon { get; set; } = "";
        public string TenMon { get; set; } = "";
        public string He { get; set; } = "";
        public byte SoTiet { get; set; }
    }

    public static class DuLieu
    {
        public static List<MonHoc> DS_Mon()
        {
            return new List<MonHoc>
            {
                new MonHoc { MaMon = "HP2_1", TenMon = "Nền tảng C#", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP2_2", TenMon = "Công nghệ ADO.NET", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP3_1", TenMon = "Lập trình Windows Forms", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP3_2", TenMon = "Xây dựng ứng dụng Windows Forms", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP4_1", TenMon = "Lập trình Web với HTML, CSS và JavaScript", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP4_2", TenMon = "Xây dựng ứng dụng Web với ASP.NET", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP5_1", TenMon = "Lập trình CSDL SQL Server căn bản", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "HP5_2", TenMon = "Lập trình CSDL SQL Server nâng cao", He = "KTV", SoTiet = 64 },
                new MonHoc { MaMon = "JLCB",  TenMon = "Joomla cơ bản", He = "CD", SoTiet = 72 },
                new MonHoc { MaMon = "LINQ",  TenMon = "Language-Integrated Query", He = "CD", SoTiet = 64 },
                new MonHoc { MaMon = "DAWEB", TenMon = "Đồ án thực tế Web với ASP.NET", He = "CD", SoTiet = 40 },
                new MonHoc { MaMon = "DAWIN", TenMon = "Đồ án thực tế Windows Forms", He = "CD", SoTiet = 40 },
                new MonHoc { MaMon = "CC++",  TenMon = "Lập trình hướng đối tượng với C/C++", He = "CD", SoTiet = 128 },
                new MonHoc { MaMon = "JQUE",  TenMon = "JQuery", He = "CD", SoTiet = 22 },
                new MonHoc { MaMon = "XML",   TenMon = "Công nghệ XML", He = "CD", SoTiet = 32 },
                new MonHoc { MaMon = "CRYS",  TenMon = "Crystal Report trong Visual Studio", He = "CD", SoTiet = 32 },
                new MonHoc { MaMon = "BWEB",  TenMon = "HTML, CSS và JavaScript", He = "CD", SoTiet = 32 },
                new MonHoc { MaMon = "XYZ",   TenMon = "Chưa đặt tên môn", He = "", SoTiet = 0 }
            };
        }
    }
}