using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace AlacakVerecekTakip.Models
{
    public class Context:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(local); database=AlacakVerecekT; integrated security=true");
        }

        public DbSet<UyelerTablosu> uyelerTablosu { get; set; }
        public DbSet<CariHesaplarTablosu> cariHesaplarTablosu { get; set; }
        public DbSet<KasaTablosu> kasaTablosu { get; set; }

    }
}
