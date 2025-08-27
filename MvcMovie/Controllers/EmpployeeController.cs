namespace MvcMovie.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            ViewData["Message"] = "Your welcome message";

            return View();
        }
    }
}