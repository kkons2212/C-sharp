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
                Console.WriteLine("Lỗi: Vui lòng nhập số nguyên hợp lệ!");
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
                Console.WriteLine("Lỗi: Vui lòng nhập số thực hợp lệ!");
            }
        }
    }
}