using System;
using System.Globalization;

namespace Mylib
{
    public static class Input
    {
        // Nhập chuỗi văn bản
        public static string ReadString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine() ?? string.Empty;
        }

        // Nhập số nguyên
        public static int ReadInt(string prompt)
        {
            int result;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    return result;
                }
                Console.WriteLine("Loi: Vui long nhap so nguyen hop le!");
            }
        }

        // Nhập số thực
        public static double ReadDouble(string prompt)
        {
            double result;
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out result))
                {
                    return result;
                }
                Console.WriteLine("Loi: Vui long nhap so thuc hop le!");
            }
        }

        // 1. Nhập DateOnly bắt buộc (Ví dụ: Ngày sinh)
        public static DateOnly ReadDateOnly(string prompt)
        {
            DateOnly result;
            // Cho phép cả định dạng chuẩn quốc tế (yyyy-MM-dd) lẫn định dạng Việt Nam (dd/MM/yyyy)
            string[] formats = { "yyyy-MM-dd", "dd/MM/yyyy", "d/M/yyyy", "dd-MM-yyyy" };

            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();

                if (DateOnly.TryParseExact(input, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
                {
                    return result;
                }

                Console.WriteLine("Loi: Ngay khong hop le! Vui long nhap theo dinh dang yyyy-MM-dd hoac dd/MM/yyyy.");
            }
        }

        // 2. Nhập DateOnly có thể NULL (Bấm Enter để bỏ qua - Ví dụ: Ngày mất)
        public static DateOnly? ReadNullableDateOnly(string prompt)
        {
            string[] formats = { "yyyy-MM-dd", "dd/MM/yyyy", "d/M/yyyy", "dd-MM-yyyy" };

            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();

                // Nếu người dùng nhấn Enter (bỏ trống)
                if (string.IsNullOrWhiteSpace(input))
                {
                    return null;
                }

                if (DateOnly.TryParseExact(input, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateOnly result))
                {
                    return result;
                }

                Console.WriteLine("Loi: Ngay khong hop le! Nhap theo dinh dang yyyy-MM-dd/dd/MM/yyyy hoac de trong (nhan Enter) neu chua qua doi.");
            }
        }
    }
}