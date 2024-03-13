using eStore.Models;
using eStore.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace eStore.Controllers
{
    public class AccessController : Controller
    {
        SaleAsm2Context db = new SaleAsm2Context();
        string adminEmail;
        string adminPass;
        public AccessController()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            adminEmail = config["adminEmail"];
            adminPass = config["adminPassword"];
        }
        [HttpGet]
        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("email") == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult Login(Member member)
        {
            if (HttpContext.Session.GetString("email") == null)
            {
                if(member.Email.Equals(adminEmail) && member.Password.Equals(adminPass))
                {
                    HttpContext.Session.SetString("admin", "admin");
                    return RedirectToAction("Index", "Member");
                }
                var u = db.Members.Where(u => u.Email.Equals(member.Email) && u.Password.Equals(member.Password)).FirstOrDefault();
                if (u != null)
                {
                    HttpContext.Session.SetString("email", member.Email.ToString());
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.Remove("email");
            return RedirectToAction("Login", "Access");
        }

        public IActionResult Unauthorized()
        {
            return View();
        }
    }
}
