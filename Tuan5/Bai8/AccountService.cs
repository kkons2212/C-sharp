using System.Globalization;
using System.Windows.Forms;

namespace Bai8
{
    internal class AccountService
    {
        // Tính tổng tiền từ cột số tiền (cột index 4) trong ListView
        public decimal TinhTongTien(ListView lsv)
        {
            decimal tong = 0;
            foreach (ListViewItem item in lsv.Items)
            {
                if (decimal.TryParse(item.SubItems[4].Text.Replace(",", ""), out decimal tien))
                {
                    tong += tien;
                }
            }
            return tong;
        }

        // Cập nhật lại số thứ tự (STT) tự động từ 1 sau khi Thêm hoặc Xóa
        public void CapNhatSTT(ListView lsv)
        {
            for (int i = 0; i < lsv.Items.Count; i++)
            {
                lsv.Items[i].Text = (i + 1).ToString(); // Cột đầu tiên (STT)
            }
        }

        // Định dạng số tiền có dấu phẩy hàng nghìn (VD: 5,200,000)
        public string DinhDangTien(decimal tien)
        {
            return tien.ToString("N0", CultureInfo.InvariantCulture);
        }
    }
}