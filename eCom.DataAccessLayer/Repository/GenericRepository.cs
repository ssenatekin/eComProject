﻿using eCom.DataAccessLayer.Abstract;
using eCom.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCom.DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using (var context = new Context())
            {
                context.Remove(t);
                context.SaveChanges();
            }
        }

        public T GetById(int id)
        {
            using (var context = new Context())
            {
                return context.Set<T>().Find(id);
            }
        }

        public List<T> GetList()
        {
            using (var context = new Context())
            {
                return context.Set<T>().ToList();
            }
        }

        public void Insert(T t)
        {
            using (var context = new Context())
            {
                context.Add(t);
                context.SaveChanges();
            }
        }

        public void Update(T t)
        {
            using (var context = new Context())
            {
                context.Update(t);
                context.SaveChanges();
            }
        }
    }
}
