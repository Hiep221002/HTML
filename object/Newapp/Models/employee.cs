using System.Dynamic;

namespace Newapp.Models
{
    /* Trần Đại Hiệp - 2021050255 */
    public class employee : Person
    {
        public string Manhanvien{get;set;}
        public string tennhanvien{get;set;}
        public int tuoi{get;set;}
        public void Nhapthongtin()
        {
            Console.WriteLine("Manhanvien =");
            Manhanvien = Console.ReadLine();
            Console.WriteLine("tennhanvien=");
            tennhanvien= Console.ReadLine();
            Console.WriteLine("tuoi = ");
            tuoi = Convert.ToInt32(Console.ReadLine());

             try{
                    tuoi = Convert.ToInt32(Console.ReadLine());
                }catch
                {
                    tuoi = 0;
                }
        }
        public void hienthi()
        {
        Console.WriteLine(Manhanvien+" - "+tennhanvien+" - "+tuoi);
        }
    }
}