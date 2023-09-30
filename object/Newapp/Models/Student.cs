namespace Newapp.Models
{
    public class Student 
    {
        public string Masinhvien {get;set;}
        public string tensinhvien {get;set;}
        public string tuoi {get;set;}
        public void nhapthongtin()
        {
            Console.Write("Masinhvien=");
            Masinhvien=Console.ReadLine();
            Console.Write("tensinhvien=");
            tensinhvien=Console.ReadLine();
            Console.Write("tuoi=");
            tuoi=Console.ReadLine();
        }

        public void hienthi()
        {
            Console.WriteLine(Masinhvien+"-"+tensinhvien+"-"+tuoi);
        }
    }
}