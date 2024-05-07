﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Automation.Entities.Model.Context
{
    public class LibraryContext:DbContext   
    {
        public LibraryContext():base("Library") 
        { 
        
        }
        public DbSet<Duyurular> Duyurular  { get; set; }
        public DbSet<EmanetKitaplar> EmanetKitaplar { get; set; }
        public DbSet<Hakkimizda> Hakkimizda{ get; set; }
        public DbSet<İletisim> İletisim { get; set; }
        public DbSet<KitapHareketleri> KitapHareketleri { get; set; }
        public DbSet<KitapKayitHareketleri> KitapKayitHareketleri { get; set; }
        public DbSet<Kitaplar> Kitaplar { get; set; }
        public DbSet<KitapTurleri> KitapTurleri { get; set; }
        public DbSet<KullaniciHareketleri> KullaniciHareketleri { get; set; }
        public DbSet<Kullanicilar> Kullanicilar { get; set; }
        public DbSet<KullaniciRolleri> KullaniciRolleri { get; set; }
        public DbSet<Roller> Roller { get; set; }
        public DbSet<Uyeler> Uyeler { get; set; }

    }
}
