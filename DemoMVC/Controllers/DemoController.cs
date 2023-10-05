using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class DemoController : Controller
    {
        /*khai bao cac pt */
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string Name ,string email)
        {
            string strResult = "Hello" +"-"+ Name +"-"+ email;
            ViewBag.thongbao = strResult;
            return View();
        } 
    }
}