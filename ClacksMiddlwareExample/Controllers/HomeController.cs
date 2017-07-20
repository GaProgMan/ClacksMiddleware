using Microsoft.AspNetCore.Mvc;

namespace ClacksMiddlwareExample.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
