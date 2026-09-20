using System;
using Mylib;

namespace Bai3
{
    public class Person
    {
        private string id;
        private string name;
        private int yob;
        private int yod ;
        public Person()
        {
            id ="A001";
            name="Nguyen Van A";
            yob = 2000;
            yod = 0 ;
        }
        public Person(String id, string name , int yob ,int yod)
        {
            this.id = id;
            this.name = name;
            this.yob = yob;
            this.yod = yod;
        }
        // copy constructor
        public Person (Person other)
        {
            if(other != null)
            {
            this.id = other.id;
            this.name = other.name;
            this.yob = other.yob;
            this.yod = other.yod;
            }
        }
        public void Input()
        {
            id = Mylib.Input.ReadString("nhap id: ");
            name = Mylib.Input.ReadString("Nhap ho ten: ");
            yob = Mylib.Input.ReadInt("nhap nam sinh: ");
            yod = Mylib.Input.ReadInt("Nhap nam mat,nhap 0 neu chua mat: ");
        }
        public void Output()
        {
            Console.WriteLine("Thong tin nguoi:");
            Console.WriteLine("Ma nguoi: "+id);
            Console.WriteLine("Ho ten: "+name);
            Console.WriteLine("nam sinh: "+yob);
            if(IsLiving()== true)
            Console.WriteLine("Tinh trang: Con song");
            else 
            Console.WriteLine("nam mat: "+yod);
        }
        public bool IsLiving()
        {
            if(yod == 0)
            {
                return true;
            }
            else 
            return false;
        }
         public static void Main(string[] args)
        {   
            if (args.Length > 0 && (args[0] == "--test" || args[0] == "test"))
                {
                    Bai3_test.Run();
                    return;
                }
            Person nguoi = new Person();
            nguoi.Input();
            nguoi.IsLiving();
            nguoi.Output();

        }
    }
}
