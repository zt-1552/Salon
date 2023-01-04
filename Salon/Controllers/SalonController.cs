using Microsoft.AspNetCore.Mvc;

namespace Salon.Controllers
{
    public class SalonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
