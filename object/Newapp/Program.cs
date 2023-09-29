using Newapp.Models;
public class Program
{
private static void Main(string[]args)
    {
        Person ps =new Person();
        string str = "Tran Dai Hiep";
        int a = 21;
        Console.WriteLine("{0} sinh nam {1}",str,ps.namsinh(a));
        
    }
}
