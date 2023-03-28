using eCom.EntityLayer.Concrete;
using System.Collections.Generic;

namespace eCom.UILayer.Models.ViewModels
{
    public class BasketViewModel
    {
        public List<BasketItem> BasketItems { get; set; }
        public decimal GrandTotal { get; set; }
    }
}
