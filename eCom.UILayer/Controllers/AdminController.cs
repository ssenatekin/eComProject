using eCom.BusinessLayer.Abstract;
using eCom.DataAccessLayer.Concrete;
using eCom.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Reflection.Metadata;

namespace eCom.UILayer.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();

        private readonly IItemService _itemService;

        public AdminController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [Authorize]
        public IActionResult Index(int id)
        {
            var product = _itemService.TGetList();
            return View(product);
        }

        [HttpGet]
        public ActionResult NewItem()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewItem(Item p)
        {
            _itemService.TInsert(p);
            return RedirectToAction("Index");
        }
        public ActionResult ItemDelete(int id)
        {
            var d = _itemService.TGetById(id);
            _itemService.TDelete(d);
            return RedirectToAction("Index");
        }
        public ActionResult ItemGet(int id)
        {
            var it = _itemService.TGetById(id);
            return View("ItemGet", it);
        }
        public ActionResult ItemUpdate(Item i)
        {
            var itm = c.Items.Find(i.Id);
            itm.ItemName = i.ItemName;
            itm.ItemDescription = i.ItemDescription;
            itm.ItemPrice = i.ItemPrice;
            itm.ItemQuantity = i.ItemQuantity;
            itm.ItemImage = i.ItemImage;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
       
    }
}
