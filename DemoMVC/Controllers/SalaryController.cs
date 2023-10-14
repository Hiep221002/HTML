/* TRANDAIHIEP-2021050255 */
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;

public class SalaryController : Controller
{
    public IActionResult SalaryIndex()
    {
        return View();
    }
    [HttpPost]
    public IActionResult SalaryIndex(string hoten ,int luongcoban,int hesoluong,int phucap)
    {
        int luong =luongcoban * hesoluong + phucap;
        string strResult = hoten +"-"+luongcoban;
        ViewBag.thongbao = strResult;
        return View();
    }
}