using Microsoft.AspNetCore.Mvc;

namespace eCom.UILayer.Controllers
{
    public class BasketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
