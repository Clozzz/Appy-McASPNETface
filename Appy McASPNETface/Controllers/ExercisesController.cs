using Microsoft.AspNetCore.Mvc;
using System;

namespace Appy_McASPNETface.Controllers
{
    public class ExercisesController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("~/Views/Exercises/BeginnerExercise");
        }

        public IActionResult BeginnerExercise()
        {
            return View();
        }

        public IActionResult IntermediateExercise()
        {
            return View();
        }
        public IActionResult AdvancedExercise()
        {
            return View();
        }
    }
}
