﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Automation.Entities.Model
{
    public class Kitaplar
    {
        public int Id { get; set; }
        public string BarkodNo { get; set; }
        public int KitapTuruId { get; set; }
        public string KitapAdi {  get; set; }
        public string Yazari { get; set; }
        public string YayinEvi { get; set; }
        public int StokAdresi { get; set; }
        public int SayfaSayisi { get; set; }
        public string Aciklama { get; set; }
        public DateTime EklemeTarihi { get; set; }= DateTime.Now;
        public DateTime GuncellemeTarihi { get; set; }= DateTime.Now;
        public bool SilindiMi {  get; set; }
    }
}
