using eCom.BusinessLayer.Abstract;
using eCom.BusinessLayer.Concrete;
using eCom.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace eCom.UILayer.Controllers
{
    public class BasketItemController : Controller
    {
        private readonly IBasketItemService _basketItemService;

        public BasketItemController(IBasketItemService basketItemService)
        {
            _basketItemService = basketItemService;
        }

        public IActionResult Index()
        {
            var values = _basketItemService.TGetList();
            return View(values);
        }
    }
}
