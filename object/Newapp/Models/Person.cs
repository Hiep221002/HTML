namespace Newapp.Models
{
        public class Person
        {
            public string FullName {get;set;}
            public string Address {get;set;}
            public string Age {get;set;}
            public void Nhapthongtin()
            {
            }
        public void hienthi()
        {
    Console.WriteLine(FullName + "-" + Address+"-"+Age );
}
}
}
