namespace Newapp.Models
{
    /* Trần Đại Hiệp - 2021050255 */
        public class Person
        {
            public string FullName {get;set;}
            public string Address {get;set;}
            public int Age {get;set;}
            public void Nhapthongtin()
            {
                Console.Write("FullName = ");
                FullName = Console.ReadLine();
                Console.Write("Address=");
                Address = Console.ReadLine();
                Console.Write("Age=");
                Age = Convert.ToInt32(Console.ReadLine());
                try{
                    Age = Convert.ToInt32(Console.ReadLine());
                }catch
                {
                    Age = 0;
                }
            }
        public void hienthi()
        {
    Console.WriteLine(FullName + " - " + Address+" - "+Age );
}
}
}
