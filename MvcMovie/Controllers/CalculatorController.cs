namespace MvcMovie.Controllers
{

    using Microsoft.AspNetCore.Mvc;
    using MvcMovie.Models;

    public class CalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Calculator model)
        {
            double result = 0;
            string error = null;
            switch (model.Operator)
            {
                case "Cong":
                    result = model.NumberA + model.NumberB;
                    break;
                case "Tru":
                    result = model.NumberA - model.NumberB;
                    break;
                case "Nhan":
                    result = model.NumberA * model.NumberB;
                    break;
                case "Chia":
                    if (model.NumberB != 0)
                    {
                        result = model.NumberA / model.NumberB;
                    }
                    else
                    {
                        error = "khong the chia cho 0";
                    }
                    break;
            }
            ViewBag.Result = result;
            ViewBag.Error = error;
            return View();
        }
    }
}