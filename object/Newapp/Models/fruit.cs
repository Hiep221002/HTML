namespace Newapp.Models
{
    public class fruit
    {
        public string Mahoaqua{get;set;}
        public string loaihoaqua{get;set;}
        public int giaban{get;set;}
        public void Nhapthongtin()
        {
            Console.Write("Mahoaqua=");
            Console.Write("loaihoaqua=");
            Console.Write("giaban=");
        }
        public void hienthi()
        {
            Console.Write(Mahoaqua+"-"+loaihoaqua+"-"+giaban);
        }
    }
}