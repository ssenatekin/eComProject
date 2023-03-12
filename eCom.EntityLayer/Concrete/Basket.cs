using eCom.EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCom.EntityLayer.Concrete
{
    public class Basket : BaseEntity
    {
        public int UserId { get; set; }
        public AppUser User { get; set; }
        //public Order Order { get; set; }
        public ICollection<BasketItem> BasketItems { get; set; }
    }
}
