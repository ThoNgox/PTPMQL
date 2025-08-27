namespace MvcMovie.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    public class PersonController : Controller
    {
        public IActionResult Index()
        {

            ViewBag.Message = "Chào mừng bạn!";

            
            ViewBag.Year = DateTime.Now.Year;
            return View();
        }
        [HttpPost]
        public IActionResult Index(string Fullname, string Address)
        {
            string strOutput = "xin chao " + Fullname + " den tu " + Address;
            ViewBag.Message = strOutput;
            return View();
        }

        public IActionResult Welcome()
        {
            ViewData["Message"] = "Your welcome message";

            return View();
        }
    }
}