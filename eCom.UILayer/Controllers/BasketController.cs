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
            var total = 0;
            for (int i = 0; i < bitem.Count; i++)
            {
                total = total + bitem[i].BItemPrice;
                ViewBag.total = total;
            }
             

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
            //if(ModelState.IsValid)
            if (bi.BItemId == id && bi.BItemQuantity >= 1)
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
        [HttpGet]
        public IActionResult BuyItems()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> BuyItems(Credit c, AppUser appUser)
        {
            var values = _bItemService.TGetList();
            //var total=0;
            //for (int i = 0; i < values.Count; i++) {
            //    total = total + values[i].BItemPrice;
            //    ViewBag.total = total; 
            //}
            if (c.CreditNo == "1111222233334444" && c.CreditUserName == "Sena" && c.CreditUserSurname == "Tekin" && c.Cvv == 123)
            {
                //int newAmount = c.CreditAmount - total;
                //c.CreditAmount= newAmount;
                return RedirectToAction("SuccessPage","Basket");
            }else
            {
                var fail = "Hatalı Giriş Yaptınız, tekrar deneyin...";
                return RedirectToAction("BuyItems", "Basket");
            }
            return View();
        }
        public IActionResult SuccessPage()
        {
            ViewBag.success = "Ödeme Başarılı...";          
            return View();
        }

    }
    }

    