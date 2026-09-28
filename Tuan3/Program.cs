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
            // Bai2_1(); //Truy vấn mảng số nguyên
            // Bai2_2(); //Truy vấn mảng chuỗi
            // Bai3_1(); //Thống kê mảng số
            // Bai3_2(); //Thống kê mảng chuỗi
            // Bai4_1(); //Lớp MonHoc
			// Bai5_1(); //Truy vấn cơ bản
			// Bai5_2(); //Thống kê trên List<MonHoc>
			// Bai6_1(); //Xây dựng lớp He
			   Bai6_2(); //Join và các toán tử tập hợp
        }

        static void Bai2_1() 
        {
            int [] mangso = {50,42,16,3,9,8,12,7,24,0};
            mangso.Dump("Mang So Ban Dau");

            // cau A
            var truyvanA = from n in mangso
                           where n % 3 == 0 && n % 4 == 0
                           orderby n descending 
                           select n;
            truyvanA.Dump("Mang so chi chia het cho 3 va 4");

            // Cau B
            var truyvanB = from n in mangso
                           where n <= 3
                           select n;
            truyvanB.Dump("Mang cac phan tu nho hon hoac bang 3");		

            // Cau C
            var truyvanC = from n in mangso 
                           select (n % 2 == 0) ? n / 2 : n;
            truyvanC.Dump("Mang so chan chia doi , so le giu nguyen");
        }

        static void Bai2_2()
        {
            string[] mangChuoi = { "đầu", "lòng", "hai", "ả", "tố", "nga",
            "Thúy", "Kiều", "là", "chị", "em", "là", "Thúy", "Vân" };

            // cau A
            var truyvanA = from n in mangChuoi
                           where n.Length == 4
                           orderby n.ToLower()[0] ascending
                           select n;
            truyvanA.Dump("cac phan tu co ky tu = 4");

            var method = mangChuoi.Where(n => n.Length == 4)
                                  .OrderBy(n => n.ToLower()[0]);
            method.Dump("cac phan tu co ky tu = 4");

            // cau B
            mangChuoi.Dump("Mang Chuoi ban dau");
            var truyvanB = from n in mangChuoi
                           select $"{n.ToLower()} - {n.ToUpper()}";
            truyvanB.Dump(" Dạng: <chữ thường> - <CHỮ HOA>");

            // cau C
            var truyvanC = from n in mangChuoi
                           where n.Contains("u")
                           select n;
            truyvanC.Dump(" các phần tử có chứa ký tự “u”");

            // Cau D
            var truyvanD = from n in mangChuoi 
                           where char.IsUpper(n[0])
                           select n;
            truyvanD.Dump("Liet ke các từ “Thúy Kiều Thúy Vân” bằng cách chọn các phần tử bắt đầu bằng chữ in hoa");

            var truyvanD2 = mangChuoi.Where(n => char.IsUpper(n[0]));
            truyvanD2.Dump("Liet ke các từ “Thúy Kiều Thúy Vân” bằng cách chọn các phần tử bắt đầu bằng chữ in hoa");
        }

        static void Bai3_1()
        { 
            int[] mangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };

            // cau a
            int tongso = mangSo.Length;
            int sochan = (from n in mangSo where n % 2 == 0 select n).Count();
            int sole = (from n in mangSo where n % 2 != 0 select n).Count();
            new { TongSo = tongso, SoChan = sochan, SoLe = sole }.Dump("Cho biết tổng số phần tử, số phần tử chẵn và số phần tử lẻ."); 
				   
            var nhomChanLe = from n in mangSo
                             group n by (n % 2 == 0 ? "Chẵn" : "Lẻ") into g
                             select new
                             {
                                 Loai = g.Key,
                                 SoLuong = g.Count(),
                                 DanhSachPhanTu = g.ToList()
                             };
            nhomChanLe.Dump("Cho biết tổng số phần tử, số phần tử chẵn và số phần tử lẻ");			   

            // cau b
            int tonggiatri = mangSo.Sum();
            int giatrilonnhat = mangSo.Max();
            int giatrinhonhat = mangSo.Min();
            new { Tonggiatri = tonggiatri, Giatrilonnhat = giatrilonnhat, Giatrinhonhat = giatrinhonhat }.Dump("Tính tổng các giá trị, giá trị lớn nhất và giá trị nhỏ nhất");

            // cau c
            int giatrikhacnhau = mangSo.Distinct().Count();
            new { Giatrikhacnhau = giatrikhacnhau }.Dump("số giá trị khác nhau trong mảng");		

            // Câu d
            var truyvanD = from n in mangSo
                           group n by n % 5 into g
                           orderby g.Key ascending
                           select new
                           {
                               SoDu = g.Key,                 
                               SoLuong = g.Count(),          
                               CacPhanTu = g.ToList()       
                           };

            truyvanD.Dump("d. Phân nhóm các phần tử theo số dư khi chia cho 5");			 
        }

        static void Bai3_2()
        { 
            string[] monAn = { "Bún bò Huế", "Hủ tiếu heo", "Bánh canh", "Bánh mì",
            "Nước Cà phê", "Mì quảng", "Cơm tấm", "Nước Chanh dây", "Mì xào",
            "Bún riêu", "Bánh cuốn", "Mì gói", "Bún chả", "Hủ tiếu Nam vang" };

            // cau a
            var xoakhoangtrang = monAn.Select(s => s.Trim()).ToList();
            int doDaiNganNhat = xoakhoangtrang.Min(s => s.Length);
            int doDaiDaiNhat = xoakhoangtrang.Max(s => s.Length);
		
            var truyvanNganNhat = from s in xoakhoangtrang
                                  where s.Length == doDaiNganNhat
                                  select s;
		
            var truyvanDaiNhat = from s in xoakhoangtrang
                                 where s.Length == doDaiDaiNhat
                                 select s;
		
            new 
            { 
                DoDaiNganNhat = doDaiNganNhat,
                MonAnNganNhat = truyvanNganNhat.ToList(),
                DoDaiDaiNhat = doDaiDaiNhat,
                MonAnDaiNhat = truyvanDaiNhat.ToList()
            }.Dump("a. Các phần tử có chiều dài ngắn nhất và dài nhất");

            // Cau b
            var NhomTheoTuDau = xoakhoangtrang
                .GroupBy(mon => mon.Split(' ')[0])
                .Select(g => new
                {
                    Tudautien = g.Key,
                    Soluong = g.Count(),
                    Danhsachmonan = g.ToList()
                });
            NhomTheoTuDau.Dump("b. Phân nhóm theo từ đầu tiên của tên món");

            // cau c
            var demsophantu = xoakhoangtrang.Count(monan => monan.Split(' ')[0] == "Bánh");
            demsophantu.Dump("Số lượng món ăn có từ đầu tiên là 'Bánh'");
        }

        public static void Bai4_1()
        {
            List<MonHoc> dsMonHoc = DuLieu.DS_Mon();
            dsMonHoc.Dump("Danh sách môn học");
        }
		public static void Bai5_1()
		{
				  List<MonHoc> dsMonHoc = DuLieu.DS_Mon();
		    // a. Liệt kê tên các môn học bắt đầu bằng "Lập trình"
		   
		    var cauA = from mh in dsMonHoc
		               where mh.TenMon.StartsWith("Lập trình")
		               select mh.TenMon;
		    cauA.Dump("a. Tên các môn học bắt đầu bằng 'Lập trình'");
		   
		    var cauA_Method = dsMonHoc.Where(mh => mh.TenMon.StartsWith("Lập trình"))
		                              .Select(mh => mh.TenMon);
		    cauA_Method.Dump("a. Tên các môn học bắt đầu bằng 'Lập trình' ");
		    // b. Liệt kê các môn thuộc hệ "CD", sắp xếp số tiết giảm dần rồi mã môn tăng dần
		  
		    var cauB = from mh in dsMonHoc
		               where mh.He == "CD"
		               orderby mh.SoTiet descending, mh.MaMon ascending
		               select mh;
		    cauB.Dump("b. Môn hệ 'CD', sắp xếp số tiết giảm dần, mã môn tăng dần ");
		   
		    var cauB_Method = dsMonHoc.Where(mh => mh.He == "CD")
		                              .OrderByDescending(mh => mh.SoTiet)
		                              .ThenBy(mh => mh.MaMon);
		    cauB_Method.Dump("b. Môn hệ 'CD' (Method Syntax)");
		    
		    // c. Liệt kê các môn có tên chứa từ "web", chỉ lấy Tên môn và Hệ
		    
		    var cauC = from mh in dsMonHoc
		               where mh.TenMon.ToLower().Contains("web")
		               select new 
		               { 
		                   mh.TenMon, 
		                   mh.He 
		               };
		    cauC.Dump("c. Môn có tên chứa từ 'web' - chỉ lấy Tên môn và Hệ ");
		    
		    var cauC_Method = dsMonHoc.Where(mh => mh.TenMon.ToLower().Contains("web"))
		                              .Select(mh => new { mh.TenMon, mh.He });
		    cauC_Method.Dump("c. Môn có tên chứa từ 'web'");
		  
		    // d. Liệt kê các môn thuộc hệ "KTV", sắp xếp tăng dần theo Mã môn
		  
		   
		    var cauD = from mh in dsMonHoc
		               where mh.He == "KTV"
		               orderby mh.MaMon ascending
		               select mh;
		    cauD.Dump("d. Môn hệ 'KTV' sắp xếp tăng dần theo Mã môn ");
		   
		    var cauD_Method = dsMonHoc.Where(mh => mh.He == "KTV")
		                              .OrderBy(mh => mh.MaMon);
		    cauD_Method.Dump("d. Môn hệ 'KTV' sắp xếp tăng dần theo Mã môn ");
		}
		public static void Bai5_2()
		{
		 List<MonHoc> dsmonhoc = DuLieu.DS_Mon();
		 
		 // a. Cho biết tổng số môn hiện có.
		 var tongso = from monhoc in dsmonhoc
		 			  group monhoc by monhoc.MaMon into g
					  select new 
					  {
					    
						MaMonhoc= g.Key,
						tongcacmon = g.Count()
					  
					  };
		  tongso.Dump("tổng các môn hiện có:");
		  
		  int tongSoMon = dsmonhoc.Count();
		  tongSoMon.Dump("Tổng các môn hiện có:");
		  //b. Đếm số môn có tên bắt đầu bằng “Lập trình”.
		  var tongmonlaptrinh = dsmonhoc.Where( monhoc => monhoc.TenMon.StartsWith("Lập trình")).Count();
		  tongmonlaptrinh.Dump("số môn có tên bắt đầu bằng “Lập trình");
		  //c.Tính tổng số tiết của hệ Kỹ thuật viên (KTV).
		  var tongsotiet = dsmonhoc.Where(monhoc => monhoc.He =="KTV").Sum(monhoc =>monhoc.SoTiet);
		  tongsotiet.Dump("tổng số tiết của hệ Kỹ thuật viên (KTV)");						
		  //d. Cho biết tổng số môn của mỗi hệ: Hệ, Tổng số môn.
		  var tongmonmoihe = from monhoc in dsmonhoc
		  					 group monhoc by monhoc.He into g
							 select new 
							 {
							   He = g.Key,
							   tongsomon = g.Count()
							 };
		  tongmonmoihe.Dump("tổng số môn của mỗi hệ: Hệ, Tổng số môn");
		  //e. Nhóm theo Số tiết; in Số tiết và Tổng số môn, sắp xếp giảm dần theo Số tiết
		  var truyvane = from monhoc in dsmonhoc
		  				 group monhoc by monhoc.SoTiet into g
						 orderby  g.Key descending 
						 select new 
						 {
						    Sotiet= g.Key,
							TongSoMon = g.Count()
						 };
			  truyvane.Dump("Nhóm theo Số tiết; in Số tiết và Tổng số môn, sắp xếp giảm dần theo Số tiết");
		 //	f. Cho biết thông tin môn học có số tiết cao nhất
		    var sotietmax = dsmonhoc.Max(monhoc => monhoc.SoTiet);
		    var truyvanf = dsmonhoc.Where(monhoc => monhoc.SoTiet == sotietmax).Select(monhoc => monhoc.TenMon);
			truyvanf.Dump("Cho biết thông tin môn học có số tiết cao nhất");
	    //g. Thống kê theo Hệ: tổng số môn, tổng số tiết, số tiết cao nhất, số tiết thấp nhất
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
		//h. Liệt kê các môn học được phân nhóm theo Hệ
		     var truyvanh = from monhoc in dsmonhoc
			               group monhoc by monhoc.He into g
						   select new 
						   {
						    He = g.Key,
							DSMon = g
						   
						   };
			truyvanh.Dump("các môn học được phân nhóm theo Hệ");
			
		//i. Liệt kê các môn học được phân nhóm theo Số tiết và tăng dần theo Số tiết
		      var truyvani = from monhoc in dsmonhoc
			               group monhoc by monhoc.SoTiet into g
						   orderby g.Key ascending 
						   select new 
						   {
						    Sotiet = g.Key,
							DSMon = g
						   
						   };
			truyvani.Dump("các môn học được phân nhóm theo Số tiết và tăng dần theo Số tiết");
		//j. Với hệ KTV, phân nhóm theo học phần HP2, HP3, HP4, HP5; sắp xếp theo Mã môn
		     var truyvanj = from monhoc in dsmonhoc 
			 				   where monhoc.He == "KTV"
							   group monhoc by monhoc.MaMon.Split('_')[0] into g
							   orderby  g.Key
							   select new 
							   {
							      HocPhan = g.Key,
								  danhsach = g.OrderBy(monhoc => monhoc.MaMon)
							   
							   };
			    truyvanj.Dump("Với hệ KTV, phân nhóm theo học phần HP2, HP3, HP4, HP5; sắp xếp theo Mã môn");
		//k. Phân nhóm theo Hệ, chỉ lấy các môn có Số tiết > 40; trong mỗi nhóm sắp xếp theo Mã môn
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
		public static void Bai6_1()
		{
		   List<He> dshe = Data.DS_He();
		   dshe.Dump("Danh sách Hệ ");
		
		}
		public static void Bai6_2()
		{
		  //a. Dùng join để liệt kê: Tên hệ, Mã môn, Tên môn.
		  List<MonHoc> dsmonhoc = DuLieu.DS_Mon();
		  List<He> dshe = Data.DS_He();
		  var truyvana = from monhoc in dsmonhoc
		  				 join he in dshe on monhoc.He equals he.MaHe
						 select new 
				          {
				             TenHe = he.TenHe,
				             MaMon = monhoc.MaMon,
				             TenMon = monhoc.TenMon
				          };
			truyvana.Dump("Tên hệ, Mã môn, Tên môn");
			//b. Liệt kê cả những hệ chưa có môn học (left outer join với GroupJoin + DefaultIfEmpty).
			 	var truyvanb = from he in dshe
				              	join monhoc in dsmonhoc on he.MaHe equals monhoc.He into dsMonTheoHe
				                from monhoc in dsMonTheoHe.DefaultIfEmpty()
				              	select new 
				               {
				                  TenHe = he.TenHe,
				                  MaMon = monhoc != null ? monhoc.MaMon : "Chưa có",
				                  TenMon = monhoc != null ? monhoc.TenMon : "Chưa có môn học"
				               };

				truyvanb.Dump("Liệt kê cả những hệ chưa có môn học ");
		    //c. Liệt kê cả hệ chưa có môn học và môn học chưa khai báo hệ.
			// 1. Left Join: Lấy tất cả các Hệ (kể cả hệ chưa có môn)
			var leftJoin = from he in dshe
			                join monhoc in dsmonhoc on he.MaHe equals monhoc.He into dsMonTheoHe
			                from monhoc in dsMonTheoHe.DefaultIfEmpty()
			                select new 
			                {
			                    TenHe = he.TenHe,
			                    MaMon = monhoc != null ? monhoc.MaMon : "Chưa có",
			                    TenMon = monhoc != null ? monhoc.TenMon : "Chưa có môn học"
			                };
			
			// 2. Right Join: Lấy tất cả các Môn học (kể cả môn chưa khai báo hệ)
			var rightJoin = from monhoc in dsmonhoc
			                 join he in dshe on monhoc.He equals he.MaHe into dsHeTheoMon
			                 from he in dsHeTheoMon.DefaultIfEmpty()
			                 select new 
			                 {
			                     TenHe = he != null ? he.TenHe : "Chưa khai báo",
			                     MaMon = monhoc.MaMon,
			                     TenMon = monhoc.TenMon
			                 };
			
			// 3. Union: Kết hợp 2 kết quả và tự động loại bỏ trùng lặp
			var truyvanc = leftJoin.Union(rightJoin);
			
			truyvanc.Dump(" Cả hệ chưa có môn và môn chưa khai báo hệ");
			//d. Chỉ liệt kê những hệ chưa có môn học và những môn học chưa khai báo hệ.
			// 1. Lọc các Hệ chưa có môn học nào (dùng Any)
			var heChuaCoMon = from he in dshe
			                  where !dsmonhoc.Any(monhoc => monhoc.He == he.MaHe)
			                  select new 
			                  {
			                      TenHe = he.TenHe,
			                      MaMon = "Chưa có",
			                      TenMon = "Chưa có môn học"
			                  };
			
			// 2. Lọc các Môn học chưa khai báo hệ (He == "" hoặc He không tồn tại trong dshe)
			var monChuaCoHe = from monhoc in dsmonhoc
			                  where string.IsNullOrEmpty(monhoc.He) || !dshe.Any(he => he.MaHe == monhoc.He)
			                  select new 
			                  {
			                      TenHe = "Chưa khai báo",
			                      MaMon = monhoc.MaMon,
			                      TenMon = monhoc.TenMon
			                  };
			
			// 3. Gộp 2 tập hợp lại bằng Union
			var truyvand = heChuaCoMon.Union(monChuaCoHe);
			
			truyvand.Dump("Hệ chưa có môn học VÀ Môn học chưa khai báo hệ");
			//e. Lấy 5 môn học đầu tiên có số tiết giảm dần; hiển thị Tên hệ, Mã môn, Tên môn, Số tiết.
			var truyvane = (from monhoc in dsmonhoc
                join he in dshe on monhoc.He equals he.MaHe into dsHeTheoMon
                from he in dsHeTheoMon.DefaultIfEmpty()
                orderby monhoc.SoTiet descending
                select new 
                {
                    TenHe = he != null ? he.TenHe : "Chưa khai báo",
                    MaMon = monhoc.MaMon,
                    TenMon = monhoc.TenMon,
                    SoTiet = monhoc.SoTiet
                }).Take(5);

  				truyvane.Dump(" 5 môn học có số tiết giảm dần");
		    //f. Cho biết tổng số môn học của mỗi hệ: Mã hệ, Tên hệ, Tổng số môn
			var truyvanf = from he in dshe
               join monhoc in dsmonhoc on he.MaHe equals monhoc.He into dsMonTheoHe
               select new 
               {
                   MaHe = he.MaHe,
                   TenHe = he.TenHe,
                   TongSoMon = dsMonTheoHe.Count()
               };

				truyvanf.Dump(" Cho biết tổng số môn học của mỗi hệ: Mã hệ, Tên hệ, Tổng số môn");
			//g. Cho biết có bao nhiêu loại Số tiết khác nhau trong danh sách môn học
			var soLoaiSoTiet = (from monhoc in dsmonhoc
                    select monhoc.SoTiet)
                   .Distinct()
                   .Count();

                soLoaiSoTiet.Dump("Số loại Số tiết khác nhau");
			//h. Tìm môn học đầu tiên có tên bắt đầu bằng “Lập trình”
			var monDauTien = dsmonhoc.FirstOrDefault(monhoc => monhoc.TenMon.StartsWith("Lập trình"));

            monDauTien.Dump(" Môn học đầu tiên có tên bắt đầu bằng 'Lập trình'");
			//i. Liệt kê các môn theo từng hệ, đánh số thứ tự trong mỗi nhóm
			var truyvani_Method = dsmonhoc.GroupBy(monhoc => monhoc.He)
                              .Select(g => new 
                              {
                                  He = string.IsNullOrEmpty(g.Key) ? "Chưa khai báo" : g.Key,
                                  DanhSachMon = g.Select((monhoc, index) => new 
                                  {
                                      STT = index + 1,
                                      MaMon = monhoc.MaMon,
                                      TenMon = monhoc.TenMon,
                                      SoTiet = monhoc.SoTiet
                                  })
                              });

            truyvani_Method.Dump("Các môn theo từng hệ, có đánh STT trong nhóm");
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
	
	public class He
	{
	  public string MaHe { get; set; } = "";
      public string TenHe { get; set; } = "";
	 
	}
	public static class Data 
	{
	 public static List<He> DS_He()
	 {
	    return new List<He>
		{
		    new He { MaHe = "KTV", TenHe = "Kỹ thuật viên" },
            new He { MaHe = "CD",  TenHe = "Chuyên đề" },
            new He { MaHe = "QT",  TenHe = "Chứng chỉ quốc tế" }
		};
	 }
	}
}

