using eCom.EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCom.EntityLayer.Concrete
{
    public class Item:BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int ItemPrice { get; set; }
        public string ItemImage { get; set;}
        public int ItemQuantity { get; set; }

        public ICollection<BasketItem> BasketItems { get; set; }
    }
}