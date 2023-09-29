using Newapp.Models;
public class Program
{
private static void Main(string[]args)
    {
        Giaiphuongtrinh pt = new Giaiphuongtrinh();
        int a = 20;
        int b = 40;
        int c = -b/a;
        pt.PTbac1(a,b,c);

        Giaiphuongtrinh pt1 = new Giaiphuongtrinh();
        int A = 10;
        int B = -20;
        int C = 5;
        int delta = b*b - 4*a*c;
        pt1.PTbac2(a,b,c,delta);
    }
}
