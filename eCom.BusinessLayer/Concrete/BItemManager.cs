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
    public class BItemManager : IBItemService
    {
        IBItemDal _bItemDal;

        public BItemManager(IBItemDal bItemDal)
        {
            _bItemDal = bItemDal;
        }

        public void TDelete(BItem t)
        {
            _bItemDal.Delete(t);
        }

        public BItem TGetById(int id)
        {
            return _bItemDal.GetById(id);
        }

        public List<BItem> TGetList()
        {
            return _bItemDal.GetList();
        }

        public void TInsert(BItem t)
        {
            _bItemDal.Insert(t);
        }

        public void TUpdate(BItem t)
        {
            _bItemDal.Update(t);
        }
    }
}
