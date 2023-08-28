internal class Program
{
    private static void Main(string[]args)
    {
        int a,b;
        Console.Write("a=");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b=");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0} < {1} = {2}",a,b,a < b);
    }
}