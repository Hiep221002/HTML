namespace Newapp.Models
{
        public class Person
        {

            public string FullName {get;set;}
            public string Address {get;set;}
            public void Nhapthongtin()
            {
            Console.Write("FullName =");
            FullName = Console.ReadLine();
            Console.Write( "Address =" );
            Address = Console.ReadLine();
            }
        public void hienthi()
        {
    Console.WriteLine(FullName + "-" + Address );
}
}
}
