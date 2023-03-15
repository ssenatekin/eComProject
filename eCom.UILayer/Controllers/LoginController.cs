using eCom.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eCom.UILayer.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(AppUser appUser)
        {
            var result = await _signInManager.PasswordSignInAsync(appUser.UserName, appUser.PasswordHash, false, true);
            if( appUser.UserName=="Admin" && result.Succeeded) // burda kullanıcı adminse usere gitsin, normal kullanıcıysa ürünler sayfasına gitsin? yada veritabanında admin kullanıcı-şifre belirlenip onunla girsin?
            {
                return RedirectToAction("Index", "User");
            }
            else if(result.Succeeded) 
            {
                return RedirectToAction("Index", "Item");
            }
            return View();
        }
    }
}
