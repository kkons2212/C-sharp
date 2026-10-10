using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class TuDienService
    {
        // Từ điển Anh - Việt
        public static Dictionary<string, string> LayTuDienAnhViet()
        {
            return new Dictionary<string, string>()
            {
                { "student", "Sinh viên, học sinh" },
                { "teacher", "Giáo viên, giảng viên" },
                { "worker", "Công nhân, người lao động" },
                { "hat", "Cái mũ, nón" },
                { "head", "Cái đầu, thủ lĩnh" },
                { "mouse", "Con chuột" },
                { "cat", "Con mèo" },
                { "dog", "Con chó" },
                { "snake", "Con rắn" },
                { "frog", "Con ếch" },
                { "sheep", "Con cừu" }
            };
        }

        // Từ điển Việt - Anh
        public static Dictionary<string, string> LayTuDienVietAnh()
        {
            return new Dictionary<string, string>()
            {
                { "Sinh viên, học sinh", "student" },
                { "Giáo viên, giảng viên", "teacher" },
                { "Công nhân, người lao động", "worker" },
                { "Cái mũ, nอน", "hat" },
                { "Cái đầu, thủ lĩnh", "head" },
                { "Con chuột", "mouse" },
                { "Con mèo", "cat" },
                { "Con chó", "dog" },
                { "Con rắn", "snake" },
                { "Con ếch", "frog" },
                { "Con cừu", "sheep" }
            };
        }
    }
}