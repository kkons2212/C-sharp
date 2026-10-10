using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Bai5
{
    public class ListService
    {
        private List<int> danhSachSo = new List<int>();

        // Lấy toàn bộ danh sách để hiển thị lên ListBox
        public List<int> LayDanhSach()
        {
            return danhSachSo;
        }

        // Thêm phần tử mới
        public void ThemPhanTu(int val)
        {
            danhSachSo.Add(val);
        }

        // Xóa phần tử theo vị trí Index
        public void XoaTaiViTri(int index)
        {
            if (index >= 0 && index < danhSachSo.Count)
            {
                danhSachSo.RemoveAt(index);
            }
        }

        // Xóa phần tử đầu và cuối
        public void XoaDauVaCuoi()
        {
            if (danhSachSo.Count > 0)
            {
                danhSachSo.RemoveAt(0);
            }
            if (danhSachSo.Count > 0)
            {
                danhSachSo.RemoveAt(danhSachSo.Count - 1);
            }
        }

        // Tính tổng các phần tử
        public int TinhTong()
        {
            int tong = 0;
            foreach (var item in danhSachSo)
            {
                tong += item;
            }
            return tong;
        }

        // Tăng mỗi phần tử lên 2 đơn vị
        public void TangLen2()
        {
            for (int i = 0; i < danhSachSo.Count; i++)
            {
                danhSachSo[i] += 2;
            }
        }

        // Thay thế bằng bình phương
        public void BinhPhuong()
        {
            for (int i = 0; i < danhSachSo.Count; i++)
            {
                danhSachSo[i] = danhSachSo[i] * danhSachSo[i];
            }
        }

        // Lấy danh sách các vị trí (Index) là số chẵn
        public List<int> LayViTriSoChan()
        {
            List<int> viTriChan = new List<int>();
            for (int i = 0; i < danhSachSo.Count; i++)
            {
                if (danhSachSo[i] % 2 == 0)
                {
                    viTriChan.Add(i);
                }
            }
            return viTriChan;
        }

        // Lấy danh sách các vị trí (Index) là số lẻ
        public List<int> LayViTriSoLe()
        {
            List<int> viTriLe = new List<int>();
            for (int i = 0; i < danhSachSo.Count; i++)
            {
                if (danhSachSo[i] % 2 != 0)
                {
                    viTriLe.Add(i);
                }
            }
            return viTriLe;
        }
    }
}