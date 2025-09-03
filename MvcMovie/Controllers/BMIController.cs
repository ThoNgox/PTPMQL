using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using System;

namespace MvcMovie.Controllers
{
    public class BMIController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Index(BMI model)
        {
           
            double bmi = model.Weight / (model.Height * model.Height);
            
            
            double roundedBmi = Math.Round(bmi, 2);

            
            ViewBag.BMI = roundedBmi;
            
            
            return View();
        }
    }
}