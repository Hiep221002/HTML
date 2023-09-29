namespace Newapp.Models
{
        public class Person
        {

            public string FullName {get;set;}
            public string Address {get;set;}
            public string Age {get;set;}
            public void Nhapthongtin()
            {
            Console.Write("FullName =");
            FullName = Console.ReadLine();
            Console.Write( "Address =" );
            Address = Console.ReadLine();
            Console.Write("Age =");
            Age = Console.ReadLine();
            }
            public int namsinh (int age)
            {
                int namsinh = 2023 - age;
                return namsinh;
            }
        public void hienthi()
        {
    Console.WriteLine(FullName + "-" + Address+"-"+Age );
}
}
}
