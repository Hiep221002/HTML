namespace Newapp.Models
{
    public class Student
    {
        public string Masinhvien {get;set;}
        public string tensinhvien {get;set;}
        public int tuoi {get;set;}
        public void nhapthongtin()
        {
            Console.Write("Masinhvien=");
            Console.Write("tensinhvien=");
            Console.Write("tuoi=");
        }
        public void hienthi()
        {
            Console.WriteLine(Masinhvien+"-"+tensinhvien+"-"+tuoi);
        }
    }
}