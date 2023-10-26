using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string PersonID, string Fullname ,int luong)
        {
            string strResult = PersonID +"-"+Fullname+"-"+luong;
            ViewBag.thongbao = strResult;
            return View();
        }
        
    }
}