using eCom.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCom.DataAccessLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //integrated security--şifresiz giriş
            optionsBuilder.UseSqlServer("server=LAPTOP-MSFD5SIP\\MSSQLSERVER17;database=Dbcom;integrated security=true;");
        }
        //dbset sınıflarımı alıp sqle tablo olarak yansıtacak.
        public DbSet<Item> Items { get; set; }

    }
}
