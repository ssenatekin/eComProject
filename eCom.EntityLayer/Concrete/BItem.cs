using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCom.EntityLayer.Concrete
{
    public class BItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int BItemId { get; set; }
        public string BItemName { get; set; }
        public string BItemDescription { get; set; }
        public int BItemPrice { get; set; }
        public string BItemImage { get; set; }
        public int BItemQuantity { get; set; }

    }
}
