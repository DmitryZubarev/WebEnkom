using Microsoft.AspNetCore.Mvc;

namespace WebEnkom.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
