using Newapp.Models;
public class Program
{
    private static void Main(string[] args)
    {
        fruit hq = new fruit();
        fruit hq2 = new fruit();

        hq2.Mahoaqua = "124412";
        hq2.loaihoaqua = "Tao";
        hq2.giaban = 10000;
        hq2.hienthi();
        
    }
/*     {
        Student std = new Student();
        std.Masinhvien ="2021050255";
        std.tensinhvien = "Tran Dai Hiep";
        std.tuoi = 21;
        std.hienthi();
    } */
/*     {
        employee emp = new employee();
        emp.Manhanvien = "n123";
        emp.tennhanvien ="Nguyen Van A";
        emp.tuoi = 15;
        emp.luong = 3000000;
        emp.hienthi();
    } */
    }