/* Tran Dai Hiep-2021050255 */
using Newapp.Models;
public class Program
{
private static void Main(string[]args)
{
     Person[] ps = new Person[3];
    for(int i = 0; i < ps.Length; i++)
    {
        Person std = new Person ();
        Console.Write("Nhap phan tu thu {0}: ", i);
        int a = Convert.ToInt32(Console.ReadLine());
        ps[i] = std;
        Console.WriteLine();
    }
}
}