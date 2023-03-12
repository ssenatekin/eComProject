using eCom.EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCom.EntityLayer.Concrete
{
    public class BasketItem : BaseEntity
    {
        public Guid BasketId { get; set; }
        public Guid ItemId { get; set; }

        public int Quantity { get; set; }

        public Basket Basket { get; set; }
        public Item Item { get; set; }
    }
}
