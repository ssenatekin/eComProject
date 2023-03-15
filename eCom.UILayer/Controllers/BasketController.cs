using eCom.BusinessLayer.Abstract;
using eCom.DataAccessLayer.Concrete;
using eCom.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace eCom.UILayer.Controllers
{
    public class BasketController : Controller
    {
        private readonly IBasketService _basketService;

        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        Context c = new Context();
        Basket by = new Basket();
        List<BasketItem> b = new List<BasketItem>();

        public IActionResult Index(int id)
        {
            var values = _basketService.TGetById(id);
            return View("values");
        }
    }
}
