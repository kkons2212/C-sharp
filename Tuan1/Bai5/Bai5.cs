using System;
using System.Collections;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Tuan1
{
    public class Bai5
    {
        public static void Run()
        {       int chon;
                double x=0,y=0;
                bool danhap=false;
                while(true)
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1. Nhap hai gia tri so thuc cho x, y");   
                Console.WriteLine("2. Tinh x^y");
                Console.WriteLine("3. Tinh can bac 2 cua x va y");
                Console.WriteLine("4. Thoat");  
                Console.Write("Chon chuc nang:"); 
                chon = Convert.ToInt32(Console.ReadLine());
                switch(chon)
                {
                    case 1:
                    Console.WriteLine("Nhap x:");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Nhap y:");
                    y = Convert.ToDouble(Console.ReadLine());
                    danhap = true;
                    break;
                    case 2:
                    if(danhap!=true)
                        {
                            Console.Write("chua nhap gia tri x va y");
                            break;
                        }
                        else
                        {
                            Console.Write($"{x} mu {y} la:"+Math.Pow(x,y));
                            
                        }
                    break;
                    case 3:
                        if(danhap!=true)
                        {
                            Console.Write("chua nhap gia tri x va y");
                            break;
                        }
                        else if(x>=0 && y>=0)
                        {
                            Console.WriteLine($"can bac 2 cua {x} la:"+Math.Sqrt(x));
                            Console.Write($"can bac 2 cua {y} la:"+Math.Sqrt(y));
                        }
                        else
                        {
                            Console.WriteLine(" x hoac y k lon hon 0 khong the tinh can bac 2 cho 2 so");
                        }
                    break;
                    case 4:
                    return;
                    default:
                    Console.WriteLine("vui long nhap so hop le");
                    break;
                }
            }
        }
   }
}