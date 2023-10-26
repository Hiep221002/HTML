using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string PersonID, string Fullname )
        {
            string strResult = PersonID +"-"+Fullname;
            ViewBag.thongbao = strResult;
            return View();
        }
        
    }
}