using System;
using System.Collections.Generic;

namespace Bai16
{
    // Delegate cho sự kiện khi chọn menu
    public delegate void MenuChooseEventHandler(int option);

    public class ConsoleMenu
    {
        protected List<string> menuItems = new List<string>();
        public string Title { get; set; } = "Menu";

        // Event mở rộng qua Sự kiện
        public event MenuChooseEventHandler Choose;

        public void AddMenuItem(string item)
        {
            menuItems.Add(item);
        }

        // Phương thức ảo mở rộng qua Thừa kế
        protected virtual void OnExecuteOption(int option)
        {
            Choose?.Invoke(option); // Gọi Event nếu có
        }

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"=== {Title} ===");
                for (int i = 0; i < menuItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {menuItems[i]}");
                }
                Console.WriteLine("0. Thoat chuong trinh");
                Console.WriteLine(new string('-', 35));

                Console.Write("Thuc hien: ");
                if (int.TryParse(Console.ReadLine(), out int option))
                {
                    if (option == 0)
                    {
                        Console.WriteLine("Da thoat chuong trinh!");
                        break;
                    }

                    if (option > 0 && option <= menuItems.Count)
                    {
                        Console.WriteLine($"\nBan thuc hien chuc nang {option}:");
                        Console.WriteLine(new string('=', 35));
                        
                        OnExecuteOption(option);
                    }
                    else
                    {
                        Console.WriteLine("Lua chon khong hop le!");
                    }
                }
                else
                {
                    Console.WriteLine("Vui long nhap so!");
                }

                Console.WriteLine("\nNhan phim bat ky de tiep tuc...");
                Console.ReadKey();
            }
        }
    }
}