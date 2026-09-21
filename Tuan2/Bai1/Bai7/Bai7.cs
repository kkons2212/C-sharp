using System;
using Mylib;
using System.Collections;
using Bai3;
namespace Bai7
{
    public class PersonList
    {
        private ArrayList Persons;

        public PersonList()
        {
            Persons = new ArrayList();
        }
        public PersonList (int soluong)
        {
            Persons = new ArrayList(soluong);
        }
        // lay so luong nguoi trong danh sach
        public int count
        {
            get => Persons.Count;
        }
        //copy constructor
        public PersonList (PersonList other)
        {
           
        if (other != null)
        {
        // Khởi tạo một ArrayList mới hoàn toàn
        this.Persons = new ArrayList();

        // Copy từng Person sang danh sách mới bằng Copy Constructor của Person
        for (int i = 0; i < other.count; i++)
        {
            Person pCopy = new Person(other[i]); 
            this.Persons.Add(pCopy);
        }
       }
            }
        
        public Person this [int index]
        {
           get
            {
                if( index <0 || index >= Persons.Count)
                throw new IndexOutOfRangeException("chi so o ngoai pham vi danh sach");
                return (Person)Persons[index];
            }
            set
            {
                 if( index <0 || index >= Persons.Count)
                throw new IndexOutOfRangeException("chi so o ngoai pham vi danh sach");
                    Persons[index] = value;
            }
           }
            public void Add(Person p)
           {
              Persons.Add(p);
           }
           public void Input()
          {
            
            int n = Mylib.Input.ReadInt("nhap So Luong nguoi trong danh sach");
            for(int i =0;i<n ;i++)
            {
                Console.WriteLine($"nhap nguoi thu {i+1}");
                Person p = new Person();
                p.Input();
                Add(p);
            }
           }
           public void Output()
          { 
            
            for(int i=0 ;i<Persons.Count;i++)
            {
                Console.WriteLine($"Nguoi Thu {i+1}:");
                this[i].Output();
            }  
          }
            public PersonList LivingPeople ()
        {   
            PersonList dstam = new PersonList();
            for(int i=0 ; i<Persons.Count;i++)
            {
                Person p = this[i];
                if(p.IsLiving()==true)
                {
                    dstam.Add(p);
                }
            }
            return dstam;
        }
        public static void Main(string[] args)
        {
            PersonList pl = new PersonList();
            Console.WriteLine(" NHẬP DANH SÁCH NHÂN KHẨU ");
            pl.Input();
            Console.WriteLine(" DANH SÁCH TOÀN BỘ NHÂN KHẨU ");
            pl.Output();
            Console.WriteLine(" DANH SÁCH NHÂN KHẨU CÒN SỐNG ");
            PersonList dsconsong = pl.LivingPeople();
            dsconsong.Output();
        }
        }
    }
