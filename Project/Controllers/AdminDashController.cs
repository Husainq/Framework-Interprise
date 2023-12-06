using Microsoft.AspNetCore.Mvc;

namespace Project_Kel5.Controllers
{
    public class AdminDashController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
