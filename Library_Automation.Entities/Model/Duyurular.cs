﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Automation.Entities.Model
{
    public class Duyurular
    {
        public int Id { get; set; }
        public string Baslik {  get; set; }
        public string Duyuru { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih {  get; set; }

    }
}
