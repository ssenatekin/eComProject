using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCom.EntityLayer.Concrete
{
    public class Credit
    {

        [Key]
        public int Id { get; set; }
        public string CreditNo { get; set; }
        public string CreditUserName { get; set; } //creditusername == appuserdeki kişi?
        public string CreditUserSurname { get; set; }
        public int Cvv { get; set; }
        public DateTime Date { get; set; }
        public string DateTry { get; set; }
        public int CreditAmount { get; set; }
    }
}
