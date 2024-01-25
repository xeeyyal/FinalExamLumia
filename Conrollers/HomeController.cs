using Microsoft.AspNetCore.Mvc;

namespace FinalExamLumia.Conrollers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
