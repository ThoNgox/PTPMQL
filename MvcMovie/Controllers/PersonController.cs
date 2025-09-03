namespace MvcMovie.Controllers
{

    using Microsoft.AspNetCore.Mvc;
    using MvcMovie.Models;

    public class PersonController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Person model)
        {
            int age = DateTime.Now.Year - model.YearOfBirth;

            ViewBag.FullName = model.FullName;
            ViewBag.Age = age;

            return View();
        }
    }
}