using eCom.BusinessLayer.Abstract;
using eCom.BusinessLayer.Concrete;
using eCom.DataAccessLayer.Concrete;
using eCom.EntityLayer.Concrete;
using eCom.UILayer.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
namespace eCom.UILayer.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class BasketController : Controller
    {
        private readonly IBasketService _basketService;
        private UserManager<AppUser> _userManager;
        private readonly IItemService _itemService;
        private readonly Context _context;
        private readonly IBItemService _bItemService;
        int Quantity = 1;
        public BasketController(IBasketService basketService, UserManager<AppUser> userManager, IItemService itemService, Context context, IBItemService bItemService)
        {
            _basketService = basketService;
            _userManager = userManager;
            _itemService = itemService;
            _context = context;
            _bItemService = bItemService;
        }

        public IActionResult Index(int id)
        {
            var bitem = _bItemService.TGetList();
            return View(bitem);
        }
        Context c = new Context();
        //[HttpGet]
        //public IActionResult AddToBasket()
        //{
        //    return View();
        //}
        //[HttpPost]
        public IActionResult AddToBasket(int id, BItem b)
        {
            var i = _itemService.TGetById(id);
            var bi = _bItemService.TGetById(id);

            if (bi.BItemId == i.Id && bi.BItemQuantity >= 1)
            {
                bi.BItemQuantity = bi.BItemQuantity + Quantity;
                _bItemService.TUpdate(bi);
            }
            else
            {
                b.Id = 0;
                b.BItemId = i.Id;
                b.BItemName = i.ItemName;
                b.BItemPrice = i.ItemPrice;
                b.BItemDescription = i.ItemDescription;
                b.BItemQuantity = Quantity;
                b.BItemImage = i.ItemImage;
                _bItemService.TInsert(b);
            }
                return RedirectToAction("Index", "Item");
            }

            public IActionResult DeleteFromBasket(int id)
            {
                var b = _bItemService.TGetById(id);
                _bItemService.TDelete(b);
                return RedirectToAction("Index");
            }
        public IActionResult BuyItems(BItem b)
        {
            List<BItem> bitems = new List<BItem>();
            var values = _bItemService.TGetList();

            var total=0;
            for (int i = 0; i < values.Count; i++) {
                total = total + values[i].BItemPrice;
                //int price = bitems[i].BItemPrice;
                
                ViewBag.total = total; 
            }
            //ViewBag.total = total;         
            var bit=_bItemService.TGetList();
            return View();
        }

        }
    }

    