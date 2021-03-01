using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Urun:IEntity
    {
        public int UrunId { get; set; }
        public string UrunAdı { get; set; }
        public string Barkot { get; set; }
        public decimal Fiyat { get; set; }
        public int KDV { get; set; }
        public string UrunTipi { get; set; }
        public int Miktar { get; set;  }
    }
}
