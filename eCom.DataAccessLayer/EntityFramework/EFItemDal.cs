using eCom.DataAccessLayer.Abstract;
using eCom.DataAccessLayer.Repository;
using eCom.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCom.DataAccessLayer.EntityFramework
{
    public class EFItemDal : GenericRepository<Item>, IItemDal
    {
        public void GetItem()
        {
            throw new NotImplementedException();
        }
    }
}
