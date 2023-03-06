using eCom.BusinessLayer.Abstract;
using eCom.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace eCom.UILayer.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        public IActionResult Index()
        {
            var values=_itemService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddItemCart()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult AddItemCart(Item item) 
        {
            _itemService.TInsert(item);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteItemCart(int id)
        {
            //valuesten gelen değer id ile uyuşuyorsa silme işlemi yapar
            var values = _itemService.TGetById(id);
            _itemService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateItem(int id) 
        {
            var values = _itemService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateItem(Item item)
        {
            _itemService.TUpdate(item);
            return RedirectToAction("Index");
        }
    }
}
