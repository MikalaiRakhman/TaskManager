using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManager.Data;
using TaskManager.Models;

namespace TaskManager.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;        

        public AccountController(AppDbContext context)
        {
            _context = context;            
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Account account)
        {

            
            var existingAccount = _context.Accounts.FirstOrDefault(a => a.Email == account.Email);

            if (existingAccount != null)
            {
                if (existingAccount.Password != null && account.Password == existingAccount.Password)
                {
                    existingAccount.LoggedIn = 1;
                    return RedirectToAction("UserPage", "UserPage");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Неверный пароль.");
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Такой аккаунт не найден");
            }

            return View(account);
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
