using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class SoHoc
    {
        private int giaTri;

        // Constructor
        public SoHoc(int giaTri)
        {
            this.giaTri = giaTri;
        }

        public int GiaTri
        {
            get => giaTri;
            set => giaTri = value;
        }

        // 1. Tìm tất cả các ước số
        public List<int> TimCacUocSo()
        {
            List<int> danhSachUoc = new List<int>();
            for (int i = 1; i <= giaTri; i++)
            {
                if (giaTri % i == 0)
                {
                    danhSachUoc.Add(i);
                }
            }
            return danhSachUoc;
        }

        // Kiểm tra số nguyên tố phụ trợ
        private bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        // 2. Tính tổng các ước số
        public int TinhTongUoc()
        {
            List<int> uocs = TimCacUocSo();
            int tong = 0;
            foreach (var uoc in uocs)
            {
                tong += uoc;
            }
            return tong;
        }

        // 3. Đếm số lượng các ước số chẵn
        public int DemUocChan()
        {
            List<int> uocs = TimCacUocSo();
            int dem = 0;
            foreach (var uoc in uocs)
            {
                if (uoc % 2 == 0)
                {
                    dem++;
                }
            }
            return dem;
        }

        // 4. Đếm số lượng các ước số nguyên tố
        public int DemUocNguyenTo()
        {
            List<int> uocs = TimCacUocSo();
            int dem = 0;
            foreach (var uoc in uocs)
            {
                if (LaSoNguyenTo(uoc))
                {
                    dem++;
                }
            }
            return dem;
        }
    }
}
