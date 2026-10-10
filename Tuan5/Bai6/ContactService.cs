using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Bai6
{
    public class ContactService
    {
        // Khởi tạo các node từ A đến Z trên TreeView khi Form load
        public void KhoiTaoCayAlphabet(TreeView treeView)
        {
            treeView.Nodes.Clear();
            for (char c = 'A'; c <= 'Z'; c++)
            {
                treeView.Nodes.Add(c.ToString(), c.ToString());
            }
        }

        // Thêm liên hệ mới vào TreeView theo chữ cái đầu của tên
        public bool ThemDanhBa(TreeView treeView, string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                return false;
            }

          
            string hienThi = $"{firstName.Trim()}, {lastName.Trim()}";

            // Lấy ký tự đầu tiên của First Name để phân loại vào node A-Z
            char chuCaiDau = char.ToUpper(firstName.Trim()[0]);

            // Tìm node gốc tương ứng với chữ cái đầu
            if (treeView.Nodes.ContainsKey(chuCaiDau.ToString()))
            {
                TreeNode parentNode = treeView.Nodes[chuCaiDau.ToString()];
                parentNode.Nodes.Add(hienThi);
                parentNode.Expand(); // Mở rộng node ra để nhìn thấy
                return true;
            }

            return false;
        }
    }
}
