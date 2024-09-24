using Microsoft.AspNetCore.Mvc;

namespace TaskManager.Controllers
{
    public class UserPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
