using Microsoft.AspNetCore.Mvc;

namespace TaskManager.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
