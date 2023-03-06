using eCom.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCom.DataAccessLayer.Abstract
{
    //iitemdal içinde methodlar olcak,ekle,sil,güncelleme,ara...,igenericdal dan miras alıyo
    public interface IItemDal:IGenericDal<Item>
    {
        void GetItem();
    }
}
