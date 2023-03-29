using eCom.EntityLayer.Common;
using eCom.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eCom.DataAccessLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //integrated security--şifresiz giriş
            optionsBuilder.UseSqlServer("server=LAPTOP-MSFD5SIP\\MSSQLSERVER17;database=DbCommerce;integrated security=true;");
            
        }
        //dbset sınıflarımı alıp sqle tablo olarak yansıtacak.
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<CompletedOrder> CompletedOrders { get; set; }
        public DbSet<BItem> BItems { get; set; }     
        public DbSet<Credit> Credits { get; set; }

    }
}
