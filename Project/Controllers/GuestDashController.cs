using Microsoft.AspNetCore.Mvc;

namespace Project_Kel5.Controllers
{
    public class GuestDashController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
