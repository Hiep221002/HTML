using System.Dynamic;

namespace Newapp.Models
{
    public class employee : Person
    {
        public string personid{get;set;}
        public string Manhanvien{get;set;}
        public string tennhanvien{get;set;}
        public int tuoi{get;set;}
        public void Nhapthongtin()
        {
            base.Nhapthongtin();
            Console.Write("Personid=");
            personid = Console.ReadLine();
        }
        public void hienthi()
        {
        Console.WriteLine("MSV :{0}",personid);
        }
    }
}