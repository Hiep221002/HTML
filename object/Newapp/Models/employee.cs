using System.Dynamic;

namespace Newapp.Models
{
    public class employee
    {
        public string Manhanvien{get;set;}
        public string tennhanvien{get;set;}
        public int tuoi{get;set;}
        public int luong{get;set;}
        public void Nhapthongtin()
        {
            Console.Write("Manhanvien = ");
            Console.Write("tennhanvien=");
            Console.Write("tuoi=");
            Console.Write("luong=");
        }
        public void hienthi()
        {
        Console.WriteLine(Manhanvien + "-" + tennhanvien + "-" + tuoi + "-" + luong);
        }
    }
}