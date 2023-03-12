using eCom.BusinessLayer.Abstract;
using eCom.DataAccessLayer.Abstract;
using eCom.DataAccessLayer.EntityFramework;
using eCom.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCom.BusinessLayer.Concrete
{
    public class BasketItemManager : IBasketItemService
    {
        IBasketItemDal _basketItemDal;

        public BasketItemManager(IBasketItemDal basketItemDal)
        {
            _basketItemDal = basketItemDal;
        }

        public void TDelete(BasketItem t)
        {
            _basketItemDal.Delete(t);
        }

        public BasketItem TGetById(int id)
        {
            return _basketItemDal.GetById(id);
        }

        public List<BasketItem> TGetList()
        {
            return _basketItemDal.GetList();
        }

        public void TInsert(BasketItem t)
        {
            _basketItemDal.Insert(t);
        }

        public void TUpdate(BasketItem t)
        {
            _basketItemDal.Update(t);
        }
    }
}
