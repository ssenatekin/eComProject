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
    public class EFBItemDal : GenericRepository<BItem>, IBItemDal
    {
        public void GetBItem()
        {
            throw new NotImplementedException();
        }
    }
}
