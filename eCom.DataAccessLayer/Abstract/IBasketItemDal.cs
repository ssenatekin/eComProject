using eCom.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCom.DataAccessLayer.Abstract
{
    public interface IBasketItemDal:IGenericDal<BasketItem>
    {
        void GetBasketItem();
    }
}
