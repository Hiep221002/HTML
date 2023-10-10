namespace Newapp.Models
{
    /* Trần Đại Hiệp - 2021050255 */
        public class Person
        {
            public string FullName {get;set;}
            public string Address {get;set;}
            public int Age {get;set;}
             public void ps()
        {
            FullName = "Nguyen van A";
            Age = 20;
            Address = "Haiduong";
        }
            public void Nhapthongtin()
            {
                Console.Write("FullName = ");
                FullName = Console.ReadLine();
                Console.Write("Address=");
                Address = Console.ReadLine();
                Console.Write("Age=");
                Age = Convert.ToInt32(Console.ReadLine());
            }
        public void hienthi()
        {
    Console.WriteLine(FullName + " - " + Address+" - "+Age );
}
}
}
