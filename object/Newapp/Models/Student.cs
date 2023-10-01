namespace Newapp.Models
{
    /* Trần Đại Hiệp - 2021050255 */
    public class Student 
    {
        public string Masinhvien {get;set;}
        public string tensinhvien {get;set;}
        public int tuoi {get;set;}
        public void nhapthongtin()
        {
            Console.Write("Masinhvien=");
            Masinhvien=Console.ReadLine();
            Console.Write("tensinhvien=");
            tensinhvien=Console.ReadLine();
            Console.Write("tuoi=");
            tuoi=Convert.ToInt32(Console.ReadLine());
             try{
                    tuoi = Convert.ToInt32(Console.ReadLine());
                }catch
                {
                    tuoi = 0;
                }
        }

        public void hienthi()
        {
            Console.WriteLine(Masinhvien+"-"+tensinhvien+"-"+tuoi);
        }
    }
}