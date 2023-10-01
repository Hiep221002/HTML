namespace Newapp.Models
{
    /* Trần Đại Hiệp - 2021050255 */
    public class fruit
    {
        public string Mahoaqua{get;set;}
        public string loaihoaqua{get;set;}
        public int giaban{get;set;}
        public void Nhapthongtin()
        {
            Console.Write("Mahoaqua=");
            Mahoaqua = Console.ReadLine();
            Console.Write("loaihoaqua=");
            loaihoaqua = Console.ReadLine();
            Console.Write("giaban=");
            giaban = Convert.ToInt32(Console.ReadLine());
            try{
                giaban = Convert.ToInt32(Console.ReadLine());
            }catch
            {
                giaban= 0;
            }
        }
        public void hienthi()
        {
            Console.Write(Mahoaqua+"-"+loaihoaqua+"-"+giaban);
        }
    }
}