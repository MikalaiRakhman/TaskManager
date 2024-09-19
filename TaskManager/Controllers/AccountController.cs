using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManager.Data;
using TaskManager.Models;

namespace TaskManager.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        List<Account> _accounts = new List<Account>();

        public AccountController(AppDbContext context)
        {
            _context = context;            
        }

        public IActionResult Index()
        {
            return View();
        }
        

        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(Account account)
        {
            if (ModelState.IsValid)
            {
                _context.Accounts.Add(account);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(account);
        }
    }
}
