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

        [Authorize]
        public IActionResult Index()
        {
            var product = c.Items.ToList();
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
            c.Items.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ItemDelete(int id)
        {
            var b = c.Items.Find(id);
            c.Items.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ItemGet(int id)
        {
            var it = c.Items.Find(id);
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
