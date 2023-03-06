using eCom.BusinessLayer.Abstract;
using eCom.DataAccessLayer.Abstract;
using eCom.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCom.BusinessLayer.Concrete
{
    public class ItemManager : IItemService
    {
        //_ ile this kullanmaya gerek kalmaz
        IItemDal _ItemDal;
        //amaç bağımlılıkları minimize etmek-dependency injection
        public ItemManager(IItemDal ıtemDal)
        {
            _ItemDal = ıtemDal;
        }       

        public void TDelete(Item t)
        {
            _ItemDal.Delete(t);
        }

        public Item TGetById(int id)
        {
            return _ItemDal.GetById(id);
        }

        public List<Item> TGetList()
        {
            return _ItemDal.GetList();
        }

        public void TInsert(Item t)
        {
            _ItemDal.Insert(t);
            //if(t.ItemName!= null && t.ItemName.Length>=10)
            //{
            //    _ItemDal.Insert(t);
            //}
            //else
            //{
            //    //hata mesajı
            //}
        }

        public void TUpdate(Item t)
        {
            _ItemDal.Update(t);
        }
    }
}
